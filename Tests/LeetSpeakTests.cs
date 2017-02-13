using Xunit;
using LeetSpeak.Objects;
using System;
using System.Collections.Generic;

namespace LeetSpeak
{
  public class LeetSpeakTest : IDisposable
  {
    [Fact]
    public void Translate_displayWord_string()
    {
      LeetSpeakApp testString = new LeetSpeakApp();
      List<string> expectedResult = new List<string>{"map"};
      Assert.Equal(expectedResult, testString.Translate("map"));
    }




    public void Dispose()
    {
      LeetSpeakApp.DeleteAll();
    }
  }
}
