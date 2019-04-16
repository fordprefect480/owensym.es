using owensym.es.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace owensym.es.Services
{
    public class StaticDataProjectService : IProjectService
    {
        public List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Name = "Play Me",
                    Description = "A .NET-based office jukebox created by Trade Me developers as part of FedEx Day 2012. The frontend is a SPA, which calls through to a Web API backed by a Mongo database.",
                    RepositoryURL = new Uri("https://github.com/TradeMe/PlayMe"),
                    ImagePath = new Uri("/img/playme.png", UriKind.Relative),
                    BackgroundCssClass = "bg-white",
                    Tags = new List<string>
                    {
                        "ASP.NET",
                        "Web API",
                        "MongoDB",
                        "Knockout",
                        "Durandal",
                        "SignalR",
                        "Bootstrap"
                    },
                    LastUpdated = new DateTime(2017, 9, 18, 8, 44, 0)
                },
                new Project
                {
                    Name = "Bechdel Tonight",
                    Description = "Look up the Australian tv schedule and compare Bechdel scores for movies.",
                    RepositoryURL = new Uri("https://github.com/TradeMe/bechdeltonight"),
                    ImagePath = null,
                    BackgroundCssClass = "bg-info",
                    Tags = new List<string>
                    {
                        ".NET Core",
                        "Bootstrap"
                    },
                    LastUpdated = new DateTime(2019, 4, 11, 21, 17, 0)
                },
                new Project
                {
                    Name = "Xep Dash",
                    Description = "The beginnings of a UWP dashboard which rotates through slides containing useful information about the company. Designed to run using Windows 10 IoT on an RPi 3.",
                    RepositoryURL = new Uri("https://github.com/TradeMe/xepdash"),
                    ImagePath = null,
                    BackgroundCssClass = "bg-warning",
                    Tags = new List<string>
                    {
                        "UWP",
                        "IoT",
                        ".NET Core"
                    },
                    LastUpdated = new DateTime(2019, 4, 11, 21, 16, 0)
                },
                new Project
                {
                    Name = "Friend Jam",
                    Description = "A web application which creates a Spotify playlist based on the tastes of 2 or more people.",
                    RepositoryURL = new Uri("https://github.com/TradeMe/friendjam"),
                    ImagePath = null,
                    BackgroundCssClass = "bg-primary",
                    Tags = new List<string>
                    {
                        "ASP.NET",
                        "SpotifyAPI",
                        "Bootstrap"
                    },
                    LastUpdated = new DateTime(2019, 4, 16, 7, 30, 0)
                }
            };
        }
    }
}
