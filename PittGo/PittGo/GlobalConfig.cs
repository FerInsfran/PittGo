using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PittGo.Classes; 
namespace PittGo
{
    public static class GlobalConfig
    {
        public static MobileServiceClient MobileService =
                 new MobileServiceClient(
                  "https://pittgo.azurewebsites.net"
                  );
        public static User LoggedInUser;
    }
}
