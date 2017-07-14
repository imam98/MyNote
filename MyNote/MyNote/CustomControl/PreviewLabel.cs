using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyNote.CustomControl
{
    public class PreviewLabel : Label
    {
        public int MaxLines = 3;

        public PreviewLabel()
        {
            LineBreakMode = LineBreakMode.TailTruncation;
        }
    }
}
