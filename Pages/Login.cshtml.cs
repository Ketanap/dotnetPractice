using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dotnetweb.Models;
using dotnetweb.Services;
namespace MyApp.Namespace
{
 
    public class LoginModel : PageModel
    {
        UserService us=new UserService();
        public void OnGet()
        {
             ViewData["msg"]="";
        }
        public void OnPost(User u)
        {
            if(us.Login(u))
            {
                ViewData["msg"]="Login Success";
            }
            else
            {
                ViewData["msg"]="Email or Password Incorrect";
            }
        }
    }
}
