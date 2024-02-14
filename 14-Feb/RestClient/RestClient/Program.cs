﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using RestSharp;

namespace RestClient_Example
{
    internal class Program
    {

        class GitHubUser
        {
            public string Login { get; set; }
            public int Id { get; set; }
            public string NodeId { get; set; }
            public string AvatarUrl { get; set; }
            public string GravatarId { get; set; }
            public string Url { get; set; }
            public string HtmlUrl { get; set; }
            public string FollowersUrl { get; set; }
            public string FollowingUrl { get; set; }
            public string GistsUrl { get; set; }
            public string StarredUrl { get; set; }
            public string SubscriptionsUrl { get; set; }
            public string OrganizationsUrl { get; set; }
            public string ReposUrl { get; set; }
            public string EventsUrl { get; set; }
            public string ReceivedEventsUrl { get; set; }
            public string Type { get; set; }
            public bool SiteAdmin { get; set; }
            public string Name { get; set; }
            public string Company { get; set; }
            public string Blog { get; set; }
            public string Location { get; set; }
            public string Email { get; set; }
            public string Hireable { get; set; }
            public string Bio { get; set; }
            public string TwitterUsername { get; set; }
            public int PublicRepos { get; set; }
            public int PublicGists { get; set; }
            public int Followers { get; set; }
            public int Following { get; set; }
            public string CreatedAt { get; set; }
            public string UpdatedAt { get; set; }
        }
        static void Main(string[] args)
        {
            
            var client = new RestClient("https://api.github.com");

            var request = new RestRequest("users/{username}", Method.Get);
            request.AddUrlSegment("username", "Narmu10");
            request.AddHeader("authority", "api.github.com");


            // for Post request

            // request.RequestFormat = DataFormat.Json;

            // request.AddBody(obj);

            var response = client.Execute<GitHubUser>(request);
            Console.WriteLine($"Status: {response.StatusCode}");

            if (!response.IsSuccessful)
            {
                // error handling
                Console.WriteLine();
            }
            var githubUser = JsonConvert.DeserializeObject<GitHubUser>(response.Content,
                 new JsonSerializerSettings
                 {
                     ContractResolver = new DefaultContractResolver
                     {
                         NamingStrategy = new SnakeCaseNamingStrategy()
                     }
                 });

            Console.WriteLine($"User: {githubUser.Login}");
            Console.WriteLine($"Created At: {githubUser.CreatedAt}");
            Console.WriteLine($"HTML URL: {githubUser.HtmlUrl}");
            Console.WriteLine($"Followers: {githubUser.Followers}");
            Console.ReadLine();
        }
    }
}