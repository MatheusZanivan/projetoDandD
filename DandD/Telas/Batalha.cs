using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DandD.Herois;
using DandD.Monstros;


namespace DandD.Telas
{
    public partial class frm_batalha : Form
    {
        public Heroi Heroi { get; set; }
        public Monstro Monstro { get; set; }
        public frm_batalha(Heroi heroi)
        {
            InitializeComponent();
            lbl_agilidade.Text += heroi.Status.Agilidade;
            lbl_defesa.Text += heroi.Status.Defesa;
            lbl_forca.Text += heroi.Status.Forca;
            lbl_sorte.Text += heroi.Status.Sorte;
            lbl_mana.Text += heroi.Status.Mana;
            lbl_vida.Text += heroi.Status.Vida;
            

            this.Heroi = heroi;

            if(this.Heroi.Classe != "Mago")
            {
                btn_curar.Enabled = false;
            }
         
            Random rand = new Random();
            int sorteio = rand.Next(0, 3);

            if (sorteio == 1)
            {
                pcb_monstro.Image = Properties.Resources.goblin;
                this.Monstro = new Goblin(1, 40, 10, 25, 40, 100, 10);
            }
            else if (sorteio == 2)
            {
                pcb_monstro.Image = Properties.Resources.aranha;
                this.Monstro = new Aranha(1, 45, 15, 25, 20, 110, 10);
            }
            else
            {
                pcb_monstro.Image = Properties.Resources.dragao;
                this.Monstro = new Dragao(1,55, 40, 15, 15, 125, 10);
            }
            lbl_vidaMonstro.Text += Monstro.Status.Vida;
        }

        private void btn_atacar_Click(object sender, EventArgs e)
        {
            this.Heroi.atacar(Monstro);
            lbl_vidaMonstro.Text = "Vida Monstro: " + Monstro.Status.Vida;
            if (this.Monstro.Status.Vida <= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja passar no mercado antes de prosseguir?", "Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    frm_comprarItens menu = new frm_comprarItens(this.Heroi);
                    menu.ShowDialog();
                }
                else
                {
                    frm_batalha form = new frm_batalha(Heroi);
                    form.Show();
                    this.Hide();
                }
            }        
            this.Monstro.atacar(Heroi);
            lbl_vida.Text = "Vida: " + this.Heroi.Status.Vida;
            
        }

        private void btn_curar_Click(object sender, EventArgs e)
        {
            
        }   
    }
}
