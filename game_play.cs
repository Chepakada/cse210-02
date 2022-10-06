using System;

namespace London_Jack // Note: actual namespace depends on the project name.
{
    ///<summary>
    ///
    ///The responsibliltiy of Game_Play is to control the sequence fo play.
    ///</summary>
    
     public class Game_play{

        List<Cards> _card = new List<Cards>();

        bool _isPlaying = true;

        int _score = 0;
        int _finalScore = 300;
        
        string _value = "";


        ///<summary>
        /// Constructs a new instance of Game_play 
        ///</summary>

        public Game_play(){
            Cards card = new Cards();
                _card.Add(card);

        }
        public void StartGame(){
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();

            }
        }
            /// <summary>
            /// Asks the user if they want to play
            /// </summary>

        public void GetInputs()
        {   foreach (Cards card in _card){
                card.first_draw();
                    _value = $"{card.value}";
        }
            Console.WriteLine($"Your first card is {_value}");
            Console.Write($"Higher or lower? [h/l]");
            string choice= Console.ReadLine();
            _isPlaying = (choice.ToLower() == "h" || choice == "l");
            //Cards.Choice = $"{choice}";
            Cards choice1 = new Cards();
            choice1.Choice= choice;

        }
     


        ///<summary>
        /// Updates the player's score
        ///</summary>

        public void DoUpdates()
        {
            if (!_isPlaying){
                return;
            }

            _score =0;
            foreach (Cards card in _card){
                card.first_draw();
                 card.Play();
                _score = card.points;
            }
            _finalScore += _score;
        }

        /// <summary>
        /// Displays the card and the score. Also asks player if he wants to play again
        /// </summary>

        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;

            }
            //foreach (Cards card in Cards){
                
            //}
            string value = "";
            string value2 = "";

            foreach (Cards card in _card){
                value = $"{card.value}";
                value2 = $"{card.value2}";
            }

            

            Console.WriteLine($"Next Card was:{value2}");
            Console.WriteLine($"Your score is: {_finalScore}\n");
            _isPlaying = (_score<=0);
        }



    }

}
