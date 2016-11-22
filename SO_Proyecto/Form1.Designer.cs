namespace SO_Proyecto
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
            this.btnCajero1 = new System.Windows.Forms.Button();
            this.btnCajero3 = new System.Windows.Forms.Button();
            this.btnCajero2 = new System.Windows.Forms.Button();
            this.lbxFila = new System.Windows.Forms.ListBox();
            this.lblPersona1 = new System.Windows.Forms.Label();
            this.lblPersona2 = new System.Windows.Forms.Label();
            this.lblPersona3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCajero1
            // 
            this.btnCajero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajero1.Location = new System.Drawing.Point(182, 38);
            this.btnCajero1.Name = "btnCajero1";
            this.btnCajero1.Size = new System.Drawing.Size(94, 76);
            this.btnCajero1.TabIndex = 0;
            this.btnCajero1.Text = "Cajero 1";
            this.btnCajero1.UseVisualStyleBackColor = true;
            // 
            // btnCajero3
            // 
            this.btnCajero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajero3.Location = new System.Drawing.Point(526, 38);
            this.btnCajero3.Name = "btnCajero3";
            this.btnCajero3.Size = new System.Drawing.Size(86, 76);
            this.btnCajero3.TabIndex = 1;
            this.btnCajero3.Text = "Cajero 3";
            this.btnCajero3.UseVisualStyleBackColor = true;
            // 
            // btnCajero2
            // 
            this.btnCajero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajero2.Location = new System.Drawing.Point(351, 38);
            this.btnCajero2.Name = "btnCajero2";
            this.btnCajero2.Size = new System.Drawing.Size(89, 76);
            this.btnCajero2.TabIndex = 2;
            this.btnCajero2.Text = "Cajero 2";
            this.btnCajero2.UseVisualStyleBackColor = true;
            // 
            // lbxFila
            // 
            this.lbxFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFila.FormattingEnabled = true;
            this.lbxFila.ItemHeight = 20;
            this.lbxFila.Location = new System.Drawing.Point(12, 137);
            this.lbxFila.Name = "lbxFila";
            this.lbxFila.Size = new System.Drawing.Size(131, 244);
            this.lbxFila.TabIndex = 3;
            // 
            // lblPersona1
            // 
            this.lblPersona1.AutoSize = true;
            this.lblPersona1.Location = new System.Drawing.Point(179, 117);
            this.lblPersona1.Name = "lblPersona1";
            this.lblPersona1.Size = new System.Drawing.Size(35, 13);
            this.lblPersona1.TabIndex = 4;
            this.lblPersona1.Text = "label1";
            // 
            // lblPersona2
            // 
            this.lblPersona2.AutoSize = true;
            this.lblPersona2.Location = new System.Drawing.Point(348, 117);
            this.lblPersona2.Name = "lblPersona2";
            this.lblPersona2.Size = new System.Drawing.Size(35, 13);
            this.lblPersona2.TabIndex = 5;
            this.lblPersona2.Text = "label2";
            // 
            // lblPersona3
            // 
            this.lblPersona3.AutoSize = true;
            this.lblPersona3.Location = new System.Drawing.Point(523, 117);
            this.lblPersona3.Name = "lblPersona3";
            this.lblPersona3.Size = new System.Drawing.Size(35, 13);
            this.lblPersona3.TabIndex = 6;
            this.lblPersona3.Text = "label3";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 419);
            this.Controls.Add(this.lblPersona3);
            this.Controls.Add(this.lblPersona2);
            this.Controls.Add(this.lblPersona1);
            this.Controls.Add(this.lbxFila);
            this.Controls.Add(this.btnCajero2);
            this.Controls.Add(this.btnCajero3);
            this.Controls.Add(this.btnCajero1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemas Operativos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCajero1;
        private System.Windows.Forms.Button btnCajero3;
        private System.Windows.Forms.Button btnCajero2;
        private System.Windows.Forms.ListBox lbxFila;
        private System.Windows.Forms.Label lblPersona1;
        private System.Windows.Forms.Label lblPersona2;
        private System.Windows.Forms.Label lblPersona3;
        private System.Windows.Forms.Timer timer;
    }
}

