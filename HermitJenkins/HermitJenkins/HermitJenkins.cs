using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hermit.Plugin;
using System.Reflection;

namespace HermitJenkins
{
    public class HermitJenkins : IPlugin
    {
        private HermitJenkinsSettingsViewModel _Settings;

        public string Author
        {
            get { return "Lucas Brendel"; }
        }

        public string Description
        {
            get { return "Jenkins job monitor"; }
        }

        public string Name
        {
            get { return "Jenkins"; }
        }

        public void SaveSettings()
        {
            throw new NotImplementedException();
        }

        public ISettingsItem Settings
        {
            get { return _Settings; }
        }

        public string Version
        {
            get { return Assembly.GetEntryAssembly().GetName().Version.ToString(); }
        }

        public HermitJenkins()
        {
            _Settings = new HermitJenkinsSettingsViewModel();
        }
    }
}
