﻿using Microsoft.AspNetCore.Mvc;
using ProductCatalog.BusinessObject.Admin;
using ProductCatalog.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.API.Controllers.Admin
{

    [Route("api/[controller]")]
[ApiController]
    public class UserController : Controller
{
        private readonly ICatalogUserBO catalogItemBO;

        public UserController(ICatalogUserBO catalogItemBO)
        {
            this.catalogItemBO = catalogItemBO;
        }

        // GET: api/CatalogItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return Ok(await catalogItemBO.GetUser());
        }


    }
}
