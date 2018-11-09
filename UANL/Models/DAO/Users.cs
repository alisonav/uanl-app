using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace UANL.Models.DAO
{
    public class Users
    {
        private const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""c:\users\fabian.molar\documents\visual studio 2015\Projects\UANL\UANL\App_Data\uanl_db.mdf"";Integrated Security=True";

        public DataTable GetUserByUsernameAndPassword(string username, string pass)
        {
            DataTable dtResult = new DataTable();
            string sqlText = "SELECT * FROM Users WHERE username = @username AND password = @password";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sqlText, conn))
                    {
                        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = pass;

                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        adapt.Fill(dtResult);
                    }
                }
            }
            catch (Exception ex)
            {
                new Entities.Exceptions() { errorMessage = ex.Message, stackTrace = ex.StackTrace };
            }
            
            return dtResult;
        }

        public int CreateUser(Entities.Users user)
        {
            int result = 0;

            string sqlText = "INSERT INTO Users (Name, Username, Password, Email, Role) VALUES (@name, @username, @password, @email, @role); SELECT @@IDENTITY";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sqlText, conn))
                    {
                        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = user.name;
                        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user.username;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = user.pass;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = user.email;
                        cmd.Parameters.Add("@role", SqlDbType.Int).Value = user.role.id;

                        result = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                new Entities.Exceptions() { errorMessage = ex.Message, stackTrace = ex.StackTrace };
            }

            return result;
        }
    }
}