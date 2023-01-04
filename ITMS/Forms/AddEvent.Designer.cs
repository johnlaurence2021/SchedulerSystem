namespace ITMS.Forms
{
    partial class AddEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEventName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSUN = new System.Windows.Forms.CheckBox();
            this.checkBoxSAT = new System.Windows.Forms.CheckBox();
            this.checkBoxFRI = new System.Windows.Forms.CheckBox();
            this.checkBoxTHU = new System.Windows.Forms.CheckBox();
            this.checkBoxWED = new System.Windows.Forms.CheckBox();
            this.checkBoxTUE = new System.Windows.Forms.CheckBox();
            this.checkBoxMON = new System.Windows.Forms.CheckBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.textAudioFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeEvent = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(160, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Name";
            // 
            // textEventName
            // 
            this.textEventName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEventName.Location = new System.Drawing.Point(160, 42);
            this.textEventName.Name = "textEventName";
            this.textEventName.Size = new System.Drawing.Size(426, 27);
            this.textEventName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.checkBoxSUN);
            this.groupBox1.Controls.Add(this.checkBoxSAT);
            this.groupBox1.Controls.Add(this.checkBoxFRI);
            this.groupBox1.Controls.Add(this.checkBoxTHU);
            this.groupBox1.Controls.Add(this.checkBoxWED);
            this.groupBox1.Controls.Add(this.checkBoxTUE);
            this.groupBox1.Controls.Add(this.checkBoxMON);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 107);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Days";
            // 
            // checkBoxSUN
            // 
            this.checkBoxSUN.AutoSize = true;
            this.checkBoxSUN.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSUN.Location = new System.Drawing.Point(494, 49);
            this.checkBoxSUN.Name = "checkBoxSUN";
            this.checkBoxSUN.Size = new System.Drawing.Size(64, 18);
            this.checkBoxSUN.TabIndex = 6;
            this.checkBoxSUN.Text = "Sunday";
            this.checkBoxSUN.UseVisualStyleBackColor = true;
            // 
            // checkBoxSAT
            // 
            this.checkBoxSAT.AutoSize = true;
            this.checkBoxSAT.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSAT.Location = new System.Drawing.Point(415, 49);
            this.checkBoxSAT.Name = "checkBoxSAT";
            this.checkBoxSAT.Size = new System.Drawing.Size(72, 18);
            this.checkBoxSAT.TabIndex = 5;
            this.checkBoxSAT.Text = "Saturday";
            this.checkBoxSAT.UseVisualStyleBackColor = true;
            this.checkBoxSAT.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBoxFRI
            // 
            this.checkBoxFRI.AutoSize = true;
            this.checkBoxFRI.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFRI.Location = new System.Drawing.Point(344, 49);
            this.checkBoxFRI.Name = "checkBoxFRI";
            this.checkBoxFRI.Size = new System.Drawing.Size(59, 18);
            this.checkBoxFRI.TabIndex = 4;
            this.checkBoxFRI.Text = "Friday";
            this.checkBoxFRI.UseVisualStyleBackColor = true;
            // 
            // checkBoxTHU
            // 
            this.checkBoxTHU.AutoSize = true;
            this.checkBoxTHU.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTHU.Location = new System.Drawing.Point(261, 49);
            this.checkBoxTHU.Name = "checkBoxTHU";
            this.checkBoxTHU.Size = new System.Drawing.Size(74, 18);
            this.checkBoxTHU.TabIndex = 3;
            this.checkBoxTHU.Text = "Thursday";
            this.checkBoxTHU.UseVisualStyleBackColor = true;
            // 
            // checkBoxWED
            // 
            this.checkBoxWED.AutoSize = true;
            this.checkBoxWED.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWED.Location = new System.Drawing.Point(173, 49);
            this.checkBoxWED.Name = "checkBoxWED";
            this.checkBoxWED.Size = new System.Drawing.Size(87, 18);
            this.checkBoxWED.TabIndex = 2;
            this.checkBoxWED.Text = "Wednesday";
            this.checkBoxWED.UseVisualStyleBackColor = true;
            // 
            // checkBoxTUE
            // 
            this.checkBoxTUE.AutoSize = true;
            this.checkBoxTUE.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTUE.Location = new System.Drawing.Point(91, 49);
            this.checkBoxTUE.Name = "checkBoxTUE";
            this.checkBoxTUE.Size = new System.Drawing.Size(68, 18);
            this.checkBoxTUE.TabIndex = 1;
            this.checkBoxTUE.Text = "Tuesday";
            this.checkBoxTUE.UseVisualStyleBackColor = true;
            // 
            // checkBoxMON
            // 
            this.checkBoxMON.AutoSize = true;
            this.checkBoxMON.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMON.Location = new System.Drawing.Point(15, 49);
            this.checkBoxMON.Name = "checkBoxMON";
            this.checkBoxMON.Size = new System.Drawing.Size(69, 18);
            this.checkBoxMON.TabIndex = 0;
            this.checkBoxMON.Text = "Monday";
            this.checkBoxMON.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPreview.Location = new System.Drawing.Point(20, 293);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(93, 34);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(128, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkGreen;
            this.button3.Location = new System.Drawing.Point(493, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnOK.Location = new System.Drawing.Point(384, 293);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 34);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textAudioFile
            // 
            this.textAudioFile.BackColor = System.Drawing.Color.White;
            this.textAudioFile.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAudioFile.Location = new System.Drawing.Point(21, 231);
            this.textAudioFile.Name = "textAudioFile";
            this.textAudioFile.ReadOnly = true;
            this.textAudioFile.Size = new System.Drawing.Size(487, 27);
            this.textAudioFile.TabIndex = 9;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBrowse.Location = new System.Drawing.Point(514, 230);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(72, 28);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(21, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Audio File";
            // 
            // dateTimeEvent
            // 
            this.dateTimeEvent.CalendarFont = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEvent.CustomFormat = "hh:mm:ss tt";
            this.dateTimeEvent.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEvent.Location = new System.Drawing.Point(20, 42);
            this.dateTimeEvent.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.dateTimeEvent.Name = "dateTimeEvent";
            this.dateTimeEvent.ShowUpDown = true;
            this.dateTimeEvent.Size = new System.Drawing.Size(134, 26);
            this.dateTimeEvent.TabIndex = 13;
            this.dateTimeEvent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimeEvent_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(181, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "NOTE : Please use WAV audio format.";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(608, 346);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeEvent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.textAudioFile);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textEventName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddEvent";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD EVENT";
            this.Load += new System.EventHandler(this.EventProperties_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEventName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSUN;
        private System.Windows.Forms.CheckBox checkBoxSAT;
        private System.Windows.Forms.CheckBox checkBoxFRI;
        private System.Windows.Forms.CheckBox checkBoxTHU;
        private System.Windows.Forms.CheckBox checkBoxWED;
        private System.Windows.Forms.CheckBox checkBoxTUE;
        private System.Windows.Forms.CheckBox checkBoxMON;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textAudioFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeEvent;
        private System.Windows.Forms.Label label4;
    }
}