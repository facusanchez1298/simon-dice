namespace SimonDice
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnAmarrillo = new System.Windows.Forms.Button();
            this.buttonJugar_click = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzul.Location = new System.Drawing.Point(166, 40);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(110, 110);
            this.btnAzul.TabIndex = 0;
            this.btnAzul.Text = " ";
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Green;
            this.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerde.Location = new System.Drawing.Point(166, 260);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(110, 110);
            this.btnVerde.TabIndex = 1;
            this.btnVerde.Text = " ";
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Red;
            this.btnRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRojo.Location = new System.Drawing.Point(56, 150);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(110, 110);
            this.btnRojo.TabIndex = 2;
            this.btnRojo.Text = " ";
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAmarrillo
            // 
            this.btnAmarrillo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarrillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmarrillo.Location = new System.Drawing.Point(276, 150);
            this.btnAmarrillo.Name = "btnAmarrillo";
            this.btnAmarrillo.Size = new System.Drawing.Size(110, 110);
            this.btnAmarrillo.TabIndex = 3;
            this.btnAmarrillo.Text = " ";
            this.btnAmarrillo.UseVisualStyleBackColor = false;
            this.btnAmarrillo.Click += new System.EventHandler(this.btn_Click);
            // 
            // buttonJugar
            // 
            this.buttonJugar_click.BackColor = System.Drawing.Color.White;
            this.buttonJugar_click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonJugar_click.Location = new System.Drawing.Point(166, 150);
            this.buttonJugar_click.Name = "buttonJugar";
            this.buttonJugar_click.Size = new System.Drawing.Size(110, 110);
            this.buttonJugar_click.TabIndex = 0;
            this.buttonJugar_click.Text = "jugar";
            this.buttonJugar_click.UseVisualStyleBackColor = false;
            this.buttonJugar_click.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(428, 411);
            this.Controls.Add(this.btnAmarrillo);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.buttonJugar_click);
            this.Controls.Add(this.btnAzul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnAmarrillo;
        private System.Windows.Forms.Button buttonJugar_click;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

