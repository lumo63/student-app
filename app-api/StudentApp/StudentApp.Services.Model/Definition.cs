﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Services.Model
{
    public class Definition
    {
        [Key]
        public Guid DefinitionKey { get; set; }
        public Guid DefinitionGroupKey { get; set; }
        public string GroupName { get; set; }
        public string Value { get; set; }
        public bool Default { get; set; } = false;
        public DateTime CreateTime { get; set; }
        public DateTime ModifyTime { get; set; }

        [ForeignKey(nameof(DefinitionGroupKey))]
        public virtual DefinitionGroup DefinitionGroup { get; set; }

        public ICollection<Subject> SubjectStatusDefinitions { get; set; }
        public ICollection<Subject> SubjectSemesterDefinitions { get; set; }
        public ICollection<Project> ProjectStatusDefinitions { get; set; }
    }
}
