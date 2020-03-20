using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using TAREA7.ViewModels;
using TAREA7.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TAREA7
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync(new Uri(NavConstants.Login));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            //especificar el view y view model.
            //registrar todas las clases que se usaran en el programa

        }
    }
}
