using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityExperimentPart1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityExperimentPart1.Controllers
{
    public class LoginModel : PageModel
    {
        public string? Email { get; set; }

        public string? PassWord { get; set; }

        public bool KeepLoggedIn { get; set; }
    }
}
