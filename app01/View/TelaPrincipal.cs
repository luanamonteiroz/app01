using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app01.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void lbl_Mensagem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
           String nome = txb_Nome.Text;
           String fone = txb_Telefone.Text;

            lbl_Mensagem.Text = "\n Nome da Pessoa: " + nome +  "\n Telefone da Pessoa: " + fone;

            
            
        }
    }
}
