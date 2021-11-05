using SevenFramework.DataBase;
using SevenFramework.DataBase.Utils;
using SevenFramework.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WSFAPIUNI.TO;
namespace WSFAPIUNI.DAO
{
    public class DAOInProdu
    {
        public IN_PRODU ConsultarInProdu(short emp_codi, int pro_cont)
        {
            try
            {
                List<SQLParams> sqlPrms = new List<SQLParams>()
                {
                    new SQLParams("EMP_CODI", emp_codi),
                    new SQLParams("PRO_CONT", pro_cont)
                };
                string sql = DBHelper.SelectQueryString<IN_PRODU>(sqlPrms);
                return new DbConnection().Get<IN_PRODU>(sql.ToString(), sqlPrms);
            }
            catch (Exception ex)
            {
                ExceptionManager.Throw(this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
                return null;
            }
        }
    }
}