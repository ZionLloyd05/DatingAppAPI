﻿using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers {
    public class UserController : Controller {
        public IActionResult Index () {
            return View ();
        }
    }
}