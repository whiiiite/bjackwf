namespace WFBlackjack
{
    public partial class Form1 : Form
    {
        List<PlayingCard> cards;
        List<PlayingCard> playerCards;
        List<PlayingCard> croupierCards;

        public Form1()
        {
            InitializeComponent();
            cards = PlayingCardsHandler.GetSetOfCards();
            playerCards = new List<PlayingCard>();
            croupierCards = new List<PlayingCard>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HitBtn.Enabled = false;
            StandBtn.Enabled = false;
            StartBtn.Enabled = true;
            BustOrWinLabel.Text = string.Empty;
        }

        public static Bitmap GetImageByName(string imageName)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".Properties.Resources";
            var rm = new System.Resources.ResourceManager(resourceName, asm);
            return (Bitmap)rm.GetObject(imageName);

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            InitRound();
            RoundSwitchButtons();
            CroupHit();
            Hit();
            CroupHit();
            Hit();

            int croupCount = CountCards(croupierCards);
            int playerCount = CountCards(playerCards);
            if (croupCount == 21)
            {
                BustOrWinLabel.Text = $"Croupier have Blackjack. You bust down!";
                NewRoundSwitchButtons();
            }
            else if (playerCount == 21)
            {
                BustOrWinLabel.Text = $"You have Blackjack. You won!";
                NewRoundSwitchButtons();
            }
        }

        private void HitBtn_Click(object sender, EventArgs e)
        {
            Hit();
        }

        private void StandBtn_Click(object sender, EventArgs e)
        {
            HitBtn.Enabled = false;
            CoupierHitsAfterStand();
            CompareCount();
            NewRoundSwitchButtons();
        }

        private void Hit()
        {
            DealCard(playerCards);
            int count = CountCards(playerCards);
            if (count == 21)
            {
                BustOrWinLabel.Text = $"You have 21. You won!";
                NewRoundSwitchButtons();
            }
            if (count > 21)
            {
                BustOrWinLabel.Text = $"You have {count}. You bust down!";
                NewRoundSwitchButtons();
            }
            PlayerStatusLabel.Text = $"Your count: {count}";
        }

        private void CroupHit()
        {
            DealCard(croupierCards);
            int count = CountCards(croupierCards);
            if (count == 21)
            {
                BustOrWinLabel.Text = $"Croupier have 21. You bust down!";
                NewRoundSwitchButtons();
            }
            if (count > 21)
            {
                BustOrWinLabel.Text = $"Croupier have {count}. You won!";
                NewRoundSwitchButtons();
            }
            CroupierStatusLabel.Text = $"Croupier count: {count}";
        }

        private void InitRound()
        {
            playerCards = new List<PlayingCard>();
            croupierCards = new List<PlayingCard>();
            cards = PlayingCardsHandler.GetSetOfCards();
            PlayingCardsHandler.Shuffle(cards);
            BustOrWinLabel.Text = string.Empty;
        }

        private void NewRoundSwitchButtons()
        {
            HitBtn.Enabled = false;
            StandBtn.Enabled = false;
            StartBtn.Enabled = true;
        }

        private void RoundSwitchButtons()
        {
            HitBtn.Enabled = true;
            StandBtn.Enabled = true;
            StartBtn.Enabled = false;
        }

        private void CoupierHitsAfterStand()
        {
            int croupCount = CountCards(croupierCards);
            while (croupCount < 17)
            {
                croupCount = CountCards(croupierCards);
                CroupHit();
            }
        }

        private void CompareCount()
        {
            int p = CountCards(playerCards);
            int c = CountCards(croupierCards);
            if (c > 21)
            {
                BustOrWinLabel.Text = $"Croupier have {c}. You won!";
            }
            else if (p > 21)
            {
                BustOrWinLabel.Text = $"You have {p}. You bust down!";
            }
            else if (p > c)
            {
                BustOrWinLabel.Text = $"You have {p}. You won!";
            } 
            else if(p < c)
            {
                BustOrWinLabel.Text = $"Croupier have {c}. You bust down!";
            }
            else
            {
                BustOrWinLabel.Text = $"You and Croupier have the same count. Tie!";
            }
        }

        private void DealCard(List<PlayingCard> setOfCard)
        {
            var card = cards.First();
            setOfCard.Add(card);
            cards.Remove(card);
        }

        private int CountCards(List<PlayingCard> cards)
        {
            int count = 0;
            int aceCount = 0;

            foreach (var card in cards)
            {
                if (card.ValueOfCard == 11)
                {
                    aceCount++;
                }

                count += card.ValueOfCard;
            }

            while (count > 21 && aceCount > 0)
            {
                count -= 10;
                aceCount--;
            }

            return count;
        }
    }
}