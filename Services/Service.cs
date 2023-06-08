namespace dotnetweb.Services;
using dotnetweb.Models;
using System.Data.SqlClient;
public class Service
{
    SqlConnection? con =null;
    public Service(){
         SqlConnection con=new SqlConnection("");
    }
    public void Execute(SqlCommand cmd)
    {
        try{
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }finally{

        }
    }
}