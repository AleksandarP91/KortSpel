using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KortSpel
{
    public partial class Form1 : Form
    {
      public static int[] cards = new int[52];

        public Form1()
        {
            

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            card.SizeMode = PictureBoxSizeMode.StretchImage;
            deck.SizeMode = PictureBoxSizeMode.StretchImage;



            for (int i = 1; i < 52; i++)
            {
                cards[i] = i;
            }
        }

        private void deck_Click(object sender, EventArgs e)
        {

            if (cards.Length > 0)
            {
                card.Image = Image.FromFile(@"..\..\images\" + cards.Last() + ".png");
                cards = cards.Reverse().Skip(1).Reverse().ToArray();
            }
            else
            { 
                 MessageBox.Show("No more cards in the deck!");
                 
            }

        }

        private void Mix_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            List<int> cardsMix = cards.ToList();
            for (int i = 0; i<cards.Length; i++)
            { 
                int card = cardsMix[r.Next(0, cards.Length)];
                cardsMix.RemoveAt(cardsMix.IndexOf(card));
                cardsMix.Add(card);
            }
            cards = cardsMix.ToArray();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            Array.Sort(cards);
        }

        
    }
}
