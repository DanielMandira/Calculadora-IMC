namespace Calculadora_IMC
{
    public partial class calcIMC : Form
    {
        public calcIMC()
        {
            InitializeComponent();
            
        }
        Class_CalculoIMC calc = new Class_CalculoIMC();
        Paciente pac = new Paciente();
        private void BTN_calcule_Click(object sender, EventArgs e)
        {
            calc.set_peso(Convert.ToDouble(TXT_peso.Text));
            calc.set_altura(Convert.ToDouble(TXT_altura.Text)); 
            LBL_Situação.Visible= true;
            LBL_Situação.Text = calc.sit();
            LBL_IMC.Visible= true;
            LBL_IMC.Text = calc.Calcular().ToString();
          
        }

        private void BTN_limpar_Click(object sender, EventArgs e)
        {
            TXT_peso.Clear();
            TXT_nome.Clear();
            TXT_altura.Clear();
            TXT_data.Clear();
            TXT_nome.Focus();
            LBL_Situação.Visible = false;
            LBL_IMC.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBL_dateTime.Text = DateTime.Now.ToString();
        }

        private void BTN_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                
                pac.set_nome(TXT_nome.Text);
                pac.set_altura(TXT_altura.Text);
                pac.set_data(TXT_data.Text);
                pac.set_situacao(calc.sit());
                pac.set_imc(calc.Calcular().ToString());
                pac.set_peso(TXT_peso.Text);
                pac.inserir();
                DGV_dados.DataSource = pac.consultar();

            }
            finally
            {
                TXT_peso.Clear();
                TXT_nome.Clear();
                TXT_altura.Clear();
                TXT_data.Clear();
                TXT_nome.Focus();
                LBL_Situação.Visible = false;
                LBL_IMC.Visible = false;

            }
        }

        private void BTN_Pesquisar_Click(object sender, EventArgs e)
        {
            DGV_dados.DataSource = pac.consultar();
            TXT_nome.Focus();
        }

        private void BTN_Atualizar_Click(object sender, EventArgs e)
        {
            try
            {

            pac.set_idx(Convert.ToInt32(LBL_idx.Text));
            pac.set_nome(TXT_nome.Text);
            pac.set_altura(TXT_altura.Text);
            pac.set_data(TXT_data.Text);
            pac.set_situacao(calc.sit());
            pac.set_imc(calc.Calcular().ToString());
            pac.set_peso(TXT_peso.Text);
            pac.atualizar();
            DGV_dados.DataSource = pac.consultar();
            }
            finally
            {
                TXT_peso.Clear();
                TXT_nome.Clear();
                TXT_altura.Clear();
                TXT_data.Clear();
                TXT_nome.Focus();
                LBL_Situação.Visible = false;
                LBL_IMC.Visible=false;
            }
        }

        private void DGV_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_dados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DGV_dados.CurrentRow.Selected = true;
                LBL_idx.Text = DGV_dados.Rows[e.RowIndex].Cells["id_paciente"].FormattedValue.ToString();
                TXT_nome.Text = DGV_dados.Rows[e.RowIndex].Cells["nome_paciente"].FormattedValue.ToString();
                TXT_altura.Text = DGV_dados.Rows[e.RowIndex].Cells["altura_paciente"].FormattedValue.ToString();
                TXT_peso.Text = DGV_dados.Rows[e.RowIndex].Cells["peso_paciente"].FormattedValue.ToString();
                LBL_Situação.Text = DGV_dados.Rows[e.RowIndex].Cells["situacao_paciente"].FormattedValue.ToString();
                LBL_IMC.Text = DGV_dados.Rows[e.RowIndex].Cells["imc_paciente"].FormattedValue.ToString();
                TXT_data.Text= DGV_dados.Rows[e.RowIndex].Cells["data_consulta"].FormattedValue.ToString();
                LBL_Situação.Visible = true;
                LBL_IMC.Visible = true;
            }
        }

        private void BTN_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                pac.set_idx(Convert.ToInt32(LBL_idx.Text));
                pac.excluir();
                DGV_dados.DataSource = pac.consultar();
            }
            finally
            {
                TXT_peso.Clear();
                TXT_nome.Clear();
                TXT_altura.Clear();
                TXT_data.Clear();
                TXT_nome.Focus();
                LBL_Situação.Visible = false;
                LBL_IMC.Visible = false;
            }
        }
    }
}