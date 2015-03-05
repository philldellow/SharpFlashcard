using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharpFlashCard.Models
{
    public class GameRules
    {
        ApplicationDbContext context = new ApplicationDbContext();
        List<FlashCards> _RoundCards = new List<FlashCards>();
        Random rnd = new Random();

        //    public FlashCards RandomCardPick()
        //    {
        //        List<FlashCards> _FlashCard = new List<FlashCards>();
        //        _FlashCard.Add( new FlashCards());
        //        //int r = rnd.Next(1, 38);
        //        return _FlashCard[0];
        //    }
        //}

        public List<FlashCards> GetRound()
        {
            List<FlashCards> Deck = context.Cards.Where(f => f.Id >= 0).ToList();

            for (int i = 0; i < 10; i++)
            {
                int QAindex = rnd.Next(0, Deck.Count());

                _RoundCards = Deck.Where(f => f.Id == QAindex).ToList();
            }

            return _RoundCards;
        }

    }
}