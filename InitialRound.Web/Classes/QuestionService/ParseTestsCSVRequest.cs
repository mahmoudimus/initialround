﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InitialRound.Web.Classes.QuestionService
{
    public class ParseTestsCSVRequest
    {
        public string AuthToken { get; set; }

        public string AntiForgeryToken { get; set; }

        public string CSV { get; set; }
    }
}
