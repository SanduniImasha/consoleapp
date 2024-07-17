using System;
using System.Runtime.InteropServices;
//using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ConsoleApp1;


namespace JsonPractice;

class Program
{
    
    static async Task Main(string[] args)
    {
        string url = "https://api.coindesk.com/v1/bpi/currentprice.json";

        HttpClient httpClient = new HttpClient();  //http client to get request  

        try
        {
            var httpResponseMessage = await httpClient.GetAsync(url); //get request
                                                                      //read the string from the response's content
            string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(jsonResponse);


            Result myPosts = JsonConvert.DeserializeObject<Result>(jsonResponse);

            Console.WriteLine(JsonConvert.SerializeObject(myPosts.BPI.GBP));

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}