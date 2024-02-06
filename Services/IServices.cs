using Dockersql.Models;

namespace DockerSQL.Service

{
    public interface IServices
    {
        public   Task<string>  StreamingAsync(string Urls);
        public IEnumerable<Colour> GetColours();
    }
}