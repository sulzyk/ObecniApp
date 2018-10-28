using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.FirebirdClient;

namespace ObecniApp.Logics
{
    class DBHelper
    {
        private IDbConnection _dbConnection;

        public DBHelper()
        {

        }
        public IDbConnection DoSaturnConnection(string login, string pass, string db)
        {
            if (login == "" && pass == "")
            {                
                return null;
            }
            if (login == "")
            {               
                return null;
            }
            if (pass == "")
            {                
                return null;
            }

            var connectionString = string.Format("User={0}; Password={1}; Database={2}", login, pass, db);

            // Test łączenia do FireBirda
            try
            {
                _dbConnection = new FbConnection(connectionString);
                if (_dbConnection.State == ConnectionState.Open) return _dbConnection;
                _dbConnection.Open();
            }
            catch (Exception)
            {                
                return null;                
            }
            return _dbConnection;
        }
    }
}
