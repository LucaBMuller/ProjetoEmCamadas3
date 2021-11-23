using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace _3A1LUCA28
{
    class Informacoes
    {
        public int id, visualizacoes, curtidas;

        Conexao obj = new Conexao();

        public void Cadastrar()
        {

            string inserir = $@"insert into usuario_publicacao values ('{id}', '{visualizacoes}', '{curtidas}');";
            obj.ExecutarComando(inserir);

        }

        public DataTable Listar()     //Requer: using System.Data;
        {
            string listar = $"SELECT * FROM usuario_publicacao; ";
            return obj.ExecutarConsulta(listar);
        }
        public void Excluir()
        {
            string deletar = $"DELETE FROM usuario_publicacao WHERE `usuario_publicacao`.`id` = '{id}'; ";
            obj.ExecutarComando(deletar);
        }

        public void Alterar()
        {
            string alterar = $"UPDATE usuario_publicacao SET visualizacoes = '{visualizacoes}', curtidas = '{curtidas}' WHERE `usuario_publicacao`.`id` = '{id}'";
            obj.ExecutarComando(alterar);
        }
    }
}
