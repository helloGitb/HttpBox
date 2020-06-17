using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpBox
{
    class Http
    {
        public static string Post(string url, byte[] data)
        {

            try
            {
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

                req.Method = "POST";

                req.ContentType = "application/x-www-form-urlencoded";

                req.ContentLength = data.Length;

                Stream streamReq = req.GetRequestStream();

                streamReq.Write(data, 0, data.Length);

                streamReq.Close();


                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                Stream streamResp = resp.GetResponseStream();

                StreamReader sr = new StreamReader(streamResp, Encoding.UTF8);

                return sr.ReadToEnd();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error occured.", "Tips", MessageBoxButtons.OK);
            }


            return null;
        }


        public static string Get(string url)
        {

            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

                req.Method = "GET";

                req.ContentType = "text/html;character=UTF8";


                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                Stream streamResp = resp.GetResponseStream();

                StreamReader sr = new StreamReader(streamResp, Encoding.UTF8);

                return sr.ReadToEnd();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error occured.", "Tips", MessageBoxButtons.OK);
            }


            return null;
        }
    }
}
