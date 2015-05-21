using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WindowsThread2
{
    public partial class Form1 : Form
    {
        Thread th1;
        private delegate void CallBackTyp(int i,String msg);
        private CallBackTyp delVar;
     
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void buttonAusgabe_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(writeOnListBox));

            delVar = new CallBackTyp(updateListBox);
            listBoxAusgabe.Items.Clear();
            th1.Start();
        }
        private void writeOnListBox()
        {                  
                for (int i = 1; i <= 1000; i++)
                {
                    listBoxAusgabe.Invoke(delVar, new Object[] { i, "Eine Meldung" });
                    //updateListBox(i,"Eine Meldung");
                    Thread.Sleep(500);
                }
            
        }
        private void updateListBox(int i,String m)
        {
            //if (listBoxAusgabe.InvokeRequired)
            //{            
            //    listBoxAusgabe.Invoke(delVar,new Object[] {i,m});
            //}
            //else
            //{
                listBoxAusgabe.Items.Add(i.ToString() + ": " + m);
                listBoxAusgabe.SelectedItem = listBoxAusgabe.Items.Count ;
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelZeit.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
