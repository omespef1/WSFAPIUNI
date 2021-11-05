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
    public class DAOFaFactu
    {
        public List<TOFaFactu> GetDocFaFactu(int emp_codi , string fac_ndoc)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * FROM FA_FACTU WHERE EMP_CODI = @EMP_CODI AND FAC_NDOC =@FAC_NDOC ORDER BY FAC_CONT ASC ");
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@EMP_CODI", emp_codi));
            parameters.Add(new Parameter("@FAC_NDOC", fac_ndoc));
            OTOContext pTOContext = new OTOContext();
            var conection = DBFactory.GetDB(pTOContext);
            var data = conection.ReadList(pTOContext, sql.ToString(), Make,parameters.ToArray());

            return data;
        }

       

        public int updateFaFactu(int emp_codi,int fac_cont, string fac_ndoc)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" UPDATE FA_FACTU SET FAC_NDOC = @FAC_NDOC WHERE EMP_CODI = @EMP_CODI AND FAC_CONT =@FAC_CONT ");
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@EMP_CODI", emp_codi));
            parameters.Add(new Parameter("@FAC_NDOC", fac_ndoc));
            parameters.Add(new Parameter("@FAC_CONT", fac_cont));
            OTOContext pTOContext = new OTOContext();
            var conection = DBFactory.GetDB(pTOContext);
            var data = conection.Update(pTOContext, sql.ToString(), parameters.ToArray());

            return data;
        }
        private static Func<IDataReader, TOFaFactu> Make = reader => new TOFaFactu
        {
            fac_cont = reader["FAC_CONT"].AsInt(),
            fac_tipo = reader["FAC_TIPO"].AsString(),
            fac_ndoc = reader["FAC_NDOC"].AsString(),
            fac_esta = reader["FAC_ESTA"].AsString(),
            fac_vato = reader["FAC_VATO"].AsDouble()


        };

    }
}