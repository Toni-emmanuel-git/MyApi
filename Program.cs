using System;
using System.Net.Http;

class Program
{
    static async Task Main(string[] args)
    {
        await Get();
    }

    static async Task Get()
    {
        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");

        var data = await response.Content.ReadAsStringAsync();
        Console.WriteLine(data);
    }

}
