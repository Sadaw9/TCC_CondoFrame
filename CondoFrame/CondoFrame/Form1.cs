using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondoFrame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Today.ToLongDateString();

            linkLabel1.Text = "Acesse o Gmail aqui";
            linkLabel1.Links.Add(0, 20, "https://myaccount.google.com/?utm_source=sign_in_no_continue");
        }

        private void cadastrarCondôminoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCondomino newfuncao1 = new frmCondomino();
            newfuncao1.ShowDialog();
        }

        private void cadastrarSindicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSindico newfuncao2 = new frmSindico();
            newfuncao2.ShowDialog();
        }

        private void cadastrarPorterioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPorteiro newfuncao3 = new frmPorteiro();
            newfuncao3.ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserva newfuncao4 = new frmReserva();
            newfuncao4.ShowDialog();
        }

        private void correspondênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCorrespondencia newfuncao5= new frmCorrespondencia();
            newfuncao5.ShowDialog();
        }

        private void reclamaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReclamacao newfuncao6 = new frmReclamacao();
            newfuncao6.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
