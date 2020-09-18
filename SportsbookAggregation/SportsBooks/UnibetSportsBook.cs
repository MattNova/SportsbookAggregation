﻿using SportsbookAggregation.SportsBooks.Models;
using SportsbookAggregation.SportsBooks.OddsProviders;
using System.Collections.Generic;

namespace SportsbookAggregation.SportsBooks
{
    public class UnibetSportsBook : ISportsBook
    {
        public string GetSportsBookName()
        {
            return "Unibet";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "ubuspa");
            return oddsProvider.AggregateFutureOfferings();
        }
    }
}
