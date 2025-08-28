using ReaLTaiizor.Forms;
namespace Aula5
{
    public partial class FrmPrincipal : MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEmpregado formDestino = new formEmpregado();
            formDestino.ShowDialog();
        }
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTerceiro formDestino = new FrmTerceiro();
            formDestino.ShowDialog();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
