using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Utilites;

namespace WebApp.Controllers
{
    


    public class PrivateController : Controller
    {
        [ExceptionLogger]
        [Authorize(Policy = "RequireModerator")]
        public IActionResult Index()
        {
            try
            {
                throw new Exception("Tra-la-la");
            }
            catch (Exception)
            {

            }
            return View();
        }
    }
}
