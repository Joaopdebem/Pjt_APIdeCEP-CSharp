using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RequisicaoAPIdeCEP
{
    public class Program
    {
        static void Main(string[] args)
        {
            InvocarGet();
            //InvocarPost();
        }

        //private static void InvocarPost() { }

        private static void InvocarGet()
        {
            string cep = "88135540";

            var client = new RestClient($"https://viacep.com.br/ws/{cep}/json/");
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(response.Content);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }

            Console.ReadKey();
        }
    }

    public class correio
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string ddd { get; set; }
        public string siafi { get; set; }

    }




}
