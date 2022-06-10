using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryPicture
{
    class question
    {
        public string id ;
        public string txtquestion;
        public string choice1;
        public string choice2;
        public string choice3;
        public string choice4;
        public string answer;
        public string idputure;

        public question(string i,string txt,string c1,string c2,string c3,string c4,string an,string idp)
        {
            id = i;
            txtquestion = txt;
            choice1 = c1;
            choice2= c2;
            choice3= c3;
            choice4 = c4;
            answer=an;
            idputure=idp;
         }

        public string gettxtquestion()
        {
            return txtquestion;
        }
        public string getAnswer()
        {
            return answer;
        }
        public string getchoice1()
        {
            return choice1;
        }
        public string getchoice2()
        {
            return choice2;
        }
        public string getchoice3()
        {
            return choice3;
        }
        public string getchoice4()
        {
            return choice4;
        }
    }
}
