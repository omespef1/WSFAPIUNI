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
    public class DAOFaClien
    {
        public TOFaClien getFaClien(int emp_codi, string cli_coda)
        {
            try
            {
                List<Parameter> parameters = new List<Parameter>()
                {
                    new Parameter("@EMP_CODI", emp_codi),
                    new Parameter("@CLI_CODA", cli_coda)
                };
                OTOContext cont = new OTOContext();
                var conn = DBFactory.GetDB(cont);
                StringBuilder sql = new StringBuilder();
                sql.AppendLine(" SELECT CLI_CODA FROM FA_CLIEN WHERE EMP_CODI = @EMP_CODI AND CLI_CODA = @CLI_CODA  ");               
                return conn.Read(cont, sql.ToString(), Make, parameters.ToArray());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int updateFaclien(int emp_codi, long cli_codi)
        {
            try
            {
                List<Parameter> parameters = new List<Parameter>()
                {
                    new Parameter("EMP_CODI", emp_codi),
                    new Parameter("CLI_CODI", cli_codi)
                };
                OTOContext cont = new OTOContext();
                var conn = DBFactory.GetDB(cont);
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("  UPDATE FA_CLIEN SET TER_CODE = 0 WHERE EMP_CODI=@EMP_CODI AND CLI_CODI = @CLI_CODI ");
                var retorno = conn.Update(cont, sql.ToString(), parameters.ToArray());
                return retorno;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        private static Func<IDataReader, TOFaClien> Make = reader => new TOFaClien
        {
            cli_coda = reader["CLI_CODA"].AsString()
           
        };
    }
}