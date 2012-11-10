using System.Data.Entity;

namespace ConsoleApplication3
{
  class Program
  {
    /// <summary>
    /// Step 1: add-migration Init
    /// Step 2: update-database (on database 'TestDb')
    /// Step 3: Change connection string to point to TestDb1
    /// Step 4: update-database on TestDb1
    /// Step 5: Uncomment property Foo on class Test
    /// Step 6: add-migration M1 to add property Foo to TestDb1
    /// Step 7: Comment out Test.Foo again
    /// Step 8: Chance connection string to point to TestDb2
    /// Step 9: Exclude migration M1 from project so it doesn't get applied to TestDb2
    /// Step 10: Uncomment property Bar on class Test
    /// Step 11: update-database to apply Init migration to TestDb2
    /// Step 11: add-migration M2 to add property Bar to TestDb2
    /// Step 12: Change connection string to point to the original TestDb again
    /// Step 13: Include migration M1 into the project again
    /// Step 13: Uncomment property Foo on class Test
    /// Step 14: Uncomment property SomeInt on class Test
    /// Step 15: update-database
    /// Step 16: add-migration M3
    /// Step 17: update-database, get an error because M3 tries to add column Foo 
    /// to database TestDb which was already just added by migration M1.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
    }
  }

  public class Test
  {
    public int ID { get; set; }
    //public string Foo { get; set; }
    //public DateTime Bar { get; set; }
    //public int SomeInt { get; set; }
  }

  public class DataContext : DbContext
  {
    public IDbSet<Test> Tests { get; set; }
  }
}
