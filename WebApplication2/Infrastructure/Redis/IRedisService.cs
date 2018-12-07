namespace WebApplication2.Infrastructure.Redis
{
    public interface IRedisService<T> where T : class
    {
        void Delete(string key);

        T Get<T>(string key);

        void Set(string key, string value);
    }
}