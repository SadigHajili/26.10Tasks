using System;

class Program
{
    static void Main() {
      int i, s = 0;

		for (i = 1; i <= 10; i++)
		{
			s = s + i;
		}
		Console.WriteLine("The Sum is:" + s);
    }
}