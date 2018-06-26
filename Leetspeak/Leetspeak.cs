using System.Text;
using System;

namespace Leetspeak
{
  public class Leetspeak
  {
    public string Translate(string sentence)
    {
      string result = "";
      string[] words = sentence.Split(' ');
      foreach (string word in words)
      {
        if(word[0].Equals('\''))
        {
          result = result + " \'" + TranslateWord(word.Remove(0,1));
        }
        else
        {
          result = result + " " + TranslateWord(word);
        }
      }
      return result.Remove(0,1);
    }

    private string TranslateWord(string word)
    {

      string translated = word.Replace("e", "3");
      translated = translated.Replace("E", "3");
      translated = translated.Replace("o", "0");
      translated = translated.Replace("O", "0");
      translated = translated.Replace("I", "1");
      translated = translated.Replace("T", "7");
      translated = translated.Replace("t", "7");

      char startWith = word[0];
      translated = translated.Replace("S", "z");
      translated = translated.Replace("s", "z");
      if(startWith.Equals('S') || startWith.Equals('s'))
      {
        StringBuilder sb = new StringBuilder(translated);
        sb[0] = startWith;
        translated = sb.ToString();
      }
      return translated;
    }
  }
}
