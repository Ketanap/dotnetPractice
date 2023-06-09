namespace dotnetweb.Services;
using dotnetweb.Models;
using System.Data.SqlClient;
public class Service
{
    SqlConnection? con =null;
    public Service(){
        con=new SqlConnection("Data Source=PCC-SERVER\\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=true;");
    }
    public void Execute(SqlCommand cmd)
    {
        try{
            con.Open();
            cmd.Connection=con;
            cmd.ExecuteNonQuery();
            con.Close();
        }finally{

        }
    }
}