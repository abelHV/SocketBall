namespace SocketBall
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbConnexio = new System.Windows.Forms.GroupBox();
            this.lbestatservidor = new System.Windows.Forms.Label();
            this.nupPort = new System.Windows.Forms.NumericUpDown();
            this.nupDret = new System.Windows.Forms.NumericUpDown();
            this.nupEsquerre = new System.Windows.Forms.NumericUpDown();
            this.tbDret = new System.Windows.Forms.TextBox();
            this.tbEsquerre = new System.Windows.Forms.TextBox();
            this.btConnectar = new System.Windows.Forms.Button();
            this.btPort = new System.Windows.Forms.Button();
            this.chkDret = new System.Windows.Forms.CheckBox();
            this.chkEsquerre = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbConnexio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEsquerre)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConnexio
            // 
            this.gbConnexio.Controls.Add(this.lbestatservidor);
            this.gbConnexio.Controls.Add(this.nupPort);
            this.gbConnexio.Controls.Add(this.nupDret);
            this.gbConnexio.Controls.Add(this.nupEsquerre);
            this.gbConnexio.Controls.Add(this.tbDret);
            this.gbConnexio.Controls.Add(this.tbEsquerre);
            this.gbConnexio.Controls.Add(this.btConnectar);
            this.gbConnexio.Controls.Add(this.btPort);
            this.gbConnexio.Controls.Add(this.chkDret);
            this.gbConnexio.Controls.Add(this.chkEsquerre);
            this.gbConnexio.Controls.Add(this.label5);
            this.gbConnexio.Controls.Add(this.label4);
            this.gbConnexio.Controls.Add(this.label3);
            this.gbConnexio.Controls.Add(this.label2);
            this.gbConnexio.Controls.Add(this.label1);
            this.gbConnexio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbConnexio.Location = new System.Drawing.Point(106, 56);
            this.gbConnexio.Name = "gbConnexio";
            this.gbConnexio.Size = new System.Drawing.Size(589, 339);
            this.gbConnexio.TabIndex = 1;
            this.gbConnexio.TabStop = false;
            this.gbConnexio.Text = "Dades Connexio";
            // 
            // lbestatservidor
            // 
            this.lbestatservidor.AutoSize = true;
            this.lbestatservidor.Location = new System.Drawing.Point(473, 52);
            this.lbestatservidor.Name = "lbestatservidor";
            this.lbestatservidor.Size = new System.Drawing.Size(0, 16);
            this.lbestatservidor.TabIndex = 12;
            // 
            // nupPort
            // 
            this.nupPort.Location = new System.Drawing.Point(187, 50);
            this.nupPort.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nupPort.Name = "nupPort";
            this.nupPort.Size = new System.Drawing.Size(91, 22);
            this.nupPort.TabIndex = 11;
            // 
            // nupDret
            // 
            this.nupDret.Location = new System.Drawing.Point(322, 203);
            this.nupDret.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nupDret.Name = "nupDret";
            this.nupDret.Size = new System.Drawing.Size(91, 22);
            this.nupDret.TabIndex = 1;
            // 
            // nupEsquerre
            // 
            this.nupEsquerre.Location = new System.Drawing.Point(322, 124);
            this.nupEsquerre.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nupEsquerre.Name = "nupEsquerre";
            this.nupEsquerre.Size = new System.Drawing.Size(91, 22);
            this.nupEsquerre.TabIndex = 2;
            // 
            // tbDret
            // 
            this.tbDret.Location = new System.Drawing.Point(187, 202);
            this.tbDret.Name = "tbDret";
            this.tbDret.Size = new System.Drawing.Size(100, 22);
            this.tbDret.TabIndex = 9;
            // 
            // tbEsquerre
            // 
            this.tbEsquerre.Location = new System.Drawing.Point(187, 123);
            this.tbEsquerre.Name = "tbEsquerre";
            this.tbEsquerre.Size = new System.Drawing.Size(100, 22);
            this.tbEsquerre.TabIndex = 8;
            // 
            // btConnectar
            // 
            this.btConnectar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btConnectar.Location = new System.Drawing.Point(52, 267);
            this.btConnectar.Name = "btConnectar";
            this.btConnectar.Size = new System.Drawing.Size(145, 30);
            this.btConnectar.TabIndex = 7;
            this.btConnectar.Text = "Connectar";
            this.btConnectar.UseVisualStyleBackColor = false;
            this.btConnectar.Click += new System.EventHandler(this.btConnectar_Click);
            // 
            // btPort
            // 
            this.btPort.BackColor = System.Drawing.SystemColors.Desktop;
            this.btPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPort.Location = new System.Drawing.Point(322, 45);
            this.btPort.Name = "btPort";
            this.btPort.Size = new System.Drawing.Size(145, 30);
            this.btPort.TabIndex = 1;
            this.btPort.Text = "Connectar";
            this.btPort.UseVisualStyleBackColor = false;
            this.btPort.Click += new System.EventHandler(this.btPort_Click);
            // 
            // chkDret
            // 
            this.chkDret.AutoSize = true;
            this.chkDret.Location = new System.Drawing.Point(527, 206);
            this.chkDret.Name = "chkDret";
            this.chkDret.Size = new System.Drawing.Size(18, 17);
            this.chkDret.TabIndex = 6;
            this.chkDret.UseVisualStyleBackColor = true;
            this.chkDret.CheckedChanged += new System.EventHandler(this.chkDret_CheckedChanged);
            // 
            // chkEsquerre
            // 
            this.chkEsquerre.AutoSize = true;
            this.chkEsquerre.Location = new System.Drawing.Point(527, 120);
            this.chkEsquerre.Name = "chkEsquerre";
            this.chkEsquerre.Size = new System.Drawing.Size(18, 17);
            this.chkEsquerre.TabIndex = 1;
            this.chkEsquerre.UseVisualStyleBackColor = true;
            this.chkEsquerre.CheckedChanged += new System.EventHandler(this.chkEsquerre_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Es Paret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Es Paret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP veí dret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP veí esquerre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port per a escoltar";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbConnexio);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbConnexio.ResumeLayout(false);
            this.gbConnexio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEsquerre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnexio;
        private System.Windows.Forms.NumericUpDown nupDret;
        private System.Windows.Forms.NumericUpDown nupEsquerre;
        private System.Windows.Forms.TextBox tbDret;
        private System.Windows.Forms.TextBox tbEsquerre;
        private System.Windows.Forms.Button btConnectar;
        private System.Windows.Forms.Button btPort;
        private System.Windows.Forms.CheckBox chkDret;
        private System.Windows.Forms.CheckBox chkEsquerre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupPort;
        private System.Windows.Forms.Label lbestatservidor;
    }
}

