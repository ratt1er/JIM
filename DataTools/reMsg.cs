using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTools
{

    public class reMsg
    {
        public string kind;
        public object msg;
        public reMsg(string _kind, object _msg)
        {
            kind = _kind;
            msg = _msg;
        }
        public reMsg(object _msg)
        {
            kind = "success";
            msg = _msg;
        }
    }
}
