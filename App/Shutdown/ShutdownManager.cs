namespace App.Shutdown
{
    internal static class ShutdownManager
    {
        static ShutdownManager()
        {
        }

        private static void Shutdown()
        {
            System.Windows.Application.Current.Shutdown();
        }

        public static void ExecuteShutdownRoutine()
        {
            Shutdown();
        }

    }
}
