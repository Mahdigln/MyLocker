//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class test
{
    private  static  readonly  object _lock=new object();

    static void Main(string[] args)
    {
        for (int i = 0; i< 10;i++)
        {
            Task.Factory.StartNew(() =>
                {
                    lock (_lock)
                    {
                        File.AppendAllText(@"I:\Programming Test\MyLocker\MyLocker\lock.txt", "first");
                        Thread.Sleep(1000);
                        File.AppendAllText(@"I:\Programming Test\MyLocker\MyLocker\lock.txt", "Second");

                    }
                }

            );
        }
        Console.ReadKey();
    }
}


