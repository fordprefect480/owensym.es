using owensym.es.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace owensym.es.Services
{
    public interface IProjectService
    {
        List<Project> GetProjects();
    }
}
