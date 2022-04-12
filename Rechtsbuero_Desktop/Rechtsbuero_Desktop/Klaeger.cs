using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechtsbuero_Desktop
{
    internal class Klaeger : Person
    {
        public Klaeger(string vorName, string nachName, string tcNummer, string telefonNummer) : base(vorName, nachName, tcNummer, telefonNummer)
        {

        }
        public Klaeger(string vorName, string nachName, string tcNummer, string emailAdresse, string telefonNummer, string geschlecht, string teamNummer, int alter) : base(vorName, nachName, tcNummer, emailAdresse, telefonNummer, geschlecht, teamNummer, alter)
        {

        }
    }
}
