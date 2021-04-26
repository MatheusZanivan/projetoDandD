
namespace DandD
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.cbo_heroi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_iniciarJogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(180, 165);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // cbo_heroi
            // 
            this.cbo_heroi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_heroi.FormattingEnabled = true;
            this.cbo_heroi.Items.AddRange(new object[] {
            "Guerreiro",
            "Arqueiro",
            "Mago"});
            this.cbo_heroi.Location = new System.Drawing.Point(180, 206);
            this.cbo_heroi.Name = "cbo_heroi";
            this.cbo_heroi.Size = new System.Drawing.Size(121, 23);
            this.cbo_heroi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Heroi";
            // 
            // btn_iniciarJogo
            // 
            this.btn_iniciarJogo.Location = new System.Drawing.Point(195, 261);
            this.btn_iniciarJogo.Name = "btn_iniciarJogo";
            this.btn_iniciarJogo.Size = new System.Drawing.Size(75, 30);
            this.btn_iniciarJogo.TabIndex = 4;
            this.btn_iniciarJogo.Text = "Iniciar Jogo";
            this.btn_iniciarJogo.UseVisualStyleBackColor = true;
            this.btn_iniciarJogo.Click += new System.EventHandler(this.btn_iniciarJogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 425);
            this.Controls.Add(this.btn_iniciarJogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_heroi);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nome: ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ComboBox cbo_heroi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_iniciarJogo;
    }
}

