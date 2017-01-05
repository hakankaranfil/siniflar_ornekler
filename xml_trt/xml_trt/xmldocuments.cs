using System;
using System.Xml;

namespace xml_trt
{
    internal class xmldocuments
    {
        public xmldocuments()
        {
        }

        public string Load { get; internal set; }

        internal XmlNodeList SelectNodes(string v)
        {
            throw new NotImplementedException();
        }
    }
}