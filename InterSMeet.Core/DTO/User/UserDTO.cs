﻿using InterSMeet.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterSMeet.Core.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int ProvinceId { get; set; }
        public string Location { get; set; } = null!;
        public int LanguageId { get; set; }
        public int? RoleId { get; set; }
        public bool EmailVerified { get; set; }
        public string CreatedAt { get; set; } = null!;
        public string UpdatedAt { get; set; } = null!;
    }
}
