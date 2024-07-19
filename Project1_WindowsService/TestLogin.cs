using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_WindowsService
{
    //Kur te krijohet nje objekt TestLogin, le te injektohet nje logger,
    //e cila i jepet si vlere variablit _logger
    public class TestLogin
    {
        private readonly ILogger<TestLogin> _logger; //1  login pra nlog.config
        private readonly IConfigurationRoot _config; //2 Configuration File pra appsettings.json
        public TestLogin(ILogger<TestLogin> logger, IConfigurationRoot config) //ctor
        {
            _logger = logger; 
            _config = config; 
        }

        public void Shenim() //3 me shenuar ne login
        {
            var test = _config["Folderi"]; //i qasemi si Dictionary
            _logger.LogInformation($"Shenuam dicka ne log {test}");
            _logger.LogError("Gabim Gabim");
        }
    }
}
