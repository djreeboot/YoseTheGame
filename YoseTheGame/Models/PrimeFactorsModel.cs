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

                if (temp <= 1000000 && temp >= 0)
                {
                    List<int> factors = new List<int>();
                    PrimeNumbers primes = new PrimeNumbers();
                    foreach (int prime in primes)
                    {
                        while (temp%prime == 0)
                        {
                            temp /= prime;
                            factors.Add(prime);
                        }

                        if (temp == 1)
                        {
                            break;
                        }
                    }

                    NumberResponse response = new NumberResponse();
                    response.number = int.Parse(number);
                    response.decomposition = factors;

                    return response;
                }
                else
                {
                    if (temp >= 0)
                    {
                        BigNumberResponse response = new BigNumberResponse();
                        response.number = temp;
                        response.error = "too big number (>1e6)";

                        return response;
                    }
                    else
                    {
                        ErrorResponse response = new ErrorResponse();
                        response.number = number;
                        response.error = number +  " is not an integer > 1";

                        return response;
                    }
                }
            }
            else
            {
                ErrorResponse response = new ErrorResponse();
                response.number = number;
                response.error = "not a number";

                return response;
            }
        }

        public List<Response> Decompose(string[] numbers)
        {
            List<Response> responses = new List<Response>();
            foreach (string number in numbers)
            {
                if (number.IsInt())
                {
                    int temp = int.Parse(number);

                    if (temp <= 1000000)
                    {
                        List<int> factors = new List<int>();
                        PrimeNumbers primes = new PrimeNumbers();
                        foreach (int prime in primes)
                        {
                            while (temp%prime == 0)
                            {
                                temp /= prime;
                                factors.Add(prime);
                            }

                            if (temp == 1)
                            {
                                break;
                            }
                        }

                        NumberResponse response = new NumberResponse();
                        response.number = int.Parse(number);
                        response.decomposition = factors;

                        responses.Add(response);
                    }
                    else
                    {
                        BigNumberResponse response = new BigNumberResponse();
                        response.number = temp;
                        response.error = "too big number (>1e6)";

                        responses.Add(response);
                    }
                }
                else
                {
                    ErrorResponse response = new ErrorResponse();
                    response.number = number;
                    response.error = "not a number";

                    responses.Add(response);
                }
            }

            return responses;
        }
    } 

}