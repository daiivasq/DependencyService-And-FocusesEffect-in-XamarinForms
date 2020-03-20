using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using TAREA7.iOS.Services;
using TAREA7.Services;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly: Dependency(typeof(DeviceOrientationService))]
namespace TAREA7.iOS.Services
{
   
    public class DeviceOrientationService : IDeviceOrientationService
    {
        #region IDeviceOrientationService implementation

        public DeviceOrientation GetOrientation()
        {
            var currentOrientation = UIApplication.SharedApplication.StatusBarOrientation;
            bool isPortrait = currentOrientation == UIInterfaceOrientation.Portrait || currentOrientation == UIInterfaceOrientation.PortraitUpsideDown;

            return !isPortrait ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;

        }

        #endregion
    }
}