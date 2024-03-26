﻿using System.Net;
using TestRail.ApiTesting;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Services
{
    public interface IProjectService
    {
        
        Task<Project> GetProject(string projectId);
        Task<Projects> GetProjects();
        Task<Project> AddProject(Project project);
        Task<Project> UpdateProject(Project project);
        HttpStatusCode DeleteProject(string id);
    }
}
