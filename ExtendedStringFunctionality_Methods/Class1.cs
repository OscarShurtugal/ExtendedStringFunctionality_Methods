using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedStringFunctionality_Methods
{
    public class ExtendedStringMethods
    {


        /// <summary>
        /// This method returns the last line find in a given text. 
        /// It's expected behaviour is to work with clipboard like variables while working with DOS Consoles or Unix consoles texts.
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns>String with the last line found in that text</returns>
        public string getLastLineFromVariable(string inputText)
        {

            inputText=inputText.Trim();
            inputText=inputText.TrimEnd();
            int countOfLines = inputText.Split('\n').Count();

            string lastLine = "";

            if (inputText.Split('\n').Last()==""||inputText.Split('\n').Last()==null||inputText.Split('\n').Last()==" ")

                lastLine=inputText.Split('\n').Last();
            else
                lastLine=inputText.Split('\n').ElementAt(countOfLines-1);

            return lastLine;
        }


        //This is just the modified date to keep track of the updates when using it on another program. It's going to expose it as a void method
        public void ModifiedDate20200323(){
            }
    }
}
