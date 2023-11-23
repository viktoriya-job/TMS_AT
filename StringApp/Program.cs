using System;
using System.Text;
using System.Globalization;

namespace StringApp
{
    static class Program
    {
        private static void Main1(string[] args)
        {


            // The string below contains combining characters.
            String s = "a\u0304\u0308bc\u0327";

            // Show each 'character' in the string.
            EnumTextElements(s);

            // Show the index in the string where each 'character' starts.
            EnumTextElementIndexes(s);


            // Show how to enumerate each real character (honoring surrogates) in a string.
            static void EnumTextElements(String s)
            {
                // This StringBuilder holds the output results.
                StringBuilder sb = new StringBuilder();

                // Use the enumerator returned from GetTextElementEnumerator
                // method to examine each real character.
                TextElementEnumerator charEnum = StringInfo.GetTextElementEnumerator(s);
                while (charEnum.MoveNext())
                {
                    sb.AppendFormat(
                      "Character at index {0} is '{1}'{2}",
                      charEnum.ElementIndex, charEnum.GetTextElement(),
                      Environment.NewLine);
                }

                // Show the results.
                Console.WriteLine("Result of GetTextElementEnumerator:");
                Console.WriteLine(sb);
            }

            // Show how to discover the index of each real character (honoring surrogates) in a string.
            static void EnumTextElementIndexes(String s)
            {
                // This StringBuilder holds the output results.
                StringBuilder sb = new StringBuilder();

                // Use the ParseCombiningCharacters method to
                // get the index of each real character in the string.
                Int32[] textElemIndex = StringInfo.ParseCombiningCharacters(s);

                // Iterate through each real character showing the character and the index where it was found.
                for (Int32 i = 0; i < textElemIndex.Length; i++)
                {
                    sb.AppendFormat(
                       "Character {0} starts at index {1}{2}",
                       i, textElemIndex[i], Environment.NewLine);
                }

                // Show the results.
                Console.WriteLine("Result of ParseCombiningCharacters:");
                Console.WriteLine(sb);

            }

            string testString = "Тестовая строка";
            int[] arrayOfIndexes = StringInfo.GetTextElementEnumerator(testString);



                //// Declare without initializing.
                //string message1;

                //// Initialize to null.
                //string message2 = null;

                //// Initialize as an empty string.
                //// Use the Empty constant instead of the literal "".
                //string message3 = System.String.Empty;

                //// Initialize with a regular string literal.
                //string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";
                //Console.WriteLine(oldPath);

                //// Initialize with a verbatim string literal.
                //string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";
                //Console.WriteLine(newPath);

                //// Difference
                //string filePath = @"C:\Users\scoleridge\Documents\""Test""\";
                //string filePath1 = "C:\\Users\\scoleridge\\Documents\\\"Test\"";

                //// Use System.String if you prefer.
                //System.String greeting = "Hello World!";

                //// In local variables (i.e. within a method body)
                //// you can use implicit typing.
                //var temp = "I'm still a strongly-typed System.String!";

                //// Use a const string to prevent 'message4' from
                //// being used to store another string value.
                //const string message4 = "You can't get rid of me!";

                //// Use the String constructor only when creating
                //// a string from a char*, char[], or sbyte*. See
                //// System.String documentation for details.
                //char[] letters = { 'A', 'B', 'C' }; 
                //string alphabet = new string(letters);

                //Console.WriteLine(alphabet);

                //string s1 = "hello";
                //string s2 = new String('a', 6); // результатом будет строка "aaaaaa"
                //string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
                //string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3); // orl

                //Console.WriteLine(s1);  // hello
                //Console.WriteLine(s2);  // aaaaaaa
                //Console.WriteLine(s3);  // world
                //Console.WriteLine(s4);  // orl

                //string msg1 = "hello";
                //string msg2 = "hello";

                //Console.WriteLine(msg1 == msg2);
                //Console.WriteLine(msg1.Equals(msg2));
                //Console.WriteLine(msg1[0]);

                //foreach (char c in msg1)
                //{
                //    Console.WriteLine(c);
                //}

                //string s11 = "A string is more ";
                //string s21 = "than the sum of its chars.";

                //string text = """
                //  <element attr="content">
                //    <body>
                //    </body>
                //  </element>
                //  """;
                //Console.WriteLine(text);

                //int val = 10;
                //string text_inter = $"""
                //              <element attr="content">
                //                <body>
                //                {val}
                //                </body>
                //              </element>
                //              """;
                //string text1 = "<element attr=\"content\">" +
                //               "<body>" +
                //               "</body>" +
                //               "</element>";
                //Console.WriteLine(text);
                //Console.WriteLine(text_inter);
                //Console.WriteLine(text1);

            }
    }
}
