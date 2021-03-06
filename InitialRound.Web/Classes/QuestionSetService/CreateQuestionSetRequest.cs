﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InitialRound.Web.Classes.QuestionSetService
{
    public class CreateQuestionSetRequest
    {
        public string AuthToken { get; set; }

        public string AntiForgeryToken { get; set; }

        public string Name { get; set; }

        public Guid[] QuestionIDs { get; set; }
    }
}