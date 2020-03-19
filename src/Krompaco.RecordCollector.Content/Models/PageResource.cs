﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Krompaco.RecordCollector.Content.Models
{
    public class PageResource : IFile
    {
        public string ResourceType { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public Uri Permalink { get; set; }

        public string FullName { get; set; }
    }
}
