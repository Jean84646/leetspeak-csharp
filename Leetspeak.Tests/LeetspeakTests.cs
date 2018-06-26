using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;
using System;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTest
  {
    [TestMethod]
    public void IsEReplaceBy3_True()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      string sentence = "lEe";
      string leetSentence = "l33";
      string translated = testLeetspeak.Translate(sentence);
      Console.WriteLine(translated);
      bool isLeet = (translated.Equals(leetSentence));
      Assert.AreEqual(true, isLeet);
    }
    [TestMethod]
    public void IsOReplaceBy0_True()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      string sentence = "bOo";
      string leetSentence = "b00";
      string translated = testLeetspeak.Translate(sentence);
      Console.WriteLine(translated);
      bool isLeet = (translated.Equals(leetSentence));
      Assert.AreEqual(true, isLeet);
    }
    [TestMethod]
    public void IsIReplaceBy1_True()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      string sentence = "Ii";
      string leetSentence = "1i";
      string translated = testLeetspeak.Translate(sentence);
      Console.WriteLine(translated);
      bool isLeet = (translated.Equals(leetSentence));
      Assert.AreEqual(true, isLeet);
    }
    [TestMethod]
    public void IsTReplaceBy7_True()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      string sentence = "Tt";
      string leetSentence = "77";
      string translated = testLeetspeak.Translate(sentence);
      Console.WriteLine(translated);
      bool isLeet = (translated.Equals(leetSentence));
      Assert.AreEqual(true, isLeet);
    }
  }
}
