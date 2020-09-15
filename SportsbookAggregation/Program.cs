﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using SportsbookAggregation.Data;
using SportsbookAggregation.SportsBooks;
using SportsbookAggregation.SportsBooks.Models;

namespace SportsbookAggregation
{
    internal static class Program
    {
        public static HttpClient HttpClient = new HttpClient();

        private static void Main(string[] args)
        {
            var dbContext = new Context();

            List<ISportsBook> sportsbooks = new List<ISportsBook> { new FanDuelSportsBook(), new BetAmericaSportsBook(), new ParxSportsBook(), new UnibetSportsBook(),  new FoxBetSportsBook(), new DraftKingsSportsBook(), new BetRiversSportsBook() };
            var gameOfferings = new List<GameOffering>();
            foreach(var sportsbook in sportsbooks)
            {
                try
                {
                    gameOfferings.AddRange(sportsbook.AggregateFutureOfferings().ToList());               
                }
                catch(Exception ex)
                {
                    LogError(ex);
                    Console.WriteLine("Failed to Parse: " + sportsbook.GetSportsBookName());
                }
            }

            try
            {
                var databaseUpdater = new SportsbookOfferingsUpdater(dbContext);
                databaseUpdater.WriteGameOfferings(gameOfferings);
            }
            catch(Exception ex)
            {
                LogError(ex);
                throw ex;
            }
        }

        public static void LogError(Exception ex)
        {
            string filePath = "ErrorLog.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------");
                writer.WriteLine("Date : " + DateTime.Now.ToString());
                writer.WriteLine();

                var exception = ex;
                while (exception != null)
                {
                    writer.WriteLine(exception.GetType().FullName);
                    writer.WriteLine("Message : " + exception.Message);
                    writer.WriteLine("StackTrace : " + exception.StackTrace);

                    exception = exception.InnerException;
                }
            }
        }
    }
}