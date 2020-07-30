using AtomSkills.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomSkills
{
    partial class Transports
    {
        public string Status
        {
            get
            {
                if ((DateTime.Now.Year - Date.Year) >= 5 && DateOff.Value == null)
                {
                    return "Требует списание.";
                }
                else if (DateOff.Value != null)
                {
                    return "Списан.";
                }
                else
                {
                    return "Аппарат в порядке.";
                }
            }
        }
    }
    partial class Orders
    {
        public string Supplier
        {
            get
            {
                string result = string.Empty;
                foreach (var x in Manager.context.Users)
                {
                    if (IDSupplier == x.ID)
                    {
                        result = $"{x.LastName} {x.FirstName} {x.MiddleName}";
                    }
                }
                return result;
            }
        }
        public string Operator
        {
            get
            {
                string result = string.Empty;
                foreach (var x in Manager.context.Users)
                {
                    if (IDOperator == x.ID)
                    {
                        result = $"{x.LastName} {x.FirstName} {x.MiddleName}";
                    }
                }
                return result;
            }
        }
        public string Transport
        {
            get
            {
                string result = string.Empty;
                foreach (var x in Manager.context.Transports)
                {
                    if (IDTrans == x.ID)
                    {
                        result = x.Number;
                    }
                }
                return result;
            }
        }
    }
}
