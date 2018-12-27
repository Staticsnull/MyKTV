using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo
{
    /// <summary>
    ///  管理员窗体类
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//事件源(谁引发的事件) 事件参数(时间,任务,地点)
        {
            ////表示触发事件的那个控件
            ///EventArgs是事件参数 
            //该事件传入的参数，比如说你用鼠标点击窗体 
            this.userControl11.BackImage = Image.FromFile(@"D:\Pictures\36.jpg");
            //this.im1.BackImage = Image.FromFile(@"D:\Pictures\38.jpg");
            //MessageBox.Show()
            string[] urls =
            {
                @"D:\Pictures\38.jpg",
                @"D:\Pictures\36.jpg",
                @"D:\Pictures\37.jpg",
                @"D:\Pictures\35.jpg",
                @"D:\Pictures\39.jpg",
                @"D:\Pictures\34.jpg",
                @"D:\Pictures\33.jpg"
            };
            int index = 1;
            foreach (string url in urls)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "0"+index;
                lvi.SubItems.Add(url);
                this.listView1.Items.Add(lvi);
                index++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show();
            //this.userControl11.BackImage = Image.FromFile(@"D:\Pictures\38.jpg");
            //this.im1.BackgroundColor = Color.Transparent;
            //MessageBox.Show((e as MouseEventArgs).Clicks.ToString());
            ListViewItem lvi =  this.listView1.SelectedItems[0];
            this.listView1.Items.Remove(lvi);
            this.listView1.Items.Insert(1, lvi);
            //添加事件
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(e.Clicks.ToString());
        }
    }
}
