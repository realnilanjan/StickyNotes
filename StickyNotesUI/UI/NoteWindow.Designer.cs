namespace StickyNotesUI.UI
{
    partial class NoteWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnMemu = new MetroFramework.Controls.MetroButton();
            this.noteMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtCreated = new MetroFramework.Controls.MetroLabel();
            this.txtModified = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Location = new System.Drawing.Point(8, 63);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(324, 268);
            this.txtNote.TabIndex = 2;
            this.txtNote.Text = "";
            this.txtNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNote_MouseDown);
            this.txtNote.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtNote_MouseMove);
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(8, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(299, 31);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Untitled Note";
            this.txtTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTitle_MouseDown);
            this.txtTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtTitle_MouseMove);
            // 
            // btnMemu
            // 
            this.btnMemu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMemu.ContextMenuStrip = this.noteMenu;
            this.btnMemu.DisplayFocus = true;
            this.btnMemu.Location = new System.Drawing.Point(313, 22);
            this.btnMemu.Name = "btnMemu";
            this.btnMemu.Size = new System.Drawing.Size(19, 31);
            this.btnMemu.TabIndex = 1;
            this.btnMemu.UseSelectable = true;
            // 
            // noteMenu
            // 
            this.noteMenu.Name = "noteMenu";
            this.noteMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // txtCreated
            // 
            this.txtCreated.FontSize = MetroFramework.MetroLabelSize.Small;
            this.txtCreated.Location = new System.Drawing.Point(8, 338);
            this.txtCreated.Name = "txtCreated";
            this.txtCreated.Size = new System.Drawing.Size(143, 19);
            this.txtCreated.TabIndex = 3;
            this.txtCreated.Text = "Created On: {0}";
            this.txtCreated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtModified
            // 
            this.txtModified.FontSize = MetroFramework.MetroLabelSize.Small;
            this.txtModified.Location = new System.Drawing.Point(189, 338);
            this.txtModified.Name = "txtModified";
            this.txtModified.Size = new System.Drawing.Size(143, 19);
            this.txtModified.TabIndex = 3;
            this.txtModified.Text = "Modified On: {0}";
            this.txtModified.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NoteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 362);
            this.Controls.Add(this.txtModified);
            this.Controls.Add(this.txtCreated);
            this.Controls.Add(this.btnMemu);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtNote);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 5);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.TextBox txtTitle;
        private MetroFramework.Controls.MetroButton btnMemu;
        private System.Windows.Forms.ContextMenuStrip noteMenu;
        private MetroFramework.Controls.MetroLabel txtCreated;
        private MetroFramework.Controls.MetroLabel txtModified;
    }
}