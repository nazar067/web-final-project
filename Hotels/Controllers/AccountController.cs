using Hotels.Models;
using Hotels.Models.ViewModels;
using Hotels.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Hotels.Controllers
{
    public class AccountController : Controller
    {
        private readonly MailSender mail;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, MailSender mail)
        {
            this.mail = mail;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        // Регистрация нового пользователя
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Создаем нового пользователя
                User user = new User
                {
                    UserName = model.Name,
                    Email = model.Email,
                    Year = model.Year
                };

                // Пытаемся создать пользователя
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    // Автоматический вход после регистрации
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

                // Если есть ошибки, добавляем их в ModelState
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        // Вход в аккаунт
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid email or password");
            }

            return View(model);
        }

        // Выход из аккаунта
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        // Подтверждение почты (заглушка)
        public IActionResult ConfirmEmail(ConfirmEmailViewModel model)
        {
            mail.EmailSender();
            return View(model);
        }

        // Смена пароля
        public IActionResult ChangePassword(string returnUrl = null)
        {
            return View(new ChangePasswordViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    var result = await userManager.ChangePasswordAsync(user, model.OldPass, model.NewPass);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "User not found.");
                }
            }

            return View(model);
        }
    }
}
