 public class Program
    {
        public static void Main()
        {
            int step;
            int length = Convert.ToInt32(Console.ReadLine());
            int sequence = Convert.ToInt32(Console.ReadLine());
            for (step = 0; step < sequence; step++)
            {
                string getWidthHeight = Console.ReadLine();
                int width = Convert.ToInt32(getWidthHeight.Split(' ')[0]);
                int height = Convert.ToInt32(getWidthHeight.Split(' ')[1]);
                if ((width >= length) && (height >= length))
                {
                    if ((width == height))
                    {
                        Console.WriteLine("ACCEPTED");
                    }
                    else
                    {
                        Console.WriteLine("CROP IT");
                    }
                }
                else
                {
                    Console.WriteLine("UPLOAD ANOTHER");
                }
            }
        }
    }
