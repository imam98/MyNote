using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;

namespace MyNote.DataModels
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}
