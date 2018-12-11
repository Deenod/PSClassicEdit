using PSClassicEdit.DataAccess;
using PSClassicEdit.DataAccess.Entities;
using PSClassicEdit.GameService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSClassicEdit.Interface
{
    public partial class MainForm : Form
    {
        private string _executingDirectory;

        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void SelectFolderBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    SelectFolderTxt.Text = fbd.SelectedPath;
                    var gameIds = FolderUtils.GetGameIds(fbd.SelectedPath);
                    var gameService = new GameService.GameService(fbd.SelectedPath);
                    GameList.Items.Clear();
                    foreach (var id in gameIds)
                    {
                        var info = gameService.GetGameInfo(id);
                        var viewItem = new ListViewItem(info.Title);
                        viewItem.SubItems.Add(info.Publisher);
                        viewItem.SubItems.Add(info.Id.ToString());
                        GameList.Items.Add(viewItem);
                    }

                    _executingDirectory = fbd.SelectedPath;
                    ApplyBtn.Enabled = true;
                }
            }
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            UpdateGameDb();
            AddStaticAssets();
            MessageBox.Show("The USB Drive is ready.", "Success!");
        }

        private void AddStaticAssets()
        {
            if (!Directory.Exists($"{_executingDirectory}\\lolhack"))
                Directory.CreateDirectory($"{_executingDirectory}\\lolhack");

            if (!Directory.Exists($"{_executingDirectory}\\028c18a9-ec4b-4632-b2cf-d4e20f252e8f"))
                Directory.CreateDirectory($"{_executingDirectory}\\028c18a9-ec4b-4632-b2cf-d4e20f252e8f");

            File.WriteAllBytes($"{_executingDirectory}\\lolhack\\lolhack.sh", Properties.Resources.lolhack);
            File.WriteAllBytes($"{_executingDirectory}\\028c18a9-ec4b-4632-b2cf-d4e20f252e8f\\LUPDATA.BIN", Properties.Resources.LUPDATA);
        }

        private void UpdateGameDb()
        {
            var gameService = new GameService.GameService(_executingDirectory);

            var gameIds = FolderUtils.GetGameIds(_executingDirectory);

            using (var db = new GameDbContext(_executingDirectory))
            {
                foreach (var existingGame in db.Games)
                {
                    db.Remove(existingGame);
                }

                foreach (var existingDisc in db.Discs)
                {
                    db.Remove(existingDisc);
                }

                db.SaveChanges();

                foreach (var id in gameIds)
                {
                    var gameInfo = gameService.GetGameInfo(id);

                    var game = new Game()
                    {
                        Id = id,
                        Title = gameInfo.Title,
                        Publisher = gameInfo.Publisher,
                        Year = gameInfo.Year,
                        Players = gameInfo.Players
                    };

                    var i = 1;

                    foreach (var discId in gameInfo.DiscIds)
                    {
                        var disc = new Disc()
                        {
                            GameId = id,
                            DiscNumber = i,
                            DiscBasename = discId
                        };

                        i++;

                        db.Add(disc);
                    }

                    db.Add(game);
                }

                db.SaveChanges();
            }
        }
    }
}
