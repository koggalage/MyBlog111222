using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CodeGuide.
using CodeGuide.Contract.DTO;
using CodeGuide.Business.Interfaces;

namespace CodeGuide.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(
            IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("filter")]
        public IActionResult GetFilteredAppointments([FromQuery]PostFilterRequestDTO request)
        {
            return Ok(_postService.GetFilteredAppointments(request));
        }

    }
}