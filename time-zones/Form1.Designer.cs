
namespace time_zones
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
            this.labelPortugal = new System.Windows.Forms.Label();
            this.labelIndia = new System.Windows.Forms.Label();
            this.labelPrimeiro = new System.Windows.Forms.Label();
            this.labelSegundo = new System.Windows.Forms.Label();
            this.labelTerceiro = new System.Windows.Forms.Label();
            this.portugal = new System.Windows.Forms.Label();
            this.india = new System.Windows.Forms.Label();
            this.primeiro = new System.Windows.Forms.Label();
            this.segundo = new System.Windows.Forms.Label();
            this.terceiro = new System.Windows.Forms.Label();
            this.labelDiferenca = new System.Windows.Forms.Label();
            this.numericUpDownMain = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrimeiro = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSegundo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTerceiro = new System.Windows.Forms.NumericUpDown();
            this.button = new System.Windows.Forms.Label();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrimeiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSegundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTerceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPortugal
            // 
            this.labelPortugal.AutoSize = true;
            this.labelPortugal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortugal.Location = new System.Drawing.Point(12, 10);
            this.labelPortugal.Name = "labelPortugal";
            this.labelPortugal.Size = new System.Drawing.Size(84, 24);
            this.labelPortugal.TabIndex = 0;
            this.labelPortugal.Text = "Portugal:";
            // 
            // labelIndia
            // 
            this.labelIndia.AutoSize = true;
            this.labelIndia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndia.Location = new System.Drawing.Point(12, 50);
            this.labelIndia.Name = "labelIndia";
            this.labelIndia.Size = new System.Drawing.Size(55, 24);
            this.labelIndia.TabIndex = 1;
            this.labelIndia.Text = "Índia:";
            // 
            // labelPrimeiro
            // 
            this.labelPrimeiro.AutoSize = true;
            this.labelPrimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrimeiro.Location = new System.Drawing.Point(7, 100);
            this.labelPrimeiro.Name = "labelPrimeiro";
            this.labelPrimeiro.Size = new System.Drawing.Size(102, 20);
            this.labelPrimeiro.TabIndex = 2;
            this.labelPrimeiro.Text = "+ 0 HORAS";
            // 
            // labelSegundo
            // 
            this.labelSegundo.AutoSize = true;
            this.labelSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSegundo.Location = new System.Drawing.Point(7, 140);
            this.labelSegundo.Name = "labelSegundo";
            this.labelSegundo.Size = new System.Drawing.Size(102, 20);
            this.labelSegundo.TabIndex = 3;
            this.labelSegundo.Text = "+ 0 HORAS";
            // 
            // labelTerceiro
            // 
            this.labelTerceiro.AutoSize = true;
            this.labelTerceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerceiro.Location = new System.Drawing.Point(7, 180);
            this.labelTerceiro.Name = "labelTerceiro";
            this.labelTerceiro.Size = new System.Drawing.Size(102, 20);
            this.labelTerceiro.TabIndex = 4;
            this.labelTerceiro.Text = "+ 0 HORAS";
            // 
            // portugal
            // 
            this.portugal.AutoSize = true;
            this.portugal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portugal.Location = new System.Drawing.Point(122, 10);
            this.portugal.Name = "portugal";
            this.portugal.Size = new System.Drawing.Size(80, 24);
            this.portugal.TabIndex = 5;
            this.portugal.Text = "00:00:00";
            // 
            // india
            // 
            this.india.AutoSize = true;
            this.india.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.india.Location = new System.Drawing.Point(122, 51);
            this.india.Name = "india";
            this.india.Size = new System.Drawing.Size(55, 24);
            this.india.TabIndex = 6;
            this.india.Text = "00:00";
            // 
            // primeiro
            // 
            this.primeiro.AutoSize = true;
            this.primeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeiro.Location = new System.Drawing.Point(122, 97);
            this.primeiro.Name = "primeiro";
            this.primeiro.Size = new System.Drawing.Size(55, 24);
            this.primeiro.TabIndex = 7;
            this.primeiro.Text = "00:00";
            // 
            // segundo
            // 
            this.segundo.AutoSize = true;
            this.segundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundo.Location = new System.Drawing.Point(122, 137);
            this.segundo.Name = "segundo";
            this.segundo.Size = new System.Drawing.Size(55, 24);
            this.segundo.TabIndex = 8;
            this.segundo.Text = "00:00";
            // 
            // terceiro
            // 
            this.terceiro.AutoSize = true;
            this.terceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terceiro.Location = new System.Drawing.Point(122, 177);
            this.terceiro.Name = "terceiro";
            this.terceiro.Size = new System.Drawing.Size(55, 24);
            this.terceiro.TabIndex = 9;
            this.terceiro.Text = "00:00";
            // 
            // labelDiferenca
            // 
            this.labelDiferenca.AutoSize = true;
            this.labelDiferenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiferenca.Location = new System.Drawing.Point(302, 10);
            this.labelDiferenca.Name = "labelDiferenca";
            this.labelDiferenca.Size = new System.Drawing.Size(134, 20);
            this.labelDiferenca.TabIndex = 10;
            this.labelDiferenca.Text = "Diferença Horária";
            // 
            // numericUpDownMain
            // 
            this.numericUpDownMain.Location = new System.Drawing.Point(306, 51);
            this.numericUpDownMain.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownMain.Minimum = new decimal(new int[] {
            23,
            0,
            0,
            -2147483648});
            this.numericUpDownMain.Name = "numericUpDownMain";
            this.numericUpDownMain.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownMain.TabIndex = 11;
            // 
            // numericUpDownPrimeiro
            // 
            this.numericUpDownPrimeiro.Location = new System.Drawing.Point(306, 97);
            this.numericUpDownPrimeiro.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownPrimeiro.Minimum = new decimal(new int[] {
            23,
            0,
            0,
            -2147483648});
            this.numericUpDownPrimeiro.Name = "numericUpDownPrimeiro";
            this.numericUpDownPrimeiro.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownPrimeiro.TabIndex = 12;
            // 
            // numericUpDownSegundo
            // 
            this.numericUpDownSegundo.Location = new System.Drawing.Point(306, 137);
            this.numericUpDownSegundo.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownSegundo.Minimum = new decimal(new int[] {
            23,
            0,
            0,
            -2147483648});
            this.numericUpDownSegundo.Name = "numericUpDownSegundo";
            this.numericUpDownSegundo.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownSegundo.TabIndex = 13;
            // 
            // numericUpDownTerceiro
            // 
            this.numericUpDownTerceiro.Location = new System.Drawing.Point(306, 177);
            this.numericUpDownTerceiro.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownTerceiro.Minimum = new decimal(new int[] {
            23,
            0,
            0,
            -2147483648});
            this.numericUpDownTerceiro.Name = "numericUpDownTerceiro";
            this.numericUpDownTerceiro.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownTerceiro.TabIndex = 14;
            // 
            // button
            // 
            this.button.AutoSize = true;
            this.button.BackColor = System.Drawing.Color.Black;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.Yellow;
            this.button.Location = new System.Drawing.Point(217, 95);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(38, 25);
            this.button.TabIndex = 15;
            this.button.Text = ">>";
            this.button.Click += new System.EventHandler(this.label1_Click);
            // 
            // relogio
            // 
            this.relogio.Enabled = true;
            this.relogio.Interval = 1000;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 217);
            this.Controls.Add(this.button);
            this.Controls.Add(this.numericUpDownTerceiro);
            this.Controls.Add(this.numericUpDownSegundo);
            this.Controls.Add(this.numericUpDownPrimeiro);
            this.Controls.Add(this.numericUpDownMain);
            this.Controls.Add(this.labelDiferenca);
            this.Controls.Add(this.terceiro);
            this.Controls.Add(this.segundo);
            this.Controls.Add(this.primeiro);
            this.Controls.Add(this.india);
            this.Controls.Add(this.portugal);
            this.Controls.Add(this.labelTerceiro);
            this.Controls.Add(this.labelSegundo);
            this.Controls.Add(this.labelPrimeiro);
            this.Controls.Add(this.labelIndia);
            this.Controls.Add(this.labelPortugal);
            this.MaximumSize = new System.Drawing.Size(280, 256);
            this.MinimumSize = new System.Drawing.Size(280, 256);
            this.Name = "Form1";
            this.Text = "Time-Zones";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrimeiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSegundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTerceiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPortugal;
        private System.Windows.Forms.Label labelIndia;
        private System.Windows.Forms.Label labelPrimeiro;
        private System.Windows.Forms.Label labelSegundo;
        private System.Windows.Forms.Label labelTerceiro;
        private System.Windows.Forms.Label portugal;
        private System.Windows.Forms.Label india;
        private System.Windows.Forms.Label primeiro;
        private System.Windows.Forms.Label segundo;
        private System.Windows.Forms.Label terceiro;
        private System.Windows.Forms.Label labelDiferenca;
        private System.Windows.Forms.NumericUpDown numericUpDownMain;
        private System.Windows.Forms.NumericUpDown numericUpDownPrimeiro;
        private System.Windows.Forms.NumericUpDown numericUpDownSegundo;
        private System.Windows.Forms.NumericUpDown numericUpDownTerceiro;
        private System.Windows.Forms.Label button;
        private System.Windows.Forms.Timer relogio;
    }
}

