using System;
using System.Collections.Generic;
using System.Linq;
using TeamSource.Enteties;
using TeamSource.Helpers;

namespace GameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = TeamsDataBase.GetAllTeams();

            // Find all TEAMS with names starting with LA
            var teamsStartingWithLA = teams.Where(team => team.Name.StartsWith("LA")).ToList();
            // teamsStartingWithLA.ForEach(team => Console.WriteLine(team.Name));


            // Find all team NAMES which are playing in "Staples Center"
            var teamsPlayingInStaplesCenter = teams.Where(team => team.Arena.Equals("Staples Center"))
                                                      .Select(team => team.Name).ToList();
            // teamsPlayingInStaplesCenter.ForEach(team => Console.WriteLine(team));



            // Find all teams coaches
            var allCoaches = teams.Select(team => team.Coach).ToList();
            // allCoaches.ForEach(coach => Console.WriteLine(coach.FullName));



            // Find 3 oldest coaches NAMES
            var oldest3CoahcesNames = allCoaches.OrderByDescending(coach => coach.Age)
                                                          .Take(3)
                                                            .Select(coach => coach.FullName)
                                                              .ToList();
            // oldest3CoahcesNames.ForEach(trainerName => Console.WriteLine(trainerName));



            // Group all teams by their arenas
            var groupedTeamsByArenas = teams.GroupBy(team => team.Arena).ToList();
            //foreach (var group in groupedTeamsByArenas)
            //{
            //    Console.WriteLine($"{group.Key}");
            //    foreach (var team in group)
            //    {
            //        Console.WriteLine($"-------------{team.Name}");
            //    }
            //}


            // Find all players in one LIST
            var allPlayers = new List<Player>();
            teams.ForEach(team => allPlayers.AddRange(team.Players));
            //allPlayers.ForEach(player => Console.WriteLine(player.FullName));

            //Find player with best avgPtsPerGame
            var playerWithMostPtsPerGame = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                                          .FirstOrDefault();
            //Console.WriteLine(playerWithMostPtsPerGame.FullName);


            // HOMEWORK

            // Find all coaches NAMES with Age > 50

            var coachesAgeOver50 = allCoaches.Where(coach => coach.Age > 50)
                                            .Select(coach => coach.FullName).ToList();
            


            // Order players by AGE - DESC

            var playersOrderedByAge = allPlayers.OrderByDescending(player => player.Age).ToList();
            

            // Find player with highest RebPerGame

            var playerHighestRebPerGame = allPlayers.OrderByDescending(player => player.PlayerStatistic["RebPerGame"])
                                                            .FirstOrDefault();


            // Find all players with PtsPerGame > 20

            var playersWithMorePtsPerGame = allPlayers.Where(player => player.PlayerStatistic["PtsPerGame"] > 20).ToList();


            // Find all players NAMES older then 30 years

            var playerNamesOlderThan30 = allPlayers.Where(player => player.Age > 30)
                                                    .Select(player => player.FullName).ToList();


            // Group players by age

            var playersGroupedByAge = allPlayers.GroupBy(player => player.Age).ToList();


            // Find All players NAMES and PtsPerGame if have RebPerGame > 7.0

            var playerHighRebPerGame = allPlayers.Where(player => player.PlayerStatistic["RebPerGame"] > 7.0)
                                        .Select(player => new { player.FullName, PtsPerGame = player.PlayerStatistic["PtsPerGame"] }).ToList();


            // Find first 3 players with highest PtsPerGame

            var first3HighestPtsPerGame = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                                  .Take(3)
                                                  .ToList();


            // Find the team which has the player with highest PtsPerGame

            var playerWithHighestPtsPerGame = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                                        .FirstOrDefault();
            Team teamOfPlayer;
            foreach (var team in teams)
            {
                foreach (var player in team.Players)
                {
                    if (player.FullName == playerHighestRebPerGame.FullName)
                    {
                        teamOfPlayer = team;
                    }
                }
            }

            // Find first 4 players with highest RebPerGame and order them by PtsPerGame - ASC

            var complexPlayers = allPlayers.OrderByDescending(player => player.PlayerStatistic["RebPerGame"])
                                            .Take(4)
                                            .OrderBy(player => player.PlayerStatistic["PtsPerGame"])
                                            .ToList();

        }
    }
}