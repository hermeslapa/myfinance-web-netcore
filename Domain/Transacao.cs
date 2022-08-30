using myfinance_web_netcore.Models;
using myfinance_web_netcore.Infra;

namespace myfinance_web_netcore.Domain
{
    public class Transacao
    {
            public List<TransacaoModel> ListaTransacoes()
        {
            List<TransacaoModel> lista = new List<TransacaoModel>();
            
            var objDAL = DAL.GetInstancia;
            objDAL.Conectar();
            
            var sql = "SELECT ID,DATA,VALOR,TIPO,HISTORICO,ID_PLANO_CONTA FROM TRANSACAO";
            var dataTable = objDAL.RetornaDataTable(sql);
            
            for(int i = 0;i< dataTable.Rows.Count; i++)
            {
                var transacao = new TransacaoModel(){
                    Id = int.Parse(dataTable.Rows[i]["ID"].ToString()),
                    Data = DateTime.Parse(dataTable.Rows[i]["DATA"].ToString()),
                    Valor = decimal.Parse(dataTable.Rows[i]["VALOR"].ToString()),
                    Tipo = dataTable.Rows[i]["TIPO"].ToString(),
                    Historico = dataTable.Rows[i]["HISTORICO"].ToString(),
                    idPlanoConta = int.Parse(dataTable.Rows[i]["ID_PLANO_CONTA"].ToString())
                };
                lista.Add(transacao);

            }
            objDAL.Desconectar();
            return lista;
             
        }  
    }
}