using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharpFlashCard.Models
{
    public class GameRules
    {
        Random rnd = new Random();
        public FlashCards RandomCardPick()
        {
            List<FlashCards> _FlashCard = new List<FlashCards>();
            int r = rnd.Next(1, 39);
            return _FlashCard[r];
        }
    }
}