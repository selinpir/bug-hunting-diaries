using System.ComponentModel.DataAnnotations;

namespace tiklaa_blazor_game.gamee
{
    public class Db_game
    {
        [Key]
        public int GameID { get; set; }
        public int Skor { get; set; }
        public int ClickCount { get; set; }
        public string Animal { get; set; }
        public DateTime Date { get; set; }

        // Foreign Key
        public int UserID { get; set; }         // Foreign key sütunu
        public Db_user user { get; set; }          // Navigation property

    }
}

