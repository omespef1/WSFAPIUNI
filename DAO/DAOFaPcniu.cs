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
    public class DAOFaPcniu
    {
        public TOFaPcniu GetFaPcniu(int emp_codi,string pcn_codi)
        {
            try
            {                
                List<Parameter> parameters = new List<Parameter>()
                {
                    new Parameter("@EMP_CODI", emp_codi),
                    new Parameter("@PCN_CODI", pcn_codi),
                };
                OTOContext cont = new OTOContext();
                var conn = DBFactory.GetDB(cont);
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM FA_PCNIU WHERE EMP_CODI = @EMP_CODI AND PCN_CODI = @PCN_CODI ");
                return conn.Read(cont, sql.ToString(), Make, parameters.ToArray());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private static Func<IDataReader, TOFaPcniu> Make = reader => new TOFaPcniu
        {
            emp_codi=reader["emp_codi"].AsInt(),
            pcn_cont=reader["pcn_cont"].AsInt(),
         //   act_cont=reader["act_cont"].AsInt(),
            pcn_obse=reader["pcn_obse"].AsString(),
            top_code=reader["top_code"].AsInt(),
            pro_cdep=reader["pro_cdep"].AsInt(),
            pro_cdes=reader["pro_cdes"].AsInt(),
            dsp_cdep=reader["dsp_cdep"].AsString(),
            dsp_cdes=reader["dsp_cdes"].AsString(),
            arb_area=reader["arb_area"].AsInt(),
            arb_sucu=reader["arb_sucu"].AsInt(),
            arb_ceco=reader["arb_ceco"].AsInt(),
            arb_proy=reader["arb_proy"].AsInt(),
            bod_codi=reader["bod_codi"].AsString(),
            bod_cont=reader["bod_cont"].AsInt(),
            cas_cont=reader["cas_cont"].AsInt(),


        };
    }
}