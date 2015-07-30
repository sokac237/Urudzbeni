using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Urudzbeni_ured
{
    class Global
    {
        private static string ImePrezime = "";
        public static string Korisnik
        {
            get { return ImePrezime; }
            set { ImePrezime = value; }
        }

        private static string IDkoirsnika = "";
        public static string KorisnikID
        {
            get { return IDkoirsnika; }
            set { IDkoirsnika = value; }
        }

        private static string Nivo = "";
        public static string NivoKorisnika
        {
            get { return Nivo; }
            set { Nivo = value; }
        }


        private static string Prava = "";
        public static string PravaKorisnika
        {
            get { return Prava; }
            set { Prava = value; }
        }
    }
}
