﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.API.DataContracts.Requests.Subject.POST
{
    public class SubjectPostRequest
    {
        public DateTime Date { get; set; }
        public SubjectPost Subject { get; set; }
    }
}
