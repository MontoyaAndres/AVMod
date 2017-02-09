using System;
using System.Windows.Forms;

namespace AVMod2
{
    public partial class Permisos : Form
    {
        public Permisos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (acepto.Checked == true)
            {
                AVMod2pro ventana = new AVMod2pro();
                this.Hide();
                ventana.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}
