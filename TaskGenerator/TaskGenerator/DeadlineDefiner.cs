using System;

namespace TaskGenerator
{
    class DeadlineDefiner
    {
        private static double defaultTime = 2;
        private static bool isFirstTime = true;

        public static double DefineDeadline(TaskGenerator selected)
        {
            if (selected.Difficulty == 5 && isFirstTime)
            {
                defaultTime = 1.5;
            }
            isFirstTime = false;
            return selected.Difficulty * defaultTime;
        }

        public static void StartTime(double deadline)
        {
            var Deadline = DateTime.Now.AddSeconds(deadline);
            Console.WriteLine(Deadline.Hour + " saat" + " " + Deadline.Minute + " deqiqe" + " " + Deadline.Second + " saniye" + " " + "sonra deadline bitir");

            while (DateTime.Now < Deadline)
            {
                string done = Console.ReadLine();
                if (done == "Done")
                {
                    break;
                }
            }
            if (DateTime.Now < Deadline)
            {
                Console.WriteLine("Tebrikler");
            }
            else
            {
                Console.WriteLine("Ugursuz olduz");
            }
        }
    }


}
