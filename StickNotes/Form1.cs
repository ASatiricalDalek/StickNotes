using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickNotes
{
    
    public partial class frm_Main : Form
    {
        int  NumberOfNotes = Properties.Settings.Default.NumberOfNotes;
        Note note = new Note();

        public frm_Main()
        {
            InitializeComponent();
            
        }

        private void btn_NewNote_Click(object sender, EventArgs e)
        {
            lst_Notes.Items.Add("Note" + NumberOfNotes);
            note.New(ref NumberOfNotes);

            //Form Note = new NoteTemplate();
            //Note.Show();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon1.Visible = true; 
                this.Hide();
                e.Cancel = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

    }
}
