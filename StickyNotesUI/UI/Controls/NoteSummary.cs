using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StickyNotes.Lib.Models;

namespace StickyNotesUI.UI.Controls
{
    public partial class NoteSummary : UserControl
    {
        NoteWindow noteWindow;
        private readonly NoteModel note;

        public NoteSummary(NoteModel note)
        {
            InitializeComponent();
            txtNoteHeader.Text = note.NoteTitle;
            this.note = note;
        }

        private void txtNoteGHeader_Click(object sender, EventArgs e)
        {
            if (noteWindow == null)
            {
                noteWindow = new NoteWindow(note);
                noteWindow.FormClosed += new FormClosedEventHandler(noteWindow_FormClosed);
                noteWindow.Show(this);
            }
            else
            {
                noteWindow.Activate();
            }
        }

        private void noteWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            noteWindow = null;
        }
    }
}
