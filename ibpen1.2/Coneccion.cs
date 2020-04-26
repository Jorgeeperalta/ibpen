using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ibpen1._2
{
    public class Coneccion
    {
        public static string str()
        {    //"datasource=db4free.net;port=3306;username=jorge_peralta;password=alefacumax;database=testeo;old guids=true";
            //"datasource=127.0.0.1;port=3307;username=root;password=root;database=testeo";

            //"Server=MYSQL5013.site4now.net;Database=db_a47d48_ale;Uid=a47d48_ale;Pwd=V3QmbvAPEMUXwrQ";
            string cadena = "Server=MYSQL5013.site4now.net;Database=db_a47d48_ale;Uid=a47d48_ale;Pwd=V3QmbvAPEMUXwrQ";
            return cadena;
        }
    }
}