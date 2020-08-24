using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;

namespace WebApplication1
{
    public static class api
    {
        public static string GetPassangersAmnt(int id)
        {
            return new WebClient().DownloadString("http://daniel.kirtchuk.com/GetPassangersAmount.php/?Id=" + id);
        }

        public static string AddPassanger(int id)
        {
            return new WebClient().DownloadString("http://daniel.kirtchuk.com/AddPassangers.php/?Id=" + id);
            
        }
        public static string RemovePassanger(int id)
        {
            return new WebClient().DownloadString("http://daniel.kirtchuk.com/RemovePassangers.php/?Id=" + id);
        }

    }
}