using owensym.es.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace owensym.es.Services
{
    public class GithubProjectService : IProjectService
    {
        public List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Name = "Play Me",
                    Description = "",
                    Tags = new List<string> { },
                    LastUpdated = new DateTime(2017, 9, 18)
                },
                new Project
                {
                    Name = "Play Me",
                    Description = "",
                    Tags = new List<string> { },
                    LastUpdated = new DateTime(2017, 9, 18)
                },
                new Project
                {
                    Name = "Play Me",
                    Description = "",
                    Tags = new List<string> { },
                    LastUpdated = new DateTime(2017, 9, 18)
                },
                new Project
                {
                    Name = "Play Me",
                    Description = "",
                    Tags = new List<string> { },
                    LastUpdated = new DateTime(2017, 9, 18)
                }
            };
        }
    }
}
