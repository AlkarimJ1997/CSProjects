namespace ThreadingDemo
{
    public static class Program
    {
        // ----- FUNCTIONS -----

        private static void Print1()
        {
            for (var i = 0; i < 1000; i++) Console.Write(1);
        }

        private static void CountTo(int max)
        {
            for(var i = 0; i <= max; i++) Console.WriteLine(i);
        }

        // ----- END OF FUNCTIONS -----
        public static void Main(string[] args)
        {
            #region Basic Threading

            // Thread t = new Thread(Print1);
            //
            // t.Start();
            //
            // for (int i = 0; i < 1000; i++) Console.Write(0);

            #endregion

            #region Thread.Sleep

            // Thread.Sleep
            // int num = 1;
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(num);
            //     Thread.Sleep(1000);
            //     num++;
            // }
            // Console.WriteLine("Thread Ends");

            #endregion

            #region Thread Locking

            // BankAccount account = new BankAccount(10);
            // Thread.CurrentThread.Name = "main";
            // Thread[] threads = Enumerable.Repeat(0, 15).Select(i => new Thread(new ThreadStart(account.IssueWithdraw))
            // {
            //     Name = i.ToString()
            // }).ToArray();
            //
            // foreach (var t in threads)
            // {
            //     Console.WriteLine($"Thread {t.Name} Alive: {t.IsAlive}");
            //     t.Start();
            // }
            //
            // // Thread Priority
            // Console.WriteLine($"Current Priority: {Thread.CurrentThread.Priority}");
            // Console.WriteLine($"Thread {Thread.CurrentThread.Name} Ending");

            #endregion
            
            #region Passing Thread Parameters
            
            Thread t = new Thread(() => CountTo(10));
            t.Start();
            
            // MultiLine Lambdas
            new Thread(() =>
            {
                CountTo(5);
                CountTo(6);
            }).Start();

            #endregion
        }
    }
}