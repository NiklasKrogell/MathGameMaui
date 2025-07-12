using MathGameMaui.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameMaui.Data
{
    public class GameRepository
    {
        string _dbPath;
        private SQLiteConnection conn;

        public GameRepository(string dbPath)
        {
            _dbPath = dbPath;
            Init();
        }

        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Game>();
        }

        public List<Game> GetAllGames()
        {
            return conn.Table<Game>().ToList();
        }

        public void Add(Game game)
        {
            conn.Insert(game);
        }

        public void Delete(int id)
        {
            conn.Delete(new Game { Id = id });
        }
    }
}
