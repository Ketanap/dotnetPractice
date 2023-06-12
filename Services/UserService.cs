namespace dotnetweb.Services;
using dotnetweb.Models;
using System.Data.SqlClient;
using System.Data;
public class UserService : Service
{
    public void Insert(User u)
    {
          SqlCommand cm =new SqlCommand("insert into tblUser (UserName,Email,Password,Gender,Address) Values(@UserName,@Email,@Password,@Gender,@Address)");
          cm.Parameters.AddWithValue("@UserName",u.UserName);
          cm.Parameters.AddWithValue("@Email",u.Email);
          cm.Parameters.AddWithValue("@Password",u.Password);
          cm.Parameters.AddWithValue("@Gender",u.Gender);
          cm.Parameters.AddWithValue("@Address",u.Address);
          Execute(cm);
            
    }
    public bool Login(User u)
    {
          SqlCommand cm =new SqlCommand("select * from tblUser where Email=@Email and Password=@Password");
          cm.Parameters.AddWithValue("@Email",u.Email);
          cm.Parameters.AddWithValue("@Password",u.Password);
          DataTable dt=GetData(cm);
          return (dt.Rows.Count>0);
    }
}