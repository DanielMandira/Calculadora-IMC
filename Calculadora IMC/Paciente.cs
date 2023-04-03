using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace Calculadora_IMC
{
    internal class Paciente : conexao
    {
        private int _idx;
        private string _nome;
        private string _altura;
        private string _peso;
        private string _data;
        private string _situacao;
        public string _imc;

        public void set_idx(int _idx)
        {
            this._idx= _idx;
        }
        public int get_idx() 
        { 
            return _idx;
        }

        public void set_nome(string _nome)
        {
            this._nome = _nome;
        }
        public string get_nome()
        {
            return _nome;
        }

        public void set_altura(string _altura)
        {
            this._altura = _altura;
        }
        public string get_altura()
        {
            return _altura;
        }

        public void set_peso(string _peso)
        {
            this._peso = _peso;
        }
        public string get_peso()
        {
            return _peso;
        }

        public void set_data(string _data)
        {
            this._data = _data;
        }
        public string get_data()
        {
            return _data;
        }

        public void set_situacao(string _situacao)
        {
            this._situacao = _situacao;
        }
        public string get_situacao()
        {
            return _situacao;
        }

        public void set_imc(string _imc)
        {
            this._imc = _imc;
        }
        public string get_imc()
        {
            return _imc;
        }
        public string convertData()
        {
            var dt = DateTime.Parse(get_data()).ToString("yyyy-MM-dd");
            return dt;
        }

        public string ConvertPeso()
        {
            string peso = get_peso();
            peso = peso.Replace(',', '.');
            return peso;
        }

        public string ConvertAltura()
        {
            string altura = get_altura();
            altura = altura.Replace(',', '.');
            return altura;
        }

        public string ConvertIMC()
        {
            string IMC = get_imc();
            IMC = IMC.Replace(',', '.');
            return IMC;
        }

        public void inserir()
        {
            string query = "INSERT INTO paciente (nome_paciente, altura_paciente, peso_paciente, situacao_paciente, imc_paciente, data_consulta) values ('" + get_nome() + "','" + ConvertAltura() + "','" + ConvertPeso() + "','" + get_situacao() + "','" + ConvertIMC() + "','" + convertData() + "' ) ";
            //verificar se conexao aberta
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }

        }

        public DataTable consultar()
        {
            this.abrirConexao();
            string mSLQ = "SELECT * FROM paciente";
            MySqlCommand cmd = new MySqlCommand(mSLQ, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharConexao();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void excluir()
        {
            string query = "DELETE FROM paciente WHERE id_paciente = '" + get_idx() + "'";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }

        public void atualizar()
        {
            string query = "UPDATE paciente SET nome_paciente ='" + get_nome() + "', altura_paciente = '" + ConvertAltura() + "', peso_paciente = '" + ConvertPeso() + "', situacao_paciente='" + get_situacao() + "', imc_paciente ='" + ConvertIMC() + "', data_consulta = '" + convertData() + "' WHERE id_paciente = '" + get_idx() + "'";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }

    }
}
