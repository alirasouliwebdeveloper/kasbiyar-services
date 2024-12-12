﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using TradeBuddy.Store.Application.Commands;
using TradeBuddy.Store.Application.Queries;
using TradeBuddy.Store.Application.Dto;

namespace TradeBuddy.Store.Api.Controller
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] AddCategoryCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result); // Returns the GUID of the added category
        }
    }
}
