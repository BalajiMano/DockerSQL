namespace DockerSQL{

    public class StreamingService : IServices
    {
      


  HttpClient httpClient = new();
        public async Task<string> StreamingAsync(string Url)
        {
        //     for (int i = 1; i <= 10; i++)
        // {
        //     await Task.Delay(1000);
        //     yield return "streaming";
        // }
          
            string? response;
               
 var StreamingData= await httpClient.GetAsync(Url);
                if(StreamingData.IsSuccessStatusCode)
                {
                    response =   await  StreamingData.Content.ReadAsStringAsync();
                    Console.WriteLine($"Url {Url}");
                     return response;
                }
                return "Failure";
         }

       
    }
}