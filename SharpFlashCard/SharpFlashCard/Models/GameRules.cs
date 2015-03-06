using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharpFlashCard.Models
{
    public class GameRules
    {
                //public bool IsCorrect
        //{
        //    get { return answer == cardAnswer; }
        //}
        GetQA getQA = new GetQA();

        public string answer;
        public string cardAnswer;
        public string question;
        FlashCards card;
        private readonly String _response = "";

        public GameRules(string A, string CA)
        {
            answer = A;
            cardAnswer = CA;
            if (answer != "")
            {
                if (answer.ToLower() == cardAnswer.ToLower())
                { _response = "Good Job"; }
                else { _response = "Oops you got it Wrong"; }
            }
        }

        public String Response
        {
            get {return _response; }
         }

        public FlashCards Card()
        {
            card = getQA.RandomCardPick();
            cardAnswer = card.Answer;
            question = card.Question;
            return card;
        }

    }
    
}