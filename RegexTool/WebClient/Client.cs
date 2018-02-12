using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebClient
{
    public class Client
    {
        HttpWebResponse _responce;
        HttpWebRequest _request;

        public void SendRequest(string uriString)
        {
            _request = (HttpWebRequest)WebRequest.Create(uriString);
        }

        public string GetTextResponce()
        {
            string result = String.Empty;

            _responce = (HttpWebResponse)_request.GetResponse();
            Stream stream = _responce.GetResponseStream();

            int charCode = 0;

            for (int i = 0; ; i++)
            {
                charCode = stream.ReadByte();
                if (charCode != -1)
                    result += (char)charCode;
                else
                    break;
            }

            return result;
        }
    }
}
