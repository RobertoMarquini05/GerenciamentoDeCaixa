using Caixa.View;

namespace Caixa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGestaoItens_Click(object sender, EventArgs e)
        {
            GestaoItens gestaoItens = new GestaoItens();
            gestaoItens.ShowDialog();
        }
    }
}
