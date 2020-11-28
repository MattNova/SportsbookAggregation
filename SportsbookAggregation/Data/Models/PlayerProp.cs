﻿using System;

namespace SportsbookAggregation.Data.Models
{
    public class PlayerProp
    {
        public Guid PlayerPropId { get; set; }
        public PropBetType PropBetType { get; set; }
        public Guid PropBetTypeId { get; set; }

        public Player Player { get; set; }
        public Guid PlayerId { get; set; }

        public Game Game { get; set; }
        public Guid GameId { get; set; }

        public GamblingSite GamblingSite { get; set; }
        public Guid GamblingSiteId { get; set; }

        public string Description { get; set; }

        public double? PropValue { get; set; }

        public int? Payout { get; set; }

        public DateTime LastRefresh { get; set; }

    }
}
