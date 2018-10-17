﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace softaware.Authentication.Basic.AspNetCore.Test
{
    [Route("api/[controller]")]
    [Authorize]
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return this.Ok();
        }
    }
}
