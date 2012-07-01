using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace ranking.sykl.no
{
    public class Start : NancyModule
    {
        public Start()
        {
            Get["/"] = _ => View["Start"];
        }
    }
}