using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Drill.ViewModels
{
    public class ClientInfoVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public double? QuoteTotal { get; set; }

    }
}