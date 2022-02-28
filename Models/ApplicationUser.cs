﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace ERP.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name ="User Bio")]
        public string? UserBio { get; set: }
    }
}
