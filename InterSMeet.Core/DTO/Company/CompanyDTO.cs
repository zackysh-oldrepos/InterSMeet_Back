﻿using InterSMeet.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterSMeet.Core.DTO
{
    public class CompanyDTO
    {
        public int CompanyId { get; set; }
        public string Address { get; set; } = null!;
    }
}