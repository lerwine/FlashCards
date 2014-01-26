using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Erwine.Leonard.Thomas.Flash_Cards
{
    public partial class CardTableForm : Form
    {
        public CardTableForm()
        {
            InitializeComponent();
        }

        private void CardTableForm_Shown(object sender, EventArgs e)
        {
            this.textCardDisplay.RichTextBox.SelectionFont = new Font(this.textCardDisplay.Font.FontFamily, 18.0F, FontStyle.Bold);
            this.textCardDisplay.RichTextBox.Text = "No deck loaded.";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
