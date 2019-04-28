using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwenSymes.Models
{
    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri ImagePath { get; set; }
        public Uri RepositoryURL { get; set; }
        public List<string> Tags { get; set; }
        public DateTime LastUpdated { get; set; }
        public string BackgroundCssClass { get; internal set; }
    }
}
