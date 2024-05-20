﻿
using Project_Backend_2024.DTO;
using Project_Backend_2024.Facade.Models;

namespace Project_Backend_2024.Services.Interfaces.Queries;

public interface IUserQueryService : IQueryModel<User, UserModel>
{
    public Task<User?> RetrieveUserAsync(int id);
}

public interface IProjectQueryService : IQueryModel<Project, ProjectModel> { }

public interface IAppliedProjectQueryService : IQueryModel<AppliedProject, AppliedProjectModel> { }

public interface IUserSkillsQueryService : IQueryModel<UserSkills, UserSkillsModel> { }

public interface ISkillQueryService : IQueryModel<Skill, SkillModel> { }

public interface IRefreshTokenQueryService : IQueryModel<RefreshToken, RefreshTokenModel> 
{
    public Task<RefreshToken?> GetByUserAsync(int userId);
    public Task<RefreshToken?> GetByTokenAsync(string token);
}
