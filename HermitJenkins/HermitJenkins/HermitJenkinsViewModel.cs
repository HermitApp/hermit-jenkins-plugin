using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hermit.Plugin;
using Caliburn.Micro;
using Newtonsoft.Json;

namespace HermitJenkins
{
    public class HermitJenkinsViewModel : Screen, IShell
    {
        public string DisplayName
        {
            get
            {
                return "Jenkins";
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        private JenkinsNode _Node;

        public JenkinsNode Node
        {
            get { return _Node; }
            set
            {
                if (value != _Node)
                {
                    _Node = value;
                    NotifyOfPropertyChange(() => Node);
                }
            }
        }
    }

    [JsonObject(ItemRequired=Required.AllowNull)]
    public class JenkinsNode : PropertyChangedBase
    {
        private string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if (value != _Description)
                {
                    _Description = value;
                    NotifyOfPropertyChange(() => Description);
                }
            }
        }

        [JsonProperty("jobs")]
        private List<JenkinsProject> _Projects;
        public List<JenkinsProject> Projects
        {
            get { return _Projects; }
            set
            {
                if (value != _Projects)
                {
                    _Projects = value;
                    NotifyOfPropertyChange(() => Projects);
                }
            }
        }
    }

    public class JenkinsProject : PropertyChangedBase
    {
        [JsonProperty("name")]
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (value != _Name)
                {
                    _Name = value;
                    NotifyOfPropertyChange(() => Name);
                }
            }
        }

        private string _ImageStatus;
        public string ImageStatus
        {
            get { return _ImageStatus; }
            set
            {
                if (value != _ImageStatus)
                {
                    if (value != _ImageStatus)
                    {
                        _ImageStatus = value;
                        NotifyOfPropertyChange(() => ImageStatus);
                    }
                }
            }
        }

        public JenkinsProject()
        {

        }

        public void CheckProjectStatus()
        {

        }
    }
}
