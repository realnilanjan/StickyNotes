using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotes.Lib
{
    public static class Queries
    {
        public static string GetNotesQuery 
        {
            get { return "SELECT * FROM AllNotes"; }
        }

        public static string InsertNotesQuery
        {
            get { return "INSERT INTO AllNotes (NoteTitle, NoteContent) VALUES (@NoteTitle, @NoteContent)"; }
        }
    }
}
