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
    public class DAOFaCpiun
    {
        public List<TOFaCpiun>GetFaCpiun(int emp_codi,int fac_cont)
        {
            OTOContext cont = new OTOContext();
            var conn = DBFactory.GetDB(cont);
            StringBuilder sql = new StringBuilder();
            sql.AppendLine(" SELECT * FROM FA_CPIUN WHERE FAC_ORIG = @FAC_ORIG ");
            List<Parameter> parameters = new List<Parameter>()
                {
                    new Parameter("EMP_CODI", emp_codi),
                      new Parameter("FAC_ORIG", fac_cont),
                };
            var retorno = conn.ReadList(cont, sql.ToString(), Make, parameters.ToArray());
            return retorno;

        }

        private static Func<IDataReader, TOFaCpiun> Make = reader => new TOFaCpiun
        {
            fac_dest =  reader["FAC_DEST"].AsInt(),
            fac_orig = reader["FAC_ORIG"].AsInt(),


        };
    }
}