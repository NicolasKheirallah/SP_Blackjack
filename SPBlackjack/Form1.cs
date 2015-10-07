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
        int playerValue ,dealerValue, playerDealtCard, dealerDealtCard, playerScore,dealerScore;
        bool dealerTurn, bustedPlayer,bustedDealer;
        
        public blackJackForm()
        {
            InitializeComponent();
            //   label2.Text = Convert.ToString(playerScore); // didnt work and even with refresh...
            //   label3.Text = Convert.ToString(dealerScore);
            currentDeck.shuffle(); // shuffles the deck
            hitBtn.Enabled = false;
            stayBtn.Enabled = false;
        }
        /// <summary>
        /// calculate the size of the players hand , checks that the hand isnt to big
        /// </summary>
        /// <param name="playerCards"></param>
        private void calculatePlayerHand(Card playerCards)
        {
            playerValue += Convert.ToInt32(playerCards.Value);
            if (isBusted(playerValue))
            { 
                bustedPlayer = true;
            }
        }
        /// <summary>
        /// calcualtes the value and checks that it doesnt go over 21
        /// </summary>
        /// <param name="dealerCards"></param>
        private void calculateDealerHand(Card dealerCards)
        {
            dealerValue += Convert.ToInt32(dealerCards.Value);
            if(isBusted(dealerValue))
            {
                bustedDealer = true;
            }
        }
        /// <summary>
        /// Checks that the value isnt over 21
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Deal button , deals two hands and puts them in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dealButton_Click(object sender, EventArgs e)
        {
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

            playerValueLbl.Text = playerValue.ToString();
            dealerValueLbl.Text = dealerValue.ToString();
            dealBtn.Enabled = false;
            hitBtn.Enabled = true;
            stayBtn.Enabled = true;
            checkValue();
        }
        /// <summary>
        /// resets everything
        /// </summary>
        private void clear() 
        {
            dealer.Clear();
            player.Clear();
            dealerLB.Items.Clear();
            playerLB.Items.Clear();
            dealerValueLbl.Text = " ";
            playerValueLbl.Text = " ";
            dealerValue = 0;
            playerValue = 0;
            playerDealtCard = 2;
            dealerDealtCard = 2;
        }

        /// <summary>
        /// clean , shuffle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shuffleButton_Click(object sender, EventArgs e)
        {
            clear();
            currentDeck.shuffle();
            dealBtn.Enabled = true;          
        }

        private void checkValue()
        {
            if (isBusted(playerValue)|| bustedPlayer == true)
            {
                MessageBox.Show("Your Hand is busted, The Dealer Wins!");
                win(false);
                hitBtn.Enabled = false;
                stayBtn.Enabled = false;
                dealBtn.Enabled = false;
                bustedPlayer = false;
            }
           if (isBusted(dealerValue)||bustedDealer == true)
            {
                MessageBox.Show("Dealer hand is busted,You Wins!");
                win(true);
                bustedDealer = false;
                hitBtn.Enabled = false;
                stayBtn.Enabled = false;
                dealBtn.Enabled = false;
            }


        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            player.Add(currentDeck.deal());
            calculatePlayerHand(player[playerDealtCard]);
            playerLB.Items.Add(player[playerDealtCard]);
            playerValueLbl.Text = playerValue.ToString();
            checkValue();
            playerDealtCard++;
        }
        /// <summary>
        /// Yup winning , increase score with +1 
        /// </summary>
        /// <param name="winning"></param>

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
        /// <summary>
        /// Stay button == No more cards for you
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stayButton_Click(object sender, EventArgs e)
        {
            hitBtn.Enabled = false;
            stayBtn.Enabled = false;
            dealerTurn = true;
            while (dealerTurn)
            {
                if (dealerValue <= 15) // if the dealer has a sum under 15 then they must draw a card. Casino rules
                {
                    dealer.Add(currentDeck.deal());
                    calculateDealerHand(dealer[dealerDealtCard]);
                    dealerLB.Items.Add(dealer[dealerDealtCard]);
                    dealerValueLbl.Text = dealerValue.ToString();
                    dealerDealtCard++;
                    checkValue();
                }
                else
                {
                    dealerTurn = false;
                }
            }

            if (!isBusted(playerValue) && playerValue > dealerValue)
            {
                MessageBox.Show("Player Wins This Round!");
                win(true);
            }
            else if (!isBusted(dealerValue) && dealerValue > playerValue)
            {
                MessageBox.Show("Dealer Wins This Round!");
                win(false);
            }
            else if(!isBusted(dealerValue) && dealerValue  == playerValue)
            {
                MessageBox.Show("Dealer Wins This Round!");
                win(false);
            }
        }
    }

    

    
}
