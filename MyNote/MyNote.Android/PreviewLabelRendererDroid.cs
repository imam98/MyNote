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

[assembly: ExportRenderer(typeof(PreviewLabel), typeof(PreviewLabelRendererDroid))]
namespace MyNote.Droid
{
    public class PreviewLabelRendererDroid : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var baseLabel = (PreviewLabel)this.Element;
                Control.SetLines(baseLabel.MaxLines);
            }
        }
    }
}