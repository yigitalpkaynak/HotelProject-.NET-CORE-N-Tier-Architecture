﻿using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        //[HttpGet]
        //public IActionResult UserListWithWorkLocation()
        //{
        //    return Ok(_appUserService.TUserListWithWorkLocation());
        //}

        [HttpGet]
        public IActionResult AppUserList()
        {
            return Ok(_appUserService.TGetList());
        }
    }
}
