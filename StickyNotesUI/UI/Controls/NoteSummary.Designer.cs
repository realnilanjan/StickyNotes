namespace StickyNotesUI.UI.Controls
{
    partial class NoteSummary
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNoteHeader = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // txtNoteGHeader
            // 
            this.txtNoteHeader.BackColor = System.Drawing.Color.Transparent;
            this.txtNoteHeader.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.txtNoteHeader.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNoteHeader.Location = new System.Drawing.Point(3, 3);
            this.txtNoteHeader.Name = "txtNoteGHeader";
            this.txtNoteHeader.Size = new System.Drawing.Size(323, 66);
            this.txtNoteHeader.TabIndex = 0;
            this.txtNoteHeader.Text = "metroLink1";
            this.txtNoteHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNoteHeader.UseCustomBackColor = true;
            this.txtNoteHeader.UseSelectable = true;
            this.txtNoteHeader.Click += new System.EventHandler(this.txtNoteGHeader_Click);
            // 
            // NoteSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.txtNoteHeader);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "NoteSummary";
            this.Size = new System.Drawing.Size(329, 72);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink txtNoteHeader;
    }
}
