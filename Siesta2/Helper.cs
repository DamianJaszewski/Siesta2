using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siesta2
{
    public static class Helper
    {
        public static string CnnVal(string Siesta)
        {
            return ConfigurationManager.ConnectionStrings[Siesta].ConnectionString;
            //www.connectionstrings.com/sql-server/
        }
    }
}
