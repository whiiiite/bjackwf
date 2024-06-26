namespace WFBlackjack;
public partial class Form1 : Form
{
    const int standartDelayMs = 300;

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
                await Task.Delay(standartDelayMs);
                Hit();
                await Task.Delay(standartDelayMs);
                CroupHit();
                await Task.Delay(standartDelayMs);
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
        CompareCountAndSetInfo();
        NewRoundSwitchButtons();
    }

    /// <summary>
    /// Hit of user(take a card)
    /// </summary>
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

    /// <summary>
    /// Hit of bot(take a card)
    /// </summary>
    private void CroupHit()
    {
        PlayingCard card = DealCard(croupierCards);
        card.IsReversed = croupierCards.Count == 2;
        SetCroupierCard(card);

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

    /// <summary>
    /// Initalize the round of game
    /// </summary>
    private void InitRound()
    {
        ResetPictures();
        playerCards = new List<PlayingCard>();
        croupierCards = new List<PlayingCard>();
        cards = PlayingCardsHandler.GetSetOfCards();
        PlayingCardsHandler.Shuffle(cards);
        BustOrWinLabel.Text = string.Empty;
    }

    /// <summary>
    /// Switch buttons enable after round ended or didnt started
    /// </summary>
    private void NewRoundSwitchButtons()
    {
        HitBtn.Enabled = false;
        StandBtn.Enabled = false;
        StartBtn.Enabled = true;
    }

    /// <summary>
    /// Switch buttons enable after round started
    /// </summary>
    private void RoundSwitchButtons()
    {
        HitBtn.Enabled = true;
        StandBtn.Enabled = true;
        StartBtn.Enabled = false;
    }

    /// <summary>
    /// Bot make hits to try win user
    /// </summary>
    /// <returns></returns>
    private async Task CoupierHitsAfterStandAsync()
    {
        PlayingCard secondCard = croupierCards[1];
        ReverseReversedCard(secondCard);
        await Task.Delay(standartDelayMs);

        int croupCount = CountCards(croupierCards);
        int playerCount = CountCards(playerCards);

        CroupierStatusLabel.Text = $"Croupier count: {croupCount}";

        if (croupCount > playerCount)
        {
            return;
        }

        while (croupCount < 17)
        {
            croupCount = CountCards(croupierCards);

            if (croupCount > playerCount)
            {
                return;
            }

            CroupHit();
            await Task.Delay(standartDelayMs);
        }
    }

    /// <summary>
    /// Compares the counts of bot and user then put the text to label
    /// </summary>
    private void CompareCountAndSetInfo()
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

    /// <summary>
    /// Revese card that was reversed(second card of croupier)
    /// </summary>
    /// <param name="card"></param>
    private void ReverseReversedCard(PlayingCard card)
    {
        if (!card.IsReversed) return;

        card.IsReversed = false;
        croupCardPicBoxes[1].Image = PlayingCardsHandler.GetImageByName(card.ResourceName);
    }

    /// <summary>
    /// Just resets pictures
    /// </summary>
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

    /// <summary>
    /// Set images to table of bot cards
    /// </summary>
    /// <param name="card"></param>
    private void SetCroupierCard(PlayingCard card)
    {
        if (croupierCards.Count == 2)
        {
            croupCardPicBoxes[1].Image = PlayingCardsHandler.GetImageByName("card_back_red");
            return;
        }

        foreach (var c in croupCardPicBoxes)
        {
            if (c.Image == null)
            {
                c.Image = PlayingCardsHandler.GetImageByName(card.ResourceName);
                return;
            }
        }
    }

    /// <summary>
    /// Set images to table of user cards
    /// </summary>
    /// <param name="card"></param>
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

    /// <summary>
    /// Gives 1 card to set
    /// </summary>
    /// <param name="setOfCard"></param>
    /// <returns>Given playing card</returns>
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

    /// <summary>
    /// Center all main labels
    /// </summary>
    private void CenterAllLabels()
    {
        CenterLabel(BustOrWinLabel);
        CenterLabel(CroupierStatusLabel);
        CenterLabel(PlayerStatusLabel);
    }

    /// <summary>
    /// Counts set values of cards
    /// </summary>
    /// <param name="cards"></param>
    /// <returns></returns>
    private int CountCards(List<PlayingCard> cards)
    {
        int count = 0;
        int aceCount = 0;

        foreach (var card in cards)
        {
            if(card.IsReversed && cards.Count == 2)
            {
                continue;
            }

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