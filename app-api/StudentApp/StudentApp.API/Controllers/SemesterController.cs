﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Services.Contracts;
using DC = StudentApp.API.DataContracts;
using RQ = StudentApp.API.DataContracts.Requests.Subject.POST;
using S = StudentApp.Services.Model;


namespace StudentApp.API.Controllers
{
    [Route("api/semester")]
    [ApiController]
    public class SemesterController : Controller
    {
        private readonly ISemesterService _service;
        private readonly IMapper _mapper;

        public SemesterController(ISemesterService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("single/{semesterKey}")]
        public async Task<Guid> GetSingle(Guid semesterKey)
        {
            return _service.GetSingleSemester(semesterKey).Result;
        }

        //TODO Aktualnie user jest hardcoded w poniższych metodach, co trzeba zmienić w kolejnych wersjach
        [HttpGet]
        public async Task<Dictionary<Guid, string>> GetSemestersByUser()
        {
            Guid tmpUserKey = Guid.Parse("00000000-0000-0000-0000-000000000002");

            var data = _service.GetAllSemestersByUser(tmpUserKey);
            var pairs = data.Result.Select(pair => new KeyValuePair<Guid, string>(pair.DefinitionKey, pair.Value));

            return pairs.ToDictionary(p => p.Key, p => p.Value);
        }

        [HttpPut("{semesterKey}")]
        public async Task<ActionResult> ChangeSemesterContext(Guid semesterKey)
        {
            var semester = await _service.ChangeSemester(semesterKey);

            return Ok();
        }

        [HttpPost("{value}")]
        public async Task<Guid> CreateSemester(string value)
        {
            Guid tmpUserKey = Guid.Parse("00000000-0000-0000-0000-000000000002");

            return _service.CreateSemester(tmpUserKey, value).Result;
        }
    }
}
