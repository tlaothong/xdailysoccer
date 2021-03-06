﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySoccer.Shared.Models
{
    public class RewardInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public int RemainingAmount { get; set; }
        public string ImagePath { get; set; }
        public string ThumbnailPath { get; set; }
        public int RewardGroupId { get; set; }
    }
}
