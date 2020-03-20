using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace TAREA7.Services
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
