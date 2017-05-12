using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = new TaskGenerator("Tullan", 4);
            var task2 = new TaskGenerator("Hoppan", 2);
            var task3 = new TaskGenerator("Qac", 3);
            var task4 = new TaskGenerator("Uc", 1);
            var task5 = new TaskGenerator("Yat", 5);
            ShowTasks.ShowAllTask();
            Console.WriteLine();
            Console.WriteLine();
            var selectedTask = ShowTasks.ShowTask(ShowTasks.Input("Task secin: "));
            double deadline = DeadlineDefiner.DefineDeadline(selectedTask);
            DeadlineDefiner.StartTime(deadline);
        }
    }


}
