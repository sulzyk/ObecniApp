using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using ObecniApp.Models;
using FirebirdSql.Data.FirebirdClient;
using Dapper;
using System.Linq;

namespace ObecniApp.Logics
{
    class Logic
    {
        public readonly DBHelper _connectHelper;
        public Logic()
        {
            _connectHelper = new DBHelper();
        }


        public Obecny GetObecny(int pracId, IDbConnection db)
        {
            var qry = string.Format("select imie_nazwisko, wejscie, wyjscie from sprawdz_obecnosc({0})", pracId);
            Obecny _obecny;
            
            
                _obecny = db.QueryFirstOrDefault<Obecny>(qry);
            
            
            return _obecny;
        }
            
    }
}
