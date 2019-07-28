using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupChecker_1._0
{
    public partial class Form1 : Form
    {

        public bool developenabled = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void airFoxHeader215_Click(object sender, EventArgs e)
        {

        }

        private void airFoxRedirect1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/id/majeur/");
        }

        private void airFoxRedirect2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/zustd6a");
        }

        private void airFoxRedirect3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCfkg1rTQnIcScFK83IMPZIA");
        }

        private void airFoxButton1_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text != "" )
            {
                if (textBox1.Text.Contains("https://steamcommunity.com/groups/"))
                {

                    checkgroup();
                    checkwords();
                }
                else
                {
                    MessageBox.Show("Error: Please send a group link", "ERROR_BAD_LINK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Error: Please enter a link", "ERROR_NO_LINK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void checkgroup()
        {
            var web = new WebClient();
            string url = textBox1.Text;
            var result = web.DownloadString(url);
            if (result.Contains(airFoxTextbox1.Text) || result.Contains(airFoxTextbox2.Text) || result.Contains(airFoxTextbox3.Text) || result.Contains(airFoxTextbox4.Text) || result.Contains(airFoxTextbox5.Text) || result.Contains(airFoxTextbox6.Text) || result.Contains(airFoxTextbox7.Text) || result.Contains(airFoxTextbox8.Text) || result.Contains(airFoxTextbox9.Text) || result.Contains(airFoxTextbox10.Text) || result.Contains(airFoxTextbox10.Text) || result.Contains(airFoxTextbox9.Text) || result.Contains(airFoxTextbox8.Text) || result.Contains(airFoxTextbox7.Text) || result.Contains(airFoxTextbox15.Text) )
            {
                label1.Text = "FAKE";
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.Text = "REAL";
                label1.ForeColor = Color.Green;
            }

            richTextBox1.Text = result;
        }

        void checkwords()
        {
            var web = new WebClient();
            string url = textBox1.Text;
            var result = web.DownloadString(url);
            if (result.Contains(suspect1.Text) || result.Contains(suspect2.Text) || result.Contains(suspect3.Text) || result.Contains(suspect4.Text) || result.Contains(suspect5.Text) || result.Contains(suspect6.Text) || result.Contains(suspect7.Text) || result.Contains(suspect8.Text) || result.Contains(suspect9.Text) || result.Contains(suspect10.Text) )
            {
                label2.Text = "THERE IS SOME SUSPECT WORDS";
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.Text = "THERE IS NOT SUSPECT WORDS";
                label2.ForeColor = Color.Green;
            }

        }

        private void airFoxOnOffBox1_CheckedChanged(object sender, EventArgs e)
        {

          if(airFoxOnOffBox1.Checked == false)
            {
                airFoxMainTabControl1.TabPages.Add(tabPage4);
            }


            if (airFoxOnOffBox1.Checked == true)
            {
                airFoxMainTabControl1.TabPages.Remove(tabPage4);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            developenabled = false;
            airFoxMainTabControl1.TabPages.Remove(tabPage4);
        }

        private void airFoxOnOffBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
                
  }
 
