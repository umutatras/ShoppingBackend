﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingBackend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiControllerBase : ControllerBase
    {
        protected readonly ISender Mediatr;

        public ApiControllerBase(ISender mediatr)
        {
            Mediatr = mediatr;
        }
    }
}
