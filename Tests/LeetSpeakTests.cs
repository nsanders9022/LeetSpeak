using Xunit;
using LeetSpeak.Objects;
using System;
using System.Collections.Generic;

namespace LeetSpeak
{
  public class LeetSpeakTest
  {
    [Fact]
    public void Translate_displayWord_string()
    {
      LeetSpeakApp testString = new LeetSpeakApp();
      Assert.Equal("map", testString.Translate("map"));
    }



    //
    // public void Dispose()
    // {
    //   LeetSpeakApp.DeleteAll();
    // }
  }
}
