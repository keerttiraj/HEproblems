 public class Program
    {
        public static void Main()
        {
            string getData = Console.ReadLine();
            int start = Convert.ToInt32(getData.Split(' ')[0]);
            int end = Convert.ToInt32(getData.Split(' ')[1]);
            int divisble = Convert.ToInt32(getData.Split(' ')[2]);
            int count = 0;
            
            for (; start<= end; start++) {
              
                if ((start%divisble) ==0){
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
