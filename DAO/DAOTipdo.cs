using Ophelia;
using Ophelia.Comun;
using Ophelia.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using WSFAPIUNI.TO;
namespace WSFAPIUNI.DAO
{
    public class DAOTipdo
    {
        public TOGnTipdo GetGnTipdo(string tip_abre )
        {
           
                try
                {
                List<Parameter> parameters = new List<Parameter>();
                parameters.Add(new Parameter("@TIP", tip_abre.ToUpper()));
                    
                    OTOContext cont = new OTOContext();
                    var conn = DBFactory.GetDB(cont);
                    StringBuilder sql = new StringBuilder();
                   string query = string.Format(" SELECT TIP_CODI FROM GN_TIPDO WHERE TIP_ABRE = '{0}' ", tip_abre);                   
                    return conn.Read(cont, query.ToString(), Make);
                }
           
                //List<Parameter> listAux = new List<Parameter>();
                //StringBuilder sql = new StringBuilder();
                //sql.Append("  SELECT  TIP_CODI FROM GN_TIPDO WHERE TIP_ABRE=@TIP_ABRE  ");              
                //listAux.Add(new Parameter("@TIP_ABRE", tip_abre));               
                //Parameter[] oParameter = listAux.ToArray();
                //OTOContext pTOContext = new OTOContext();
                //var conection = DBFactory.GetDB(pTOContext);
                //var objeto = conection.GetScalar(pTOContext, sql.ToString(), oParameter);
                //return objeto;


            
            catch(Exception ex)
            {
                return null;
            }
           
        }
        private static Func<IDataReader, TOGnTipdo> Make = reader => new TOGnTipdo
        {
            tip_codi = reader["TIP_CODI"].AsInt()

        };
    }
}