using System.Threading.Tasks;
using BookStore.Domain.Core;
using BookStore.Domain.Core.Entities;
using BookStore.Models;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Web;
using Microsoft.EntityFrameworkCore;


namespace BookStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;



        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Name = model.Name, Surname = model.Surname, PhoneNumber = model.Number, Email = model.Email,
                    UserName = model.Email

                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {

                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View(model);
        }

        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _signInManager
                .PasswordSignInAsync(model.Email, model.Password, true, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Profile", "Account");
            }
            else
            {


                ModelState.AddModelError(string.Empty, "Incorrect login or password.");

            }

            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Profile()
        {

            return View(await _userManager.FindByNameAsync(User.Identity.Name));

        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Edit()
        {
            return View(await _userManager.FindByNameAsync(User.Identity.Name));
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Edit(EditViewModel model)
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);

            user.Name = model.Name;
            user.Surname = model.Surname;
            user.PhoneNumber = model.Number; 
            //user.Email = model.Email;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Profile", "Account");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                //return View(await _userManager.FindByNameAsync(User.Identity.Name));
            }


            return RedirectToAction("Profile", "Account");

        }
    
}

}
