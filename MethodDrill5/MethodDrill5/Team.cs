using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill5
{
    static public class Team
    {
        // fields
        public static string BestTeam;
        public static string Reason;

        static Team()
        {
            BestTeam = "St. Louis Cardinals";
            Reason = "I used the best baseball team to be a static constructor because this data is sealed to be true";
        }

    }
}
