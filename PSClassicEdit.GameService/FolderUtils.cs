using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSClassicEdit.GameService
{
    public class FolderUtils
    {
        public static List<int> GetGameIds(string executingDirectory)
        {
            var directoriesToIgnore = new string[]
            {
                "databases",
                "system",
                "geninfo",
                "preferences"
            };

            var gamesDir = $"{executingDirectory}\\Games";
            var dirList = Directory.GetDirectories(gamesDir).ToList();
            var filteredDirList = dirList.Where(d => !directoriesToIgnore.Contains(new DirectoryInfo(d).Name)).ToArray();
            var gameIds = new List<int>();

            if (ValidateDirectoryStructure(filteredDirList))
            {
                for (int i = 0; i < filteredDirList.Length; i++)
                {
                    gameIds.Add(i + 1);
                }
            }
            else
            {
                throw new Exception("Your games directory structure is invalid.");
            }

            return gameIds;
        }

        private static bool ValidateDirectoryStructure(string[] structure)
        {
            var validDirectoryStructure = true;

            for (int i = 0; i < structure.Length; i++)
            {
                if (TryConvertString(structure[i]))
                {
                    if (Convert.ToInt32(new DirectoryInfo(structure[i]).Name) != i + 1)
                    {
                        validDirectoryStructure = false;
                    }
                }
                else
                {
                    validDirectoryStructure = false;
                }
            }

            return validDirectoryStructure;
        }

        private static bool TryConvertString(string input)
        {
            var name = new DirectoryInfo(input).Name;
            var isInt = false;

            try
            {
                int num = Convert.ToInt32(name);
                isInt = true;
            }
            catch { }

            return isInt;
        }
    }
}
