namespace DockerSQL

{
    public interface IServices
    {
        public   Task<string>  StreamingAsync(string Urls);
    }
}