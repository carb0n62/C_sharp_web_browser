using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChromeFox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///Quits the browser.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Shows the "about" box with stuff in it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ChromeFox. Web browser Project.\r\n\r\nVersion: 0.1 Alpha.");
        }

        /// <summary>
        /// Displays the page requested on click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            NavigateToPage();
        }

        /// <summary>
        /// The main function to navigate on a page.
        /// </summary>
        private void NavigateToPage()
        {
            toolStripStatusLabel1.Text = "Loading page...";
            webBrowser1.Navigate(textBox1.Text);
        }

        /// <summary>
        /// Function so that you can navigate by pressing "Enter"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If "Enter" is pressed then do sth.
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                NavigateToPage();
            }


            //Need to fix this...
            /*else if (e.KeyChar == (char)ConsoleKey.F5)
            {
                webBrowser1.Refresh();
            }*/
        }

        /// <summary>
        /// Function used to do stuff when the page is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Loading complete !";
        }

        /// <summary>
        /// Function that animates the progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_ProgressChanged_1(object sender, WebBrowserProgressChangedEventArgs e)
        {
            // "if" to avoid division by zero.
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
            }
        }

        /// <summary>
        /// Useless function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Function to go back.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        /// <summary>
        /// Function to go forward.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        /// <summary>
        /// Function to refresh the page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        /// <summary>
        /// Function to stop the loading of the page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        /// <summary>
        /// Function to navigate to the home page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com");
        }
    }
}
