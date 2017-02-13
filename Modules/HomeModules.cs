using Nancy;
using System.Collections.Generic;
using LeetSpeak.Objects;

namespace LeetSpeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/translate"] = _ => {
        string newSentence = Request.Form["new-sentence"];
        string translatedSentence = LeetSpeakApp.Translate(newSentence);
        return View["index.cshtml", translatedSentence];
      };
    }
  }
}
