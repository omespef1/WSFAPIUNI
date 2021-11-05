using SevenFramework.DataBase;
using SevenFramework.DataBase.Utils;
using SevenFramework.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using WSFAPIUNI.TO;

namespace WSFAPIUNI.DAO
{
    public class DAOCaCxcob
    {
        public List<CA_CXCOB> GetCaCxcob(int emp_codi, int fac_cont)
        {
           
                List<SQLParams> sqlPrms = new List<SQLParams>()
                {
                    new SQLParams("EMP_CODI", emp_codi),
                    new SQLParams("FAC_CONT", fac_cont)
                };
                string sql = DBHelper.SelectQueryString<CA_CXCOB>(sqlPrms);
                return new DbConnection().GetList<CA_CXCOB>(sql.ToString(), sqlPrms);
          
           
        }
        public CA_CXCOB GetCaCxCobPago(int emp_codi, int fac_cont)
        {

            List<SQLParams> sqlPrms = new List<SQLParams>()
                {
                    new SQLParams("EMP_CODI", emp_codi),
                    new SQLParams("FAC_CONT", fac_cont)
                };
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT SUM(CXC_PAGO) CXC_SALD , SUM(CXC_TOTA) CXC_TOTA FROM CA_CXCOB ");
            sql.Append(" WHERE EMP_CODI=@EMP_CODI  AND FAC_CONT = @FAC_CONT ");
            return new DbConnection().Get<CA_CXCOB>(sql.ToString(), sqlPrms);


        }

        /// <summary>
        /// Método opcional para consultar los saldos pendientes de una factua, este método es para la nueva configuración
        /// </summary>
        /// <param name="emp_codi"></param>
        /// <param name="fac_cont"></param>
        /// <returns></returns>
        public CA_CXCOB GetCaCxCobPagoOPC(int emp_codi, int fac_cont)
        {

            List<SQLParams> sqlPrms = new List<SQLParams>()
                {
                    new SQLParams("EMP_CODI", emp_codi),
                    new SQLParams("FAC_CONT", fac_cont)
                };
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT SUM(CXC_SALD) CXC_SALD , SUM(CXC_TOTA) CXC_TOTA FROM CA_CXCOB ");
            sql.Append(" WHERE EMP_CODI=@EMP_CODI  AND FAC_CONT = @FAC_CONT  AND CXC_ESTA='A'");
            return new DbConnection().Get<CA_CXCOB>(sql.ToString(), sqlPrms);


        }

        public List<CA_CXCOB> GetCaCxcob(int emp_codi, int fac_cont, string cxc_cref)
        {
          
            StringBuilder sql = new StringBuilder();
              sql.Append("  SELECT *                            ");
              sql.Append("  FROM   FA_FACTU fa                  ");
              sql.Append("  INNER JOIN CA_CXCOB CC              ");
              sql.Append("  ON FA.EMP_CODI = CC.EMP_CODI        ");
              sql.Append("  AND FA.FAC_CONT = CC.FAC_CONT       ");
              sql.Append("  WHERE CC.CXC_ESTA = 'A'             ");
              sql.Append("  AND fa.FAC_ESTA = 'A'               ");
              sql.Append("  AND CC.FAC_CONT = @FAC_CONT                ");
            sql.Append("  AND CC.CXC_CREF = @CXC_CREF              ");
            sql.Append("  AND CC.EMP_CODI = @EMP_CODI              ");
            List<SQLParams> sQLParams = new List<SQLParams>();
            sQLParams.Add(new SQLParams("EMP_CODI", emp_codi));
            sQLParams.Add(new SQLParams("FAC_CONT", fac_cont));
            sQLParams.Add(new SQLParams("CXC_CREF", cxc_cref));
            return new DbConnection().GetList<CA_CXCOB>(sql.ToString(), sQLParams);
        }

    }
}