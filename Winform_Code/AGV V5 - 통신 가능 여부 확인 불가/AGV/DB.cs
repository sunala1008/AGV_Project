using AGV.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGV
{
    class DB
    {

        public static EmployeeData employee { get; } = new EmployeeData();

        public static AGVData agvInfo { get; } = new AGVData();
    }
}
