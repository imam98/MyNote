using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using MyNote.CustomControl;
using MyNote.UWP;

[assembly: ExportRenderer(typeof(ContentEditor), typeof(ContentEditorRendererUWP))]
namespace MyNote.UWP
{
    public class ContentEditorRendererUWP : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
            }
        }
    }
}
