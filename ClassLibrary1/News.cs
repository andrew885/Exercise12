﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class News
    {
        public string Text { get; set; }
        public News(string message)
        {
            Text = message;                       
        }
    }
}
