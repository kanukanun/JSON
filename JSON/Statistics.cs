using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    class Statistics
    {
        public class RESULT
        {
            public int STATUS { get; set; }
            public string ERROR_MSG { get; set; }
            public string DATE { get; set; }
        }

        public class NARROWINGCOND
        {
            public string CODE_CAT01_FROM { get; set; }
            public string CODE_CAT01_TO { get; set; }
        }

        public class PARAMETER
        {
            public string LANG { get; set; }
            public string STATS_DATA_ID { get; set; }
            public NARROWINGCOND NARROWING_COND { get; set; }
            public string DATA_FORMAT { get; set; }
            public int START_POSITION { get; set; }
            public string METAGET_FLG { get; set; }
        }

        public class STATNAME
        {
            public string __invalid_name__atcode { get; set; }
            public string __invalid_name__doru { get; set; }
        }

        public class GOVORG
        {
            public string __invalid_name__atcode { get; set; }
            public string __invalid_name__doru { get; set; }
        }

        public class TITLE
        {
            public string __invalid_name__atno { get; set; }
            public string __invalid_name__doru { get; set; }
        }

        public class TABLEINF
        {
            public string __invalid_name__atid { get; set; }
            public STATNAME STAT_NAME { get; set; }
            public GOVORG GOV_ORG { get; set; }
            public string STATISTICS_NAME { get; set; }
            public TITLE TITLE { get; set; }
            public int SURVEY_DATE { get; set; }
            public int TOTAL_NUMBER { get; set; }
            public int FROM_NUMBER { get; set; }
            public int TO_NUMBER { get; set; }
        }

        public class CLASSOBJ
        {
            public string __invalid_name__atid { get; set; }
            public string __invalid_name__atname { get; set; }
            public object CLASS { get; set; }
        }

        public class CLASSINF
        {
            public List<CLASSOBJ> CLASS_OBJ { get; set; }
        }

        public class NOTE
        {
            public string __invalid_name__atchar { get; set; }
            public string __invalid_name__doru { get; set; }
        }

        public class VALUE
        {
            public string __invalid_name__attab { get; set; }
            public string __invalid_name__atcat01 { get; set; }
            public string __invalid_name__atcat02 { get; set; }
            public string __invalid_name__atarea { get; set; }
            public string __invalid_name__attime { get; set; }
            public string __invalid_name__atunit { get; set; }
            public string __invalid_name__doru { get; set; }
        }

        public class DATAINF
        {
            public List<NOTE> NOTE { get; set; }
            public List<VALUE> VALUE { get; set; }
        }

        public class STATISTICALDATA
        {
            public TABLEINF TABLE_INF { get; set; }
            public CLASSINF CLASS_INF { get; set; }
            public DATAINF DATA_INF { get; set; }
        }

        public class GETSTATSDATA
        {
            public RESULT RESULT { get; set; }
            public PARAMETER PARAMETER { get; set; }
            public STATISTICALDATA STATISTICAL_DATA { get; set; }
        }

        public class RootObject
        {
            public GETSTATSDATA GET_STATS_DATA { get; set; }
        }
    }
}
