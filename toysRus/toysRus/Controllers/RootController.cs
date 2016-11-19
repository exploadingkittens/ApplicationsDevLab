using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace toysRus.Controllers
{
    public class RootController : Controller
    {
        public const string INFO_MSG = "msg";
        public const string ERROR_MSG = "errorMsg";

        public void AddError(string msg)
        {
            GetOrAddMsgList(ERROR_MSG).Add(msg);
        }

        public void AddInfo(string msg)
        {
            GetOrAddMsgList(INFO_MSG).Add(msg);
        }

        private List<string> GetOrAddMsgList(string listName)
        {
            object msgList;

            if (!TempData.TryGetValue(listName, out msgList))
            {
                msgList = new List<string>();
                TempData[listName] = msgList;
            }
            else
            {
                msgList = new List<string>(((IEnumerable<string>)msgList));
                TempData[listName] = msgList;
            }

            return (List<string>)msgList;
        }
    }
}