


namespace BarclayServer.Models
{

    public interface IPlayer
    {
        int Id { get; set; }
        bool IsDeleted { get; set; }

        string Name { get; set; }
    }



    public class Player : IPlayer
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }


        public int Number { get; set; }

        public IList<PlayerPositions> Positions { get; set; }
        
        public PlayerStatus Status { get; set; }


        public Player(String name)
        {
            this.IsDeleted = false;
            this.Name = name;
            this.Number = 0;

            this.Positions = new List<PlayerPositions>();
        }

    }

    public enum PlayerPositions
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Striker
    }

    public enum PlayerStatus
    {
        Healthy,
        Injury,
        Away
    }
}





