namespace WFBlackjack
{
    public class PlayingCard
    {
        public string Name { get; set; }

        public string ResourceName { get; set; }

        public bool IsReversed { get; set; }

        private int valueOfCard = 2;
        public int ValueOfCard 
        {
            get 
            {
                return valueOfCard;
            }
            set
            {
                if (valueOfCard < 2 || valueOfCard > 11)
                {
                    throw new ArgumentOutOfRangeException("Value can not be less than 2 and more than 11");
                }

                valueOfCard = value;
            }
        }
        
    }
}
