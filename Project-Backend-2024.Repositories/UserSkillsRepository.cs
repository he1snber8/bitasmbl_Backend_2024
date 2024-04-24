﻿using Project_Backend_2024.DTO;
using Project_Backend_2024.Facade.Interfaces;
using Project_Backend_2024.Repositories;

public class UserSkillsRepository : RepositoryBase<UserSkills>, IRepositoryBase<UserSkills>
{
    public UserSkillsRepository(DatabaseContext context) : base(context) { }
}
