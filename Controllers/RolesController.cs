﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Drawing.Text;

namespace RBA.Controllers
{
    [Authorize(Roles ="Admin")]
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _manager;

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            _manager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = _manager.Roles;
            return View(roles);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var roles = _manager.Roles;
            return View();
        }

        [HttpPost]
        public IActionResult Create(IdentityRole role)
        {
            //Check if the role exists
            if (!_manager.RoleExistsAsync(role.Name).GetAwaiter().GetResult()) 
            { 
                _manager.CreateAsync(new IdentityRole(role.Name)).GetAwaiter().GetResult();
            
            }
            return RedirectToAction("Index");
        }
        

    }
}
