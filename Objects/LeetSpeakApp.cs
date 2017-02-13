using System.Collections.Generic;
using System;

namespace LeetSpeak.Objects
{
  public class LeetSpeakApp
  {
    private string _sentence;

    public void LeetSpeak(string sentence)
    {
      _sentence = sentence;
    }

    public string Translate(string sentence)
    {
      List<char> translated = new List<char>{};

      char[] array = sentence.ToCharArray();

      for (int character = 0; character < sentence.Length; character++)
      {
        if (array[character] == 'e' || array[character] == 'E')
        {
          translated.Add('3');
        }
        else
        {
          translated.Add(array[character]);
        }

      }



      string result = string.Join("", translated.ToArray());
      return result;
    }

    // public static void DeleteAll()
    // {
    //   _original.Clear();
    // }

  }
}
