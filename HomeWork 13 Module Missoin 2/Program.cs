using System.Linq;

class Program
{
    
    
    static void Main ()
    {
        string text = File.ReadAllText("Text1.txt");
        var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
       

        List<string> word = text.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
       
         var query = word.GroupBy(x => x)
              .Where(g => g.Count() > 1400)
              .Select(y => new { Element = y.Key , Counter = y.Count() })
              .ToList();

        foreach (var item in query)
        {
            Console.WriteLine(item);
        }

        
    }
}


