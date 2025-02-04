﻿using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LMS_LibraryManagementSystem_.ViewModel
{
    public class ApplicationUserCreateVM
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Password")]
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public List<string> SelectedRole { get; set; } = new List<string>();
        public List<SelectListItem>? Roles { get; set; }
    }
}
