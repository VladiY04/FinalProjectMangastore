using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProject.Views.Home
{
    public class RegisterPageModel : PageModel
    {
    //    private readonly UserManager<IdentityUser> _userManager;
    //    private readonly SignInManager<IdentityUser> _signInManager;
    //    public RegisterPageModel(UserManager<IdentityUser> userManager,
    //    SignInManager<IdentityUser> signInManager)
    //    {
    //        _userManager = userManager;
    //        _signInManager = signInManager;
    //    }
    //    [BindProperty]
    //    public InputModel Input { get; set; }
    //    public string ErrorMessage { get; set; }
    //    public class InputModel
    //    {
    //        [Required]
    //        [EmailAddress]
    //        public string Email { get; set; }
    //        [Required]
    //        [DataType(DataType.Password)]
    //        public string Password { get; set; }
    //        [DataType(DataType.Password)]
    //        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    //        public string ConfirmPassword { get; set; }
    //    }
    //    public void OnGet()
    //    {
    //    }
    //    public async Task<IActionResult> OnPostAsync()
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var user = new IdentityUser
    //            {
    //                UserName = Input.Email,
    //                Email =
    //            Input.Email
    //            };
    //            var result = await _userManager.CreateAsync(user,
    //            Input.Password);
    //            if (result.Succeeded)
    //            {
    //                await _signInManager.SignInAsync(user, isPersistent: false);
    //                return RedirectToPage("/Index");
    //            }
    //            foreach (var error in result.Errors)
    //            {
    //                ModelState.AddModelError(string.Empty, error.Description);
    //            }
    //        }
    //        return Page();
    //    }
    }
}
