using System.Collections.Generic;
using System;

namespace LeetSpeak.Objects
{
  public class LeetSpeakApp
  {
    private string _sentence;
    private static List<string> _original = new List<string>{};
    // private static List<string> _translated = new List<string>{};

    public void LeetSpeak(string sentence)
    {
      _sentence = sentence;
      _original.Add(sentence);
    }

    public List<string> Translate(string sentence)
    {
      List<string> translated = new List<string>{};
      translated.Add(sentence);
      return translated;
    }

    public static void DeleteAll()
    {
      _original.Clear();
    }

  }
}
