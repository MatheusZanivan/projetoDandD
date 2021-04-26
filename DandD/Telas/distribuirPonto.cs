using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DandD.Herois;

namespace DandD.Telas
{
    public partial class frm_pontosStatus : Form
    {
        public string Nome { get; set; }
        public string Heroi { get; set; }

        public Guerreiro Guerreiro { get; set; }

        public Mago Mago { get; set; }

        public Arqueiro Arqueiro { get; set; }
        public frm_pontosStatus(string nome, string heroi)
        {
            InitializeComponent();
            Nome = nome;
            Heroi = heroi;
        }

        public int confeirPontos(int forca, int defesa, int agilidade, int sorte, int vida, int mana)
        {
            int soma = forca + defesa + agilidade + sorte + vida + mana;
            if (soma > 300)
            {
                return 1;
            }
            else if (soma < 300)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        private void btn_ok_Click_1(object sender, EventArgs e)
        {
            int valor = confeirPontos((int)nud_forca.Value, (int)nud_defesa.Value, (int)nud_agilidade.Value, (int)nud_sorte.Value, (int)nud_vida.Value, (int)nud_mana.Value);
            if (valor == 1)
            {
                MessageBox.Show("Os seus pontos de habilidade passaram de 300!");
            }
            else if (valor == 2)
            {
                MessageBox.Show("Os seus pontos de habilidade são menor do que 300!");
                //MessageBox com sim e não
                DialogResult dialogResult = MessageBox.Show("Deseja jogar mesmo assim e tentar no hardcore?", "Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Heroi == "Guerreiro")
                    {
                        Guerreiro = new Guerreiro(Nome, 10, 1, (int)nud_forca.Value, (int)nud_defesa.Value, (int)nud_agilidade.Value, (int)nud_sorte.Value, (int)nud_vida.Value, (int)nud_mana.Value, "Guerreiro");
                        frm_batalha form = new frm_batalha(Guerreiro);
                        form.Show();
                        this.Hide();
                    }
                    else if (Heroi == "Mago")
                    {
                        Mago = new Mago(Nome, 10, 1, (int)nud_forca.Value, (int)nud_defesa.Value, (int)nud_agilidade.Value, (int)nud_sorte.Value, (int)nud_vida.Value, (int)nud_mana.Value, "Mago");
                        frm_batalha form = new frm_batalha(Mago);
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        Arqueiro = new Arqueiro(Nome, 10, 1, (int)nud_forca.Value, (int)nud_defesa.Value, (int)nud_agilidade.Value, (int)nud_sorte.Value, (int)nud_vida.Value, (int)nud_mana.Value, "Arqueiro");
                        frm_batalha form = new frm_batalha(Arqueiro);
                        form.Show();
                        this.Hide();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Não");
                }
            }
            else
            {
                if (Heroi == "Guerreiro")
                {
                    Guerreiro = new Guerreiro(Nome, 10, 1, (int)nud_forca.Value, (int)nud_defesa.Value, (int)nud_agilidade.Value, (int)nud_sorte.Value, (int)nud_vida.Value, (int)nud_mana.Value, "Guerreiro");
                    frm_batalha form = new frm_batalha(Guerreiro);
                    form.Show();
                    this.Hide();
                }
                else if (Heroi == "Mago")
                {
                    Mago = new Mago(Nome, 10, 1, (int)nud_forca.Value, (int)nud_defesa.Value, (int)nud_agilidade.Value, (int)nud_sorte.Value, (int)nud_vida.Value, (int)nud_mana.Value, "Mago");
                    frm_batalha form = new frm_batalha(Mago);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    Arqueiro = new Arqueiro(Nome, 10, 1, (int)nud_forca.Value, (int)nud_defesa.Value, (int)nud_agilidade.Value, (int)nud_sorte.Value, (int)nud_vida.Value, (int)nud_mana.Value, "Arqueiro");
                    frm_batalha form = new frm_batalha(Arqueiro);
                    form.Show();
                    this.Hide();
                }
            }
        }
    }
}
