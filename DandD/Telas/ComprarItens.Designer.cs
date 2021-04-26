
namespace DandD.Telas
{
    partial class frm_comprarItens
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
            this.btn_comprarEspada = new System.Windows.Forms.Button();
            this.pcb_espada = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_comprarCajado = new System.Windows.Forms.Button();
            this.btn_comprarArco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_espada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_comprarEspada
            // 
            this.btn_comprarEspada.BackColor = System.Drawing.Color.Peru;
            this.btn_comprarEspada.Enabled = false;
            this.btn_comprarEspada.ForeColor = System.Drawing.Color.Wheat;
            this.btn_comprarEspada.Location = new System.Drawing.Point(87, 250);
            this.btn_comprarEspada.Name = "btn_comprarEspada";
            this.btn_comprarEspada.Size = new System.Drawing.Size(75, 34);
            this.btn_comprarEspada.TabIndex = 0;
            this.btn_comprarEspada.Text = "Comprar";
            this.btn_comprarEspada.UseVisualStyleBackColor = false;
            this.btn_comprarEspada.Click += new System.EventHandler(this.btn_comprarEspada_Click);
            // 
            // pcb_espada
            // 
            this.pcb_espada.Image = global::DandD.Properties.Resources.espada;
            this.pcb_espada.Location = new System.Drawing.Point(87, 137);
            this.pcb_espada.Name = "pcb_espada";
            this.pcb_espada.Size = new System.Drawing.Size(75, 80);
            this.pcb_espada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_espada.TabIndex = 1;
            this.pcb_espada.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DandD.Properties.Resources.cajado;
            this.pictureBox1.Location = new System.Drawing.Point(242, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DandD.Properties.Resources.arco;
            this.pictureBox2.Location = new System.Drawing.Point(390, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btn_comprarCajado
            // 
            this.btn_comprarCajado.BackColor = System.Drawing.Color.Peru;
            this.btn_comprarCajado.Enabled = false;
            this.btn_comprarCajado.ForeColor = System.Drawing.Color.Wheat;
            this.btn_comprarCajado.Location = new System.Drawing.Point(242, 250);
            this.btn_comprarCajado.Name = "btn_comprarCajado";
            this.btn_comprarCajado.Size = new System.Drawing.Size(75, 34);
            this.btn_comprarCajado.TabIndex = 4;
            this.btn_comprarCajado.Text = "Comprar";
            this.btn_comprarCajado.UseVisualStyleBackColor = false;
            this.btn_comprarCajado.Click += new System.EventHandler(this.btn_comprarCajado_Click);
            // 
            // btn_comprarArco
            // 
            this.btn_comprarArco.BackColor = System.Drawing.Color.Peru;
            this.btn_comprarArco.Enabled = false;
            this.btn_comprarArco.ForeColor = System.Drawing.Color.Wheat;
            this.btn_comprarArco.Location = new System.Drawing.Point(390, 250);
            this.btn_comprarArco.Name = "btn_comprarArco";
            this.btn_comprarArco.Size = new System.Drawing.Size(75, 34);
            this.btn_comprarArco.TabIndex = 5;
            this.btn_comprarArco.Text = "Comprar";
            this.btn_comprarArco.UseVisualStyleBackColor = false;
            this.btn_comprarArco.Click += new System.EventHandler(this.btn_comprarArco_Click);
            // 
            // frm_comprarItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 367);
            this.Controls.Add(this.btn_comprarArco);
            this.Controls.Add(this.btn_comprarCajado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcb_espada);
            this.Controls.Add(this.btn_comprarEspada);
            this.Name = "frm_comprarItens";
            this.Text = "ComprarItens";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_espada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_comprarEspada;
        private System.Windows.Forms.PictureBox pcb_espada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_comprarCajado;
        private System.Windows.Forms.Button btn_comprarArco;
    }
}