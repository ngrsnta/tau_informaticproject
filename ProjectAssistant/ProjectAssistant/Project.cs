using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant
{
    class Project
    {

            public int projectid_number { get; set; }
            public int companyid_number { get; set; }
            public string title { get; set; } = "";
            public string projectdesc { get; set; } = "";
            public string areaofinterest { get; set; } = "";
            public string skills { get; set; } = "";
            public string deadline { get; set; } = "";
            public string start { get; set; } = "";
            public string end { get; set; } = "";
            public string branchdec { get; set; } = "";

    }
    
}
