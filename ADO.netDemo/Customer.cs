using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.netDemo
{
    public class Customer
    {
        public static void CreateDatabase()
        {
            SqlConnection con = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog=master; integrated security=true");
            try
            {
                //writing sql query
                string query = "create database Customerdatabase";
                SqlCommand cm = new SqlCommand(query, con);

                //opening connection
                con.Open();

                //Executing sql query
                cm.ExecuteNonQuery();

                //Displaying message
                Console.WriteLine("Database created successfully");
                Console.WriteLine("------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public static SqlConnection con = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog=Customerdatabase; integrated security=true");
        public static void CreateTable()
        {
            try
            {
                //writing sql query
                string query = "create table Customer(Id int identity(1,1)primary key, Name varchar(200), City varchar(200)) ";
                SqlCommand cm = new SqlCommand(query, con); //we can pass store procedure, query,cant inherit this class

                //opening connection
                con.Open();

                //Executing sql query
                cm.ExecuteNonQuery();

                //Displaying message
                Console.WriteLine("Table created successfully");
                Console.WriteLine("------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}