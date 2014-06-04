using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YoseTheGame.Models
{
    public class ErrorResponse : Response
    {
        public string number { get; set; }
        public string error { get; set; }
    }
}