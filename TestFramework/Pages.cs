using System;
namespace TestFramework
{
    public static class Pages
    {
        public static class HomePage
        {
            static string Url = "https://pluralsight.com";
            static string PageTitle = "Home | Pluaralsight";

            public static void GoTo()
            {
                Browser.GoTo(Url);
            }

            public static bool IsAt()
            {
                return Browser.Title == PageTitle;
            }
        }
    }
}
