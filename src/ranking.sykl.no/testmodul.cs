using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ranking.sykl.no
{
    public class testmodul : Nancy.NancyModule
    {
        public testmodul()
        {
            Get["/"] = _ =>  "<h1>Hurra for ranking.sykl.no på appharbor</h1>";
        }

    }
}