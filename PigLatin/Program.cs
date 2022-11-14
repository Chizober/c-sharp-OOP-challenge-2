using System;
using System.Text.RegularExpressions;
namespace PigLatin{
  class PigLatinClass
{
  public  string ToPigLatin(string words)
  {
 List<string> pigLatin =new List<string>();

 foreach(string word in words.Split(" "))
 {
  if (Regex.IsMatch(word, @"[a-zA-Z]$"))
  {
   pigLatin.Add( word.Substring(1) + word[0] + "ay");
   } else
  {
    pigLatin.Add(word.ToString());
  }
 }
return string.Join(" ", pigLatin);
 }
}
class ToEnglish
{
   public string FromPig(string words)
  {
List<string> pigLatin =new List<string>();

 foreach(string word in words.Split(" "))
 {
  if (Regex.IsMatch(word, @"[a-zA-Z]$"))
  {
    pigLatin.Add(word.Substring(0) + word.Substring(word.Length));
   } else
  {
    pigLatin.Add(word.ToString());
  }
 }
return string.Join(" ", pigLatin);
 }
}
class Answers
{
  static void Main(string[] args)
  {
    string words;
    Console.WriteLine("Enter a word, phrase or a sentence");
    words = Console.ReadLine();
    // Console.ReadKey();
    PigLatinClass pig  = new PigLatinClass();
    string pigLatin = pig.ToPigLatin(words);
    Console.WriteLine(pigLatin);
    Console.WriteLine("Press Enter to change back to English");
    Console.ReadKey(true);
      ToEnglish eng  = new ToEnglish();
    pigLatin = eng.FromPig(words);
    Console.WriteLine(pigLatin);
    
  }
  }
}
;
