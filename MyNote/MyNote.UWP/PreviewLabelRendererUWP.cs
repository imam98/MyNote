using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using MyNote.CustomControls;
using MyNote.UWP;

[assembly: ExportRenderer(typeof(PreviewLabel), typeof(PreviewLabelRendererUWP))]
namespace MyNote.UWP
{
    public class PreviewLabelRendererUWP : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.TextTrimming = Windows.UI.Xaml.TextTrimming.CharacterEllipsis;
            }
        }
    }
}
