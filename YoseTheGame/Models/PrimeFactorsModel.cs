using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace YoseTheGame.Models
{
    public class PrimeFactorsModel
    {
        public Response Decompose(string number)
        {
            if (number.IsInt())
            {
                int temp = int.Parse(number);
                List<int> decomposition = new List<int>();
                while (temp != 1)
                {
                    temp /= 2;
                    decomposition.Add(2);
                }

                NumberResponse response = new NumberResponse();
                response.number = int.Parse(number);
                response.decomposition = decomposition;

                return response;
            }
            else
            {
                ErrorResponse response = new ErrorResponse();
                response.number = number;
                response.error = "not a number";

                return response;
            }
        }
    } 

}