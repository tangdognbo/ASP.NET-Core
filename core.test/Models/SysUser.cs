using System;
using System.ComponentModel.DataAnnotations;

namespace core.test.Models
{
    public class SysUser
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(200)]
        public string UserName { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }

        [StringLength(200)]
        public string TrueName { get; set; }

        [StringLength(50)]
        public string Card { get; set; }

        [StringLength(200)]
        public string MobileNumber { get; set; }

        [StringLength(200)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        [StringLength(200)]
        public string EmailAddress { get; set; }

        [StringLength(200)]
        public string OtherContact { get; set; }

        [StringLength(200)]
        public string Province { get; set; }

        [StringLength(200)]
        public string City { get; set; }

        [StringLength(200)]
        public string Village { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public bool State { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(200)]
        public string CreatePerson { get; set; }

        [StringLength(10)]
        public string Sex { get; set; }

        public DateTime? Birthday { get; set; }

        public DateTime? JoinDate { get; set; }

        [StringLength(10)]
        public string Marital { get; set; }

        [StringLength(50)]
        public string Political { get; set; }

        [StringLength(20)]
        public string Nationality { get; set; }

        [StringLength(20)]
        public string Native { get; set; }

        [StringLength(50)]
        public string School { get; set; }

        [StringLength(100)]
        public string Professional { get; set; }

        [StringLength(20)]
        public string Degree { get; set; }

        [Required]
        [StringLength(50)]
        public string DepId { get; set; }

        [Required]
        [StringLength(50)]
        public string PosId { get; set; }

        [StringLength(3000)]
        public string Expertise { get; set; }

        [StringLength(20)]
        public string JobState { get; set; }

        [StringLength(200)]
        public string Photo { get; set; }

        [StringLength(200)]
        public string Attach { get; set; }

    }
}
