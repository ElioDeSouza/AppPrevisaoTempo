using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppPrevisaoTempo.Model;

namespace AppPrevisaoTempo.Services
{
   class DataServise
    {
         public static async Task<Tempo> GetPrevisaoDoTempo(string cidade)
        {
            string appId = "152dbc4cacb1df9b5ca15a18989c2396";

            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + cidade + "&units=metric" + "&appid=" + appId;
        }
    }
}
