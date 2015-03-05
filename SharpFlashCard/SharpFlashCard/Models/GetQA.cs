using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharpFlashCard.Models
{
    public class GetQA
    {
        ApplicationDbContext context = new ApplicationDbContext();
        List<FlashCards> _RoundCards = new List<FlashCards>();
        FlashCards Card;
        Random rnd = new Random();

            public FlashCards RandomCardPick()
            {
                List<FlashCards> Deck = context.Cards.Where(f => f.Id >= 0).ToList();
                int QAindex = rnd.Next(0, Deck.Count());

                Card = Deck.Where(f => f.Id == QAindex).First();

                return Card;
            }

        public List<FlashCards> GetRound()
        {
            List<FlashCards> Deck = context.Cards.Where(f => f.Id >= 0).ToList();

            for (int i = 0; i < 5; i++)
            {
                int QAindex = rnd.Next(0, Deck.Count());

                _RoundCards = Deck.Where(f => f.Id == QAindex).ToList();
            }
            return _RoundCards;
        }

    }
   
}