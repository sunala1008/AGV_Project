using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGV.Data
{
    class AGVData : EntityData<AGVRegist>
    {
        //public AGVRegist GetAGVINFO(string AGVName)
        //{
        //    using (AGV_ProjectEntities context = new AGV_ProjectEntities())
        //    {
        //        var query = from x in context.AGVRegists
        //                    select new
        //                    {
        //                        AGVIP = x.AGVIP,
        //                        AGVPort = x.AGVPort
        //                    };

        //        var list = query.ToList();

        //        //return list.ConvertAll(x => x.AGVIP);
        //    }
        //}

        public Regist Check(string ENum, string pw, string EName)
        {
            using (AGV_ProjectEntities context = new AGV_ProjectEntities())
            {
                var query = from x in context.Regists
                            where
                             x.EmployeeNum.Equals(ENum) && x.Password.Equals(pw) && x.OperatorName.Equals(EName)
                            select x;

                var list = query.ToList();

                return list.FirstOrDefault();
            }
        }
    }
}
