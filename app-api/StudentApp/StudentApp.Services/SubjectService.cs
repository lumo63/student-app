﻿using AutoMapper;
using Microsoft.Extensions.Options;
using StudentApp.API.Common.Settings;
using StudentApp.Services.Contracts;
using StudentApp.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentApp.Tools.Configurations;

namespace StudentApp.Services
{
    public class SubjectService : ISubjectService
    {
        private AppSettings _settings;
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public SubjectService(IOptions<AppSettings> settings, IMapper mapper, DataContext context)
        {
            _settings = settings?.Value;
            _mapper = mapper;
            _context = context;
        }

        public async Task<Subject> CreateAsync(Subject subject)
        {
            if (string.IsNullOrEmpty(subject.Name))
                throw new AppException("Subject Name is required.");
            
            await _context.Subject.AddAsync(subject);
            await _context.SaveChangesAsync();
            
            return subject;
        }

        public async Task<bool> UpdateAsync(Subject subject)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(Guid SubjectKEY)
        {
            throw new NotImplementedException();
        }

        public async Task<Subject> GetSingleAsync(Guid SubjectKEY)
        {
            return _context.Subject.SingleAsync(subject => subject.SubjectKey == SubjectKEY).Result;
        }
    }
}
