using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using MyNote.CustomControl;
using MyNote.iOS;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(ContentEditor), typeof(ContentEditorRendereriOS))]
namespace MyNote.iOS
{
    public class ContentEditorRendereriOS : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            
            if (Control != null)
            {
                Control.Layer.BorderWidth = 0;
            }
        }
    }
}
