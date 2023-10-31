using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Game2048
{
    public partial class Frm2cs : Form
    {
        public Frm2cs()
        {
            InitializeComponent();
            listView1.Columns[0].ListView.Font = new Font("Arial", 12, FontStyle.Bold);
            listView1.Columns[1].ListView.Font = new Font("Arial", 12, FontStyle.Bold);
            listView1.Columns[2].ListView.Font = new Font("Arial", 12, FontStyle.Bold);
            listView1.Columns[3].ListView.Font = new Font("Arial", 12, FontStyle.Bold);
        }
        public Frm2cs(string text, string label, string ten)
        {
            InitializeComponent();
            textTime = text;
            labelDiem = label;
            name = ten;

        }
        private string textTime;
        private string labelDiem;
        private string name;

        string path = @"info\info.txt";
        
        
        void addThongTin()
        {
            int i = 0;

            //ListViewItem item1 = new ListViewItem();
            //item1.Text = (++i).ToString();
            //item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = input });
            //item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = labelDiem });
            //item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = textTime });
            //listView1.Items.Add(item1);

            if (!File.Exists(path))
            {
                // Tạo file mới và ghi dữ liệu vào file
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.Write(++i + "|");
                    writer.Write(name + "|");
                    writer.Write(labelDiem + "|");
                    writer.WriteLine(textTime + "|");
                }
            }
            else
            {
                // Mở file hiện có và ghi dữ liệu vào cuối file
                using (StreamWriter writer = File.AppendText(path))
                {
                    writer.Write(++i + "|");
                    writer.Write(name + "|");
                    writer.Write(labelDiem + "|");
                    writer.WriteLine(textTime + "|");
                }
            }
            using (StreamReader reader = new StreamReader(path))
            {
                // Đọc từng dòng dữ liệu trong file
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Tạo một ListViewItem mới và thêm vào ListView
                    string[] values = line.Split('|');
                    ListViewItem item = new ListViewItem(values[0]);
                    item.SubItems.Add(values[1]);
                    item.SubItems.Add(values[2]);
                    item.SubItems.Add(values[3]);
                    listView1.Items.Add(item);
                }
            }

        }
        void SapXep()
        {
            int count = 1;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem item = listView1.Items[i];
                item.Text = count.ToString();
                count++;
            }
        }
        private class ListViewItemComparer : IComparer
        {
            private int col;

            public ListViewItemComparer()
            {
                col = 0;
            }

            public ListViewItemComparer(int column)
            {
                col = column;
            }

            public int Compare(object x, object y)
            {
                int returnVal = -1; // giảm dần

                if (int.TryParse(((ListViewItem)x).SubItems[col].Text, out int num1) && int.TryParse(((ListViewItem)y).SubItems[col].Text, out int num2))
                {
                    returnVal = -1 * num1.CompareTo(num2); // giảm dần
                }
                else // nếu không phải số nguyên thì so sánh theo thứ tự chuỗi
                {
                    returnVal = -1 * String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                }

                return returnVal;
            }
        }

        private void Frm2cs_Load(object sender, EventArgs e)
        {
            addThongTin();
            listView1.ListViewItemSorter = new ListViewItemComparer(2); // sắp xếp theo subitem thứ hai
            listView1.Sort();
            SapXep();
        }

        private void Frm2cs_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

       
    }
}
