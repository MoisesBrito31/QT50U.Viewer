using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace QT50U_Viewer
{
    public partial class Form1 : Form
    {
        public int blueInf = 60;
        public int blueSup = 100;
        public int yellowInf = 20;
        public int yellowSup = 60;
        public int redInf = 0;
        public int redSup = 20;

        public string porta = "";
        public int bound = 19200;
        public int idSlave = 12;
        public int registro = 5;
        public int polling = 200;
        public string status = "";
        public bool cicloON = false;
        public float fatorScala = 0.00f; 



        public Form1()
        {
            InitializeComponent();
            //ThreadStart start = new ThreadStart(ciclo);
            //Thread th = new Thread(start);
            //th.Start();
        }    

        private void Form1_Load(object sender, EventArgs e)
        {           
            verificaPortas();
            timer1.Interval = polling;
            cmbBound.SelectedIndex = 1;
            timer1.Enabled = false;
            //cicloON = false;
            butConectar.Text = "Conectar";
            painelConexInfo.Enabled = true;
            painelEscala.Enabled = true;
            painelFaixas.Enabled = true;
            txtNome.Enabled = true;
        }

        private void verificaPortas()
        {
            for (int x = 1; x < 20; x++)
            {
                try
                {
                    SerialPort p = new SerialPort(string.Format("COM{0}", x));
                    p.Open();
                    cbxPorta.Items.Add(p.PortName);
                    p.Close();

                }
                catch { }
            }
        }

        private void alteratank(int valor, int min,int max)
        {
            int fator = (max - min);
            float nf= (float)(valor - min) / fator * 100;
            fatorScala = (float)(valor - min) / fator;
            int n = Convert.ToInt32(nf);
            Size z = new Size(panel1.Size.Width, n * 3);
            panel1.Size = z;
            Point p = new Point(panel1.Location.X, 370 - n * 3);
            panel1.Location = p;


            if(n>=redInf && n<=redSup)
            {
                panel1.BackColor = Color.Red;
            }
            else if(n>=yellowInf && n<=yellowSup)
            {
                panel1.BackColor = Color.Yellow;
            }
            else if (n >= blueInf && n <= blueSup)
            {
                panel1.BackColor = Color.Blue;
            }
            else
            {
                panel1.BackColor = Color.Black;
            }
            scala();
            lblPecent.Text = Convert.ToString(n)+" %";
        }

        private void numRedInf_ValueChanged(object sender, EventArgs e)
        {
            redInf = Convert.ToInt32(numRedInf.Value);
        }

        private void numRedSup_ValueChanged(object sender, EventArgs e)
        {
            redSup = Convert.ToInt32(numRedSup.Value);
        }

        private void numYelInf_ValueChanged(object sender, EventArgs e)
        {
            yellowInf = Convert.ToInt32(numYelInf.Value);
        }

        private void numYelSup_ValueChanged(object sender, EventArgs e)
        {
            yellowSup = Convert.ToInt32(numYelSup.Value);
        }

        private void numBlueInf_ValueChanged(object sender, EventArgs e)
        {
            blueInf = Convert.ToInt32(numBlueInf.Value);
        }

        private void numBlueSup_ValueChanged(object sender, EventArgs e)
        {
            blueSup = Convert.ToInt32(numBlueSup.Value);
        }

        private void cbxPorta_SelectedIndexChanged(object sender, EventArgs e)
        {
            porta = cbxPorta.SelectedItem.ToString();
        }

        private void cmbBound_SelectedIndexChanged(object sender, EventArgs e)
        {
            bound = Convert.ToInt32(cmbBound.SelectedItem.ToString());
        }

        private void numIDSlave_ValueChanged(object sender, EventArgs e)
        {
            idSlave = Convert.ToInt32(numIDSlave.Value);
        }

        private void numRegistro_ValueChanged(object sender, EventArgs e)
        {
            registro = Convert.ToInt32(numRegistro.Value);
        }

        private void numPooling_ValueChanged(object sender, EventArgs e)
        {
            polling = Convert.ToInt32(numPooling.Value);
            timer1.Interval=polling;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(butConectar.Text=="Conectar")
            {
                timer1.Enabled = true;
                //cicloON = true;
                butConectar.Text = "Desconectar";
                painelConexInfo.Enabled = false;
                painelEscala.Enabled = false;
                painelFaixas.Enabled = false;
                txtNome.Enabled = false;
            }
            else
            {
                timer1.Enabled = false;
                //cicloON = false;
                butConectar.Text = "Conectar";
                painelConexInfo.Enabled = true;
                painelEscala.Enabled = true;
                painelFaixas.Enabled = true;
                txtNome.Enabled = true;
            }
        
        }

        private void scala()
        {
            int es = (Convert.ToInt32(numScalaMax.Value) - Convert.ToInt32(numScalaMin.Value));
            float result = (float)(fatorScala * es) + Convert.ToInt32(numScalaMin.Value);
            string texto = Convert.ToString(result);
            string index = "";
            string temp="";
            for(int x = 0;x<texto.Length;x++)
            {
                index = texto.Substring(x,1);
                temp = string.Format("{0}{1}", temp, index);
                if (index=="." || index==",")
                {
                    texto = temp + texto.Substring(x + 1, 1);
                    x = 1000;
                }
            }
            lblValor.Text = texto;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            modbus mod = new modbus();
            try
            {
                byte adress = Convert.ToByte(idSlave);
                ushort end = (ushort)(registro-1);
                short[] buffer = new short[2];
                mod.Open(porta, bound, 8, Parity.None, StopBits.One);
                mod.SendFc3(adress, end, 2, ref buffer);
                int MB = Convert.ToInt32(buffer[0]);
                int LB = Convert.ToInt32(buffer[1]);
                lblLeitura.Text = Convert.ToString(MB+LB);
                lblStatus.Text = mod.modbusStatus;
                mod.Close();
                alteratank(MB+LB,Convert.ToInt32(num4ma.Value),Convert.ToInt32(num20ma.Value));
            }
            catch(Exception ex)
            {
                status = "";
                status = mod.modbusStatus;
                timer1.Enabled = false;
                butConectar.Text = "Conectar";
                painelConexInfo.Enabled = true;
                MessageBox.Show(ex.Message);
            }
        }

        private void ciclo()
        {
            while (true)
            {
                if (cicloON)
                
                    {

                        modbus mod = new modbus();
                        try
                        {
                            byte adress = Convert.ToByte(idSlave);
                            ushort end = (ushort)(registro - 1);
                            short[] buffer = new short[2];
                            mod.Open(porta, bound, 8, Parity.None, StopBits.One);
                            mod.SendFc3(adress, end, 2, ref buffer);
                            int MB = Convert.ToInt32(buffer[0]);
                            int LB = Convert.ToInt32(buffer[1]);
                            lblLeitura.Text = Convert.ToString(MB + LB);
                            lblStatus.Text = mod.modbusStatus;
                            mod.Close();
                            alteratank(MB + LB, Convert.ToInt32(num4ma.Value), Convert.ToInt32(num20ma.Value));
                        }
                        catch (Exception ex)
                        {
                            status = "";
                            status = mod.modbusStatus;
                            timer1.Enabled = false;
                            butConectar.Text = "Conectar";
                            painelConexInfo.Enabled = true;
                        }
                    }

                Thread.Sleep(polling);
            }
        }

        private void txtEscala_TextChanged(object sender, EventArgs e)
        {
            lblScala.Text = txtEscala.Text;
        }
    }
}
