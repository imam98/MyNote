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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using MyNote.CustomControls;
using MyNote.Droid;

[assembly: ExportRenderer(typeof(ContentEditor), typeof(ContentEditorRendererDroid))]
namespace MyNote.Droid
{
    public class ContentEditorRendererDroid : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = null;
            }
        }
    }
}