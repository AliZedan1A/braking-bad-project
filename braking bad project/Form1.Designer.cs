namespace braking_bad_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navbar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textsearchEND = new System.Windows.Forms.TextBox();
            this.btnsearchEND = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.characters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlEND = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.series = new System.Windows.Forms.Label();
            this.season = new System.Windows.Forms.Label();
            this.air_date = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.PnlCharacters = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNickName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnltct = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tct = new System.Windows.Forms.RichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEND.SuspendLayout();
            this.PnlCharacters.SuspendLayout();
            this.pnltct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.navbar.Controls.Add(this.button3);
            this.navbar.Controls.Add(this.button2);
            this.navbar.Controls.Add(this.button1);
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1280, 79);
            this.navbar.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(500, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(330, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Breaking Bad Characters";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(144, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(330, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Breaking Bad episodes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textsearchEND
            // 
            this.textsearchEND.Location = new System.Drawing.Point(3, 40);
            this.textsearchEND.Name = "textsearchEND";
            this.textsearchEND.Size = new System.Drawing.Size(187, 33);
            this.textsearchEND.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textsearchEND, "ضع الرقم التعريفي للحلقة");
            this.textsearchEND.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textsearchEND_KeyDown);
            this.textsearchEND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchEND_KeyPress);
            // 
            // btnsearchEND
            // 
            this.btnsearchEND.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearchEND.Location = new System.Drawing.Point(196, 40);
            this.btnsearchEND.Name = "btnsearchEND";
            this.btnsearchEND.Size = new System.Drawing.Size(94, 33);
            this.btnsearchEND.TabIndex = 1;
            this.btnsearchEND.Text = "search";
            this.toolTip1.SetToolTip(this.btnsearchEND, "انقر للبحث");
            this.btnsearchEND.UseVisualStyleBackColor = true;
            this.btnsearchEND.Click += new System.EventHandler(this.btnsearchEND_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.characters});
            this.dataGridView1.Location = new System.Drawing.Point(143, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(463, 255);
            this.dataGridView1.TabIndex = 2;
            // 
            // characters
            // 
            this.characters.HeaderText = "Characters";
            this.characters.Name = "characters";
            this.characters.ReadOnly = true;
            this.characters.Width = 420;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(301, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pnlEND
            // 
            this.pnlEND.BackColor = System.Drawing.Color.DimGray;
            this.pnlEND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEND.Controls.Add(this.textsearchEND);
            this.pnlEND.Controls.Add(this.label6);
            this.pnlEND.Controls.Add(this.label1);
            this.pnlEND.Controls.Add(this.label2);
            this.pnlEND.Controls.Add(this.btnsearchEND);
            this.pnlEND.Controls.Add(this.label3);
            this.pnlEND.Controls.Add(this.label4);
            this.pnlEND.Controls.Add(this.label5);
            this.pnlEND.Controls.Add(this.series);
            this.pnlEND.Controls.Add(this.season);
            this.pnlEND.Controls.Add(this.air_date);
            this.pnlEND.Controls.Add(this.ID);
            this.pnlEND.Controls.Add(this.dataGridView1);
            this.pnlEND.Controls.Add(this.title);
            this.pnlEND.Location = new System.Drawing.Point(13, 100);
            this.pnlEND.Name = "pnlEND";
            this.pnlEND.Size = new System.Drawing.Size(684, 591);
            this.pnlEND.TabIndex = 4;
            this.pnlEND.Visible = false;
            this.pnlEND.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEND_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "id :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number Of episodes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Series :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Season :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "air Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Titel :";
            // 
            // series
            // 
            this.series.AutoSize = true;
            this.series.Location = new System.Drawing.Point(152, 263);
            this.series.Name = "series";
            this.series.Size = new System.Drawing.Size(0, 26);
            this.series.TabIndex = 4;
            // 
            // season
            // 
            this.season.AutoSize = true;
            this.season.Location = new System.Drawing.Point(152, 212);
            this.season.Name = "season";
            this.season.Size = new System.Drawing.Size(0, 26);
            this.season.TabIndex = 3;
            // 
            // air_date
            // 
            this.air_date.AutoSize = true;
            this.air_date.Location = new System.Drawing.Point(152, 145);
            this.air_date.Name = "air_date";
            this.air_date.Size = new System.Drawing.Size(0, 26);
            this.air_date.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(627, 22);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 26);
            this.ID.TabIndex = 1;
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(152, 87);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 26);
            this.title.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 40;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = ":ملاحظة";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(190, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 33);
            this.button5.TabIndex = 10;
            this.button5.Text = "search";
            this.toolTip1.SetToolTip(this.button5, "انقر للبحث");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PnlCharacters
            // 
            this.PnlCharacters.BackColor = System.Drawing.Color.DimGray;
            this.PnlCharacters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlCharacters.Controls.Add(this.button5);
            this.PnlCharacters.Controls.Add(this.comboBox1);
            this.PnlCharacters.Controls.Add(this.label7);
            this.PnlCharacters.Controls.Add(this.pictureBox1);
            this.PnlCharacters.Controls.Add(this.label8);
            this.PnlCharacters.Controls.Add(this.label9);
            this.PnlCharacters.Controls.Add(this.label10);
            this.PnlCharacters.Controls.Add(this.label11);
            this.PnlCharacters.Controls.Add(this.label12);
            this.PnlCharacters.Controls.Add(this.lblNickName);
            this.PnlCharacters.Controls.Add(this.lblStatus);
            this.PnlCharacters.Controls.Add(this.lblBirthday);
            this.PnlCharacters.Controls.Add(this.idlbl);
            this.PnlCharacters.Controls.Add(this.lblName);
            this.PnlCharacters.Location = new System.Drawing.Point(791, 85);
            this.PnlCharacters.Name = "PnlCharacters";
            this.PnlCharacters.Size = new System.Drawing.Size(685, 591);
            this.PnlCharacters.TabIndex = 5;
            this.PnlCharacters.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-3, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 34);
            this.comboBox1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(565, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "id :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(8, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 26);
            this.label8.TabIndex = 5;
            this.label8.Text = "Name Of Characters";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nickname :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 26);
            this.label10.TabIndex = 7;
            this.label10.Text = "Status :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 26);
            this.label11.TabIndex = 6;
            this.label11.Text = "Birthday :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 26);
            this.label12.TabIndex = 5;
            this.label12.Text = "Name :";
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(156, 288);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(0, 26);
            this.lblNickName.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(148, 237);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 26);
            this.lblStatus.TabIndex = 3;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(148, 170);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(0, 26);
            this.lblBirthday.TabIndex = 2;
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(627, 22);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(0, 26);
            this.idlbl.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(148, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 26);
            this.lblName.TabIndex = 0;
            // 
            // pnltct
            // 
            this.pnltct.BackColor = System.Drawing.Color.DimGray;
            this.pnltct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnltct.Controls.Add(this.dataGridView2);
            this.pnltct.Controls.Add(this.tct);
            this.pnltct.Controls.Add(this.label23);
            this.pnltct.Location = new System.Drawing.Point(384, 722);
            this.pnltct.Name = "pnltct";
            this.pnltct.Size = new System.Drawing.Size(679, 254);
            this.pnltct.TabIndex = 6;
            this.pnltct.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(1, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(671, 146);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Episode Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 630;
            // 
            // tct
            // 
            this.tct.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tct.Location = new System.Drawing.Point(0, 0);
            this.tct.Name = "tct";
            this.tct.Size = new System.Drawing.Size(674, 95);
            this.tct.TabIndex = 2;
            this.tct.Text = "";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(627, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 26);
            this.label23.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::braking_bad_project.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(1505, 968);
            this.Controls.Add(this.pnltct);
            this.Controls.Add(this.PnlCharacters);
            this.Controls.Add(this.pnlEND);
            this.Controls.Add(this.navbar);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEND.ResumeLayout(false);
            this.pnlEND.PerformLayout();
            this.PnlCharacters.ResumeLayout(false);
            this.PnlCharacters.PerformLayout();
            this.pnltct.ResumeLayout(false);
            this.pnltct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel navbar;
        private TextBox textsearchEND;
        private Button btnsearchEND;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Panel pnlEND;
        private Label series;
        private Label season;
        private Label air_date;
        private Label ID;
        private Label title;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn characters;
        private ToolTip toolTip1;
        private Button button3;
        private Panel PnlCharacters;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lblNickName;
        private Label lblStatus;
        private Label lblBirthday;
        private Label idlbl;
        private Label lblName;
        private Button button5;
        private ComboBox comboBox1;
        private Panel pnltct;
        private RichTextBox tct;
        private Label label23;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}