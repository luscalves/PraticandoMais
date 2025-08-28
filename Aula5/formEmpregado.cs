using ReaLTaiizor.Forms;

namespace Aula5
{
    public partial class formEmpregado : MaterialForm
    {

        Empregado c = new Empregado();
        public formEmpregado()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            c.nome = txtNome.Text;
            c.idade = Convert.ToInt32(txtIdade.Text);

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            lblNome.Text = "nome: " + c.nome;
            lblIdade.Text ="idade: " +  c.idade.ToString();
        }

    }
}
