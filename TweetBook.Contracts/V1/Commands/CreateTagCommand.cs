﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetBook.Contracts.V1.Commands
{
    public class CreateTagCommand
    {
        public string TagName { get; set; }
    }
}