//You read a single line of ASCII symbols, and the message is somewhere inside it, you must find it.
// The input consists of three parts separated with "|" like this:
//"{firstPart}|{secondPart}|{thirdPart}"
//Each word starts with a capital letter and has a fixed length,
//you can find those in each different part of the input.
//The first part carries the capital letters for each word inside the message.
//You need to find those capital letters 1 or more from A to Z.
//The capital letters should be surrounded from both sides with any of the following symbols – "#, $, %, *, &".
//And those symbols should match on both sides.
//This means that $AOTP$ - is a valid pattern for the capital letters.
//$AKTP% - is invalid since the symbols do not match.
//The second part of the data contains the starting letter ASCII code and words length /between 1 – 20 characters/,
//in the following format: "{asciiCode}:{length}".
//For example, "67:05" – means that '67' - ASCII code equal to the capital letter "C",
//represents a word starting with "C" with the following 5 characters: like "Carrot".
//The ASCII code should be a capital letter equal to a letter from the first part.
//Word's length should be exactly 2 digits. Length less than 10 will always have a padding zero, you don't need to check that. 
//The third part of the message are words separated by spaces.
//Those words have to start with the Capital letter [A…Z] equal to the ASCII code
//and have exactly the length for each capital letter you have found in the second part.
//Those words can contain any ASCII symbol without spaces.
//When you find a valid word, you have to print it on a new line.


using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

internal class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('|');
        char[] capitalLetters = GetCapitalLetters(input[0]);
        Dictionary<char, int> wordLengthsByFirstLetter = GetWordLengths(input[1], capitalLetters);
        List<string> extractedWords = ExtractValidWords(input[2], wordLengthsByFirstLetter);

        for (int i = 0; i < capitalLetters.Length; i++)
            Console.WriteLine(extractedWords.Find(x => x[0] == capitalLetters[i]));        
    }

    private static List<string> ExtractValidWords(string inputText, Dictionary<char, int> wordLengthsByFirstLetter)
    {
        string[] allWords = inputText.Split();
        List<string> validWords = new List<string>();
        foreach (string word in allWords)
        {
            char firstLetter = word[0];
            if (wordLengthsByFirstLetter.ContainsKey(firstLetter)
                && wordLengthsByFirstLetter[firstLetter] == word.Length)
            {
                validWords.Add(word);
            }
        }
        return validWords;
    }

    private static Dictionary<char, int> GetWordLengths(string inputText, char[] capitalLetters)
    {
        var wordLengthsByFirstLetter = new Dictionary<char, int>();

        string regex = @"(?<ascii>[\d]{2}):(?<length>[\d]{2})";
        MatchCollection matches = Regex.Matches(inputText, regex);

        foreach (Match match in matches)
        {
            char asciiSymbol = (char)int.Parse(match.Groups["ascii"].Value);
            int length = 1 + int.Parse(match.Groups["length"].Value);

            if (capitalLetters.Contains(asciiSymbol))
            {
                if (wordLengthsByFirstLetter.ContainsKey(asciiSymbol))
                    wordLengthsByFirstLetter[asciiSymbol] = length;
                else
                    wordLengthsByFirstLetter.Add(asciiSymbol, length);
            }
        }
        return wordLengthsByFirstLetter;
    }

    private static char[] GetCapitalLetters(string inputText)
    {
        string regex = @"([#$%*&])(?<capitalChars>[A-Z]+)\1";
        MatchCollection match = Regex.Matches(inputText, regex);
        string regexResult = String.Empty;
        for (int i = 0; i < match.Count; i++)
        {
            regexResult += match[i].Groups["capitalChars"].Value;
        }

        return regexResult.ToCharArray();
    }
}