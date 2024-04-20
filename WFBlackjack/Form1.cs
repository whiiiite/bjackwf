namespace WFBlackjack
{
    public partial class Form1 : Form
    {
        List<PlayingCard> cards;
        List<PlayingCard> playerCards;
        List<PlayingCard> croupierCards;

        List<PictureBox> croupCardPicBoxes;
        List<PictureBox> playerCardPicBoxes;

        public Form1()
        {
            InitializeComponent();
            cards = PlayingCardsHandler.GetSetOfCards();
            playerCards = new List<PlayingCard>();
            croupierCards = new List<PlayingCard>();

            croupCardPicBoxes = new List<PictureBox>
            {
                CroupCardPicBox1,
                CroupCardPicBox2,
                CroupCardPicBox3,
                CroupCardPicBox4,
                CroupCardPicBox5,
                CroupCardPicBox6,
            };

            playerCardPicBoxes = new List<PictureBox>
            {
                PlayerCardPicBox1,
                PlayerCardPicBox2,
                PlayerCardPicBox3,
                PlayerCardPicBox4,
                PlayerCardPicBox5,
                PlayerCardPicBox6,
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HitBtn.Enabled = false;
            StandBtn.Enabled = false;
            StartBtn.Enabled = true;
            BustOrWinLabel.Text = string.Empty;
            CenterAllLabels();
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            InitRound();
            RoundSwitchButtons();

            await Task.Run(() =>
            {
                this.Invoke(async () =>
                {
                    CroupHit();
                    await Task.Delay(200);
                    Hit();
                    await Task.Delay(200);
                    CroupHit();
                    await Task.Delay(200);
                    Hit();
                });
            });

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

            CenterAllLabels();
        }

        private void HitBtn_Click(object sender, EventArgs e)
        {
            Hit();
        }

        private async void StandBtn_Click(object sender, EventArgs e)
        {
            HitBtn.Enabled = false;
            StandBtn.Enabled = false;
            await CoupierHitsAfterStandAsync();
            CompareCount();
            NewRoundSwitchButtons();
        }

        private void Hit()
        {
            PlayingCard card = DealCard(playerCards);
            SetPlayerCard(card);
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

            CenterAllLabels();
        }

        private async void CroupHit()
        {
            await Task.Run(() =>
            {
                this.Invoke(async () =>
                {
                    PlayingCard card = DealCard(croupierCards);
                    SetCroupierCard(card);
                    await Task.Delay(500);
                });
            });

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

            CenterAllLabels();
        }

        private void InitRound()
        {
            ResetPictures();
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

        private async Task CoupierHitsAfterStandAsync()
        {
            await Task.Run(async () =>
            {
                int croupCount = CountCards(croupierCards);
                while (croupCount < 17)
                {
                    croupCount = CountCards(croupierCards);
                    CroupHit();
                    await Task.Delay(200);
                }
            });
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
            else if (p < c)
            {
                BustOrWinLabel.Text = $"Croupier have {c}. You bust down!";
            }
            else
            {
                BustOrWinLabel.Text = $"You and Croupier have the same count. Tie!";
            }

            CenterAllLabels();
        }

        private void ResetPictures()
        {
            foreach (var pic in croupCardPicBoxes)
            {
                pic.Image = null;
            }

            foreach (var pic in playerCardPicBoxes)
            {
                pic.Image = null;
            }
        }

        private void SetCroupierCard(PlayingCard card)
        {
            foreach (var c in croupCardPicBoxes)
            {
                if (c.Image == null)
                {
                    c.Image = PlayingCardsHandler.GetImageByName(card.ResourceName);
                    return;
                }
            }
        }

        private void SetPlayerCard(PlayingCard card)
        {
            foreach (var c in playerCardPicBoxes)
            {
                if (c.Image == null)
                {
                    c.Image = PlayingCardsHandler.GetImageByName(card.ResourceName);
                    return;
                }
            }
        }

        private PlayingCard DealCard(List<PlayingCard> setOfCard)
        {
            var card = cards.First();
            setOfCard.Add(card);
            cards.Remove(card);

            return card;
        }

        private void CenterLabel(Label label)
        {
            label.Location = new Point((this.ClientSize.Width - label.Width) / 2, label.Top);
        }

        private void CenterAllLabels()
        {
            CenterLabel(BustOrWinLabel);
            CenterLabel(CroupierStatusLabel);
            CenterLabel(PlayerStatusLabel);
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