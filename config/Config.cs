using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_NAVIGATOR.config
{
    public class Config
    {


        public String SSH_HOST = "172.16.4.23";
        public String SSH_USER = "adm_nttdata_ggf";
        public String SSH_PASSW = "lkm34r_DFf.s";
        public String DB_HOST = "localhost";
        public String DB_PORT = "6432";
        public String DB_USER = "pantheon";
        public String DB_SCHEMA = "pantheon2015";
        public String DB_PASSWORD = "fghr56#AKio9";


        //public String SSH_HOST = "10.1.1.196";
        //public String SSH_USER = "adm_nttdata_ggfsrv";
        //public String SSH_PASSW = "srv_klj2n3mnkdlo$.&";
        //public String DB_HOST = "localhost";
        //public String DB_PORT = "6432";
        //public String DB_USER = "gpe";
        //public String DB_SCHEMA = "gpe";
        //public String DB_PASSWORD = "gpe1602";

        public Config(System.Xml.Linq.XElement option) {
            var sshOption = option.Descendants("ssh").ToList()[0];
            SSH_HOST = sshOption.Attribute("host").Value;
            SSH_USER = sshOption.Attribute("user").Value;
            SSH_PASSW = sshOption.Attribute("pass").Value;
            
            var dbOption = option.Descendants("database").ToList()[0];
            DB_HOST = dbOption.Attribute("host").Value;
            DB_PORT = dbOption.Attribute("port").Value;
            DB_USER = dbOption.Attribute("user").Value;
            DB_SCHEMA = dbOption.Attribute("schema").Value;
            DB_PASSWORD = dbOption.Attribute("pass").Value;

        }
    }
}
