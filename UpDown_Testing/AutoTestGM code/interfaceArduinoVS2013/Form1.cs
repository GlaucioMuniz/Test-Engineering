using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  // necessário para ter acesso as portas

namespace interfaceArduinoVS2013
{
    public partial class Form1 : Form
    {

        string RxString;
        int Count;

        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true;

        }

        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
            

            
        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
            textBoxReceber.Clear();

        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    btConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;

                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta 
                serialPort1.Close();            //fecha a porta
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)          //porta está aberta
                serialPort1.Write(textBoxEnviar.Text);  //envia o texto presente no textbox Enviar
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
        }

        private void trataDadoRecebido(object sender, EventArgs e)

        {
            textBoxReceber.AppendText(RxString);

            if (RxString == "d")
            {
                //Contador
                Count += 1;
                txtCont.Clear();
                txtCont.AppendText(Count.ToString());
            }

            if (textBoxReceber.Text.Length == 144) //numero de caracteres na caixa de texto 4 linhas
            {
                textBoxReceber.Clear(); // apagar todo texto.
            }

            if (RxString == "u")
            {
                opUP.Checked = true; // sinal do sensor UP, recebido via serial tx do Arduino

            }
            if (RxString == "d")
            {
                opDOWN.Checked = true;  // sinal do sensor DOWN, recebido via serial tx do Arduino
            }

        }

        private void button1_Click(object sender, EventArgs e) //restar contador
        {
            txtCont.Clear();
            textBoxReceber.Clear();
            Count = 0;
        }

        private void opDOWN_CheckedChanged(object sender, EventArgs e)
        {
            if (opDOWN.Checked)
            {
                System.Diagnostics.Process.Start(@"C:\teste\teste.exe");
            }
        }
    }
}
