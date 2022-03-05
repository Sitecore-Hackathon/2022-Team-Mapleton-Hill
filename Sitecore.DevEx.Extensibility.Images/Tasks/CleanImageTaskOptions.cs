using Sitecore.DevEx.Client.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sitecore.DevEx.Extensibility.Images.Tasks
{
    public class CleanImageTaskOptions : TaskOptionsBase
    {
        public string Config { get; set; }

        public string EnvironmentName { get; set; }

        public bool Verbose { get; set; }

        public bool Trace { get; set; }

        public override void Validate()
        {
            this.Require("Config");
            this.Default("EnvironmentName", (object)"default");
        }
    }
}
