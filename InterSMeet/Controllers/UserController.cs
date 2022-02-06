﻿using InterSMeet.ApiRest.Utils;
using InterSMeet.BLL.Contracts;
using InterSMeet.Core.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InterSMeet.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        internal IUserBL UserBL { get; set; }

        public UserController(IUserBL UserBL)
        {
            this.UserBL = UserBL;
        }

        // ==================================================================================
        // @ Session
        // ==================================================================================

        [HttpPost("sign-in")]
        [AllowAnonymous]
        public ActionResult<AuthenticatedDTO> SignIn(SignInDTO signInDto)
        {
            return Ok(UserBL.SignIn(signInDto));
        }

        [HttpPost("refresh")]
        [AllowAnonymous]
        public ActionResult<StudentDTO> RefreshToken()
        {
            return Ok(UserBL.RefreshToken(HttpContext.Request.Headers.First(x => x.Key == "refresh-token").Value));
        }

        [HttpPost("check-access")]
        [Authorize]
        public ActionResult<StudentDTO> CheckAccessToken()
        {
            // [Authorize] tag handle access token validation,
            // returns 401 status if token isn't valid
            return Ok(); // return 200 if token is valid
        }

        // @ Password

        [HttpPost("send-restore-password/{credential}")]
        public ActionResult SendRestorePassword(string credential)
        {
            UserBL.SendRestorePassword(credential);
            return Ok();
        }

        [HttpPost("check-restore-password/{restorePasswordCode}")]
        [Authorize]
        public ActionResult CheckRestorePassword(string restorePasswordCode)
        {
            var username = ControllerUtils.GetUserIdentity(HttpContext);
            UserBL.CheckRestorePassword(restorePasswordCode, username);
            return Ok();
        }

        [HttpPost("restore-password")]
        public ActionResult RestorePassword(RestorePasswordDTO restoreDto)
        {
            UserBL.RestorePassword(restoreDto.NewPassword, restoreDto.RestorePasswordCode, restoreDto.Credential);
            return Ok();
        }

        // ==================================================================================
        // @ Registration
        // ==================================================================================

        [HttpPost("sign-up/student")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [AllowAnonymous]
        public ActionResult<AuthenticatedDTO> StudentSignUp(StudentSignUpDTO signUpDto)
        {
            return Ok(UserBL.StudentSignUp(signUpDto));
        }

        [HttpPost("sign-up/company")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [AllowAnonymous]
        public ActionResult<AuthenticatedDTO> CompanySignUp(CompanySignUpDTO signUpDto)
        {
            return Ok(UserBL.CompanySignUp(signUpDto));
        }

        // @ Credential validation

        [HttpPost("check/email")]
        [AllowAnonymous]
        public ActionResult<AuthenticatedDTO> CheckEmail(string email)
        {
            UserBL.CheckEmail(email);
            return Ok();
        }

        [HttpPost("check/username")]
        [AllowAnonymous]
        public ActionResult<AuthenticatedDTO> CheckUsername(string username)
        {

            UserBL.CheckUsername(username);
            return Ok();
        }

        // @ Email Verification

        [HttpPost("confirm-email/{verificationCode}")]
        [Authorize]
        public ActionResult EmailVerification(string verificationCode)
        {
            var username = ControllerUtils.GetUserIdentity(HttpContext);
            UserBL.EmailVerification(verificationCode, username);
            return Ok();
        }

        [HttpPost("send-confirm-email")]
        [Authorize]
        public ActionResult SendEmailVerification()
        {
            var username = ControllerUtils.GetUserIdentity(HttpContext);
            UserBL.SendEmailVerification(username);
            return Ok();
        }

        // @ Public data

        [HttpGet("languages")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<LanguageDTO>> FindAllLanguages()
        {
            return Ok(UserBL.FindAllLanguages());
        }

        // GET api/users/provinces
        [HttpGet("provinces")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<ProvinceDTO>> FindAllProvinces()
        {
            return Ok(UserBL.FindAllProvinces());
        }

        // ==================================================================================
        // @ Admin
        // ==================================================================================

        [HttpPost("languages")]
        [Authorize(Roles = "Admin")]
        public ActionResult<LanguageDTO> CreateLanguage(LanguageDTO languageDto)
        {
            return Ok(UserBL.CreateLanguage(languageDto));
        }
    }
}
