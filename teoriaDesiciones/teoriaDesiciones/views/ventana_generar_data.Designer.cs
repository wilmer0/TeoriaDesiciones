﻿namespace teoriaDesiciones.views
{
    partial class ventana_generar_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_generar_data));
            this.periodoInicialText = new System.Windows.Forms.ComboBox();
            this.periodoFinalText = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // periodoInicialText
            // 
            this.periodoInicialText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodoInicialText.FormattingEnabled = true;
            this.periodoInicialText.Location = new System.Drawing.Point(148, 263);
            this.periodoInicialText.Name = "periodoInicialText";
            this.periodoInicialText.Size = new System.Drawing.Size(121, 21);
            this.periodoInicialText.TabIndex = 0;
            // 
            // periodoFinalText
            // 
            this.periodoFinalText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodoFinalText.FormattingEnabled = true;
            this.periodoFinalText.Location = new System.Drawing.Point(304, 264);
            this.periodoFinalText.Name = "periodoFinalText";
            this.periodoFinalText.Size = new System.Drawing.Size(121, 21);
            this.periodoFinalText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Periodo inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Periodo final";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(151, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 226);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "GENERAR DATA PARA LOS PERIODOS SELECCIONADOS";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Location = new System.Drawing.Point(148, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "Generar Data";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(304, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ver Reporte";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ventana_generar_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodoFinalText);
            this.Controls.Add(this.periodoInicialText);
            this.Name = "ventana_generar_data";
            this.Text = "ventana_generar_data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox periodoInicialText;
        private System.Windows.Forms.ComboBox periodoFinalText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}