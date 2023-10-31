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
using System.Diagnostics;
using System.Threading;

namespace Game2048
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
            
        }
        private Stopwatch stopwatch = new Stopwatch();
        Random rand = new Random();
        Label[,] lbs = new Label[4, 4];
        int diem = 0;
        string input;
        SoundPlayer sound = new SoundPlayer(@"sound\3.wav");

        public static string Show(string caption, string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = caption;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                return textBox.Text;
            }
            else
            {
                return string.Empty;
            }
        }


        void LoadGiaTri()
        {
            lbs[0, 0] = lb1;
            lbs[0, 1] = lb2;
            lbs[0, 2] = lb3;
            lbs[0, 3] = lb4;
            lbs[1, 0] = lb5;
            lbs[1, 1] = lb6;
            lbs[1, 2] = lb7;
            lbs[1, 3] = lb8;
            lbs[2, 0] = lb9;
            lbs[2, 1] = lb10;
            lbs[2, 2] = lb11;
            lbs[2, 3] = lb12;
            lbs[3, 0] = lb13;
            lbs[3, 1] = lb14;
            lbs[3, 2] = lb15;
            lbs[3, 3] = lb16;
            
        }
       
        void setBackGruond()
        {

            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    lbs[a, b].BorderStyle = BorderStyle.Fixed3D;
                    lbs[a, b].TextAlign = ContentAlignment.MiddleCenter;
                    if (lbs[a, b].Text != "")
                        chosseColor(lbs[a, b]);
                    else
                        lbs[a, b].BackColor = Color.White;
                }
            }
        }
        void chosseColor(Label a)
        {
            int txt = int.Parse(a.Text);
            switch (txt)
            {
                case 2:
                    a.BackColor = Color.Moccasin;
                    a.Font = new Font(a.Font.FontFamily, 34, a.Font.Style);

                    break;
                case 4:
                    a.BackColor = Color.DarkKhaki;
                    a.Font = new Font(a.Font.FontFamily, 34, a.Font.Style);

                    break;
                case 8:
                    a.BackColor = Color.Gold;
                    a.Font = new Font(a.Font.FontFamily, 34, a.Font.Style);

                    break;
                case 16:
                    a.BackColor = Color.DarkOrange;
                    a.Font = new Font(a.Font.FontFamily, 34, a.Font.Style);

                    break;
                case 32:
                    a.BackColor = Color.OrangeRed;
                    a.Font = new Font(a.Font.FontFamily, 34, a.Font.Style);

                    break;
                case 64:
                    a.BackColor = Color.Cyan;
                    a.Font = new Font(a.Font.FontFamily, 34, a.Font.Style);
                    break;
                case 128:
                    a.BackColor = Color.MediumBlue;
                    a.Font = new Font(a.Font.FontFamily, 28, a.Font.Style);
                    break;
                case 256:
                    a.BackColor = Color.Magenta;
                    a.Font = new Font(a.Font.FontFamily, 28, a.Font.Style);
                    break;
                case 512:
                    a.BackColor = Color.MediumOrchid;
                    a.Font = new Font(a.Font.FontFamily, 28, a.Font.Style);
                    break;
                case 1024:
                    a.BackColor = Color.DarkSlateBlue;
                    a.Font = new Font(a.Font.FontFamily, 24, a.Font.Style);
                    break;
                case 2048:
                    a.BackColor = Color.MidnightBlue;
                    a.Font = new Font(a.Font.FontFamily, 24, a.Font.Style);
                    break;
            }
        }
        void resetGiaTri()
        {
            for(int i = 0; i <= 3; i++)
            {
                for( int j = 0; j <= 3; j++)
                {
                    lbs[i, j].Text = "";
                }
            }
        }
        
        bool checkFull()
        {
            bool flag = true;
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    if (ktraSo(i, j) == false)
                    {
                        flag = true;
                    }
                    else
                        return false;
                }
            }
           
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (lbs[i, j + 1].Text == lbs[i, j].Text && lbs[i,j].Text!="")
                        flag = false;
                    else
                        flag = true;
                }
            }
            
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 1; j--)
                {
                    if (lbs[i, j - 1].Text == lbs[i, j].Text && lbs[i, j].Text != "")
                        flag = false;
                    else
                        flag = true;
                }
            }
            
            for (int j = 0; j <= 3; j++)
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (lbs[i + 1, j].Text == lbs[i, j].Text && lbs[i, j].Text != "")
                        flag = false;
                    else
                        flag = true;
                }
            }
            
            for (int j = 3; j >= 0; j--)
            {
                for (int i = 3; i >= 1; i--)
                {
                    if (lbs[i - 1, j].Text ==  lbs[i, j].Text && lbs[i, j].Text != "")
                        flag = false;
                    else
                        flag = true;
                }
            }
            return flag;
        }
        bool ktraSo(int i,int j)
        {
            if (lbs[i, j].Text == "")
                return true;
            else return false;
        }
        void LoadBatDau()
        {
            bool ktra;
            int i = 0;
            if (checkFull() == false) {
                do
                {
                    int hang = rand.Next(0, 4);
                    int cot = rand.Next(0, 4);
                    ktra = ktraSo(hang, cot);
                    i++;
                    if (ktra == true)
                    {
                        lbs[hang, cot].Text = "2";

                        if (i >= 5)
                        {
                            lbs[hang, cot].Text = "4";
                            i = 0;
                        }
                    }
                } while (ktra == false);

                setBackGruond();
            }
            else
            {
                stopwatch.Stop();
                timer3.Stop();
                DialogResult result=MessageBox.Show("Bạn đã thua,hãy lưu điểm?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    Frm2cs f = new Frm2cs(lbTime.Text, lbDiem.Text,input);
                    f.ShowDialog();
                    
                }
                else if (result == DialogResult.Cancel)
                {
                    
                }
            }         
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            input = Show("Thông báo ", "Nhập tên của bạn để vào game:");
            LoadGiaTri();
            lbThongBao.Text = "                 Lưu ý: Khi đầy các ô, Nếu bạn di chuyển 1 bước đi không có nghĩa thì bạn sẽ bị xử thua!!!             ";
            timer2.Start();
            sound.Play();
            lbName.Text = input;
        }

        
        bool KiemTraDeTaoMoiPhai()
        {

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (lbs[i, j + 1].Text == "" && lbs[i, j].Text != "")
                        return true;
                    if (lbs[i, j].Text == lbs[i, j + 1].Text && lbs[i, j + 1].Text != "" && lbs[i, j].Text != "")
                        return true;
                }
            }
            return false;
        }
        void KiemTraSangPhai1()
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (lbs[i, j + 1].Text == "" && lbs[i, j].Text != "")
                    {
                        lbs[i, j + 1].Text = lbs[i, j].Text;
                        lbs[i, j].Text = "";
                    }
                }
            }
        }
        void KiemTraSangPhai2()
        { 
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 3; j >=1 ; j--)
                {
                    if (lbs[i, j ].Text == lbs[i, j-1].Text && lbs[i, j - 1].Text !="" && lbs[i, j].Text !="")
                    {
                        lbs[i, j].Text = (Int32.Parse(lbs[i, j].Text) + Int32.Parse(lbs[i, j-1].Text)).ToString();
                        diem += Int32.Parse(lbs[i, j].Text);
                        lbs[i, j-1].Text = "";                                             
                    }
                }
                KiemTraSangPhai1();
            }
        }
        bool KiemTraDeTaoMoiTrai()
        {
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 1; j--)
                {
                    if (lbs[i, j - 1].Text == "" && lbs[i, j].Text != "")
                    {
                        return true;
                    }
                    if (lbs[i, j - 1].Text == lbs[i, j].Text && lbs[i, j - 1].Text != "" && lbs[i, j].Text != "")
                        return true;
                }
            }
            return false;
        }
        void KiemTraSangTrai1()
        {
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 1; j--)
                {
                    if (lbs[i, j - 1].Text == "" && lbs[i, j].Text != "")
                    {
                        lbs[i, j - 1].Text = lbs[i, j].Text;
                        lbs[i, j].Text = "";
                    }
                }
            }
        }
        void KiemTraSangTrai2()
        { 
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 0; j <=2; j++)
                {
                    if (lbs[i, j + 1].Text == lbs[i, j].Text && lbs[i, j + 1].Text != "" && lbs[i, j].Text != "")
                    {
                        lbs[i, j].Text = (Int32.Parse(lbs[i, j].Text) + Int32.Parse(lbs[i, j+1].Text)).ToString();
                        diem += Int32.Parse(lbs[i, j].Text);
                        lbs[i, j+1].Text = "";                                             
                    }
                }
                KiemTraSangTrai1();
            }
        }
        bool KiemTraDeTaoMoiXuong()
        {
            for (int j = 0; j <= 3; j++)
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (lbs[i + 1, j].Text == "" && lbs[i, j].Text != "")
                        return true;
                    if (lbs[i + 1, j].Text == lbs[i, j].Text && lbs[i + 1, j].Text != "" && lbs[i, j].Text != "")
                        return true;
                }
            } return false;
        }
        void KiemTraDiXuong1()
        {
            for (int j = 0; j <= 3; j++)
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (lbs[i + 1, j].Text == "" && lbs[i, j].Text != "")
                    {
                        lbs[i + 1, j].Text = lbs[i, j].Text;
                        lbs[i, j].Text = "";
                    }
                }
            }
        }
        void KiemTraDiXuong2() { 
            for (int j = 0; j <= 3; j++)
            {
                for (int i = 3; i >=1; i--)
                {
                    if (lbs[i-1, j].Text == lbs[i, j].Text && lbs[i-1, j].Text != "" && lbs[i, j].Text != "")
                    {
                        lbs[i, j ].Text = (Int32.Parse(lbs[i, j].Text) + Int32.Parse(lbs[i-1, j].Text)).ToString();
                        diem += Int32.Parse(lbs[i, j].Text);
                        lbs[i-1, j].Text = "";                                               
                    }
                }
                KiemTraDiXuong1();
            }
        }
        bool KiemTraDeTaoMoiLen()
        {
            for (int j = 3; j >= 0; j--)
            {
                for (int i = 3; i >= 1; i--)
                {
                    if (lbs[i - 1, j].Text == "" && lbs[i, j].Text != "")
                        return true;
                    if (lbs[i - 1, j].Text == lbs[i, j].Text && lbs[i - 1, j].Text != "" && lbs[i, j].Text != "")
                        return true;
                }
            } return false;
        }
        void KiemTraDiLen1()
        {
            for (int j = 3; j >= 0; j--)
            {
                for (int i = 3; i >= 1; i--)
                {
                    if (lbs[i - 1, j].Text == "" && lbs[i, j].Text != "")
                    {
                        lbs[i - 1, j].Text = lbs[i, j].Text;
                        lbs[i, j].Text = "";
                    }
                }
            }
        }
        void KiemTraDiLen2() { 
            for (int j = 3; j >= 0; j--)
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (lbs[i+1, j].Text == lbs[i, j].Text && lbs[i+1, j ].Text != "" && lbs[i, j].Text != "")
                    {
                        lbs[i, j ].Text = (Int32.Parse(lbs[i, j ].Text) + Int32.Parse(lbs[i+1, j].Text)).ToString();
                        diem += Int32.Parse(lbs[i, j].Text);
                        lbs[i+1, j].Text = "";                                        
                    }
                   
                }
                KiemTraDiLen1();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();          
            button5.Text = "Chơi lại";
            resetGiaTri();
            LoadBatDau();
            LoadBatDau();
            btDiLen.Enabled = true;
            btSangPhai.Enabled = true;
            btDiXuong.Enabled = true;
            btSangTrai.Enabled = true;
            timer1.Start();
            diem = 0;
            stopwatch.Start();
            timer3.Start();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {           
            lbDiem.Text = diem.ToString();           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbThongBao.Text = lbThongBao.Text.Substring(1) + lbThongBao.Text.Substring(0, 1);
        }

        private void btCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDiLen_Click(object sender, EventArgs e)
        {           
                bool Ktra = KiemTraDeTaoMoiLen();
                KiemTraDiLen1();
                KiemTraDiLen1();
                KiemTraDiLen1();
                KiemTraDiLen2();
                if (Ktra == true || checkFull()==true)
                    LoadBatDau();   
            

        }

        private void btDiXuong_Click(object sender, EventArgs e)
        {
                bool Ktra = KiemTraDeTaoMoiXuong();
                KiemTraDiXuong1();
                KiemTraDiXuong1();
                KiemTraDiXuong1();
                KiemTraDiXuong2();
            if (Ktra == true || checkFull() == true)
                LoadBatDau();
            

        }

        private void btSangTrai_Click(object sender, EventArgs e)
        {          
                bool Ktra = KiemTraDeTaoMoiTrai();
                KiemTraSangTrai1();
                KiemTraSangTrai1();
                KiemTraSangTrai1();
                KiemTraSangTrai2();
            if (Ktra == true || checkFull() == true)
                LoadBatDau();
            


        }

        private void btSangPhai_Click(object sender, EventArgs e)
        {          
                bool Ktra = KiemTraDeTaoMoiPhai();
                KiemTraSangPhai1();
                KiemTraSangPhai1();
                KiemTraSangPhai1();
                KiemTraSangPhai2();
            if (Ktra == true || checkFull() == true)
                LoadBatDau();  
           

        }





        //private void frm1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    bool Ktra;
        //    switch (e.KeyCode)
        //    {

        //        case Keys.W:
        //            // Xử lý khi nhấn mũi tên lên
        //            Ktra = KiemTraDeTaoMoiLen();
        //            KiemTraDiLen1();
        //            KiemTraDiLen1();
        //            KiemTraDiLen1();
        //            KiemTraDiLen2();
        //            if (Ktra == true)
        //                LoadBatDau();
        //            break;
        //        case Keys.S:
        //            // Xử lý khi nhấn mũi tên xuống
        //            Ktra = KiemTraDeTaoMoiXuong();
        //            KiemTraDiXuong1();
        //            KiemTraDiXuong1();
        //            KiemTraDiXuong1();
        //            KiemTraDiXuong2();
        //            if (Ktra == true)
        //                LoadBatDau();
        //            break;
        //        case Keys.A:
        //            // Xử lý khi nhấn mũi tên trái
        //            Ktra = KiemTraDeTaoMoiTrai();
        //            KiemTraSangTrai1();
        //            KiemTraSangTrai1();
        //            KiemTraSangTrai1();
        //            KiemTraSangTrai2();
        //            if (Ktra == true)
        //                LoadBatDau();
        //            break;
        //        case Keys.D:
        //            // Xử lý khi nhấn mũi tên phải
        //            Ktra = KiemTraDeTaoMoiPhai();
        //            KiemTraSangPhai1();
        //            KiemTraSangPhai1();
        //            KiemTraSangPhai2();
        //            if (Ktra == true)
        //                LoadBatDau();
        //            break;
        //    }
        //}

        private void frm1_KeyUp(object sender, KeyEventArgs e)
        {
            bool Ktra;
            switch (e.KeyCode)
            {

                case Keys.W:
                case Keys.Up: 
                    // Xử lý khi nhấn mũi tên lên
                    Ktra = KiemTraDeTaoMoiLen();
                    KiemTraDiLen1();
                    KiemTraDiLen1();
                    KiemTraDiLen1();
                    KiemTraDiLen2();
                    

                    if (Ktra == true || checkFull() == true)
                        LoadBatDau();
                    break;
                case Keys.S:
                case Keys.Down:
                    // Xử lý khi nhấn mũi tên xuống
                    Ktra = KiemTraDeTaoMoiXuong();
                    KiemTraDiXuong1();
                    KiemTraDiXuong1();
                    KiemTraDiXuong1();
                    KiemTraDiXuong2();
                    

                    if (Ktra == true || checkFull() == true)
                        LoadBatDau();
                    break;
                case Keys.A:
                case Keys.Left:
                    // Xử lý khi nhấn mũi tên trái
                    Ktra = KiemTraDeTaoMoiTrai();
                    KiemTraSangTrai1();
                    KiemTraSangTrai1();
                    KiemTraSangTrai1();
                    KiemTraSangTrai2();
                    

                    if (Ktra == true || checkFull() == true)
                        LoadBatDau();
                    break;
                case Keys.D:
                case Keys.Right:
                    // Xử lý khi nhấn mũi tên phải
                    Ktra = KiemTraDeTaoMoiPhai();
                    KiemTraSangPhai1();
                    KiemTraSangPhai1();
                    KiemTraSangPhai2();
                    

                    if (Ktra == true || checkFull() == true)
                        LoadBatDau();
                    break;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopwatch.Elapsed;
            lbTime.Text = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Hours, ts.Minutes, ts.Seconds);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btDoi_Click(object sender, EventArgs e)
        {
            input = Show("Thông báo ", "Nhập tên của bạn để vào game:");
            lbName.Text = input;
        }
    }
}
