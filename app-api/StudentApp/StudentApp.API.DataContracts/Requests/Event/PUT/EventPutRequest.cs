﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.API.DataContracts.Requests.Event.PUT
{
    public class EventPutRequest
    {
        public DateTime Date { get; set; }
        public EventPut Event { get; set; }
    }
}
