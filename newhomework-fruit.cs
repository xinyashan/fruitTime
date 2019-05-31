using System;

namespace HWFRUIT
{


    public class ninjafruit
    {

        public string _ninjafruit { set; get; }
        public string _holyninjamagic { set; get; }


        public ninjafruit(string ninjafruit, string holyninjamagic)
        {
            _ninjafruit = ninjafruit;
            _holyninjamagic = holyninjamagic;
            Console.WriteLine("Use your ninja powers to continue this mission! Remember each fruit represents different power!");



        }
        public void usemagic(int magicpowerused)
        {
            for (int i = 0; i < magicpowerused; i++)
            {
                Console.WriteLine("The user has used {0}");
                Console.WriteLine("Warning! If you use this magical power move your health will be damaged too! It is about {0}!", _holyninjamagic);


            }



        }

        // The end of the usepower method!!!! 


    }
}