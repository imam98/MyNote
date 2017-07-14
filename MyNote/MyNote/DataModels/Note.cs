using System;
using System.Collections.Generic;
using System.Text;

namespace MyNote.DataModels
{
    public class Note
    {
        public string Title { get; set; }
        public string NotePreview { get; set; }
        public string Filename { get; set; }
        public DateTime Created { get; set; }
    }
}
