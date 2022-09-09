using BlazorE.Models.Users;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlazorE.Catalog.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ProtectedSessionStorage _sessionStorage;
        private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

        public CustomAuthenticationStateProvider(ProtectedSessionStorage sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var userSessionStorageResult = await _sessionStorage.GetAsync<UserSession>(nameof(UserSession));
                var userSession = userSessionStorageResult.Success ? userSessionStorageResult.Value : null;
                if (userSession == null)
                    return await Task.FromResult(new AuthenticationState(_anonymous));
                var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(
                    new List<Claim>
                           {
                              new Claim(ClaimTypes.Name, userSession.UserName),
                              new Claim(ClaimTypes.Role, userSession.Role)
                           }, "CustomAuth"));
                return await Task.FromResult(new AuthenticationState(claimsPrincipal));
            }
            catch
            {
                return await Task.FromResult(new AuthenticationState(_anonymous));
            }
        }

        public async Task UpdateAuthenticationStateAsync(UserSession userSession)
        {
            ClaimsPrincipal claimsPrincipal;
            if (userSession is not null)
            {
                await _sessionStorage.SetAsync(nameof(UserSession), userSession);
                claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(
                    new List<Claim>
                           {
                                new Claim(ClaimTypes.Name, userSession.UserName),
                                new Claim(ClaimTypes.Role, userSession.Role)
                           }));
            }
            else
            {
                await _sessionStorage.DeleteAsync(nameof(UserSession));
                claimsPrincipal = _anonymous;
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }
    }
}
