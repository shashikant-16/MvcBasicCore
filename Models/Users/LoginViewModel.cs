﻿using System.ComponentModel.DataAnnotations;

namespace MvcBasicCore.Models.Users
{
    public class LoginViewModel
    {
       
        [Required]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
