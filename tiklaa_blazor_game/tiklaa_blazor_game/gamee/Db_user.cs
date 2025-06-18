namespace tiklaa_blazor_game.gamee
{
    public class Db_user
    {
        public int ID {  get; set; }
        public string UserName { get; set; }

        //yonlendirme
        public List<Db_game> GamePlay {  get; set; }

    }
}
