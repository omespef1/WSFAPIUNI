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
    public class DAOGnParam
    {
        public TOGnParam GetGnParam(int emp_codi)
        {
            OTOContext cont = new OTOContext();
            var conn = DBFactory.GetDB(cont);
            StringBuilder sql = new StringBuilder();
            sql.AppendLine(" SELECT * FROM GN_PARAM WHERE EMP_CODI = @EMP_CODI ");
            List<Parameter> parameters = new List<Parameter>()
                {
                    new Parameter("EMP_CODI", emp_codi),                     
                };
            var retorno = conn.Read(cont, sql.ToString(), Make, parameters.ToArray());
            return retorno;
        }
        private static Func<IDataReader, TOGnParam> Make = reader => new TOGnParam
        {
           mon_codi = reader["MON_CODI"].AsInt()

        };
    }
}
