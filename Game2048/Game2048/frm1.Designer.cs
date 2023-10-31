
namespace Game2048
{
    partial class frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.btDiLen = new System.Windows.Forms.Button();
            this.btSangPhai = new System.Windows.Forms.Button();
            this.btDiXuong = new System.Windows.Forms.Button();
            this.btSangTrai = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb16 = new System.Windows.Forms.Label();
            this.lb12 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb15 = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb14 = new System.Windows.Forms.Label();
            this.lb13 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbThongBao = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btCLose = new System.Windows.Forms.Button();
            this.lbDiem = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label2 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btDoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btDiLen
            // 
            this.btDiLen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btDiLen.Enabled = false;
            this.btDiLen.Image = global::Game2048.Properties.Resources.len;
            this.btDiLen.Location = new System.Drawing.Point(198, 142);
            this.btDiLen.Name = "btDiLen";
            this.btDiLen.Size = new System.Drawing.Size(97, 133);
            this.btDiLen.TabIndex = 0;
            this.btDiLen.UseVisualStyleBackColor = false;
            this.btDiLen.Click += new System.EventHandler(this.btDiLen_Click);
            // 
            // btSangPhai
            // 
            this.btSangPhai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btSangPhai.Enabled = false;
            this.btSangPhai.Image = global::Game2048.Properties.Resources.phai;
            this.btSangPhai.Location = new System.Drawing.Point(301, 274);
            this.btSangPhai.Name = "btSangPhai";
            this.btSangPhai.Size = new System.Drawing.Size(136, 93);
            this.btSangPhai.TabIndex = 0;
            this.btSangPhai.UseVisualStyleBackColor = false;
            this.btSangPhai.Click += new System.EventHandler(this.btSangPhai_Click);
            // 
            // btDiXuong
            // 
            this.btDiXuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btDiXuong.Enabled = false;
            this.btDiXuong.Image = global::Game2048.Properties.Resources.xuong;
            this.btDiXuong.Location = new System.Drawing.Point(198, 364);
            this.btDiXuong.Name = "btDiXuong";
            this.btDiXuong.Size = new System.Drawing.Size(97, 133);
            this.btDiXuong.TabIndex = 0;
            this.btDiXuong.UseVisualStyleBackColor = false;
            this.btDiXuong.Click += new System.EventHandler(this.btDiXuong_Click);
            // 
            // btSangTrai
            // 
            this.btSangTrai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btSangTrai.Enabled = false;
            this.btSangTrai.Image = global::Game2048.Properties.Resources.trai;
            this.btSangTrai.Location = new System.Drawing.Point(56, 274);
            this.btSangTrai.Name = "btSangTrai";
            this.btSangTrai.Size = new System.Drawing.Size(136, 93);
            this.btSangTrai.TabIndex = 0;
            this.btSangTrai.UseVisualStyleBackColor = false;
            this.btSangTrai.Click += new System.EventHandler(this.btSangTrai_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(124, 525);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(254, 110);
            this.button5.TabIndex = 4;
            this.button5.Text = "Bắt đầu";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb16);
            this.panel1.Controls.Add(this.lb12);
            this.panel1.Controls.Add(this.lb8);
            this.panel1.Controls.Add(this.lb4);
            this.panel1.Controls.Add(this.lb15);
            this.panel1.Controls.Add(this.lb11);
            this.panel1.Controls.Add(this.lb7);
            this.panel1.Controls.Add(this.lb3);
            this.panel1.Controls.Add(this.lb14);
            this.panel1.Controls.Add(this.lb13);
            this.panel1.Controls.Add(this.lb10);
            this.panel1.Controls.Add(this.lb2);
            this.panel1.Controls.Add(this.lb9);
            this.panel1.Controls.Add(this.lb6);
            this.panel1.Controls.Add(this.lb5);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Location = new System.Drawing.Point(490, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 563);
            this.panel1.TabIndex = 5;
            // 
            // lb16
            // 
            this.lb16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb16.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb16.Location = new System.Drawing.Point(441, 425);
            this.lb16.Name = "lb16";
            this.lb16.Size = new System.Drawing.Size(140, 134);
            this.lb16.TabIndex = 15;
            this.lb16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb12
            // 
            this.lb12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb12.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb12.Location = new System.Drawing.Point(441, 285);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(140, 132);
            this.lb12.TabIndex = 14;
            this.lb12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb8
            // 
            this.lb8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb8.Location = new System.Drawing.Point(441, 144);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(140, 132);
            this.lb8.TabIndex = 13;
            this.lb8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb4
            // 
            this.lb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(441, 0);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(140, 132);
            this.lb4.TabIndex = 12;
            this.lb4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb15
            // 
            this.lb15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb15.Location = new System.Drawing.Point(295, 427);
            this.lb15.Name = "lb15";
            this.lb15.Size = new System.Drawing.Size(140, 132);
            this.lb15.TabIndex = 11;
            this.lb15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb11
            // 
            this.lb11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb11.Location = new System.Drawing.Point(295, 285);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(140, 132);
            this.lb11.TabIndex = 10;
            this.lb11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb7
            // 
            this.lb7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb7.Location = new System.Drawing.Point(295, 144);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(140, 132);
            this.lb7.TabIndex = 9;
            this.lb7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb3
            // 
            this.lb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(295, 0);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(140, 132);
            this.lb3.TabIndex = 8;
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb14
            // 
            this.lb14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb14.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb14.Location = new System.Drawing.Point(149, 427);
            this.lb14.Name = "lb14";
            this.lb14.Size = new System.Drawing.Size(140, 132);
            this.lb14.TabIndex = 7;
            this.lb14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb13
            // 
            this.lb13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb13.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb13.Location = new System.Drawing.Point(3, 427);
            this.lb13.Name = "lb13";
            this.lb13.Size = new System.Drawing.Size(140, 132);
            this.lb13.TabIndex = 6;
            this.lb13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb10
            // 
            this.lb10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(149, 285);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(140, 132);
            this.lb10.TabIndex = 5;
            this.lb10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(149, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(140, 132);
            this.lb2.TabIndex = 4;
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb9
            // 
            this.lb9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb9.Location = new System.Drawing.Point(3, 285);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(140, 132);
            this.lb9.TabIndex = 3;
            this.lb9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb6
            // 
            this.lb6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.Location = new System.Drawing.Point(149, 144);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(140, 132);
            this.lb6.TabIndex = 2;
            this.lb6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb5
            // 
            this.lb5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(3, 144);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(140, 132);
            this.lb5.TabIndex = 1;
            this.lb5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(0, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(143, 132);
            this.lb1.TabIndex = 0;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(1110, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Điểm của bạn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbThongBao
            // 
            this.lbThongBao.BackColor = System.Drawing.Color.Transparent;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.ForeColor = System.Drawing.Color.DarkRed;
            this.lbThongBao.Location = new System.Drawing.Point(358, 9);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(857, 42);
            this.lbThongBao.TabIndex = 8;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btCLose
            // 
            this.btCLose.BackColor = System.Drawing.Color.Teal;
            this.btCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCLose.ForeColor = System.Drawing.Color.Transparent;
            this.btCLose.Location = new System.Drawing.Point(1188, 525);
            this.btCLose.Name = "btCLose";
            this.btCLose.Size = new System.Drawing.Size(254, 110);
            this.btCLose.TabIndex = 9;
            this.btCLose.Text = "Thoát";
            this.btCLose.UseVisualStyleBackColor = false;
            this.btCLose.Click += new System.EventHandler(this.btCLose_Click);
            // 
            // lbDiem
            // 
            this.lbDiem.BackColor = System.Drawing.Color.Transparent;
            this.lbDiem.Cursor = System.Windows.Forms.Cursors.No;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.Color.Navy;
            this.lbDiem.Location = new System.Drawing.Point(1271, 45);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(141, 49);
            this.lbDiem.TabIndex = 10;
            this.lbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Maroon;
            this.lbTime.Location = new System.Drawing.Point(1242, 101);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(127, 28);
            this.lbTime.TabIndex = 11;
            this.lbTime.Text = "00:00:00";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(1110, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Thời gian: ";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1101, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Player: ";
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Cursor = System.Windows.Forms.Cursors.No;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbName.Location = new System.Drawing.Point(1214, 193);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(198, 90);
            this.lbName.TabIndex = 14;
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btDoi
            // 
            this.btDoi.BackColor = System.Drawing.Color.Yellow;
            this.btDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoi.Location = new System.Drawing.Point(1188, 297);
            this.btDoi.Name = "btDoi";
            this.btDoi.Size = new System.Drawing.Size(133, 46);
            this.btDoi.TabIndex = 15;
            this.btDoi.Text = "Đổi tên";
            this.btDoi.UseVisualStyleBackColor = false;
            this.btDoi.Click += new System.EventHandler(this.btDoi_Click);
            // 
            // frm1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1481, 666);
            this.Controls.Add(this.btDoi);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.btCLose);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btSangTrai);
            this.Controls.Add(this.btDiXuong);
            this.Controls.Add(this.btSangPhai);
            this.Controls.Add(this.btDiLen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDiLen;
        private System.Windows.Forms.Button btSangPhai;
        private System.Windows.Forms.Button btDiXuong;
        private System.Windows.Forms.Button btSangTrai;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb16;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb15;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb14;
        private System.Windows.Forms.Label lb13;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btCLose;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDoi;
    }
}

