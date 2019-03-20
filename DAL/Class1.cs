using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class Class1
    {
        public Class1()
        {
            var a = ConfigurationManager.ConnectionStrings["connectStr"];
            int b = 0;
        }
    }
}
