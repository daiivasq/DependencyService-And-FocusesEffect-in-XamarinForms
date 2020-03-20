﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using TAREA7.Controls;
using TAREA7.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(EntryBackground), typeof(MyEntryRendererIos))]
namespace TAREA7.iOS.Renderers
{
    public class MyEntryRendererIos:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}