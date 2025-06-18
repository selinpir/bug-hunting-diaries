using System.ComponentModel.DataAnnotations;

namespace tiklaa_blazor_game.gamee
{
    public class Db_leader
    {
        [Key]
        public int leaderID { get; set; }
        public string UserName { get; set; }
        public int Skor { get; set; }
    }
}
