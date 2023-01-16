using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Loan_Management_System.Void
{
    public abstract class Database
    {
        private readonly string _connectionString;
        private readonly MySqlConnection _connection;

        public Database()
        {
            _connectionString = "server=localhost;userid=ct_lending;password=Lending@2019_ChonaTalan;database=chonatalan_lending";
            _connection = new MySqlConnection(_connectionString);
        }

        protected MySqlConnection DTConnection()
        {
            return _connection;
        }

        //protected void OpenConnection()
        //{
        //    _connection.Close();
        //    if (_connection.State == ConnectionState.Closed)
        //    {
        //        _connection.Open();
        //    }
        //}

        //protected void CloseConnection()
        //{
        //    if (_connection.State == ConnectionState.Open)
        //    {
        //        _connection.Close();
        //    }
        //}
    }
}
