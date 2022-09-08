using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorE.Models.Users
{
    public class User
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; } = null!;
        [MaxLength(50)]
        public string? MidleName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; } = null!;
        [MaxLength(20)]
        public string? Phone { get; set; }
        [MaxLength(100)]
        public string? Email { get; set; }
        [Required, MaxLength(16)]
        public string Password { get; set; } = null!;
        public bool LockConfirmed { get; set; }
        public int JobTitleId { get; set; }
        public int UserRoleId { get; set; }
        public int LeaderId { get; set; }

        [ForeignKey(nameof(LeaderId))]
        public User Leader { get; set; } = null!;
        [ForeignKey(nameof(UserRoleId))]
        public UserRole UserRole { get; set; } = null!;

        public IEnumerable<User> Users { get; set; } = null!;
    }
}
