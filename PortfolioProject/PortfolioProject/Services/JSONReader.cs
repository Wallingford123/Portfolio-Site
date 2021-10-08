using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortfolioProject.Models;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace PortfolioProject.Services
{
    public class JSONReader
    {
        public List<ProjectModel> GetProjects(){
            List<ProjectModel> projects = JSONToList(new ProjectModel(),"JSON/Projects.json","Projects");
            foreach(ProjectModel p in projects)
            {
                p.description = p.description.Replace("\n", "<br />");
                p.contentURL = p.contentURL.Replace("/v/", "https://www.youtube.com/embed/");
            }
            return projects;
        }

        List<T> JSONToList<T>(T arg, string location, string objectName)
        {
            JObject o = JObject.Parse(File.ReadAllText(location));
            JArray a = (JArray)o[objectName];

            List<T> _list = new List<T>();
            _list = a.ToObject<List<T>>();

            return _list;
        }    }
}
