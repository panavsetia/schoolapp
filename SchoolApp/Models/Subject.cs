﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolApp.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public bool Mandatory { get; set; }
    }
}