using System;
using System.Collections.Generic;
using System.Windows.Forms;
/// <summary>
/// GUI part of the code
/// </summary>
namespace BlackJack
{
    public partial class blackJackForm : Form
    { 
        Deck currentDeck = new Deck();
        List<Card> player = new List<Card>();
        List<Card> dealer = new List<Card>();
        int playerSum ,dealerSum, playerDealtCard, dealerDealtCard, playerScore,dealerScore;
        bool dealerTurn;
        
        public blackJackForm()
        {
            InitializeComponent();
         //   label2.Text = Convert.ToString(playerScore); // didnt work and even with refresh...
         //   label3.Text = Convert.ToString(dealerScore);
            hitBtn.Enabled = false;
            stayBtn.Enabled = false;
        }
        private void calculatePlayerHand(Card playerCards)
        {
                    playerSum += Convert.ToInt32(playerCards.Value);
        }

        private void calculateDealerHand(Card dealerCards)
        {
                    dealerSum += Convert.ToInt32(dealerCards.Value);
        }

        private bool isBusted(int sum)
        {
            if (sum > 21) // if card sum is bigger than 21 , then the person loses
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            currentDeck.shuffle();
            for (int i = 0; i < 2; i++) // adds two cards for each new game
            {
                dealer.Add(currentDeck.deal());
                player.Add(currentDeck.deal());
                dealerLB.Items.Add(dealer[i]);
                playerLB.Items.Add(player[i]);
            }

            foreach (Card playerHand in player)
            {
                calculatePlayerHand(playerHand);
            }

            foreach (Card dealerHand in dealer)
            {
                calculateDealerHand(dealerHand);
            }
 
            playerValueLbl.Text = playerSum.ToString();
            dealerValueLbl.Text = dealerSum.ToString();
            dealBtn.Enabled = false;
            hitBtn.Enabled = true;
            stayBtn.Enabled = true;
                  
        }
        private void clear()
        {
            dealerLB.Items.Clear();
            playerLB.Items.Clear();
            dealer.Clear();
            player.Clear();
            dealerValueLbl.Text = " ";
            playerValueLbl.Text = " ";
            dealerSum = 0;
            playerSum = 0;
            playerDealtCard = 2;
            dealerDealtCard = 2;
        }
        private void shuffleButton_Click(object sender, EventArgs e)
        {
            clear();
            currentDeck.shuffle();
            dealBtn.Enabled = true;          
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            
            player.Add(currentDeck.deal());
            calculatePlayerHand(player[playerDealtCard]);
            playerLB.Items.Add(player[playerDealtCard]);
            playerValueLbl.Text = playerSum.ToString();

            if (isBusted(playerSum))
            {
                MessageBox.Show("Your Hand is busted, The Dealer Wins!");
                hitBtn.Enabled = false;
                stayBtn.Enabled = false;
                dealBtn.Enabled = false;
                win(false);
            }
            playerDealtCard++;
        }

        private void win(bool winning)
        {
            if (winning == true) {
                playerScore = playerScore + 1;
                playerScoreLbl.Text = playerScore.ToString();
                    }
            if (winning == false)
            {
                dealerScore = dealerScore + 1;
                dealerScorelbl.Text = dealerScore.ToString();

            }
        }
        private void stayButton_Click(object sender, EventArgs e)
        {
            hitBtn.Enabled = false;
            stayBtn.Enabled = false;
            dealerTurn = true;
            while (dealerTurn)
            {
                if (dealerSum <= 15) // if the dealer has a sum under 15 then they must draw a card. Casino rules
                {
                    dealer.Add(currentDeck.deal());
                    calculateDealerHand(dealer[dealerDealtCard]);
                    dealerLB.Items.Add(dealer[dealerDealtCard]);
                    dealerValueLbl.Text = dealerSum.ToString();
                    dealerDealtCard++;
                    if (isBusted(dealerSum))
                    {
                        MessageBox.Show("Dealer hand is busted!");
                        win(true);
                        hitBtn.Enabled = false;
                        stayBtn.Enabled = false;
                        dealBtn.Enabled = false;
                    }
                }
                else
                {
                    dealerTurn = false;
                }
            }

            if (!isBusted(playerSum) && playerSum > dealerSum)
            {
                MessageBox.Show("Player Wins!");
                win(true);
            }
            else if (!isBusted(dealerSum) && dealerSum > playerSum)
            {
                MessageBox.Show("Dealer Wins!");
                win(false);
            }
        }
    }

    

    
}
