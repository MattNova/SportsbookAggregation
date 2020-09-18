﻿using SportsbookAggregation.SportsBooks.Models;
using SportsbookAggregation.SportsBooks.OddsProviders;
using System.Collections.Generic;

namespace SportsbookAggregation.SportsBooks
{
    public class BetRiversSportsBook : ISportsBook
    {
        public string GetSportsBookName()
        {
            return "BetRivers";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var oddsProvider = new BetRiversOddsProvider("https://pa.betrivers.com", GetSportsBookName());
            return oddsProvider.AggregateFutureOfferings();
        }
    }
}
