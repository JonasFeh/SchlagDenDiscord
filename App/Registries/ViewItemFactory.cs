using SchlagDenDiscord.Core.Core;
using System;
using System.Collections.Generic;

namespace App.Registries
{
    public static class ViewItemFactory
    {
        public static Dictionary<Guid,ViewItem> ViewItems { get; set; }

        static ViewItemFactory()
        {
            ViewItems = new Dictionary<Guid,ViewItem>();

        }

        public static void StartUpMVVM()
        {
            foreach (var viewItem in ViewItems)
            {
                viewItem.Value.OnStartup();
            }
        }

        public static void ShutdownMVVM()
        {
            foreach (var viewItem in ViewItems)
            {
                viewItem.Value.OnShutdown();
            }
        }

    }
}
