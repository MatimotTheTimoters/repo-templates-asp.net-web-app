using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.InteropServices;

namespace DataAccess
{
    public class DataHelper
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MasterDb"].ConnectionString;


    }
}
