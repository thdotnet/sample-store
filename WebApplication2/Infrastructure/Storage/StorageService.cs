using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Blob;
using WebApplication2.Core.Models;
using Newtonsoft.Json;

namespace WebApplication2.Infrastructure.Storage
{
    public class StorageService
    {
        private readonly CloudStorageAccount _account;
        private readonly CloudBlobClient _blobClient;

        public StorageService(IConfiguration config)
        {
            _account = CloudStorageAccount.Parse(config.GetSection("Azure:Storage").Value);
            _blobClient = _account.CreateCloudBlobClient();
        }

        public void Add(Carrinho carrinho)
        {            
            var container = _blobClient.GetContainerReference("carrinho");
            container.CreateIfNotExistsAsync().Wait();

            var blob = container.GetBlockBlobReference($"{Guid.NewGuid()}.json");
            blob.UploadTextAsync(JsonConvert.SerializeObject(carrinho)).Wait();
        }


    }
}
