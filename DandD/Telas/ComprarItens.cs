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
    public partial class frm_comprarItens : Form
    {
        public Heroi Heroi { get; set; }
        public frm_comprarItens(Heroi heroi)
        {
            InitializeComponent();
            this.Heroi = heroi;

            if(Heroi.Classe == "Guerreiro")
            {
                btn_comprarEspada.Enabled = true;
            }

            if (Heroi.Classe == "Mago")
            {
                btn_comprarCajado.Enabled = true;
            }

            if (Heroi.Classe == "Arqueiro")
            {
                btn_comprarArco.Enabled = true;
            }
        }

        private void btn_comprarEspada_Click(object sender, EventArgs e)
        {
            Heroi.Itens.Espada = true;
        }

        private void btn_comprarCajado_Click(object sender, EventArgs e)
        {
            Heroi.Itens.Cajado = true;
        }

        private void btn_comprarArco_Click(object sender, EventArgs e)
        {
            Heroi.Itens.Arco = true;
        }
    }
}
