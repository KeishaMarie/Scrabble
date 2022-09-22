using System;

namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    public string Description { get; set; }
    public Scrabble(string description)
    {
      Description = description;
    }
    private Dictionary<char, int> Scores = new Dictionary<char, int>
    {
      {'A', 1}, {'B', 3}, {'C', 3},{'D', 2},
      {'E', 1}, {'F', 4}, {'G', 2}, {'H', 4},
      {'I', 1}, {'J', 8}, {'K', 5}, {'L', 1},
      {'M', 3}, {'N', 1},{'O', 1}, {'P', 3},
      {'Q', 10}, {'R', 1}, {'S', 1}, {'T', 1},
      {'U', 1}, {'V', 4}, {'W', 4}, {'X', 8},
      {'Y', 4}, {'Z', 10}
    };
    public static GetValue()
    {
      foreach (KeyValuePair<char, int> entry in Scores)
      {
        Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
      }
    }
    public static CheckScore(string userInput)
    {
      int totalScore;
      char[] uInput = userInput.ToCharArray();
      foreach (char ch in uInput)
      {
        foreach (KeyValuePair<char, int> entry in Scores)
        {
          if (ch == entry.Key)
          {
            totalScore += entry.Value;
          }
        }
      }
    }
  }
}