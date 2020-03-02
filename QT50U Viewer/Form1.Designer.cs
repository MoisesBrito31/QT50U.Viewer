namespace QT50U_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPecent = new System.Windows.Forms.Label();
            this.painelFaixas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numBlueSup = new System.Windows.Forms.NumericUpDown();
            this.numYelSup = new System.Windows.Forms.NumericUpDown();
            this.numRedSup = new System.Windows.Forms.NumericUpDown();
            this.numBlueInf = new System.Windows.Forms.NumericUpDown();
            this.numYelInf = new System.Windows.Forms.NumericUpDown();
            this.numRedInf = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.painelConexInfo = new System.Windows.Forms.GroupBox();
            this.num20ma = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.num4ma = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numPooling = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numRegistro = new System.Windows.Forms.NumericUpDown();
            this.numIDSlave = new System.Windows.Forms.NumericUpDown();
            this.cmbBound = new System.Windows.Forms.ComboBox();
            this.cbxPorta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.butConectar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLeitura = new System.Windows.Forms.Label();
            this.painelEscala = new System.Windows.Forms.GroupBox();
            this.txtEscala = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numScalaMax = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numScalaMin = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblScala = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.painelFaixas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYelSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYelInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedInf)).BeginInit();
            this.painelConexInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num20ma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4ma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPooling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIDSlave)).BeginInit();
            this.painelEscala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScalaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScalaMin)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QT50U_Viewer.Properties.Resources.tank;
            this.pictureBox1.Location = new System.Drawing.Point(79, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(135, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 10);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(135, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 300);
            this.panel2.TabIndex = 2;
            // 
            // lblPecent
            // 
            this.lblPecent.AutoSize = true;
            this.lblPecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPecent.Location = new System.Drawing.Point(178, 371);
            this.lblPecent.Name = "lblPecent";
            this.lblPecent.Size = new System.Drawing.Size(39, 20);
            this.lblPecent.TabIndex = 3;
            this.lblPecent.Text = "0 %";
            // 
            // painelFaixas
            // 
            this.painelFaixas.Controls.Add(this.label2);
            this.painelFaixas.Controls.Add(this.label1);
            this.painelFaixas.Controls.Add(this.numBlueSup);
            this.painelFaixas.Controls.Add(this.numYelSup);
            this.painelFaixas.Controls.Add(this.numRedSup);
            this.painelFaixas.Controls.Add(this.numBlueInf);
            this.painelFaixas.Controls.Add(this.numYelInf);
            this.painelFaixas.Controls.Add(this.numRedInf);
            this.painelFaixas.Controls.Add(this.panel5);
            this.painelFaixas.Controls.Add(this.panel4);
            this.painelFaixas.Controls.Add(this.panel3);
            this.painelFaixas.Location = new System.Drawing.Point(82, 454);
            this.painelFaixas.Name = "painelFaixas";
            this.painelFaixas.Size = new System.Drawing.Size(200, 126);
            this.painelFaixas.TabIndex = 4;
            this.painelFaixas.TabStop = false;
            this.painelFaixas.Text = "Faixas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Superior";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "inferior";
            // 
            // numBlueSup
            // 
            this.numBlueSup.Location = new System.Drawing.Point(129, 94);
            this.numBlueSup.Name = "numBlueSup";
            this.numBlueSup.Size = new System.Drawing.Size(65, 20);
            this.numBlueSup.TabIndex = 12;
            this.numBlueSup.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numBlueSup.ValueChanged += new System.EventHandler(this.numBlueSup_ValueChanged);
            // 
            // numYelSup
            // 
            this.numYelSup.Location = new System.Drawing.Point(129, 68);
            this.numYelSup.Name = "numYelSup";
            this.numYelSup.Size = new System.Drawing.Size(65, 20);
            this.numYelSup.TabIndex = 11;
            this.numYelSup.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numYelSup.ValueChanged += new System.EventHandler(this.numYelSup_ValueChanged);
            // 
            // numRedSup
            // 
            this.numRedSup.Location = new System.Drawing.Point(129, 41);
            this.numRedSup.Name = "numRedSup";
            this.numRedSup.Size = new System.Drawing.Size(65, 20);
            this.numRedSup.TabIndex = 10;
            this.numRedSup.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numRedSup.ValueChanged += new System.EventHandler(this.numRedSup_ValueChanged);
            // 
            // numBlueInf
            // 
            this.numBlueInf.Location = new System.Drawing.Point(43, 94);
            this.numBlueInf.Name = "numBlueInf";
            this.numBlueInf.Size = new System.Drawing.Size(65, 20);
            this.numBlueInf.TabIndex = 9;
            this.numBlueInf.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numBlueInf.ValueChanged += new System.EventHandler(this.numBlueInf_ValueChanged);
            // 
            // numYelInf
            // 
            this.numYelInf.Location = new System.Drawing.Point(43, 68);
            this.numYelInf.Name = "numYelInf";
            this.numYelInf.Size = new System.Drawing.Size(65, 20);
            this.numYelInf.TabIndex = 8;
            this.numYelInf.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numYelInf.ValueChanged += new System.EventHandler(this.numYelInf_ValueChanged);
            // 
            // numRedInf
            // 
            this.numRedInf.Location = new System.Drawing.Point(43, 41);
            this.numRedInf.Name = "numRedInf";
            this.numRedInf.Size = new System.Drawing.Size(65, 20);
            this.numRedInf.TabIndex = 7;
            this.numRedInf.ValueChanged += new System.EventHandler(this.numRedInf_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(6, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(31, 20);
            this.panel5.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Location = new System.Drawing.Point(6, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(31, 21);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(6, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(31, 20);
            this.panel3.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(79, 11);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.Text = "Tank Nome";
            // 
            // painelConexInfo
            // 
            this.painelConexInfo.Controls.Add(this.num20ma);
            this.painelConexInfo.Controls.Add(this.label10);
            this.painelConexInfo.Controls.Add(this.num4ma);
            this.painelConexInfo.Controls.Add(this.label9);
            this.painelConexInfo.Controls.Add(this.numPooling);
            this.painelConexInfo.Controls.Add(this.label7);
            this.painelConexInfo.Controls.Add(this.numRegistro);
            this.painelConexInfo.Controls.Add(this.numIDSlave);
            this.painelConexInfo.Controls.Add(this.cmbBound);
            this.painelConexInfo.Controls.Add(this.cbxPorta);
            this.painelConexInfo.Controls.Add(this.label6);
            this.painelConexInfo.Controls.Add(this.label5);
            this.painelConexInfo.Controls.Add(this.label4);
            this.painelConexInfo.Controls.Add(this.label3);
            this.painelConexInfo.Location = new System.Drawing.Point(347, 12);
            this.painelConexInfo.Name = "painelConexInfo";
            this.painelConexInfo.Size = new System.Drawing.Size(226, 199);
            this.painelConexInfo.TabIndex = 6;
            this.painelConexInfo.TabStop = false;
            this.painelConexInfo.Text = "Conexão Info";
            // 
            // num20ma
            // 
            this.num20ma.Location = new System.Drawing.Point(98, 170);
            this.num20ma.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num20ma.Name = "num20ma";
            this.num20ma.Size = new System.Drawing.Size(120, 20);
            this.num20ma.TabIndex = 13;
            this.num20ma.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "20ma valor:";
            // 
            // num4ma
            // 
            this.num4ma.Location = new System.Drawing.Point(98, 144);
            this.num4ma.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num4ma.Name = "num4ma";
            this.num4ma.Size = new System.Drawing.Size(120, 20);
            this.num4ma.TabIndex = 11;
            this.num4ma.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "4ma valor:";
            // 
            // numPooling
            // 
            this.numPooling.Location = new System.Drawing.Point(98, 118);
            this.numPooling.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPooling.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPooling.Name = "numPooling";
            this.numPooling.Size = new System.Drawing.Size(120, 20);
            this.numPooling.TabIndex = 9;
            this.numPooling.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPooling.ValueChanged += new System.EventHandler(this.numPooling_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Polling (ms)";
            // 
            // numRegistro
            // 
            this.numRegistro.Location = new System.Drawing.Point(98, 92);
            this.numRegistro.Name = "numRegistro";
            this.numRegistro.Size = new System.Drawing.Size(120, 20);
            this.numRegistro.TabIndex = 7;
            this.numRegistro.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRegistro.ValueChanged += new System.EventHandler(this.numRegistro_ValueChanged);
            // 
            // numIDSlave
            // 
            this.numIDSlave.Location = new System.Drawing.Point(99, 68);
            this.numIDSlave.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numIDSlave.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIDSlave.Name = "numIDSlave";
            this.numIDSlave.Size = new System.Drawing.Size(120, 20);
            this.numIDSlave.TabIndex = 6;
            this.numIDSlave.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numIDSlave.ValueChanged += new System.EventHandler(this.numIDSlave_ValueChanged);
            // 
            // cmbBound
            // 
            this.cmbBound.FormattingEnabled = true;
            this.cmbBound.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400"});
            this.cmbBound.Location = new System.Drawing.Point(98, 44);
            this.cmbBound.Name = "cmbBound";
            this.cmbBound.Size = new System.Drawing.Size(121, 21);
            this.cmbBound.TabIndex = 5;
            this.cmbBound.SelectedIndexChanged += new System.EventHandler(this.cmbBound_SelectedIndexChanged);
            // 
            // cbxPorta
            // 
            this.cbxPorta.FormattingEnabled = true;
            this.cbxPorta.Location = new System.Drawing.Point(98, 22);
            this.cbxPorta.Name = "cbxPorta";
            this.cbxPorta.Size = new System.Drawing.Size(121, 21);
            this.cbxPorta.TabIndex = 4;
            this.cbxPorta.SelectedIndexChanged += new System.EventHandler(this.cbxPorta_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Registro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Id Slave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bound";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Porta";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // butConectar
            // 
            this.butConectar.Location = new System.Drawing.Point(421, 228);
            this.butConectar.Name = "butConectar";
            this.butConectar.Size = new System.Drawing.Size(75, 23);
            this.butConectar.TabIndex = 10;
            this.butConectar.Text = "Conectar";
            this.butConectar.UseVisualStyleBackColor = true;
            this.butConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "mA";
            // 
            // lblLeitura
            // 
            this.lblLeitura.AutoSize = true;
            this.lblLeitura.Location = new System.Drawing.Point(241, 14);
            this.lblLeitura.Name = "lblLeitura";
            this.lblLeitura.Size = new System.Drawing.Size(13, 13);
            this.lblLeitura.TabIndex = 12;
            this.lblLeitura.Text = "0";
            this.lblLeitura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // painelEscala
            // 
            this.painelEscala.Controls.Add(this.txtEscala);
            this.painelEscala.Controls.Add(this.label13);
            this.painelEscala.Controls.Add(this.numScalaMax);
            this.painelEscala.Controls.Add(this.label11);
            this.painelEscala.Controls.Add(this.numScalaMin);
            this.painelEscala.Controls.Add(this.label12);
            this.painelEscala.Location = new System.Drawing.Point(347, 271);
            this.painelEscala.Name = "painelEscala";
            this.painelEscala.Size = new System.Drawing.Size(218, 110);
            this.painelEscala.TabIndex = 14;
            this.painelEscala.TabStop = false;
            this.painelEscala.Text = "Escala Info";
            // 
            // txtEscala
            // 
            this.txtEscala.Location = new System.Drawing.Point(95, 80);
            this.txtEscala.Name = "txtEscala";
            this.txtEscala.Size = new System.Drawing.Size(120, 20);
            this.txtEscala.TabIndex = 15;
            this.txtEscala.Text = "L";
            this.txtEscala.TextChanged += new System.EventHandler(this.txtEscala_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Escala";
            // 
            // numScalaMax
            // 
            this.numScalaMax.Location = new System.Drawing.Point(95, 53);
            this.numScalaMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numScalaMax.Name = "numScalaMax";
            this.numScalaMax.Size = new System.Drawing.Size(120, 20);
            this.numScalaMax.TabIndex = 17;
            this.numScalaMax.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Valor Max";
            // 
            // numScalaMin
            // 
            this.numScalaMin.Location = new System.Drawing.Point(95, 27);
            this.numScalaMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numScalaMin.Name = "numScalaMin";
            this.numScalaMin.Size = new System.Drawing.Size(120, 20);
            this.numScalaMin.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Valar Min";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.DarkGray;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(355, 476);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 39);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "0";
            // 
            // lblScala
            // 
            this.lblScala.AutoSize = true;
            this.lblScala.BackColor = System.Drawing.Color.DarkGray;
            this.lblScala.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScala.Location = new System.Drawing.Point(513, 476);
            this.lblScala.Name = "lblScala";
            this.lblScala.Size = new System.Drawing.Size(37, 39);
            this.lblScala.TabIndex = 16;
            this.lblScala.Text = "L";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Location = new System.Drawing.Point(353, 459);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 74);
            this.panel6.TabIndex = 17;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 596);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(594, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 618);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblScala);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.painelEscala);
            this.Controls.Add(this.lblLeitura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.butConectar);
            this.Controls.Add(this.painelConexInfo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.painelFaixas);
            this.Controls.Add(this.lblPecent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QT50U Viewer 1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.painelFaixas.ResumeLayout(false);
            this.painelFaixas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYelSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYelInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedInf)).EndInit();
            this.painelConexInfo.ResumeLayout(false);
            this.painelConexInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num20ma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4ma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPooling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIDSlave)).EndInit();
            this.painelEscala.ResumeLayout(false);
            this.painelEscala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScalaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScalaMin)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPecent;
        private System.Windows.Forms.GroupBox painelFaixas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numBlueSup;
        private System.Windows.Forms.NumericUpDown numYelSup;
        private System.Windows.Forms.NumericUpDown numRedSup;
        private System.Windows.Forms.NumericUpDown numBlueInf;
        private System.Windows.Forms.NumericUpDown numYelInf;
        private System.Windows.Forms.NumericUpDown numRedInf;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox painelConexInfo;
        private System.Windows.Forms.NumericUpDown numPooling;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numRegistro;
        private System.Windows.Forms.NumericUpDown numIDSlave;
        private System.Windows.Forms.ComboBox cmbBound;
        private System.Windows.Forms.ComboBox cbxPorta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button butConectar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLeitura;
        private System.Windows.Forms.NumericUpDown num20ma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown num4ma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox painelEscala;
        private System.Windows.Forms.TextBox txtEscala;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numScalaMax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numScalaMin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblScala;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

