namespace WindowsFormsApplication1
{
    partial class Comprovacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 53);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(-5, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 64);
            this.panel2.TabIndex = 1;
            // 
            // txtcode
            // 
            this.txtcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(147, 72);
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '*';
            this.txtcode.Size = new System.Drawing.Size(281, 22);
            this.txtcode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca el codigo de administrador";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.button1.Location = new System.Drawing.Point(17, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.button2.Location = new System.Drawing.Point(428, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Comprovacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(580, 174);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comprovacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprovacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Button button2;
    }
}