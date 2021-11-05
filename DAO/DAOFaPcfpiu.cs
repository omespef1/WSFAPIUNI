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
    public class DAOFaPcfiu
    {
        public TOFaPcfiu GetFaCfpiu(int emp_codi,string pcf_codi,string codigoEstudio)
        {
            try
            {
                List<Parameter> parameters = new List<Parameter>()
                {
                    new Parameter("@EMP_CODI", emp_codi),
                    new Parameter("@PCF_CODI",pcf_codi),
                    new Parameter("@PCF_COES",codigoEstudio)              
                };
                OTOContext cont = new OTOContext();
                var conn = DBFactory.GetDB(cont);
                StringBuilder sql = new StringBuilder();
                sql.AppendLine(" SELECT * FROM FA_PCFIU WHERE EMP_CODI = @EMP_CODI AND PCF_CODI =@PCF_CODI AND PCF_COES = @PCF_COES ");
                return conn.Read(cont, sql.ToString(), Make, parameters.ToArray());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private static Func<IDataReader, TOFaPcfiu> Make = reader => new TOFaPcfiu
        {
            pcf_cont=reader["pcf_cont"].AsInt(),
            pcf_codi=reader["pcf_codi"].AsString(),
            pcf_tiac=reader["pcf_tiac"].AsString(),
            pcf_obse=reader["pcf_obse"].AsString(),
            top_como=reader["top_como"].AsInt(),
            top_come=reader["top_come"].AsInt(),
            top_comt=reader["top_comt"].AsInt(),
            top_cose=reader["top_cose"].AsInt(),
            top_cois=reader["top_cois"].AsInt(),
            pro_cmop=reader["pro_cmop"].AsInt(),
            pro_cmos=reader["pro_cmos"].AsInt(),
            pro_cmep=reader["pro_cmep"].AsInt(),
            pro_cmes=reader["pro_cmes"].AsInt(),
            pro_cmtp=reader["pro_cmtp"].AsInt(),
            pro_cmts=reader["pro_cmts"].AsInt(),
            pro_csep=reader["pro_csep"].AsInt(),
            pro_cses=reader["pro_cses"].AsInt(),
            pro_cisp=reader["pro_cisp"].AsInt(),
            pro_ciss=reader["pro_ciss"].AsInt(),
            dsp_cmop=reader["dsp_cmop"].AsString(),
            dsp_cmos=reader["dsp_cmos"].AsString(),
            dsp_cmep=reader["dsp_cmep"].AsString(),
            dsp_cmes=reader["dsp_cmes"].AsString(),
            dsp_cmtp=reader["dsp_cmtp"].AsString(),
            dsp_cmts=reader["dsp_cmts"].AsString(),
            dsp_csep=reader["dsp_csep"].AsString(),
            dsp_cses=reader["dsp_cses"].AsString(),
            dsp_cisp=reader["dsp_cisp"].AsString(),
            dsp_ciss=reader["dsp_ciss"].AsString(),
            arb_area=reader["arb_area"].AsInt(),
            arb_sucu=reader["arb_sucu"].AsInt(),
            arb_ceco=reader["arb_ceco"].AsInt(),
            arb_proy=reader["arb_proy"].AsInt(),
            bod_codi=reader["bod_codi"].AsInt(),
            bod_cont=reader["bod_cont"].AsInt(),
            cas_cont=reader["cas_cont"].AsInt()


        };
    }
}