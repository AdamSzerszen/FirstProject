using FirstProject.BusinessLogic.Services.Dialogs;
using FirstProject.BusinessLogic.Services.Messaging;
using FirstProject.Services.DialogService;
using FirstProject.Services.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace FirstProject.Dependencies
{
    public static class Configuration
    {
        private static bool configured = false;

        public static void Configure(IUnityContainer container)
        {
            if (configured)
                return;

            container.RegisterType<IMessagingService, MessagingService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IDialogService, DialogService>(new ContainerControlledLifetimeManager());

            FirstProject.BusinessLogic.Dependencies.Configuration.Configure(container);

            configured = true;
        }
    }
}
