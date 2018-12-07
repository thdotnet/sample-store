using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Core.Interfaces;

namespace WebApplication2.Infrastructure.Redis
{
    public class RedisService<T> : IRedisService<T> where T : class
    {
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _db;

        public RedisService(IConfiguration config)
        {
            _redis = ConnectionMultiplexer.Connect(config.GetSection("Azure:Redis").Value);
            _db = _redis.GetDatabase();
        }


        public T Get<T>(string key)
        {
            var value = _db.StringGet(key);

            if (string.IsNullOrWhiteSpace(value) == false)
            {
                return JsonConvert.DeserializeObject<T>(value);
            }

            return default(T);
        }

        public void Set(string key, string value)
        {
            _db.StringSet(key, value);            
        }

        public void Delete(string key)
        {
            _db.KeyDelete(key);
        }
    }
}
