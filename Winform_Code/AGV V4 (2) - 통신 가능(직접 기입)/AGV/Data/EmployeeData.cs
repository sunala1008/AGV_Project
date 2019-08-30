using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGV.Data
{
    class EmployeeData : EntityData<Regist>
    {
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
