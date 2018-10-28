using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ObecniApp.Models;
using ObecniApp.Logics;
using System.Data;

namespace ObecniApp
{
    public partial class MainPage : ContentPage
    {
        private Logic _logic;
        private IDbConnection db;
        public MainPage()
        { _logic = new Logic();
            db = _logic._connectHelper.DoSaturnConnection("SYSDBA", "masterkey", "10.11.147.136/3025:d:\\bazyfb25\\saturn_itm.fdb");
            InitializeComponent();
            Obecny _obecny = new Obecny();
            if (db != null) {
                _obecny = _logic.GetObecny(102301, db);
            }
            lblImieNazwisko.Text = _obecny.Imie_nazwisko;
            lblWejscie.Text = _obecny.Wejscie.ToString();
            lblWyjscie.Text = _obecny.Wyjscie.ToString();
        }
    }
}
