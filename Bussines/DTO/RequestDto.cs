﻿using DataAccess.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.DTO
{
    public class RequestDto
    {
        public int id { set; get; }
        public int? sendUserId { get; set; }
        public int receiveUserId { get; set; }
        public RequestEnum requestEnum { get; set; }
        public RequestResponse requestResult { get; set; } = RequestResponse.None;
    }
}
