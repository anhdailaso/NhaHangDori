using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cas.Helpers;

namespace Cas.Areas.Vietcon.Models.Helper
{
    public class StatusUtil
    {
        public static string OrderReturnStatusText(int status)
        {
            string sText = "-";
            switch (status)
            {
                case -2:
                    {
                        sText = Protect.ToString(Resources.Vietcon.STATUS_ORDER_RETURN_m2);
                        break;
                    }
                case 0:
                    {
                        sText = Protect.ToString(Resources.Vietcon.STATUS_ORDER_RETURN_0);
                        break;
                    }
                case 1:
                    {
                        sText = Protect.ToString(Resources.Vietcon.STATUS_ORDER_RETURN_1);
                        break;
                    }
                case 2:
                    {
                        sText = Protect.ToString(Resources.Vietcon.STATUS_ORDER_RETURN_2);
                        break;
                    }
            }
            return sText;
        }
    }
}