using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using CRUDwithWebAPI;

namespace CRUDwithWebAPI12
{
    public class BookRep
    {

        //string ConnectValues;

        BookShop Regiss = new BookShop();

           string ConnectValues = "Data source=DESKTOP-Q9V2K5P\\SQLEXPRESS;Initial Catalog = Web API;User id=sa;password=Anaiyaan@123;";
           SqlConnection connection;

        public BookRep()
        {
            connection = new SqlConnection(ConnectValues);
        }
        public void SignUp1(BookShop Regiss)
        {
            try

            {

                var InsertSql = $"Insert into  BookShop Values('{Regiss.BookName}','{Regiss.Authour}','{Regiss.ToatalNoPages}','{Regiss.PublishedBy}',{Regiss.ContactNo})";
                //var ConnectValues = "Data source=DESKTOP-Q9V2K5P\\SQLEXPRESS;Initial Catalog=batch-8;User id=sa;password=Anaiyaan@123;";
                //SqlConnection connection = new SqlConnection(ConnectValues);
                connection.Open();
                connection.Execute(InsertSql);
                connection.Close();

            }

            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)

            {
                throw;
            }

        }

        public IEnumerable<BookShop> SignUpUpdate(string b,long a)
        {
            try
            {


                

                    var UpdateSql = $" UPdate BookShop set ToatalNoPages= {a} where BookName ='{b}';";
                   // SqlConnection connection = new SqlConnection(ConnectValues);
                    connection.Open();
                    var selectsall = connection.Query<BookShop>(UpdateSql);
                    connection.Close();
                    return selectsall;
                
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        public object SignUpUpdate(string b)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookShop> DeleteTable(string BookName)

        {
            try
            {
                var DeleteSql = $"Delete from BookShop where BookName='{BookName}';";
                SqlConnection connection = new SqlConnection(ConnectValues);
                connection.Open();
                var selectsall = connection.Query<BookShop>(DeleteSql);
                connection.Close();
                return selectsall;
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public IEnumerable<BookShop> Select()

        {
            try
            {
                var selectquary = $"select * from BookShop ";
                SqlConnection connection = new SqlConnection(ConnectValues);
                connection.Open();
                var selectsall = connection.Query<BookShop>(selectquary);
                connection.Close();
                return selectsall;


            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
