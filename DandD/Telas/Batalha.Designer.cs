
namespace DandD.Telas
{
    partial class frm_batalha
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
            this.lbl_sorte = new System.Windows.Forms.Label();
            this.lbl_agilidade = new System.Windows.Forms.Label();
            this.lbl_vida = new System.Windows.Forms.Label();
            this.lbl_mana = new System.Windows.Forms.Label();
            this.lbl_defesa = new System.Windows.Forms.Label();
            this.lbl_forca = new System.Windows.Forms.Label();
            this.pcb_monstro = new System.Windows.Forms.PictureBox();
            this.btn_atacar = new System.Windows.Forms.Button();
            this.lbl_vidaMonstro = new System.Windows.Forms.Label();
            this.btn_curar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_monstro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_sorte);
            this.groupBox1.Controls.Add(this.lbl_agilidade);
            this.groupBox1.Controls.Add(this.lbl_vida);
            this.groupBox1.Controls.Add(this.lbl_mana);
            this.groupBox1.Controls.Add(this.lbl_defesa);
            this.groupBox1.Controls.Add(this.lbl_forca);
            this.groupBox1.Location = new System.Drawing.Point(12, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habilidades";
            // 
            // lbl_sorte
            // 
            this.lbl_sorte.AutoSize = true;
            this.lbl_sorte.Location = new System.Drawing.Point(107, 18);
            this.lbl_sorte.Name = "lbl_sorte";
            this.lbl_sorte.Size = new System.Drawing.Size(40, 15);
            this.lbl_sorte.TabIndex = 7;
            this.lbl_sorte.Text = "Sorte: ";
            // 
            // lbl_agilidade
            // 
            this.lbl_agilidade.AutoSize = true;
            this.lbl_agilidade.Location = new System.Drawing.Point(6, 82);
            this.lbl_agilidade.Name = "lbl_agilidade";
            this.lbl_agilidade.Size = new System.Drawing.Size(63, 15);
            this.lbl_agilidade.TabIndex = 8;
            this.lbl_agilidade.Text = "Agilidade: ";
            // 
            // lbl_vida
            // 
            this.lbl_vida.AutoSize = true;
            this.lbl_vida.Location = new System.Drawing.Point(107, 48);
            this.lbl_vida.Name = "lbl_vida";
            this.lbl_vida.Size = new System.Drawing.Size(36, 15);
            this.lbl_vida.TabIndex = 6;
            this.lbl_vida.Text = "Vida: ";
            // 
            // lbl_mana
            // 
            this.lbl_mana.AutoSize = true;
            this.lbl_mana.Location = new System.Drawing.Point(107, 82);
            this.lbl_mana.Name = "lbl_mana";
            this.lbl_mana.Size = new System.Drawing.Size(43, 15);
            this.lbl_mana.TabIndex = 5;
            this.lbl_mana.Text = "Mana: ";
            // 
            // lbl_defesa
            // 
            this.lbl_defesa.AutoSize = true;
            this.lbl_defesa.Location = new System.Drawing.Point(6, 48);
            this.lbl_defesa.Name = "lbl_defesa";
            this.lbl_defesa.Size = new System.Drawing.Size(48, 15);
            this.lbl_defesa.TabIndex = 7;
            this.lbl_defesa.Text = "Defesa: ";
            // 
            // lbl_forca
            // 
            this.lbl_forca.AutoSize = true;
            this.lbl_forca.Location = new System.Drawing.Point(9, 18);
            this.lbl_forca.Name = "lbl_forca";
            this.lbl_forca.Size = new System.Drawing.Size(42, 15);
            this.lbl_forca.TabIndex = 6;
            this.lbl_forca.Text = "Força: ";
            // 
            // pcb_monstro
            // 
            this.pcb_monstro.Image = global::DandD.Properties.Resources.dragao;
            this.pcb_monstro.Location = new System.Drawing.Point(21, 46);
            this.pcb_monstro.Name = "pcb_monstro";
            this.pcb_monstro.Size = new System.Drawing.Size(212, 298);
            this.pcb_monstro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_monstro.TabIndex = 1;
            this.pcb_monstro.TabStop = false;
            // 
            // btn_atacar
            // 
            this.btn_atacar.Location = new System.Drawing.Point(264, 368);
            this.btn_atacar.Name = "btn_atacar";
            this.btn_atacar.Size = new System.Drawing.Size(103, 60);
            this.btn_atacar.TabIndex = 2;
            this.btn_atacar.Text = "Atacar";
            this.btn_atacar.UseVisualStyleBackColor = true;
            this.btn_atacar.Click += new System.EventHandler(this.btn_atacar_Click);
            // 
            // lbl_vidaMonstro
            // 
            this.lbl_vidaMonstro.AutoSize = true;
            this.lbl_vidaMonstro.Location = new System.Drawing.Point(485, 34);
            this.lbl_vidaMonstro.Name = "lbl_vidaMonstro";
            this.lbl_vidaMonstro.Size = new System.Drawing.Size(84, 15);
            this.lbl_vidaMonstro.TabIndex = 3;
            this.lbl_vidaMonstro.Text = "Vida Monstro: ";
            // 
            // btn_curar
            // 
            this.btn_curar.Location = new System.Drawing.Point(419, 368);
            this.btn_curar.Name = "btn_curar";
            this.btn_curar.Size = new System.Drawing.Size(103, 60);
            this.btn_curar.TabIndex = 4;
            this.btn_curar.Text = "Curar";
            this.btn_curar.UseVisualStyleBackColor = true;
            this.btn_curar.Click += new System.EventHandler(this.btn_curar_Click);
            // 
            // frm_batalha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.btn_curar);
            this.Controls.Add(this.lbl_vidaMonstro);
            this.Controls.Add(this.btn_atacar);
            this.Controls.Add(this.pcb_monstro);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_batalha";
            this.Text = "Batalha";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_monstro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_agilidade;
        private System.Windows.Forms.Label lbl_defesa;
        private System.Windows.Forms.Label lbl_forca;
        private System.Windows.Forms.Label lbl_sorte;
        private System.Windows.Forms.Label lbl_vida;
        private System.Windows.Forms.Label lbl_mana;
        private System.Windows.Forms.PictureBox pcb_monstro;
        private System.Windows.Forms.Button btn_atacar;
        private System.Windows.Forms.Label lbl_vidaMonstro;
        private System.Windows.Forms.Button btn_curar;
    }
}