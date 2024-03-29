﻿using InterSMeet.Core.DTO;
using InterSMeet.Core.DTO.Offer;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterSMeet.BLL.Contracts
{
    public interface IOfferBL
    {
        /// <summary>
        /// Performs Offer Pagination.<br></br><br></br>
        /// 
        /// If private data is requested, <strong>companyId</strong> field is ignored<br></br>
        /// and this method will fetch authenticated consumer offers (if it's a Company or a Student).<br></br><br></br>
        /// 
        /// If consumer is a student, only offers he has applied for will be returned.<br></br>
        /// If consumer is a company, only offers he has created will be returned.<br></br>
        /// </summary>
        /// <param name="options">Pagination options</param>
        /// <param name="username">Provided to fetch private offer applicant data, only about authenticated Company</param>
        /// <returns>
        /// List of Public OfferDTO if <strong>privateData</strong> is true<br></br>
        /// List of Private OfferDTO if <strong>privateData</strong> is false
        /// </returns>
        OfferPaginationResponseDTO Pagination(OfferPaginationOptionsDTO options, string username);
        IEnumerable<OfferDTO> FindAll();
        OfferDTO FindById(int offerId);
        IEnumerable<PrivateOfferDTO> FindCompanyOffers(string name);
        OfferDTO Create(CreateOfferDTO createOfferDTO, string username);
        OfferDTO Update(UpdateOfferDTO updateOfferDTO, string username, int offerId);
        OfferDTO Delete(int offerId, string username);
        ApplicationDTO CreateApplication(int offerId, string username);
        ApplicationDTO DeleteApplication(int offerId, string username);
        ApplicantDTO UpdateApplicationStatus(int offerId, int studentId, string username, ApplicationStatusDTO status);
    }
}
