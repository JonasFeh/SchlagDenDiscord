using App.Registries;

namespace App.Startup
{
    internal static class StartupManager
    {

        static StartupManager()
        {

        }

        public static void StartUp()
        {
            ViewItemFactory.StartUpMVVM();
        }

    }
}
