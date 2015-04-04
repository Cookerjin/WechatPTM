using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text;

namespace WechatPTM.Framework.WebHelper
{
    public class WebHelper
    {
        public static object WebPost(string PostUrl, string PostData,string MediaType,Encoding encode)
        {
            HttpWebRequest request = WebRequest.Create(PostUrl) as HttpWebRequest;
            request.Method = "POST";
            request.MediaType = MediaType;
            using (Stream sr = request.GetRequestStream())
            {
                byte[] bs = encode.GetBytes(PostData);
                request.ContentLength = bs.Length;
                sr.Write(bs, 0, bs.Length);
                sr.Close();
            }

            HttpWebResponse resp;
            string sResponse = "";

            try
            {
                resp = request.GetResponse() as HttpWebResponse;
                using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
                {
                    sResponse = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {

            }

            return sResponse;
        }
    }
}
