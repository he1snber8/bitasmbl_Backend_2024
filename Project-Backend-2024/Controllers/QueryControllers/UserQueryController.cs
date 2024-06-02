﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_Backend_2024.Services.Interfaces.Queries;


namespace Project_Backend_2024.Controllers.QueryControllers;

[ApiController]
[Route("queries/[controller]")]
public class UserController : Controller
{
    private readonly IUserQueryService _userQueryService;

    public UserController(IUserQueryService userQueryService)
    {
        _userQueryService = userQueryService;
    }

    [HttpGet("{email}")]
    public async Task<IActionResult> GetByEmail(string email)
    {
        var userModel = await _userQueryService.GetByEmailAsync(email);
        if (userModel == null)
        {
            return NotFound();
        }
        return Ok(userModel);
    }

    //[Authorize(Roles ="User")]
    [HttpGet("get_all")]
    public IActionResult GetAll()
    {
        try
        {
            var userModels = _userQueryService.GetAll().ToList();
            return Ok(userModels);
        }
        catch (Exception)
        {
            return Unauthorized("you are not authorized, fuck off");
        }
    }

}