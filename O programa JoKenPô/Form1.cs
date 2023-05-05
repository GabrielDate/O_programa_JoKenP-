using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O_programa_JoKenPô
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RbtPedra_CheckedChanged(object sender, EventArgs e)
        {
            PtbJogador.Image = Properties.Resources.pedraquadrada;
        }

        private void RbtPapel_CheckedChanged(object sender, EventArgs e)
        {
            PtbJogador.Image = Properties.Resources.papel;
        }

        private void RbtTesoura_CheckedChanged(object sender, EventArgs e)
        {
            PtbJogador.Image = Properties.Resources.tesoura;
        }

        private void BtnJogar_Click(object sender, EventArgs e)
        {
            jogadamaquina();
        }

        private void PtbMaquina_Click(object sender, EventArgs e)
        {
            jogadamaquina();
        }

        void jogadamaquina()
        {

            Random sort = new Random();
            int o = sort.Next(1, 4);

            switch (o)
            {
                case 1:
                    PtbMaquina.Image = Properties.Resources.pedraquadrada;
                    break;
                case 2:
                    PtbMaquina.Image = Properties.Resources.papel;
                    break;
                case 3:
                    PtbMaquina.Image = Properties.Resources.tesoura;
                    break;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            PtbMaquina.Image = default;
        }
    }
    }
