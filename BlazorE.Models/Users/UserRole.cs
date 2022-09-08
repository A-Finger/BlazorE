using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorE.Models.Users
{
    public class UserRole
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Value { get; set; } = null!;

        public UserRole() { }
        public UserRole(int id, string userRole)
        {
            Id = id;
            Value = userRole;
        }

        public IEnumerable<User> Users { get; set; } = null!;
    }
}
