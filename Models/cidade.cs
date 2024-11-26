using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace _231479_231464.Models
{
    public class cidade
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }
    }
    public void Incluir()
    {
        try
        {
            banco.AbrirConexao();
            banco.Comando = new MySqlCommand("INSERT INTO cidades (nome, uf) VALUES (@nome, @uf)", banco.Conexao);
            banco.Comando.Parameters.AddWithValue("@nome", nome);
            String banco.Comando.Parameters.AddWithValue("@uf", uf);
            Banco.Comando.ExecuteNonQuery();
            
            .FecharConexao();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
