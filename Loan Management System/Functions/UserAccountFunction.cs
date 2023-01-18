using Loan_Management_System.Void;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Loan_Management_System.Models;

namespace Loan_Management_System.Functions
{
    public class UserAccountFunction : Database
    {
        public bool AuthenticateLoginCredentials(string username, string password)
        {
            using (var connection = DTConnection())
            {
                connection.Open();
                string que = @"select username, userpass, fullname, role 
                                from user_accounts 
                                where username=@username and userpass=sha1(@password);";
                using (var com = new MySqlCommand(que, connection))
                {
                    com.Parameters.Add("@username", MySqlDbType.String).Value = username;
                    com.Parameters.Add("@password", MySqlDbType.String).Value = password;
                    using (MySqlDataReader reader = com.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.Read() == true)
                        {
                            SessionData.Session_Username = (string)reader[0];
                            SessionData.Session_Fullname = (string)reader[2];
                            SessionData.Session_Role = (string)reader[3];
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        public string ConnectionStatus()
        {
            string status = DTConnection().State.ToString();
            return status;
        }
    }
}
