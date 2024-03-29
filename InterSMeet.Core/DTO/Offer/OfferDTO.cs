﻿

using System.ComponentModel.DataAnnotations;

namespace InterSMeet.Core.DTO.Offer
{
    public class OfferDTO
    {
        public int OfferId { get; set; }
        public int ApplicantCount { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? Schedule { get; set; }
        public double Salary { get; set; }
        public int CompanyId { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
