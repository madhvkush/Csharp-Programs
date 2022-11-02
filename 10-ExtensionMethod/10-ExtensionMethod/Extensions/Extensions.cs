using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ExtensionMethod.Extensions
{
    //REf:- https://www.c-sharpcorner.com/UploadFile/3d39b4/extension-method-in-C-Sharp/
    //REf:- http://www.tutorialsteacher.com/csharp/csharp-extension-method
    static class Extensions
    {

        /// <summary>
        /// <para>Counts only Word (no special word count)</para>
        /// <para>Note:- this would be applicable on Strings</para>
        /// </summary>
        /// <param name="Str">string</param>
        /// <returns></returns>
        public static int WordCount(this string Str) // call with string types
        {
            string[] userString = Str.Split(new char[] { ' ', '.', '?' },
                                       StringSplitOptions.RemoveEmptyEntries);
            int wordCount = userString.Length;
            return wordCount;
        }

        /// <summary>
        /// <para>Check Greater than</para>
        /// <para>Note:- this would be applicable on doubles</para>
        /// </summary>
        /// <param name="a">Number to be check</param>
        /// <param name="b">Greater than from </param>
        /// <returns></returns>
        public static bool IsGreaterThan(this double a, double b) // call with double data types
        {
            return a > b;
        }
    }
}
