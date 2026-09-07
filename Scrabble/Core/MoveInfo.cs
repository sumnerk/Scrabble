namespace Scrabble.Core.Types
{
    [Serializable]
    public class MoveInfo
    {
        public int MoveNumber { get; set; }
        public string Action { get; set; }
        public string Who { get; set; }
        public string Words { get; set; }
        public TimeSpan MoveDuration { get; set; }
        public TimeSpan TotalMoveDuration { get; set; }
        public int Score { get; set; }
        public string Description { get; set; }

        public MoveInfo()
        {
            MoveNumber = 0;
            Action = string.Empty;
            Who = string.Empty;
            Words = string.Empty;
            MoveDuration = TimeSpan.Zero;
            TotalMoveDuration = TimeSpan.Zero;
            Score = 0;
            Description = string.Empty;
        }
    }
}