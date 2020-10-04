using MetroFramework.Forms;
using StickyNotes.Lib.Models;
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
    public partial class NoteWindow : MetroForm
    {
        public NoteWindow(NoteModel note)
        {
            InitializeComponent();
            this.Tag = note.Id;
            txtTitle.Text = note.NoteTitle;
            txtNote.Text = note.NoteContent;
            DateTime createdon = Convert.ToDateTime(note.DateCreated);
            DateTime IST = createdon.AddHours(5.5);
            txtCreated.Text = String.Format(txtCreated.Text, IST.ToString());
        }

        Point _mouseLoc;

        private void txtTitle_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void txtTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void txtNote_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void txtNote_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
    }
}
