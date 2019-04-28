using OwenSymes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Octokit.GraphQL;
using Octokit.GraphQL.Core;

namespace OwenSymes.Services
{
    public class GithubProjectService : IProjectService
    {
        Connection GitHubConnection;

        public GithubProjectService()
        {
            var productInformation = new ProductHeaderValue("fordprefect480", "v0.1");
            GitHubConnection = new Connection(productInformation, "28cf3158718374ff4cb2f6dd3b1c0dd307b25906");
        }

        public async Task<List<Project>> GetProjects()
        {
            var projects = new List<Project>();
            var query = new Query()
                .RepositoryOwner(new Arg<string>("owner"))
                .Repositories()
                .Select(repo => repo.Single())
                .Compile();
            var vars = new Dictionary<string, object> { { "owner", "fordprefect480" } };
            var result = GitHubConnection.Run(query, vars);
            foreach (var repository in result.Result.Nodes.ToList())
            {
                projects.Add(new Project
                {
                    Name = repository.Name,
                    Description = repository.Description,
                    RepositoryURL = new Uri(repository.Url),
                    ImagePath = repository.Name == "PlayMe" ? new Uri("/img/playme.png", UriKind.Relative) : null,
                    BackgroundCssClass = "bg-white",
                    Tags = repository.RepositoryTopics().Select(rt => rt.Nodes.Select(n => n.Topic.Name)).ToList(),
                    LastUpdated = new DateTime(2017, 9, 18, 8, 44, 0)
                });
            }

            return projects;
        }
    }
}
