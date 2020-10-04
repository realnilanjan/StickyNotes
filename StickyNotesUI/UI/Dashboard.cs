using MetroFramework.Forms;
using StickyNotes.Lib.DataAccess;
using StickyNotes.Lib.Models;
using StickyNotesUI.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotesUI.UI
{
    public partial class Dashboard : MetroForm
    {
        List<NoteModel> AllNotes;

        public Dashboard()
        {
            InitializeComponent();
            this.LoadNotes();

            foreach (var note in AllNotes)
            {
                NoteModel noteModel = new NoteModel
                {
                    Id = note.Id,
                    NoteTitle = note.NoteTitle,
                    NoteContent = note.NoteContent,
                    DateCreated = note.DateCreated,
                    DateModified = note.DateModified
                };

                NoteSummary noteSummary = new NoteSummary(noteModel);
                notesListFlow.Controls.Add(noteSummary);
            }
        }

        private void LoadNotes()
        {
            SqliteDataAccess dataAccess = new SqliteDataAccess();
            AllNotes = dataAccess.LoadNotes();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
        }
    }
}
