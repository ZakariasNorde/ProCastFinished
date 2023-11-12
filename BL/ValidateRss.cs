using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Xml;

namespace BL
{
    public class ValidateRss
    {
        public static bool urlExist(string url)
        {
            PodManager podManager = new PodManager();
            List<PoddCast> allaPoddar = podManager.getPoddList();
            int i = 0;
            bool hittat = false;
            while (i < allaPoddar.Count && !hittat)
            {
                PoddCast enPodd = allaPoddar[i];
                if (enPodd.Url.Equals(url))
                {
                    hittat = true;
                }
                i++;
            }
            return hittat;
        }

        public static bool RssValidering(String txtUrl)
        {
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        string rssContent = client.DownloadString(txtUrl);

                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.LoadXml(rssContent);

                        XmlNode channelNode = xmlDocument.SelectSingleNode("//channel");
                        if (channelNode != null)
                        {
                            return true;
                        }
                        else
                        {
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Om länken är invalid kastas ett exception och i detta block gör den inget utan den vidare till nästa kod och returnerar false
                }

                return false;
            }
        }
    }
}
