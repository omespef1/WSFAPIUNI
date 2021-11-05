using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSFAPIUNI.TO
{
    public class TOOutFaFactu
    {
        public int fac_cont { get; set; }
        public int fac_nume { get; set; }
        public int retorno { get; set; }
        public string arb_csuc { get; set; }
        public int top_codi { get; set; }
        public DateTime fac_fech { get; set; }
        public string txtError { get; set; }
    }
}