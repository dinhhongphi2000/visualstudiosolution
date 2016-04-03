using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SINHVIEN.Code
{
    public class SessionHelper
    {
        public static void SetSession(UserSession session)
        {
            HttpContext.Current.Session["LoginSession"] = session;
        }

        public static UserSession GetSession()
        {
            var result = HttpContext.Current.Session["LoginSession"];
            if (result == null)
                return null;
            return result as UserSession;
        }
    }
}