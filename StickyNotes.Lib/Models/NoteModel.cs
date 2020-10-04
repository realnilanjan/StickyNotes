using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotes.Lib.Models
{
    public class NoteModel
    {
        public int Id { get; set; }
        public string NoteTitle { get; set; }
        public string NoteContent { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
    }
}
