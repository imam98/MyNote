using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net;

namespace MyNote
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
