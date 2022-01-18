using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Configuration;

namespace UnitTestProject1.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetUserName();
        string GetPassword();
        string GetWebsite();
        int GetPageLoadTimeout();
        int GetElementLoadTimeout();
    }
}
