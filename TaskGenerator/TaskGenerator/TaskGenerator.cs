using System;
using System.Collections.Generic;

namespace TaskGenerator
{
    
    class TaskGenerator
    {
        public string Name;
        public int Difficulty;
        ShowTasks instance = new ShowTasks();

        public TaskGenerator(string name, int difficulty)
        {
            this.Name = name;
            this.Difficulty = difficulty;
            instance.AddTask(this);
        }


    }
}
