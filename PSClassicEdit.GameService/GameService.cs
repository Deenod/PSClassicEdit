using PSClassicEdit.GameService.Models;
using SharpConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSClassicEdit.GameService
{
    public class GameService
    {

        private string _executingDirectory;

        public GameService(string executingDirectory)
        {
            _executingDirectory = executingDirectory;
        }

        public GameInfo GetGameInfo(int gameId)
        {
            var gamesDirectory = $"{_executingDirectory}\\Games";

            Configuration config = null;

            try
            {
                config = Configuration.LoadFromFile($"{gamesDirectory}\\{gameId}\\GameData\\Game.ini");
            }
            catch { }

            var section = config["Game"];

            var game = new GameInfo()
            {
                Id = gameId,
                Title = section["Title"].StringValue,
                Publisher = section["Publisher"].StringValue,
                Year = section["Year"].IntValue,
                Players = section["Players"].IntValue,
                DiscIds = section["Discs"].StringValue.Split(',').ToList()
            };

            return game;
        }
    }
}
