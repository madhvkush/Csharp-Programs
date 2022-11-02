using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace _3_XML_1_.Models
{
    public class KeyWordOps
    {
        public bool AddKeyword(string keyword)
        {
            try
            {
                XDocument xdoc = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/Keywords.xml"));

                xdoc.Root.Add(new XElement("Keyword", keyword));

                xdoc.Save(HttpContext.Current.Server.MapPath("~/App_Data/Keywords.xml"));
                return true;
            }
            catch { return false; }
        }

        public bool Delete(string keyword)
        {
            try
            {
                XDocument xdoc = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/Keywords.xml"));
                xdoc.Root.Elements("Keyword").Where(i => i.Value.ToString() == keyword).Remove();
                xdoc.Save(HttpContext.Current.Server.MapPath("~/App_Data/Keywords.xml"));
                return true;
            }
            catch { return false; }
        }
        public List<string> GetKeywords()
        {
            List<string> result = new List<string>();
            XDocument xdoc = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/Keywords.xml"));

            var keyList = from t in xdoc.Root.Elements("Keyword")
                          select (t.Value.ToString());
            result.AddRange(keyList);
            return result;
        }
    }
}