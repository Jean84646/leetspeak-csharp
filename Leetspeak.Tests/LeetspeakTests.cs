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
    [TestMethod]
    public void IsSReplaceByz_True()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      string sentence = "SsS";
      string leetSentence = "Szz";
      string translated = testLeetspeak.Translate(sentence);
      Console.WriteLine(translated);
      bool isLeet = (translated.Equals(leetSentence));
      Assert.AreEqual(true, isLeet);
    }
    [TestMethod]
    public void FinalTest_True()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      string sentence = "Don't you love these 'String' exercises? I do!";
      string leetSentence = "D0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0!";
      string translated = testLeetspeak.Translate(sentence);
      Console.WriteLine(translated);
      bool isLeet = (translated.Equals(leetSentence));
      Assert.AreEqual(true, isLeet);
    }
  }
}
