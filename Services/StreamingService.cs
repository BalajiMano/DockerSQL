using Dockersql.Models;

namespace DockerSQL.Service
{

    public class StreamingService : IServices
    {

 private readonly ColourContext _context;

 public StreamingService(ColourContext context)
        {
            _context = context;
          
        }

        HttpClient httpClient = new();
        public async Task<string> StreamingAsync(string Url)
        {
            //     for (int i = 1; i <= 10; i++)
            // {
            //     await Task.Delay(1000);
            //     yield return "streaming";
            // }

            string? response;

            var StreamingData = await httpClient.GetAsync(Url);
            if (StreamingData.IsSuccessStatusCode)
            {
                response = await StreamingData.Content.ReadAsStringAsync();
                Console.WriteLine($"Url {Url}");
                return response;
            }
            return "Failure";
        }

        public IEnumerable<Colour> GetColours()
        {
            var _colourList=new List<Colour>{
                 new Colour() {id=1,ColourName="WHITE"},
                 new Colour() {id=2,ColourName="RED"},
                 new Colour() {id=3,ColourName="BLACK"},
                 new Colour() {id=4,ColourName="GREEN"}};
            var items=     _context.ColourItems.Where(col=>col.ColourName.Length>2);
            foreach( var col in items)
            {
                yield return col;
            }
            //return _colourList;
        }


    }
}