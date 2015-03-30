using RiotSharp.CurrentGameEndpoint;

namespace LoLCurrentGame.Business.Entities
{
    public class CurrentGameEndpoint
    {
        public BannedChampion BannedChampion{ get; set; }
        public CurrentGame CurrentGame { get; set; }
        public Mastery Mastery { get; set; }
        public Observer Observer { get; set; }
        public Participant Participant { get; set; }
        public Rune Rune { get; set; }
    }

}