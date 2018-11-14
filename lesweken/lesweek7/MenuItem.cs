// Class definition.
   public class MenuItem
   {
      // Class members.
      private int prijs;
      private string product;
      private string eenheid;

      // Property.
      public int Number { get; set; }
      
      public int Prijs { get; set; }




      // Method.
      public int Multiply(int num)
      {
          return num * Number;
      }

      // Instance Constructor.
      public MenuItem()
      {
          Number = 0;
      }
   }