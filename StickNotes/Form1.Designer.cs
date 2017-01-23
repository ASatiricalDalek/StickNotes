namespace StickNotes
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.lst_Notes = new System.Windows.Forms.ListBox();
            this.btn_NewNote = new System.Windows.Forms.Button();
            this.btn_DeleteNote = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_NewStickPad = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_RenameNote = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_Notes
            // 
            this.lst_Notes.FormattingEnabled = true;
            this.lst_Notes.Location = new System.Drawing.Point(12, 85);
            this.lst_Notes.Name = "lst_Notes";
            this.lst_Notes.Size = new System.Drawing.Size(230, 251);
            this.lst_Notes.TabIndex = 0;
            // 
            // btn_NewNote
            // 
            this.btn_NewNote.Location = new System.Drawing.Point(248, 85);
            this.btn_NewNote.Name = "btn_NewNote";
            this.btn_NewNote.Size = new System.Drawing.Size(98, 30);
            this.btn_NewNote.TabIndex = 2;
            this.btn_NewNote.Text = "New Note";
            this.btn_NewNote.UseVisualStyleBackColor = true;
            this.btn_NewNote.Click += new System.EventHandler(this.btn_NewNote_Click);
            // 
            // btn_DeleteNote
            // 
            this.btn_DeleteNote.Location = new System.Drawing.Point(248, 306);
            this.btn_DeleteNote.Name = "btn_DeleteNote";
            this.btn_DeleteNote.Size = new System.Drawing.Size(98, 30);
            this.btn_DeleteNote.TabIndex = 3;
            this.btn_DeleteNote.Text = "Delete Note";
            this.btn_DeleteNote.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // btn_NewStickPad
            // 
            this.btn_NewStickPad.Location = new System.Drawing.Point(250, 39);
            this.btn_NewStickPad.Name = "btn_NewStickPad";
            this.btn_NewStickPad.Size = new System.Drawing.Size(95, 22);
            this.btn_NewStickPad.TabIndex = 5;
            this.btn_NewStickPad.Text = "New StickPad";
            this.btn_NewStickPad.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btn_RenameNote
            // 
            this.btn_RenameNote.Location = new System.Drawing.Point(248, 121);
            this.btn_RenameNote.Name = "btn_RenameNote";
            this.btn_RenameNote.Size = new System.Drawing.Size(98, 30);
            this.btn_RenameNote.TabIndex = 7;
            this.btn_RenameNote.Text = "Rename";
            this.btn_RenameNote.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "StickNotes is hanging out down here!";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 363);
            this.Controls.Add(this.btn_RenameNote);
            this.Controls.Add(this.btn_NewStickPad);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_DeleteNote);
            this.Controls.Add(this.btn_NewNote);
            this.Controls.Add(this.lst_Notes);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_Main";
            this.Text = "StickNotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Notes;
        private System.Windows.Forms.Button btn_NewNote;
        private System.Windows.Forms.Button btn_DeleteNote;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_NewStickPad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_RenameNote;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

