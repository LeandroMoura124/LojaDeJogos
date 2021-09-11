using LojaDeJogos.Repositório;
using MySql.Data.MySqlClient;
using LojaDeJogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaDeJogos.Repositório
{
    public class Ações
    {
        Conexão con = new Conexão();
        MySqlCommand cmd = new MySqlCommand();


        public void CadastrarFuncionario(Funcionario func)
        {
            string data_sistema = Convert.ToDateTime(func.FuncDtNasc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into Funcionario values(@IDfunc, @nomeFunc, @cpf, @rg, @nascimento, @endereco, @cel, @email, @cargo)", con.ConectarBD());
            cmd.Parameters.Add("@IDfunc", MySqlDbType.VarChar).Value = func.FuncCod;
            cmd.Parameters.Add("@nomeFunc", MySqlDbType.VarChar).Value = func.FuncNome;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = func.FuncCPF;
            cmd.Parameters.Add("@rg", MySqlDbType.VarChar).Value = func.FuncRg;
            cmd.Parameters.Add("@nascimento", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = func.FuncEnd;
            cmd.Parameters.Add("@cel", MySqlDbType.VarChar).Value = func.FuncCel;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = func.FuncEmail;
            cmd.Parameters.Add("@cargo", MySqlDbType.VarChar).Value = func.FuncCargo;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }
        public List<Funcionario> ListarFuncionario()//Criando Um metodo para listar os funcionarios
        {
            MySqlCommand cmd = new MySqlCommand("select * from funcionario", con.ConectarBD());
            var DadosFuncionario = cmd.ExecuteReader();
            return ListarTodosFuncionario(DadosFuncionario);
        }

        public List<Funcionario> ListarTodosFuncionario(MySqlDataReader dt)
        {
            var TodosFuncionarios = new List<Funcionario>();
            while (dt.Read())
            {
                var FuncionarioTemp = new Funcionario()
                {
                    FuncCod = ushort.Parse(dt["IDfunc"].ToString()),
                    FuncNome = dt["nomeFunc"].ToString(),
                    FuncCPF = dt["cpf"].ToString(),
                    FuncRg = dt["rg"].ToString(),
                    FuncDtNasc = DateTime.Parse(dt["nascimento"].ToString()),
                    FuncEnd = dt["endereco"].ToString(),
                    FuncCel = dt["cel"].ToString(),
                    FuncEmail = dt["email"].ToString(),
                    FuncCargo = dt["cargo"].ToString()
                   
                };
                TodosFuncionarios.Add(FuncionarioTemp);
            }
            dt.Close();
            return TodosFuncionarios;
        }


















        public void CadastrarJogos(Jogo jogo)
        {
            //string data_sistema = Convert.ToDateTime(jogo.JogoAnoLanc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into jogos values(@IDjogos, @nomeJogo, @versao, @desenvolvedor, @genero, @faixaet, @plataforma, @AnoLanc, @sinopse)", con.ConectarBD());
            cmd.Parameters.Add("@IDjogos", MySqlDbType.VarChar).Value = jogo.JogoCod;
            cmd.Parameters.Add("@nomeJogo", MySqlDbType.VarChar).Value = jogo.JogoNome;
            cmd.Parameters.Add("@versao", MySqlDbType.VarChar).Value = jogo.JogoVersao;
            cmd.Parameters.Add("@desenvolvedor", MySqlDbType.VarChar).Value = jogo.JogoDesenv;
            cmd.Parameters.Add("@genero", MySqlDbType.VarChar).Value = jogo.JogoGen;
            cmd.Parameters.Add("@faixaet", MySqlDbType.VarChar).Value = jogo.JogoFaixaEt;
            cmd.Parameters.Add("@plataforma", MySqlDbType.VarChar).Value = jogo.JogoPlat;
            cmd.Parameters.Add("@AnoLanc", MySqlDbType.Int32).Value = jogo.JogoAnoLanc;
            cmd.Parameters.Add("@sinopse", MySqlDbType.VarChar).Value = jogo.JogoSinopse;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }
        public List<Jogo> ListarJogo()//Criando Um metodo para listar os funcionarios
        {
            MySqlCommand cmd = new MySqlCommand("select * from jogos", con.ConectarBD());
            var DadosJogo = cmd.ExecuteReader();
            return ListarTodosJogo(DadosJogo);
        }

        public List<Jogo> ListarTodosJogo(MySqlDataReader dt)
        {
            var TodosJogo = new List<Jogo>();
            while (dt.Read())
            {
                var JogoTemp = new Jogo()
                {
                    JogoCod = ushort.Parse(dt["IDjogos"].ToString()),
                    JogoNome = dt["nomeJogo"].ToString(),
                    JogoVersao = Int32.Parse(dt["versao"].ToString()),
                    JogoDesenv = dt["desenvolvedor"].ToString(),
                    JogoGen = dt["genero"].ToString(),
                    JogoFaixaEt = Int32.Parse(dt["faixaet"].ToString()),
                    JogoPlat = dt["plataforma"].ToString(),
                    JogoAnoLanc = Int32.Parse(dt["AnoLanc"].ToString()),
                    JogoSinopse = dt["sinopse"].ToString()

                };
                TodosJogo.Add(JogoTemp);
            }
            dt.Close();
            return TodosJogo;
        }



































        public void CadastrarClientes(Cliente cliente)
        {
            string data_sistema = Convert.ToDateTime(cliente.ClieDtNasc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into cliente values(@nomeCliente, @cpf, @nascimento, @email, @cel, @enderecocli)", con.ConectarBD());
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cliente.ClienteCPF;
            cmd.Parameters.Add("@nomeCliente", MySqlDbType.VarChar).Value = cliente.ClienteNome;
            cmd.Parameters.Add("@nascimento", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = cliente.ClienteEmail;
            cmd.Parameters.Add("@cel", MySqlDbType.VarChar).Value = cliente.ClienteCel;
            cmd.Parameters.Add("@enderecocli", MySqlDbType.VarChar).Value = cliente.ClienteEnd;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }
        public List<Cliente> ListarCliente()//Criando Um metodo para listar os funcionarios
        {
            MySqlCommand cmd = new MySqlCommand("select * from cliente", con.ConectarBD());
            var DadosCliente = cmd.ExecuteReader();
            return ListarTodosCliente(DadosCliente);
        }

        public List<Cliente> ListarTodosCliente(MySqlDataReader dt)
        {
            var TodosCliente = new List<Cliente>();
            while (dt.Read())
            {
                var ClienteTemp = new Cliente()
                {
                    ClienteCPF = dt["cpf"].ToString(),
                    ClienteNome = dt["nomeCliente"].ToString(),
                    ClieDtNasc = DateTime.Parse(dt["nascimento"].ToString()),
                    ClienteEmail = dt["email"].ToString(),
                    ClienteCel =   dt["cel"].ToString(),
                    ClienteEnd = dt["enderecocli"].ToString()
                
                };
                TodosCliente.Add(ClienteTemp);
            }
            dt.Close();
            return TodosCliente;
        }



        /*public void DeletarFuncionario(int dlt)
          {
              var comando = String.Format("delete from funcionario where funcCod = {0}", dlt);
              MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
              cmd.ExecuteReader();
          }*/


    }
}