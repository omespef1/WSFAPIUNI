using Ophelia;
using Ophelia.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WSFAPIUNI.DAO
{
    public class DAOAfActiv
    {
        public string GetActCodi(int emp_codi,int act_cont)
        {
            try
            {
              
                OTOContext cont = new OTOContext();
                var conn = DBFactory.GetDB(cont);
                StringBuilder sql = new StringBuilder();
                sql.AppendLine(" SELECT ACT_CODI FROM GN_ACTIV  WHERE EMP_CODI = @EMP_CODI AND ACT_CONT = @ACT_CONT ");
                List<Parameter> parameters = new List<Parameter>()
                {
                    new Parameter("EMP_CODI", emp_codi),
                     new Parameter("ACT_CONT", act_cont),
                };
                var retorno = conn.GetScalar(cont, sql.ToString(), parameters.ToArray()).ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}