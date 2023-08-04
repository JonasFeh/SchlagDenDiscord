using App.Registries;
using Common;
using Data;
using Data.Serializer;

namespace App.Startup
{
    internal static class StartupManager
    {
        private static DataSerializer DataSerializer { get; set; }

        private static ProcessImage ProcessImage
        {
            get => ProcessImage.Instance;
            set => ProcessImage.Instance = value;
        }

        static StartupManager()
        {
            DataSerializer = new DataSerializer();
        }

        public static void StartUp()
        {
            ViewItemFactory.StartUpMVVM();
            LoadProcessImage();
        }

        private static void LoadProcessImage()
        {
            DataSerializer.Load<ProcessImage>( Constants.Data.FileNameTeams, out var data );
            if ( data == null )
            {
                return;
            }

            ProcessImage = data;
        }
    }
}
