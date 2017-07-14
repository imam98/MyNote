using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using MyNote.CustomControl;
using MyNote.iOS;

[assembly: ExportRenderer(typeof(PreviewLabel), typeof(PreviewLabelRendereriOS))]
namespace MyNote.iOS
{
    public class PreviewLabelRendereriOS : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var baseLabel = (PreviewLabel)this.Element;
                Control.Lines = baseLabel.MaxLines;
            }
        }
    }
}
