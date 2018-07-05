using GeoSeleniumWebdriver.Settings;

namespace GeoSeleniumWebdriver.ComponentHelper
{
    public class WindowHelper
    {
        public static string GetTitle()
        {
            return ObjectRepository.Driver.Title;
        }
    }
}
