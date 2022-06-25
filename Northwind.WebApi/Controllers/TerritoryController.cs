using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;
using System;
using System.Linq;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerritoryController : ApiBaseController<ITerritoryService, Territory, DtoTerritory>
    {
        private readonly ITerritoryService territoryService;
        public TerritoryController(ITerritoryService territoryService) : base(territoryService)
        {
            this.territoryService = territoryService;
        }

    }
}
