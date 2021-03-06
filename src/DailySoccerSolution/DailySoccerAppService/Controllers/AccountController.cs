﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server;
using DailySoccer.Shared.Models;
using DailySoccer.Shared.Facades;

namespace DailySoccerAppService.Controllers
{
    public class AccountController : ApiController
    {
        public ApiServices Services { get; set; }
        

        [HttpGet]
        public CreateNewGuestRespond CreateNewGuest()
        {
            var result = FacadeRepository.Instance.AccountFacade.CreateNewGuest();
            return result;
        }

        [HttpGet]
        public CreateNewGuestRespond CreateNewGuestWithFacebook(string OAuthId)
        {
            var email = "testuser@dailysoccer.com";
            var result = FacadeRepository.Instance.AccountFacade.CreateNewGuestWithFaceebook(OAuthId, email);
            return result;
        }

        [HttpGet]
        public bool UpdateAccountWithFacebook(string secretCode, string OAuthId)
        {
            var email = "testuser@dailysoccer.com";
            FacadeRepository.Instance.AccountFacade.UpdateAccountWithFacebook(secretCode, OAuthId, email);
            return true;
        }

        [HttpGet]
        public AccountInformation GetAccountByOAuthId(string OAuthId)
        {
            var result = FacadeRepository.Instance.AccountFacade.GetAccountByOAuthId(OAuthId);
            return result;
        }

        [HttpGet]
        public AccountInformation GetAccountBySecretCode(string secretCode)
        {
            var result = FacadeRepository.Instance.AccountFacade.GetAccountBySecretCode(secretCode);
            return result;
        }

        [HttpGet]
        public RequestConfirmPhoneNumberRespond RequestConfirmPhoneNumber(string userId, string phoneNo)
        {
            var request = new RequestConfirmPhoneNumberRequest
            {
                PhoneNo = phoneNo,
                UserId = userId
            };
            var result = FacadeRepository.Instance.AccountFacade.RequestConfirmPhoneNumber(request);
            return result;
        }

        [HttpGet]
        public ConfirmPhoneNumberRespond ConfirmPhoneNumber(string userId, string verificationCode)
        {
            var request = new ConfirmPhoneNumberRequest
            {
                UserId = userId,
                VerificationCode = verificationCode
            };
            var result = FacadeRepository.Instance.AccountFacade.ConfirmPhoneNumber(request);
            return result;
        }

        [HttpGet]
        public bool TieFacbookWithFacebookData(string secretCode, string OAuthId)
        {
            var result = FacadeRepository.Instance.AccountFacade.TieFacbookWithFacebookData(secretCode, OAuthId);
            return result;
        }

        [HttpGet]
        public bool TieFacbookWithLocalData(string secretCode, string OAuthId)
        {
            var result = FacadeRepository.Instance.AccountFacade.TieFacbookWithLocalData(secretCode, OAuthId);
            return result;
        }

    }
}
