using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using TAREA7.Services;
using Xamarin.Forms;

namespace TAREA7.ViewModels
{
    public class LoginPageViewModel 
    {
        public DelegateCommand RotationCommand { get; set; }
        public LoginPageViewModel()
        {
            RotationCommand = new DelegateCommand(() => {
                DependencyService.Get<IDeviceOrientationService>().GetOrientation();

            });
        }
    }
}
