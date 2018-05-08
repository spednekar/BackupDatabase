using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            if (ConfigureService.IsConfigured)
            {
                Log.Info("Service Configured");
            }
        }
    }
}
