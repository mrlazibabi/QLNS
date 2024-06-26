﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNS.Models.QuanLiNhanSuModels;
using QLNS.Services;

namespace QLNS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentServices _depService;
        public DepartmentsController(IDepartmentServices depService)
        {
            _depService = depService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
        {
            try
            {
                var deps = await _depService.GetAllDepartments();
                return Ok(deps);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepById(int id)
        {
            var dep = await _depService.GetDepById(id);
            return dep == null ? NotFound() : Ok(dep);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddDepartment(DepartmentModel model)
        {
            try
            {
                var newDep = await _depService.AddDepartment(model);
                return Ok(newDep);
            }
            catch
            {
                return BadRequest("Adding Error");
            }
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateDepartment(int id, DepartmentModel model)
        {
            if (id == model.DepartmentId)
            {
                await _depService.UpdateDepartment(id, model);
                return Ok();
            }
            else
            {
                return BadRequest("Not Found");
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            else
            {
                await _depService.DeleteDepartment(id);
                return Ok();
            }
        }
    }
}
