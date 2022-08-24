using System;
using myfinance_web_netcore.Infra;

namespace myfinance_web_netcore.Models
{
    public class PlanoContaModel
    {
        public int Id {get;set;}
        public string? Descricao {get;set;}
        public string? Tipo {get;set;}

        public List<PlanoContaModel> ListaPlanoContas(){
            List<PlanoContaModel> lista = new List<PlanoContaModel>();
            var objDAL.GetInstancia;
            objDAL.Conectar();
            var sql = "SELECT ID,DESCRICAO,TIPO FROM PLANO_CONTAS";
            var dataTable = objDAL.RetornaDataTable(sql);
            
            for(int i = 0;i< dataTable.Rows.Count; i++)
            {
                var planoConta = new PlanoContaModel(){
                    Id = int.Parse(dataTable.Rows[i]["ID"].ToString());
                    Descricao = dataTable.Rows[i]["DESCRICAO"].ToString();
                    Tipo = dataTable.Rows[i]["TIPO"].ToString();
                };
                lista.Add(planoConta);

            }
            return lista;
             
        }
    
    
    }
}