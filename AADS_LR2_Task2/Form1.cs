using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADS_LR2_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindWords_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            int wordLength = (int)numLength.Value;

            string[] words = input.Split(' ');

            var selectedWords = words.Where(word => word.Length == wordLength);

            lstWords.Items.Clear();
            foreach (var word in selectedWords)
            {
                lstWords.Items.Add(word);
            }
        }
    }
}
