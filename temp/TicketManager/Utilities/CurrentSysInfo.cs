using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class CurrentSysInfo: ISystemInformation
    {

        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }

        public string GetMachineName()
        {
            return Environment.MachineName;
        }
    }
}
