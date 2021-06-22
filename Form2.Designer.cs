
namespace Opa
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bt_novouser = new System.Windows.Forms.Button();
            this.tb_nomeuser = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_senhauser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_repsenhauser = new System.Windows.Forms.TextBox();
            this.tb_cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_emailuser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_novouser
            // 
            this.bt_novouser.Location = new System.Drawing.Point(12, 238);
            this.bt_novouser.Name = "bt_novouser";
            this.bt_novouser.Size = new System.Drawing.Size(100, 23);
            this.bt_novouser.TabIndex = 6;
            this.bt_novouser.Text = "Novo usuário";
            this.bt_novouser.UseVisualStyleBackColor = true;
            this.bt_novouser.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_nomeuser
            // 
            this.tb_nomeuser.Location = new System.Drawing.Point(85, 76);
            this.tb_nomeuser.Name = "tb_nomeuser";
            this.tb_nomeuser.Size = new System.Drawing.Size(100, 23);
            this.tb_nomeuser.TabIndex = 1;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(85, 105);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 23);
            this.tb_username.TabIndex = 2;
            // 
            // tb_senhauser
            // 
            this.tb_senhauser.Location = new System.Drawing.Point(85, 159);
            this.tb_senhauser.Name = "tb_senhauser";
            this.tb_senhauser.Size = new System.Drawing.Size(100, 23);
            this.tb_senhauser.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(4, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(4, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha :";
            // 
            // tb_repsenhauser
            // 
            this.tb_repsenhauser.Location = new System.Drawing.Point(85, 188);
            this.tb_repsenhauser.Name = "tb_repsenhauser";
            this.tb_repsenhauser.Size = new System.Drawing.Size(100, 23);
            this.tb_repsenhauser.TabIndex = 5;
            // 
            // tb_cancelar
            // 
            this.tb_cancelar.Location = new System.Drawing.Point(118, 238);
            this.tb_cancelar.Name = "tb_cancelar";
            this.tb_cancelar.Size = new System.Drawing.Size(100, 23);
            this.tb_cancelar.TabIndex = 7;
            this.tb_cancelar.Text = "Cancelar";
            this.tb_cancelar.UseVisualStyleBackColor = true;
            this.tb_cancelar.Click += new System.EventHandler(this.tb_cancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(4, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email :";
            // 
            // tb_emailuser
            // 
            this.tb_emailuser.Location = new System.Drawing.Point(85, 132);
            this.tb_emailuser.Name = "tb_emailuser";
            this.tb_emailuser.Size = new System.Drawing.Size(100, 23);
            this.tb_emailuser.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(85, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "Arq-o";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(228, 276);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_emailuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_cancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_repsenhauser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_senhauser);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_nomeuser);
            this.Controls.Add(this.bt_novouser);
            this.Name = "Form2";
            this.Text = "Arq-o";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_novouser;
        private System.Windows.Forms.TextBox tb_nomeuser;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_senhauser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tb_cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_emailuser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_repsenhauser;
    }
}