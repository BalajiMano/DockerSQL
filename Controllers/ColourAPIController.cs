using Dockersql.Models;
using Microsoft.AspNetCore.Mvc;

namespace DockerSQL.Models
{
[ApiController]
[Route("[Controller]")]
    public class ColourAPIController: ControllerBase
    {
        private readonly ColourContext _context;

        public ColourAPIController(ColourContext context)
        {
 _context =context;
        }
[HttpGet]
        public ActionResult<IEnumerable<Colour>> GetColourItems()
        {
             

            List<int> agreementNos= [990909,8888,7777];
            
            List<string> strings=["bala","anu"];
             List<Task> tasks= new List<Task>();
 Parallel.For(0,agreementNos.Count,i=>
 {
    Console.WriteLine($"Thread Before ID is {Thread.CurrentThread.ManagedThreadId}");
    tasks.Add(Task.Factory.StartNew(()=> Console.WriteLine($"AgreeNo {agreementNos[i]} and Thread ID {Thread.CurrentThread.ManagedThreadId}")));
 });
 Console.WriteLine("DB Changes Completed");
 //Task.WaitAll(tasks.ToArray());
//             Parallel.ForEach(strings,  (name)=>
//      {
//       Console.WriteLine($"agreement number {name}");
//  });

            return _context.ColourItems;
        }

// [HttpGet]
//         public ActionResult<IEnumerable<String>> Get()
//         {
// return new string[] {"value1", "values2"};
//         }
    }
}