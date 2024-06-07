﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Core.Domain.Identity
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid> // Kế thừa từ IndentityUser với kiểu dữ liệu khóa chính là guid
    {
        [Required]
        [MaxLength(100)]
        public required string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public required string LastName { get; set; }

        public bool IsActive { get; set; }

        public string? RefreshToken { get; set; }

        public DateTime? RefreshTokenExpiryTime { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? Dob { get; set; }

        [MaxLength(100)]
        public string? Avatar { get; set; }

        public DateTime? VipStartDate { get; set; }

        public DateTime? VipExpireDate { get; set; }

        public DateTime? LateLoginDate { get; set; }

        public double Balance { get; set; }
    }
}