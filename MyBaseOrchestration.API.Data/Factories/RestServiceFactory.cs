using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBaseOrchestration.API.Data.Interfaces;
using ServiceStack;

namespace MyBaseOrchestration.API.Data.Factories
{
    public class RestServiceFactory : IRestServiceFactory
    {
        public string BaseUri { get; set; }

        public RestServiceFactory(string baseUri)
        {
            BaseUri = baseUri;
        }
        public IServiceClient GenerateInstance()
        {
            var client = new JsonServiceClient(BaseUri);
            return client;
        }
    }
}
