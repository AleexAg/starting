namespace CursoCsharp.Ejercicios
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.nametext = new System.Windows.Forms.Label();
            this.txtejercicios = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEj2 = new System.Windows.Forms.Button();
            this.btnej3 = new System.Windows.Forms.Button();
            this.panelvisor = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nametext
            // 
            this.nametext.Dock = System.Windows.Forms.DockStyle.Top;
            this.nametext.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametext.ForeColor = System.Drawing.Color.White;
            this.nametext.Location = new System.Drawing.Point(0, 0);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(1151, 64);
            this.nametext.TabIndex = 0;
            this.nametext.Text = "Alex Aguirre";
            this.nametext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtejercicios
            // 
            this.txtejercicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtejercicios.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtejercicios.ForeColor = System.Drawing.Color.White;
            this.txtejercicios.Location = new System.Drawing.Point(0, 64);
            this.txtejercicios.Name = "txtejercicios";
            this.txtejercicios.Size = new System.Drawing.Size(1151, 22);
            this.txtejercicios.TabIndex = 1;
            this.txtejercicios.Text = "EJERCICIOS";
            this.txtejercicios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.btnEj2);
            this.flowLayoutPanel1.Controls.Add(this.btnej3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 86);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(310, 586);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Consolas", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 103);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ejercicio N°1\r\n{Operadores Aritmeticos}";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnEj1_Click);
            // 
            // btnEj2
            // 
            this.btnEj2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEj2.FlatAppearance.BorderSize = 0;
            this.btnEj2.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnEj2.ForeColor = System.Drawing.Color.White;
            this.btnEj2.Location = new System.Drawing.Point(3, 112);
            this.btnEj2.Name = "btnEj2";
            this.btnEj2.Size = new System.Drawing.Size(301, 103);
            this.btnEj2.TabIndex = 0;
            this.btnEj2.Text = "Ejercicio N°2\r\n{Radio y longitud}";
            this.btnEj2.UseVisualStyleBackColor = false;
            this.btnEj2.Click += new System.EventHandler(this.btnEj2_Click);
            // 
            // btnej3
            // 
            this.btnej3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnej3.FlatAppearance.BorderSize = 0;
            this.btnej3.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnej3.ForeColor = System.Drawing.Color.White;
            this.btnej3.Location = new System.Drawing.Point(3, 221);
            this.btnej3.Name = "btnej3";
            this.btnej3.Size = new System.Drawing.Size(301, 103);
            this.btnej3.TabIndex = 1;
            this.btnej3.Text = "Ejercicio N°3\r\n{Operadores logicos}";
            this.btnej3.UseVisualStyleBackColor = false;
            this.btnej3.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelvisor
            // 
            this.panelvisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelvisor.Location = new System.Drawing.Point(310, 86);
            this.panelvisor.Name = "panelvisor";
            this.panelvisor.Size = new System.Drawing.Size(841, 586);
            this.panelvisor.TabIndex = 3;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1151, 672);
            this.Controls.Add(this.panelvisor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtejercicios);
            this.Controls.Add(this.nametext);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Menu de ejercicios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nametext;
        private System.Windows.Forms.Label txtejercicios;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEj2;
        private System.Windows.Forms.Panel panelvisor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnej3;
    }
}