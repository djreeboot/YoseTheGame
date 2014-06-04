using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YoseTheGame.Models
{
    public class NumberResponse : Response
    {
        public int number { get; set; }
        public List<int> decomposition { get; set; }
    }
}