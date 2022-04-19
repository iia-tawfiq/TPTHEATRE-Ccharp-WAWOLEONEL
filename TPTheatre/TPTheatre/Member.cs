using TPTheatre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TPTheatre
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        public object Nom { get; private set; }
        public object Prenom { get; private set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Member member = (Member)listBox1.SelectedItem;
                this.textBox1.Text = member.Nom.ToString();
                this.textBox2.Text = member.Prenom.ToString();
            }
        }
    }
}
