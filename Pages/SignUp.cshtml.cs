using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dotnetweb.Models;
using dotnetweb.Services;
namespace MyApp.Namespace
{
    public class SignUpModel : PageModel
    {
        UserService us=new UserService();
        public void OnGet()
        {
        }
        public void OnPost(User u)
        {
            us.Insert(u);
        }
    }
}
