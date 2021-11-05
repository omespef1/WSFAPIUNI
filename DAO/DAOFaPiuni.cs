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
    public class DAOFaPiuni
    {
        public TOFaPiuni getFaPiuni(int emp_codi)
        {
            try
            {
                List<Parameter> parameters = new List<Parameter>()
                {
                    new Parameter("EMP_CODI", emp_codi),                   
                };
                OTOContext cont = new OTOContext();
                var conn = DBFactory.GetDB(cont);
                StringBuilder sql = new StringBuilder();
                sql.AppendLine(" SELECT * FROM FA_PIUNI  WHERE EMP_CODI= @EMP_CODI  ");
                return conn.Read(cont, sql.ToString(), Make, parameters.ToArray());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private static Func<IDataReader, TOFaPiuni> Make = reader => new TOFaPiuni
        {
            tcl_codi =reader["tcl_codi"].AsInt(),
            arb_conc= reader["arb_conc"].AsInt(),
            act_cont= reader["act_cont"].AsInt(),
            cal_codi= reader["cal_codi"].AsInt(),
            coc_codi= reader["coc_codi"].AsInt(),
            cim_codi= reader["cim_codi"].AsInt(),
            arb_sucu= reader["arb_sucu"].AsInt(),
            arb_corp= reader["arb_corp"].AsInt(),
            ven_codi= reader["ven_codi"].AsInt(),
            lis_codi= reader["lis_codi"].AsInt(),
            cob_cont= reader["cob_cont"].AsInt(),
            ase_codi= reader["ase_codi"].AsInt(),
            ite_cobe= reader["ite_cobe"].AsInt(),
            rut_codi= reader["rut_codi"].AsInt(),
            pai_codi= reader["pai_codi"].AsInt(),
            reg_codi= reader["reg_codi"].AsInt(),
            dep_codi= reader["dep_codi"].AsInt(),
            mun_codi= reader["mun_codi"].AsInt(),
            arb_area= reader["arb_area"].AsInt(),
            arb_proy= reader["arb_proy"].AsInt(),


        };
    }
}