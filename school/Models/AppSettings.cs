﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school.Models
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string ConnectionStringLocal { get; set; }
        public string ConnectionStringPublic { get; set; }
    }
}
