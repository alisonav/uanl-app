using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UANL.Entities
{
    public class Exceptions
    {
        public string errorMessage { get; set; }
        public string stackTrace { get; set; }

        public Exceptions()
        {
            this.errorMessage = "";
            this.stackTrace = "";
        }
    }
}