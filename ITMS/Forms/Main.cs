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
//using MySql.Data.MySqlClient;
using System.Data.SQLite;
using ITMS.Models;
using ITMS.Forms;

namespace ITMS.Forms
{
    public partial class Main : Form
    {
        // SQLite Connection 
        DialogResult iChoice;
        SQLiteConnection con = new SQLiteConnection(@"Data Source =.\audioDB.db;");
        SQLiteCommand cmd;
        //SQLiteDataAdapter adapter;
        String ID;


        //  System.Timers.Timer timer;
        SoundPlayer player;
        SoundPlayer preview;
        public Main()
        {
            InitializeComponent();
            //addForm = new AddEvent();
            //addForm.Owner = this;
            //addForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
            preview = new SoundPlayer();
            timeScheduler.Start();
            LoadScheduler();

            TimeLog.Text = DateTime.Now.ToString("HH:mm:ss tt");
            lblDisplayTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblToday.Text = DateTime.Now.ToString("dddd");


            timerDisplay.Start();

            // DISABLE BUTTON
            btnNewEvent.Enabled = false;
            btnEditEvent.Enabled = false;
            btnDeleteEvent.Enabled = false;
            btnRun.Enabled = false;

        }


        // Alarm 

        delegate void UpdateLable(Label lbl, string value);

        void UpdateDateLable(Label lbl, String value)
        {
            lbl.Text = value;
        }




        // EXECUTE BELL

        private void PlayScheduler()
        {
            try
            {
                con.Open();
                cmd = new SQLiteCommand("select EventTime,EventDay,AudioFile FROM Scheduler where EventTime = @EventTime and EventDay LIKE '%" + lblToday.Text + "%'", con);
                cmd.Parameters.AddWithValue("@EventTime", TimeLog.Text);

                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    testPlay.Invoke((MethodInvoker)(() => testPlay.Text = dr[0].ToString()));
                    textAudio.Invoke((MethodInvoker)(() => textAudio.Text = dr[2].ToString()));
                    player.SoundLocation = textAudio.Text;
                    player.Play();

                }
                con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // DISPLAY SCHEDULER

        public void LoadScheduler()
        {
            con.Open();
            cmd = new SQLiteCommand("select * from Scheduler", con);
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                List<Scheduler> results = new List<Scheduler>();


                while (dr.Read())
                {
                    Scheduler newItem = new Scheduler();

                    newItem.SchedID = dr.GetInt32(0);
                    newItem.EventTime = dr.IsDBNull(1) ? null : dr.GetString(1);
                    newItem.EventName = dr.IsDBNull(2) ? null : dr.GetString(2);
                    newItem.EventDay = dr.IsDBNull(3) ? null : dr.GetString(3);
                    newItem.AudioFile = dr.IsDBNull(4) ? null : dr.GetString(4);
                    results.Add(newItem);
                }
                schedulerBindingSource.DataSource = results;
            }

            con.Close();


        }





        //private void button2_Click(object sender, EventArgs e)
        //{
        //    player.Stop();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    player.Play();
        //}

        private void timeScheduler_Tick(object sender, EventArgs e)
        {
            TimeLog.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDisplayTime.Text = DateTime.Now.ToString("hh:mm:ss tt");

            timeScheduler.Start();
            PlayScheduler();


        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
         //   this.Enabled = false;
            AddEvent mm = new AddEvent();
            mm.Owner = this;
            mm.Show();

        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
           // this.Enabled = false;
            EditEvent mm = new Forms.EditEvent();
            mm.textID.Text = this.dgvScheduler.CurrentRow.Cells[0].Value.ToString();
            mm.dateTimeEvent.Text = this.dgvScheduler.CurrentRow.Cells[1].Value.ToString();
            mm.textEventName.Text = this.dgvScheduler.CurrentRow.Cells[2].Value.ToString();
            mm.textAudioFile.Text = this.dgvScheduler.CurrentRow.Cells[4].Value.ToString();

            mm.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            //   dateTimePicker1.CustomFormat = "hh:mm:ss tt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // timer.Start();
            //  lblStatusnew.Text = "Running....";

            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //   timer.Stop();

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            timeScheduler.Start();
            btnStop.Enabled = true;
            btnNewEvent.Enabled = false;
            btnEditEvent.Enabled = false;
            btnDeleteEvent.Enabled = false;
            btnRun.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timeScheduler.Stop();
            btnNewEvent.Enabled = true;
            btnEditEvent.Enabled = true;
            btnDeleteEvent.Enabled = true;
            btnStop.Enabled = false;
            btnRun.Enabled = true;
        }



      



        private void timerDisplay_Tick_1(object sender, EventArgs e)
        {
            lblDisplayTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblToday.Text = DateTime.Now.ToString("dddd");
            timerDisplay.Start();
        }

        private void dgvScheduler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteEvent.Enabled = true;
            btnEditEvent.Enabled = true;
            try
            {

                dgvScheduler.CurrentRow.Selected = true;
                ID = dgvScheduler.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                textAudio.Text = dgvScheduler.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                testPlay.Text = dgvScheduler.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            iChoice = MessageBox.Show("Are you sure you want to delete?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iChoice == DialogResult.Yes)
            {
                con.Open();
                cmd = new SQLiteCommand("delete from Scheduler where SchedID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Event Deleted Successfully!");
                LoadScheduler();


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (textAudio.Text == "")
                {
                    MessageBox.Show("Please select Audio File!");
                }
                else
                {
                    preview.SoundLocation = textAudio.Text;
                    preview.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStoAudio_Click(object sender, EventArgs e)
        {
            preview.Stop();
        }
    }
}
