using Ophelia;
using Ophelia.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WSFAPIUNI.DAO
{
    public class DAOGnArbol
    {
        public string GetArbCodi(int emp_codi, int tar_codi,int arb_cont)
        {
            OTOContext cont = new OTOContext();
            var conn = DBFactory.GetDB(cont);
            StringBuilder sql = new StringBuilder();
            sql.AppendLine(" SELECT ARB_CODI FROM GN_ARBOL WHERE TAR_CODI = @TAR_CODI AND EMP_CODI = @EMP_CODI AND ARB_CONT = @ARB_CONT");
            List<Parameter> parameters = new List<Parameter>()
                {
                    new Parameter("EMP_CODI", emp_codi),
                    new Parameter("ARB_CONT",arb_cont),
                    new Parameter("TAR_CODI",tar_codi)
                };
            var retorno = conn.GetScalar(cont, sql.ToString(), parameters.ToArray());
            if (retorno == null)
                return "";
            return retorno.ToString();
            
        }
        public string GetArbCodiAnt(int emp_codi, int tar_codi, string arb_coan)
        {
            try
            {
                OTOContext cont = new OTOContext();
                var conn = DBFactory.GetDB(cont);
                StringBuilder sql = new StringBuilder();
                sql.AppendLine(" SELECT ARB_CODI FROM GN_ARBOL WHERE TAR_CODI = @TAR_CODI AND EMP_CODI = @EMP_CODI AND ARB_COAN = @ARB_COAN ");
                List<Parameter> parameters = new List<Parameter>()
                {
                    new Parameter("EMP_CODI", emp_codi),
                    new Parameter("ARB_COAN",arb_coan),
                    new Parameter("TAR_CODI",tar_codi)
                };
                var retorno = conn.GetScalar(cont, sql.ToString(), parameters.ToArray());
                if (retorno == null)
                    return "";
                return retorno.ToString();
            }
            catch(Exception ex)
            {
                return null;
            }
          

        }
    }
}