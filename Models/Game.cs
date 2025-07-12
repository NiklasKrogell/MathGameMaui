using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Column = SQLite.ColumnAttribute;
using Table = SQLite.TableAttribute;

namespace MathGameMaui.Models
{
    [Table("Game")]
    public class Game
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        public GameOperation Type { get; set; }
        public int Score { get; set; }
        public DateTime DatePlayed { get; set; }
    }

    public enum GameOperation 
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }
}
