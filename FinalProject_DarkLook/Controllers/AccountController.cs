using FinalProject_DarkLook.Models;
using FinalProject_DarkLook.ViewModels.AcoountViewModel;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_DarkLook.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _manager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _env;
        public AccountController(UserManager<AppUser> manager, SignInManager<AppUser> signInManager, IWebHostEnvironment env)
        {
            _manager = manager;
            _signInManager = signInManager;
            _env = env;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);

            }

            AppUser appUser = new AppUser
            {
                Name = registerVM.Name,
                SurName = registerVM.SurName,
                Email = registerVM.Email,
                UserName = registerVM.UserName
            };

            IdentityResult identityResult = await _manager.CreateAsync(appUser, registerVM.Password);

            if (!identityResult.Succeeded)
            {
                foreach (IdentityError identityError in identityResult.Errors)
                {
                    ModelState.AddModelError("", identityError.Description);
                }
                return View(registerVM);
            }

            await _signInManager.SignInAsync(appUser, false);
            if (!identityResult.Succeeded)
            {
                foreach (IdentityError identityError in identityResult.Errors)
                {
                    ModelState.AddModelError("", identityError.Description);
                }
                return View(registerVM);
            }

            await _signInManager.SignInAsync(appUser, false);
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Dgka Cryptography", "dgkacryptography@gmail.co"));
            message.To.Add(new MailboxAddress(appUser.Name, appUser.Email));
            message.Subject = "Email Tesdiqleyin";

            string emailbody = string.Empty;

            using (StreamReader stream = new StreamReader(Path.Combine(_env.WebRootPath, "template", "confirmemail.html")))
            {
                emailbody = stream.ReadToEnd();
            }

            string emailconfirmtokent = await _manager.GenerateEmailConfirmationTokenAsync(appUser);

            string url = Url.Action("confirmemail", "account", new { Id = appUser.Id, token = emailconfirmtokent }, Request.Scheme);

            emailbody = emailbody.Replace("{{fullName}}", $"{appUser.Name} {appUser.SurName}").Replace("{{url}}", $"{url}");

            message.Body = new TextPart(TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("dgkacryptography@gmail.com", "Mehemmed.696");
            smtp.Send(message);
            smtp.Disconnect(true);


            return RedirectToAction("Login", "account");

        }
        public async Task<IActionResult> ConfirmEmail(string Id, string token)
        {
            if (string.IsNullOrWhiteSpace(Id) || string.IsNullOrWhiteSpace(token))
            {
                return NotFound();
            }

            AppUser appUser = await _manager.FindByIdAsync(Id);

            if (appUser == null)
            {
                return NotFound();
            }

            IdentityResult identityResult = await _manager.ConfirmEmailAsync(appUser, token);
            if (!identityResult.Succeeded)
            {
                return NotFound();
            }

            return RedirectToAction("Login");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("login", "account");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
                return NotFound();

            AppUser appUser = await _manager.FindByEmailAsync(loginVM.Email);

            if (appUser == null)
            {
                ModelState.AddModelError("", "Email Və Ya şifrə Yanlışdir");
                return View(loginVM);
            }

            //if (appUser.EmailConfirmed == false)
            //{
            //    return RedirectToAction("Index", "Home");
            //}

            Microsoft.AspNetCore.Identity.SignInResult signinResult = await _signInManager
                .PasswordSignInAsync(appUser, loginVM.Password, true, true);

            if (signinResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Email Bloklanıb");
                return View(loginVM);
            }

            if (!signinResult.Succeeded)
            {
                ModelState.AddModelError("", "Email Və Ya şifrə Yanlışdir");
                return View(loginVM);
            }

         
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return NotFound();

            AppUser appUser = await _manager.FindByEmailAsync(email);

            if (appUser == null)
                return NotFound();

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Dgka Cryptography", "dgkacryptography@gmail.com"));
            message.To.Add(new MailboxAddress(appUser.Name, appUser.Email));
            message.Subject = "Reset Password";

            string emailbody = string.Empty;

            using (StreamReader stream = new StreamReader(Path.Combine(_env.WebRootPath, "template", "forgotpassword.html")))
            {
                emailbody = stream.ReadToEnd();
            }

            string forgetpasswordtoken = await _manager.GeneratePasswordResetTokenAsync(appUser);

            string url = Url.Action("changepassword", "account", new { Id = appUser.Id, token = forgetpasswordtoken }, Request.Scheme);

            emailbody = emailbody.Replace("{{fullName}}", $"{appUser.Name} {appUser.SurName}").Replace("{{url}}", $"{url}");

            message.Body = new TextPart(TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("dgkacryptography@gmail.com", "Mehemmed.696");
            smtp.Send(message);
            smtp.Disconnect(true);

            return View();
        }
    } 
}
