using System;
using Microsoft.Extensions.Configuration;

namespace listbot.Helpers
{

    public interface IWegmansManager
    {

    }


    public class WegmansManager : IWegmansManager
    {

        IConfiguration _config;

        public WegmansManager(IConfiguration config)
        {
            _config = config;
        }
    }
}
