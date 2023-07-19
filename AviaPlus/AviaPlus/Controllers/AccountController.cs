using AviaPlus.Helpers;
using AviaPlus.Models;
using AviaPlus.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AviaPlus.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            AppUser appUser = await _userManager.FindByNameAsync(loginVM.Username);
            if (appUser == null)
            {
                ModelState.AddModelError("", "Username or password is wrong!");
                return View();
            }
            if (appUser.IsDeactive)
            {
                ModelState.AddModelError("", "Your account has been blocked!");
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, loginVM.IsRemember, true);
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Your account has been blocked for 3 minutes!");
                return View();
            }
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Username or password is wrong!");
                return View();
            }
            await _signInManager.SignInAsync(appUser, loginVM.IsRemember);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            AppUser appUser = new AppUser()
            {
                Name = registerVM.Name,
                Surname = registerVM.Surname,
                Email = registerVM.Email,
                UserName = registerVM.Username,
                IsFemale = registerVM.IsFemale,
            };
            IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(appUser, Helper.Roles.Member.ToString());
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        //public async Task CreateRoles()
        //{
        //    if (!await _roleManager.RoleExistsAsync(Helper.Roles.Admin.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Helper.Roles.Admin.ToString() });
        //    }
        //    if (!await _roleManager.RoleExistsAsync(Helper.Roles.ConManager.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Helper.Roles.ConManager.ToString() });
        //    }
        //    if (!await _roleManager.RoleExistsAsync(Helper.Roles.Member.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Helper.Roles.Member.ToString() });
        //    }
        //}
    }
}
