using IgniteCSharpApi.Communications;
using IgniteCSharpApi.Communications.Requests;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace IgniteCSharpApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new User
        {
            Id = 1,
            Age = 7,
            Name = "welisson"
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUser), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RegisterUserBody request)
    {
        var response = new ResponseRegisterUser
        {
            Id = 1,
            Name = request.Name
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] UpdateUserBody body)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>()
        {
            new User {Id = 1, Age = 7, Name = "welisson"},
            new User {Id = 2, Age = 7, Name = "maria"}
        };

        return Ok(response);
    }

    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] UpdatePasswordBody request)
    {
        return NoContent();
    }

    [HttpPut("change-welisson")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword2([FromBody] UpdatePasswordBody request)
    {
        return NoContent();
    }
}
