using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Web;
using System.IO;
using System.Net;
using Newtonsoft.Json;

using Rhino;
using Rhino.Geometry;
using Rhino.Display;

//http://statdb.nstac.go.jp/api/1.0b/app/getStatsList?appId=c4027947d9d064ddbc034e3520f0a95d2935ade5&statsCode=00200&searchWord=%E2%80%98%E4%BA%BA%E5%8F%A3%E6%8E%A8%E8%A8%88%E2%80%99
//http://statdb.nstac.go.jp/api/1.0b/app/getStatsData?appId=c4027947d9d064ddbc034e3520f0a95d2935ade5&statsDataId=0003104197&cdCat01From=000&cdCat01To=002
//http://statdb.nstac.go.jp/api/1.0b/app/json/getStatsData?appId=c4027947d9d064ddbc034e3520f0a95d2935ade5&statsDataId=0003104197&cdCat01From=000&cdCat01To=002
//人口推計 平成26年10月1日現在人口推計　都道府県，年齢（5歳階級），男女別人口－総人口


namespace JSON
{
    class Loop : Rhino_Processing
    {
        public override void Setup()
        {
            var url = "http://statdb.nstac.go.jp/api/1.0b/app/json/getStatsData?appId=c4027947d9d064ddbc034e3520f0a95d2935ade5&statsDataId=0003104197&cdCat01From=000&cdCat01To=002";

            var json = RequestToAPI(url);

            Statistics.VALUE obj = JsonConvert.DeserializeObject<Statistics.VALUE>(json);

            string scale = obj.__invalid_name__doru;

            RhinoApp.WriteLine(json.Substring(1, 100));
        }

        private static string RequestToAPI(string url)
        {
            WebRequest req = WebRequest.Create(url);
            HttpWebResponse response = null;
            string rxText = string.Empty;
            try
            {
                // レスポンスの取得
                response = (HttpWebResponse)req.GetResponse();
                Stream resStream = response.GetResponseStream();
                var sr = new StreamReader(resStream, Encoding.UTF8);
                rxText = sr.ReadToEnd();
                sr.Close();
                resStream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return string.Empty;
            }
            finally
            {
                if (response != null)
                    response.Close();
            }

            return rxText;
        }

        
        public override void Draw()
        {

        }
    }
}

//http://kisuke0303.sakura.ne.jp/blog/?p=214