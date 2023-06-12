namespace dotnetweb.Services;
using dotnetweb.Models;
using System.Data.SqlClient;
using System.Data;
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
            
        }finally{
            con.Close();
        }
    }
    public DataTable GetData(SqlCommand cmd)
    {
        
        try{
            con.Open();
            cmd.Connection=con;
            DataTable dt=new DataTable(); 
            dt.Load(cmd.ExecuteReader());
            return dt;
        }catch(Exception ex){
            return new DataTable();
        }        
        finally{
            con.Close();
        }
    }
}