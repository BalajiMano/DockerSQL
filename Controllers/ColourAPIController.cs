using System.Reflection.Metadata.Ecma335;
using Dockersql.Models;
using DockerSQL.Service;
using Microsoft.AspNetCore.Mvc;

namespace DockerSQL.Models
{
    [ApiController]
    [Route("[Controller]")]
    public class ColourAPIController : ControllerBase
    {
        private readonly ColourContext _context;
        private readonly IServices _streamingService;
        public ColourAPIController(ColourContext context, IServices services)
        {
            _context = context;
            _streamingService = services;
        }
        [HttpGet]
        public ActionResult<int> GetColourItems()
        {
            //   var colors=_streamingService.GetColours();
            //      if(colors.Any()) return colors;
            //      return colors.ToList();
            //   var _colours= _context.ColourItems.ToList();

            //   if(_colours.Any()) return Ok(_colours.Count());
            //   return Ok(0);

          //  return Ok(GetColor());
Console.WriteLine("Before GetColor Execution");
            var _colours = GetColor().Where(col=>col.ColourName=="RED");
            Console.WriteLine("After GetColor Executed");
            if (_colours.Any())
            {
                //   return Ok(0);
                Console.WriteLine("After Any Executed");
                return Ok(_colours.Count());
            }
            return Ok(_colours.Count());

            /* List<int> agreementNos = [990909, 8888, 7777];

             List<string> strings = ["bala", "anu"];
             List<Task> tasks = new List<Task>();
             Parallel.For(0, agreementNos.Count, i =>
             {
                 Console.WriteLine($"Thread Before ID is {Thread.CurrentThread.ManagedThreadId}");
                 tasks.Add(Task.Factory.StartNew(() => Console.WriteLine($"AgreeNo {agreementNos[i]} and Thread ID {Thread.CurrentThread.ManagedThreadId}")));
             });
             Console.WriteLine("DB Changes Completed");
             //Task.WaitAll(tasks.ToArray());
             //             Parallel.ForEach(strings,  (name)=>
             //      {
             //       Console.WriteLine($"agreement number {name}");
             //  });
             */


        }

        public IQueryable<Colour> GetColor()
        {
            return _context.ColourItems;
        }

        // [HttpGet]
        //         public ActionResult<IEnumerable<String>> Get()
        //         {
        // return new string[] {"value1", "values2"};
        //         }
    }
}