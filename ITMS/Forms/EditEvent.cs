using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SQLite;
//using MySql.Data.MySqlClient;

namespace ITMS.Forms
{
    public partial class EditEvent : Form
    {
        // SQLite Connection
        SQLiteConnection con = new SQLiteConnection(@"Data Source =.\audioDB.db;");
        SQLiteCommand cmd;
        SoundPlayer player;

        DialogResult iChoice;

        public EditEvent()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (textAudioFile.Text == "")
                {
                    MessageBox.Show("Please select Audio File!");
                }
                else
                {
                    player.SoundLocation = textAudioFile.Text;
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditEvent_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main mm = (Main)Application.OpenForms["Main"];
            mm.LoadScheduler();
         //   mm.Enabled = true;
            this.Close();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            iChoice = MessageBox.Show("Are you sure you want to update?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iChoice == DialogResult.Yes)
            {
                try
                {
                    cmd = new SQLiteCommand("update Scheduler set EventTime = @EventTime, EventName = @EventName, AudioFile = @AudioFile, EventDay = @EventDay where SchedID = @SchedID", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@SchedID", textID.Text);
                    cmd.Parameters.AddWithValue("@EventTime", dateTimeEvent.Text);
                    cmd.Parameters.AddWithValue("@EventName", textEventName.Text);
                    cmd.Parameters.AddWithValue("@AudioFile", textAudioFile.Text);
                    cmd.Parameters.AddWithValue("@EventDay", GetDay());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Event Successfully Updated.", "SUCCESS", MessageBoxButtons.OK);
                    Main mm = (Main)Application.OpenForms["Main"];
                    mm.LoadScheduler();
                    mm.Enabled = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // SELECTED DAYS

        private string GetDay()
        {
            StringBuilder result = new StringBuilder();
            if (checkBoxMON.Checked)
                result.AppendFormat("{0},", checkBoxMON.Text);
            if (checkBoxTUE.Checked)
                result.AppendFormat("{0},", checkBoxTUE.Text);
            if (checkBoxWED.Checked)
                result.AppendFormat("{0},", checkBoxWED.Text);
            if (checkBoxTHU.Checked)
                result.AppendFormat("{0},", checkBoxTHU.Text);
            if (checkBoxFRI.Checked)
                result.AppendFormat("{0},", checkBoxFRI.Text);
            if (checkBoxSAT.Checked)
                result.AppendFormat("{0},", checkBoxSAT.Text);
            if (checkBoxSUN.Checked)
                result.AppendFormat("{0},", checkBoxSUN.Text);
            if (result.Length > 0) result.Length--;
            return result.ToString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog v1 = new OpenFileDialog();
            v1.Filter = "Text files (All files (*.*)|*.*";

            if (v1.ShowDialog() == DialogResult.OK)
            {
                textAudioFile.Text = v1.FileName;

            }
        }

        private void EditEvent_Leave(object sender, EventArgs e)
        {
         
        }
    }
}
