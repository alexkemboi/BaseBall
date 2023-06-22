using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        bool baseballIsRunning=true;
        ScoreTracker tracker = new ScoreTracker();
        while (baseballIsRunning)
        {
            Console.WriteLine("Welcome to Baseball");
            Console.WriteLine("Choose the operation to perform");
            Console.WriteLine("1:Add Score");
            Console.WriteLine("2:Remove Score");
            Console.WriteLine("3:view Score");
            Console.WriteLine("4:Clear Scores");
            int choice= int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    tracker.AddScore();
                    break;
                case 2:
                    tracker.RemoveScore();
                    break;
                case 3:
                    tracker.ViewScore();
                    break;
                case 4:
                    tracker.ClearScore();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
        }

    }
}
public class ScoreTracker
{
    public List<int> record;
    public ScoreTracker()
    {
        record = new List<int>();
    }
    public  void AddScore()
    {
        Console.WriteLine("Enter a score eg 1-10,+,D,C"); ;
        int score = int.Parse(Console.ReadLine());
        record.Add(score);
    }
    public  void RemoveScore()
    {
        Console.WriteLine("Kindly input an index to remove score");
        int index= int.Parse(Console.ReadLine());
        if (index < record.Count&&index>=0)
        {
            record.RemoveAt(index);
        }
    }
    public  void ViewScore()
    {
        foreach(int i in record)
        {
            Console.WriteLine("Score:"i);
        }
      
    }
    public  void ClearScore()
    {
            record.Clear();
     }
        
}