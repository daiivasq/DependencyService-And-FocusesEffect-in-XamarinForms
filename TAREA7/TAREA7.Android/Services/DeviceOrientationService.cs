using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TAREA7.Droid.Services;
using TAREA7.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly: Dependency(typeof(DeviceOrientationService))]
namespace TAREA7.Droid.Services
{
   public class DeviceOrientationService : IDeviceOrientationService
    {
        #region IDeviceOrientationService implementation

        public DeviceOrientation GetOrientation()
        {

            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            var rotation = windowManager.DefaultDisplay.Rotation;


            bool isLandscape = rotation == SurfaceOrientation.Rotation90 || rotation == SurfaceOrientation.Rotation270;

            return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;

        }

        #endregion
    }
}