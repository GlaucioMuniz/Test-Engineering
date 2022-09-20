namespace interfaceArduinoVS2013
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.textBoxEnviar = new System.Windows.Forms.TextBox();
            this.textBoxReceber = new System.Windows.Forms.TextBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.opUP = new System.Windows.Forms.RadioButton();
            this.opDOWN = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.btReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(8, 19);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(81, 23);
            this.btConectar.TabIndex = 0;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(6, 48);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(81, 23);
            this.btEnviar.TabIndex = 2;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // textBoxEnviar
            // 
            this.textBoxEnviar.Location = new System.Drawing.Point(102, 50);
            this.textBoxEnviar.Name = "textBoxEnviar";
            this.textBoxEnviar.Size = new System.Drawing.Size(147, 20);
            this.textBoxEnviar.TabIndex = 3;
            // 
            // textBoxReceber
            // 
            this.textBoxReceber.Location = new System.Drawing.Point(6, 77);
            this.textBoxReceber.Multiline = true;
            this.textBoxReceber.Name = "textBoxReceber";
            this.textBoxReceber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceber.Size = new System.Drawing.Size(241, 61);
            this.textBoxReceber.TabIndex = 4;
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM2";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // opUP
            // 
            this.opUP.AutoSize = true;
            this.opUP.Location = new System.Drawing.Point(6, 33);
            this.opUP.Name = "opUP";
            this.opUP.Size = new System.Drawing.Size(88, 17);
            this.opUP.TabIndex = 5;
            this.opUP.TabStop = true;
            this.opUP.Text = "SENSOR UP";
            this.opUP.UseVisualStyleBackColor = true;
            // 
            // opDOWN
            // 
            this.opDOWN.AutoSize = true;
            this.opDOWN.Location = new System.Drawing.Point(141, 33);
            this.opDOWN.Name = "opDOWN";
            this.opDOWN.Size = new System.Drawing.Size(108, 17);
            this.opDOWN.TabIndex = 6;
            this.opDOWN.TabStop = true;
            this.opDOWN.Text = "SENSOR DOWN";
            this.opDOWN.UseVisualStyleBackColor = true;
            this.opDOWN.CheckedChanged += new System.EventHandler(this.opDOWN_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxReceber);
            this.groupBox1.Controls.Add(this.textBoxEnviar);
            this.groupBox1.Controls.Add(this.btEnviar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btConectar);
            this.groupBox1.Location = new System.Drawing.Point(13, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexão Serial";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opDOWN);
            this.groupBox2.Controls.Add(this.opUP);
            this.groupBox2.Location = new System.Drawing.Point(13, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 67);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contador: ";
            // 
            // txtCont
            // 
            this.txtCont.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCont.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCont.Location = new System.Drawing.Point(198, 251);
            this.txtCont.Name = "txtCont";
            this.txtCont.ReadOnly = true;
            this.txtCont.Size = new System.Drawing.Size(62, 20);
            this.txtCont.TabIndex = 10;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(68, 249);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(64, 23);
            this.btReset.TabIndex = 11;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Created by Glaucio Muniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UpDownSensor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.TextBox textBoxEnviar;
        private System.Windows.Forms.TextBox textBoxReceber;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton opUP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton opDOWN;
    }
}

