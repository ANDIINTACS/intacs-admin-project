using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INTACSAdmin.Models
{
    [Table("intClient")]
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string? ClientName { get; set; }

        [StringLength(500)]
        public string? Address { get; set; }

        [StringLength(50)]
        public string? ClientId { get; set; }

        [StringLength(50)]
        public string? Position { get; set; }

        public DateTime? ExpDate { get; set; }

        public int? UserLicense { get; set; }

        public int? UserAttendance { get; set; }

        public int? UserPOS { get; set; }

        public int? Entity { get; set; }

        [StringLength(150)]
        public string? Website { get; set; }

        [StringLength(200)]
        public string? MainBusiness { get; set; }

        public int PasswordExpirationPolicy { get; set; }

        [StringLength(200)]
        public string? ContactPerson { get; set; }

        [StringLength(200)]
        public string? Email { get; set; }

        [StringLength(50)]
        public string? MobileNo { get; set; }

        public bool Active { get; set; }
    }
}
