namespace EnigmaSimulator.WinForms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.lblAnillos = new System.Windows.Forms.Label();
            this.cboRotor2 = new System.Windows.Forms.ComboBox();
            this.cboRotor3 = new System.Windows.Forms.ComboBox();
            this.txtRotores = new System.Windows.Forms.TextBox();
            this.txtAnillos = new System.Windows.Forms.TextBox();
            this.cboAnillo3 = new System.Windows.Forms.ComboBox();
            this.cboAnillo2 = new System.Windows.Forms.ComboBox();
            this.cboAnillo1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRotores = new System.Windows.Forms.Label();
            this.cmdConfigurarConexiones = new System.Windows.Forms.Button();
            this.txtConexiones = new System.Windows.Forms.TextBox();
            this.lblConexiones = new System.Windows.Forms.Label();
            this.cboRotor1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarConfiguracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anillosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEntrada);
            this.groupBox1.Location = new System.Drawing.Point(12, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(6, 19);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(440, 137);
            this.txtEntrada.TabIndex = 0;
            // 
            // lblAnillos
            // 
            this.lblAnillos.AutoSize = true;
            this.lblAnillos.Location = new System.Drawing.Point(14, 70);
            this.lblAnillos.Name = "lblAnillos";
            this.lblAnillos.Size = new System.Drawing.Size(157, 13);
            this.lblAnillos.TabIndex = 5;
            this.lblAnillos.Text = "Posicion Inicial (Groundstellung)";
            // 
            // cboRotor2
            // 
            this.cboRotor2.FormattingEnabled = true;
            this.cboRotor2.Location = new System.Drawing.Point(252, 29);
            this.cboRotor2.Name = "cboRotor2";
            this.cboRotor2.Size = new System.Drawing.Size(53, 21);
            this.cboRotor2.TabIndex = 8;
            // 
            // cboRotor3
            // 
            this.cboRotor3.FormattingEnabled = true;
            this.cboRotor3.Location = new System.Drawing.Point(311, 29);
            this.cboRotor3.Name = "cboRotor3";
            this.cboRotor3.Size = new System.Drawing.Size(53, 21);
            this.cboRotor3.TabIndex = 9;
            // 
            // txtRotores
            // 
            this.txtRotores.Location = new System.Drawing.Point(370, 29);
            this.txtRotores.Name = "txtRotores";
            this.txtRotores.Size = new System.Drawing.Size(59, 20);
            this.txtRotores.TabIndex = 10;
            // 
            // txtAnillos
            // 
            this.txtAnillos.Location = new System.Drawing.Point(370, 69);
            this.txtAnillos.Name = "txtAnillos";
            this.txtAnillos.Size = new System.Drawing.Size(59, 20);
            this.txtAnillos.TabIndex = 14;
            // 
            // cboAnillo3
            // 
            this.cboAnillo3.FormattingEnabled = true;
            this.cboAnillo3.Location = new System.Drawing.Point(311, 69);
            this.cboAnillo3.Name = "cboAnillo3";
            this.cboAnillo3.Size = new System.Drawing.Size(53, 21);
            this.cboAnillo3.TabIndex = 13;
            // 
            // cboAnillo2
            // 
            this.cboAnillo2.FormattingEnabled = true;
            this.cboAnillo2.Location = new System.Drawing.Point(252, 69);
            this.cboAnillo2.Name = "cboAnillo2";
            this.cboAnillo2.Size = new System.Drawing.Size(53, 21);
            this.cboAnillo2.TabIndex = 12;
            // 
            // cboAnillo1
            // 
            this.cboAnillo1.FormattingEnabled = true;
            this.cboAnillo1.Location = new System.Drawing.Point(193, 69);
            this.cboAnillo1.Name = "cboAnillo1";
            this.cboAnillo1.Size = new System.Drawing.Size(53, 21);
            this.cboAnillo1.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRotores);
            this.groupBox2.Controls.Add(this.cmdConfigurarConexiones);
            this.groupBox2.Controls.Add(this.txtConexiones);
            this.groupBox2.Controls.Add(this.lblConexiones);
            this.groupBox2.Controls.Add(this.txtAnillos);
            this.groupBox2.Controls.Add(this.cboAnillo3);
            this.groupBox2.Controls.Add(this.cboAnillo2);
            this.groupBox2.Controls.Add(this.cboAnillo1);
            this.groupBox2.Controls.Add(this.txtRotores);
            this.groupBox2.Controls.Add(this.cboRotor3);
            this.groupBox2.Controls.Add(this.cboRotor2);
            this.groupBox2.Controls.Add(this.lblAnillos);
            this.groupBox2.Controls.Add(this.cboRotor1);
            this.groupBox2.Location = new System.Drawing.Point(12, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 140);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuracion";
            // 
            // lblRotores
            // 
            this.lblRotores.AutoSize = true;
            this.lblRotores.Location = new System.Drawing.Point(14, 31);
            this.lblRotores.Name = "lblRotores";
            this.lblRotores.Size = new System.Drawing.Size(141, 13);
            this.lblRotores.TabIndex = 23;
            this.lblRotores.Text = "Orden Rotores (Walzenlage)";
            this.lblRotores.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmdConfigurarConexiones
            // 
            this.cmdConfigurarConexiones.Location = new System.Drawing.Point(354, 107);
            this.cmdConfigurarConexiones.Name = "cmdConfigurarConexiones";
            this.cmdConfigurarConexiones.Size = new System.Drawing.Size(75, 23);
            this.cmdConfigurarConexiones.TabIndex = 22;
            this.cmdConfigurarConexiones.Text = "Configurar";
            this.cmdConfigurarConexiones.UseVisualStyleBackColor = true;
            // 
            // txtConexiones
            // 
            this.txtConexiones.Location = new System.Drawing.Point(193, 109);
            this.txtConexiones.Name = "txtConexiones";
            this.txtConexiones.Size = new System.Drawing.Size(146, 20);
            this.txtConexiones.TabIndex = 21;
            // 
            // lblConexiones
            // 
            this.lblConexiones.AutoSize = true;
            this.lblConexiones.Location = new System.Drawing.Point(14, 110);
            this.lblConexiones.Name = "lblConexiones";
            this.lblConexiones.Size = new System.Drawing.Size(129, 13);
            this.lblConexiones.TabIndex = 20;
            this.lblConexiones.Text = "Conexiones (Steckerbrett)";
            this.lblConexiones.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboRotor1
            // 
            this.cboRotor1.FormattingEnabled = true;
            this.cboRotor1.Location = new System.Drawing.Point(193, 29);
            this.cboRotor1.Name = "cboRotor1";
            this.cboRotor1.Size = new System.Drawing.Size(53, 21);
            this.cboRotor1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSalida);
            this.groupBox3.Location = new System.Drawing.Point(12, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 162);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salida";
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(6, 19);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(440, 137);
            this.txtSalida.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.reiniciarConfiguracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 22);
            this.toolStripMenuItem1.Text = "Menu01";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // reiniciarConfiguracionToolStripMenuItem
            // 
            this.reiniciarConfiguracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotoresToolStripMenuItem,
            this.anillosToolStripMenuItem,
            this.tableroToolStripMenuItem,
            this.todoToolStripMenuItem});
            this.reiniciarConfiguracionToolStripMenuItem.Name = "reiniciarConfiguracionToolStripMenuItem";
            this.reiniciarConfiguracionToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.reiniciarConfiguracionToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarConfiguracionToolStripMenuItem.Click += new System.EventHandler(this.reiniciarConfiguracionToolStripMenuItem_Click);
            // 
            // rotoresToolStripMenuItem
            // 
            this.rotoresToolStripMenuItem.Name = "rotoresToolStripMenuItem";
            this.rotoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rotoresToolStripMenuItem.Text = "Rotores";
            // 
            // anillosToolStripMenuItem
            // 
            this.anillosToolStripMenuItem.Name = "anillosToolStripMenuItem";
            this.anillosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.anillosToolStripMenuItem.Text = "Anillos";
            // 
            // tableroToolStripMenuItem
            // 
            this.tableroToolStripMenuItem.Name = "tableroToolStripMenuItem";
            this.tableroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tableroToolStripMenuItem.Text = "Tablero";
            // 
            // todoToolStripMenuItem
            // 
            this.todoToolStripMenuItem.Name = "todoToolStripMenuItem";
            this.todoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.todoToolStripMenuItem.Text = "Todo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 520);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(498, 565);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(498, 411);
            this.Name = "Form1";
            this.Text = "Enigma Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lblAnillos;
        private System.Windows.Forms.ComboBox cboRotor2;
        private System.Windows.Forms.ComboBox cboRotor3;
        private System.Windows.Forms.TextBox txtRotores;
        private System.Windows.Forms.TextBox txtAnillos;
        private System.Windows.Forms.ComboBox cboAnillo3;
        private System.Windows.Forms.ComboBox cboAnillo2;
        private System.Windows.Forms.ComboBox cboAnillo1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblConexiones;
        private System.Windows.Forms.Button cmdConfigurarConexiones;
        private System.Windows.Forms.TextBox txtConexiones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.ComboBox cboRotor1;
        private System.Windows.Forms.Label lblRotores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reiniciarConfiguracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anillosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todoToolStripMenuItem;
    }
}