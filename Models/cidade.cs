using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using _231479_231464;
using System.Data.SqlClient;

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
            banco.Comando.ExecuteNonQuery();

            FecharConexao();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

    public void Alterar() {
        try {
            // Abre a conexão com o banco
            banco.AbrirConexao();
            // Alimenta o método Command com a instrução desejada e indica a conexão utilizada
            banco.Comando = new MySqlCommand("Update cidades set nome = @nome, uf = @uf where id = @id", banco.Conexao);
            // Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
            banco.Comando.Parameters.AddWithValue("@nome", nome); // Parâmtro String
            banco.Comando.Parameters.AddWithValue("@uf", uf);
            banco.Comando.Parameters.AddWithValue("@id", id);
            // Executa o Comando, no MYSQL, tem a função do Raio do Workbench
            banco.Comando.ExecuteNonQuery();
            // Fecha a conexão
            banco.FecharConexao();
        } catch (Exception e) { 
            MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

    public void Excluir() {
        try
        {
            // Abre a conexão com o banco
            banco.AbrirConexao();
            // Alimenta o método Command com a instrução desejada e indica a conexão utilizada
            banco.Comando = new MySqlCommand("delete from cidades where id = @id", banco.Conexao);
            // Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
            banco.Comando.Parameters.AddWithValue("@id", id);
            // Executa o Comando, no MYSQL, tem a função do Raio do Workbench
            banco.Comando.ExecuteNonQuery();
            // Fecha a conexão
            banco.FecharConexao();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public DataTable Consultar()
    {
        try
        {
            banco.AbrirConexao();
            banco.Comando = new MySqlCommand("SELECT * FROM Cidades where nome like @Nome " +
            "order by nome", banco.Conexao);
            banco.Comando.Parameters.AddWithValue("@Nome", nome + "%");
            banco.Adaptador = new MySqlDataAdapter(banco.Comando);
            banco.datTabela = new DataTable();
            banco.Adaptador.Fill(banco.datTabela);
            banco.FecharConexao();
            return banco.datTabela;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;


        }
    }

}




