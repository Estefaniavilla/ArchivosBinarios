﻿namespace ArchivosBinarios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblInstrucciones = new Label();
            btnEscribir = new Button();
            btnLeer = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(36, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(157, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Manejo de Archivos Binarios";
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Location = new Point(36, 91);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(336, 15);
            lblInstrucciones.TabIndex = 1;
            lblInstrucciones.Text = "Haga clic en 'Escribir' para guardar datos en un archivo binario";
            // 
            // btnEscribir
            // 
            btnEscribir.Location = new Point(36, 161);
            btnEscribir.Name = "btnEscribir";
            btnEscribir.Size = new Size(137, 23);
            btnEscribir.TabIndex = 2;
            btnEscribir.Text = "Escribir";
            btnEscribir.UseVisualStyleBackColor = true;
            btnEscribir.Click += btnEscribir_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(218, 161);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(154, 23);
            btnLeer.TabIndex = 3;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLeer);
            Controls.Add(btnEscribir);
            Controls.Add(lblInstrucciones);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblInstrucciones;
        private Button btnEscribir;
        private Button btnLeer;
    }
}
