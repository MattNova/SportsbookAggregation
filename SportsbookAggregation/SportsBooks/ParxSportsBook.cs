﻿using SportsbookAggregation.SportsBooks.Models;
using SportsbookAggregation.SportsBooks.OddsProviders;
using System.Collections.Generic;

namespace SportsbookAggregation.SportsBooks
{
    public class ParxSportsBook : ISportsBook
    {
        public string GetSportsBookName()
        {
            return "Parx";
        }

        public IEnumerable<GameOffering> AggregateFutureOfferings()
        {
            var oddsProvider = new KambicdnOddsProvider(GetSportsBookName(), "parxuspa");
            return oddsProvider.AggregateFutureOfferings();
        }
    }
}
