﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCrawler.Models
{
    public class CrawlerConfigurations
    {
        public String Id { get; set; }

        [MaxLength(255)]
        public string ConfigconfigurationName { get; set; }

        [MaxLength(255)]
        public string ConfigconfigurationValue { get; set; }

        public DateTime DataCreateTime { get; set; }

        public bool IsEnabled { get; set; }

        public int ConfigconfigurationKey { get; set; }

    }
}
