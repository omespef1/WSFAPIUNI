using Ophelia;
using Ophelia.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using Ophelia.Comun;
using WSFAPIUNI.TO;
namespace WSFAPIUNI.DAO
{
    public class DAOGnFlag
    {
        public ToGnFlag GetGnFlag(string dig_codi,int emp_codi)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * FROM GN_DIGFL  WHERE DIG_CODI=@DIG_CODI and EMP_CODI =@EMP_CODI  ");
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@DIG_CODI", dig_codi));
            parameters.Add(new Parameter("@EMP_CODI", emp_codi));
            OTOContext pTOContext = new OTOContext();
            var conection = DBFactory.GetDB(pTOContext);
            var data = conection.Read(pTOContext, sql.ToString(), Make, parameters.ToArray());
            return data;
        }
        public Func<IDataReader, ToGnFlag> Make = reader => new ToGnFlag
        {
            dig_codi = reader["DIG_CODI"].AsString(),
            dig_nomb = reader["DIG_NOMB"].AsString(),
            dig_valo = reader["DIG_VALO"].AsString()
        };
    }
}