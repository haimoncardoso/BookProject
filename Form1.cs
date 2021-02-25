using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_livros
{
    public partial class FrmLivro : Form
    {
        public FrmLivro()
        {
            InitializeComponent();
        }

        private void ChkAtraves_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAtraves.Checked == true)
            {
                ChkAtraves.ForeColor = Color.Blue;
                PicSuspense.Image = Properties.Resources.Através_do_Fogo;
                ChkAtraves.Text = "Através do fogo";
                ListLivros.Items.Add("Através do fogo");
                ListGeneros.Items.Add("Suspense");
            }
            else
            {
                ChkAtraves.ForeColor = Color.Black;
                PicSuspense.Image = Properties.Resources.Suspense;
                ChkAtraves.Text = "Livro 1";
                ListLivros.Items.Remove("Através do fogo");
                ListGeneros.Items.Remove("Suspense");
            }
        }

        private void ChkOrigem_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkOrigem.Checked == true)
            {
                ChkOrigem.ForeColor = Color.Blue;
                PicSuspense1.Image = Properties.Resources.Origem2;
                ChkOrigem.Text = "Origem 2";
                ListLivros.Items.Add("Origem 2");
                ListGeneros.Items.Add("Suspense");
            }
            else
            {
                ChkOrigem.ForeColor = Color.Black;
                PicSuspense1.Image = Properties.Resources.Suspense;
                ChkOrigem.Text = "Livro 2";
                ListLivros.Items.Remove("Origem 2");
                ListGeneros.Items.Remove("Suspense");
            }
        }

        private void ChkMisterio_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkMisterio.Checked == true)
            {
                ChkMisterio.ForeColor = Color.Blue;
                PicSuspense3.Image = Properties.Resources.Misterio_No_Caribe;
                ChkMisterio.Text = "Mistério no Caribe";
                ListLivros.Items.Add("Mistério no Caribe");
                ListGeneros.Items.Add("Suspense");
            }
            else
            {
                ChkMisterio.ForeColor = Color.Black;
                PicSuspense3.Image = Properties.Resources.Suspense;
                ChkMisterio.Text = "Livro 3";
                ListLivros.Items.Remove("Mistério no Caribe");
                ListGeneros.Items.Remove("Suspense");
            }
        }

        private void ChkFortaleza_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkFortaleza.Checked == true)
            {
                ChkFortaleza.ForeColor = Color.Blue;
                PicSuspense4.Image = Properties.Resources.Fortaleza_Digital;
                ChkFortaleza.Text = "Fortaleza Digital";
                ListLivros.Items.Add("Fortaleza Digital");
                ListGeneros.Items.Add("Suspense");
            }
            else
            {
                ChkFortaleza.ForeColor = Color.Black;
                PicSuspense4.Image = Properties.Resources.Suspense;
                ChkFortaleza.Text = "Livro 4";
                ListLivros.Items.Remove("Fortaleza Digital");
                ListGeneros.Items.Remove("Suspense");
            }
        }

        private void ChkFiccao1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkFiccao1.Checked == true)
            {
                ChkFiccao1.ForeColor = Color.Blue;
                PicFiccao1.Image = Properties.Resources.Walking_Dead;
                ChkFiccao1.Text = "The Walkind Dead";
                ListLivros.Items.Add("The Walkind Dead");
                ListGeneros.Items.Add("Ficção");
            }
            else
            {
                ChkFiccao1.ForeColor = Color.Black;
                PicFiccao1.Image = Properties.Resources.Ficção;
                ChkFiccao1.Text = "Livro 1";
                ListLivros.Items.Remove("The Walkind Dead");
                ListGeneros.Items.Remove("Ficção");
            }
        }

        private void ChkFiccao2_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkFiccao2.Checked == true)
            {
                ChkFiccao2.ForeColor = Color.Blue;
                PicFiccao2.Image = Properties.Resources.Star_Trek;
                ChkFiccao2.Text = "Star trek";
                ListLivros.Items.Add("Star Trek");
                ListGeneros.Items.Add("Ficção");
            }
            else
            {
                ChkFiccao2.ForeColor = Color.Black;
                PicFiccao2.Image = Properties.Resources.Ficção;
                ChkFiccao2.Text = "Livro 2";
                ListLivros.Items.Remove("Star Trek");
                ListGeneros.Items.Remove("Ficção");
            }
        }

        private void ChkFiccao3_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkFiccao3.Checked == true)
            {
                ChkFiccao3.ForeColor = Color.Blue;
                PicFiccao3.Image = Properties.Resources.Predador;
                ChkFiccao3.Text = "Predador";
                ListLivros.Items.Add("Predador");
                ListGeneros.Items.Add("Ficção");
            }
            else
            {
                ChkFiccao3.ForeColor = Color.Black;
                PicFiccao3.Image = Properties.Resources.Ficção;
                ChkFiccao3.Text = "Livro 3";
                ListLivros.Items.Remove("Predador");
                ListGeneros.Items.Remove("Ficção");
            }
        }

        private void ChkFiccao4_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkFiccao4.Checked == true)
            {
                ChkFiccao4.ForeColor = Color.Blue;
                PicFiccao4.Image = Properties.Resources.God_Of_War;
                ChkFiccao4.Text = "God Of War";
                ListLivros.Items.Add("God Of War");
                ListGeneros.Items.Add("Ficção");
            }
            else
            {
                ChkFiccao4.ForeColor = Color.Black;
                PicFiccao4.Image = Properties.Resources.Ficção;
                ChkFiccao4.Text = "Livro 4";
                ListLivros.Items.Remove("God Of War");
                ListGeneros.Items.Remove("Ficção");
            }
        }

        private void ChkTerror1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTerror1.Checked == true)
            {
                ChkTerror1.ForeColor = Color.Blue;
                PicTerror1.Image = Properties.Resources.Sombras_na_Casa;
                ChkTerror1.Text = "Sombras na Casa";
                ListLivros.Items.Add("Sombras na Casa");
                ListGeneros.Items.Add("Terror");
            }
            else
            {
                ChkTerror1.ForeColor = Color.Black;
                PicTerror1.Image = Properties.Resources.Terror;
                ChkTerror1.Text = "Livro 1";
                ListLivros.Items.Remove("Sombras na Casa");
                ListGeneros.Items.Remove("Terror");
            }
        }

        private void ChkTerror2_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTerror2.Checked == true)
            {
                ChkTerror2.ForeColor = Color.Blue;
                PicTerror2.Image = Properties.Resources.A_Estrada_da_Noite;
                ChkTerror2.Text = "A Estrada da Noite";
                ListLivros.Items.Add("A Estrada da Noite");
                ListGeneros.Items.Add("Terror");
            }
            else
            {
                ChkTerror2.ForeColor = Color.Black;
                PicTerror2.Image = Properties.Resources.Terror;
                ChkTerror2.Text = "Livro 2";
                ListLivros.Items.Remove("A Estrada da Noite");
                ListGeneros.Items.Remove("Terror");
            }
        }

        private void ChkTerror3_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTerror3.Checked == true)
            {
                ChkTerror3.ForeColor = Color.Blue;
                PicTerror3.Image = Properties.Resources.Fim_do_Jogo;
                ChkTerror3.Text = "Fim do Jogo";
                ListLivros.Items.Add("Fim do Jogo");
                ListGeneros.Items.Add("Terror");
            }
            else
            {
                ChkTerror3.ForeColor = Color.Black;
                PicTerror3.Image = Properties.Resources.Terror;
                ChkTerror3.Text = "Livro 3";
                ListLivros.Items.Remove("Fim do Jogo");
                ListGeneros.Items.Remove("Terror");
            }
        }

        private void ChkTerror4_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTerror4.Checked == true)
            {
                ChkTerror4.ForeColor = Color.Blue;
                PicTerror4.Image = Properties.Resources.A_Passagem;
                ChkTerror4.Text = "A Passagem";
                ListLivros.Items.Add("A Passagem");
                ListGeneros.Items.Add("Terror");
            }
            else
            {
                ChkTerror4.ForeColor = Color.Black;
                PicTerror4.Image = Properties.Resources.Terror;
                ChkTerror4.Text = "Livro 4";
                ListLivros.Items.Remove("A Passagem");
                ListGeneros.Items.Remove("Terror");
            }
        }

        private void ChkRomance1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkRomance1.Checked == true)
            {
                ChkRomance1.ForeColor = Color.Blue;
                PicRomance1.Image = Properties.Resources.Para_Sempre;
                ChkRomance1.Text = "Para Sempre";
                ListLivros.Items.Add("Para Sempre");
                ListGeneros.Items.Add("Romance");
            }
            else
            {
                ChkRomance1.ForeColor = Color.Black;
                PicRomance1.Image = Properties.Resources.Romance;
                ChkRomance1.Text = "Livro 1";
                ListLivros.Items.Remove("Para Sempre");
                ListGeneros.Items.Remove("Romance");
            }
        }

        private void ChkRomance2_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkRomance2.Checked == true)
            {
                ChkRomance2.ForeColor = Color.Blue;
                PicRomance2.Image = Properties.Resources.Um_Dia;
                ChkRomance2.Text = "Um dia";
                ListLivros.Items.Add("Um dia");
                ListGeneros.Items.Add("Romance");
            }
            else
            {
                ChkRomance2.ForeColor = Color.Black;
                PicRomance2.Image = Properties.Resources.Romance;
                ChkRomance2.Text = "Livro 2";
                ListLivros.Items.Remove("Um dia");
                ListGeneros.Items.Remove("Romance");
            }
        }

        private void ChkRomance3_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkRomance3.Checked == true)
            {
                ChkRomance3.ForeColor = Color.Blue;
                PicRomance3.Image = Properties.Resources.Destinados;
                ChkRomance3.Text = "Destinados";
                ListLivros.Items.Add("Destinados");
                ListGeneros.Items.Add("Romance");
            }
            else
            {
                ChkRomance3.ForeColor = Color.Black;
                PicRomance3.Image = Properties.Resources.Romance;
                ChkRomance3.Text = "Livro 3";
                ListLivros.Items.Remove("Destinados");
                ListGeneros.Items.Remove("Romance");
            }
        }

        private void ChkRomance4_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkRomance4.Checked == true)
            {
                ChkRomance4.ForeColor = Color.Blue;
                PicRomance4.Image = Properties.Resources.Querido_John;
                ChkRomance4.Text = "Querido John";
                ListLivros.Items.Add("Querido John");
                ListGeneros.Items.Add("Romance");
            }
            else
            {
                ChkRomance4.ForeColor = Color.Black;
                PicRomance4.Image = Properties.Resources.Romance;
                ChkRomance4.Text = "Livro 4";
                ListLivros.Items.Remove("Querido John");
                ListGeneros.Items.Remove("Romance");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
