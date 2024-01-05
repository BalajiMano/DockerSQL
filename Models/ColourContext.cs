
using Microsoft.EntityFrameworkCore;
namespace Dockersql.Models
{

    public class ColourContext :DbContext
    {
     public ColourContext(DbContextOptions<ColourContext> opt):base(opt)
     {

     }
     public DbSet<Colour> ColourItems {set; get;}
    }
}