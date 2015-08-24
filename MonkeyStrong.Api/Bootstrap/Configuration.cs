using System.Configuration;
using MonkeyStrong.Api.Bootstrap.Interfaces;

namespace MonkeyStrong.Api.Bootstrap
{
    public class Configuration : IConfiguration
    {
        public string MongoDbUrl
        {
            get { return ConfigurationManager.AppSettings["MongoUrl"]; }
        }
    }
}