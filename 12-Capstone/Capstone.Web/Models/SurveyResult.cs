﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class SurveyResult
    {
        public string ParkName { get; set; }

        public string ParkCode { get; set; }

        public int Count { get; set; }

        public int SurveyId { get; set; }
    }
}
