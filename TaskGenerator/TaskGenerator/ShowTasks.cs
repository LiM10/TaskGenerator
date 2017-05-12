using System;
using System.Collections.Generic;

namespace TaskGenerator
{
    class ShowTasks
    {
        public static List<TaskGenerator> Tasks = new List<TaskGenerator>();

        public static TaskGenerator ShowTask(int num)
        {
            if (num > Tasks.Count || num <= 0)
            {
                Console.WriteLine("Bele bir task yoxdur!!!");
                ShowAllTask();
            }else
            {
                Console.WriteLine("Taskin adi: " + Tasks[num - 1].Name);
                Console.WriteLine("Taskin cetinlik derecesi: " + Tasks[num - 1].Difficulty);
                return Tasks[num - 1];
            }
            return null;
        }

        public static void ShowAllTask()
        {
            int order = 0;
            foreach (var task in Tasks)
            {
                order++;
                Console.WriteLine(order+"." + "Taskin adi:" + task.Name);
                Console.WriteLine("Taskin cetinlik derecesi:" + task.Difficulty);
            }
        }

        public void AddTask(TaskGenerator obj)
        {
            Tasks.Add(obj);
        }

        public static int Input(string message)
        {
            Console.Write(message);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
    }
}
