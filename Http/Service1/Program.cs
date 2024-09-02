HttpClient httpClient = new HttpClient();

HttpResponseMessage responseMessage = await httpClient.GetAsync("https://localhost:7144/api/values");

if (responseMessage.IsSuccessStatusCode)
{
    Console.WriteLine(await responseMessage.Content.ReadAsStringAsync());
}
