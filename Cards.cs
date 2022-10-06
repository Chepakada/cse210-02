using System;

namespace London_Jack{

    public class Cards{

        public int value= 0;
        public int points = 0;

        public string Choice = "";

        public int value2 = 0;


        

        public Cards(){


        }
        //public  static first_draw(){
        public void first_draw(){
            Random random = new Random();
            value = random.Next(1, 14);
        }  
        //}
        ///<summary>
        ///Construct first distribution of Card
        ///</summary>
        public void Play(){
            

            Random random1 = new Random();
            value2 = random1.Next(1, 14);


            if (value2 < value && Choice == "l" ||value2 > value && Choice == "h" ){
                points += 100;
            }
            else 
            points += -75;


        }
    }
} 
