﻿using System.Collections.Generic;
using System.Threading.Tasks;
using CIDashboard.Data.Entities;

namespace CIDashboard.Data.Interfaces
{
    public interface ICiDashboardService
    {
        Task<IEnumerable<Project>> GetProjects(string username);

        Task<Project> AddProject(string username, Project project);

        Task<bool> UpdateProjectName(int projectId, string projectName);

        Task<bool> UpdateProjectOrder(int projectId, int position);

        Task<Project> RemoveProject(int projectId);

        Task<BuildConfig> AddBuildConfigToProject(int projectId, BuildConfig buildConfig);

        Task<BuildConfig> RemoveBuildConfig(int buildId);

        Task<bool> UpdateBuildConfigExternalId(int buildId, string buildName, string externalId);

        Task<bool> UpdateBuildConfigOrder(int buildId, int position);
    }
}