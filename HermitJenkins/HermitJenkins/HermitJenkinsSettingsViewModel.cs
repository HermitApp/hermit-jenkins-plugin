using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hermit.Plugin;

namespace HermitJenkins
{
    public class HermitJenkinsSettingsViewModel : ISettingsItem
    {
        public string Name
        {
            get { return "Jenkins Settings"; }
        }
    }
}
