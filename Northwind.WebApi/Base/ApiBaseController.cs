using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Base;
using Northwind.Entity.IBase;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WebApi.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBaseController<TService, T, TDto> : ControllerBase where TService : IGenericService<T, TDto> where T:EntityBase where TDto : DtoBase
    {
        private readonly TService service;

        public ApiBaseController(TService service)
        {
            this.service = service;
        }

        //api/customer/find
        //api/customer/Getir
        [HttpGet("Find")]
        public IResponse<TDto> Find(int id)
        {
            try
            {
                return service.Find(id);
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        [HttpGet("GetAll")]
        public IResponse<List<TDto>> GetAll()
        {
            try
            {
                return service.GetAll();
            }
            catch (Exception ex)
            {
                return new Response<List<TDto>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        [HttpPost("Add")]
        public IResponse<TDto> Add(TDto entity)
        {
            try
            {
                return service.Add(entity);
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }
    }
}
