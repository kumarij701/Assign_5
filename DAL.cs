using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class DAL
    {
        
        static void Main(string[] args)
        {
            var context = new TaskssDbContext();

            //var query =context.Tasks.Where(t=>t.TaskId==1);
            var query = from c in context.Tasks select c;
            foreach (var task in query)
            {
                Console.WriteLine("Task Data:");
                Console.WriteLine($"{task.TaskId} + {task.Time} + {task.TaskOwner} + {task.TaskStatus}+{task.StoryDescription}");
            }
            Console.Read();
            //InsertData();

        }

        /**public static void ReadData()
        {
            //var query =context.Tasks.Where(t=>t.TaskId==1);
            var query = context.Tasks.ToList();
            foreach (var task in query)
            {
                Console.WriteLine("Task Data:");
                Console.WriteLine($"{task.TaskId} + {task.Time} + {task.TaskOwner} + {task.TaskStatus}+{task.StoryDescription}");
            }
            Console.Read();

        }
        
        public static void InsertData()
        {
            var t = new Task
            {
                TaskId = 10,
                Time = TimeSpan.Parse("10"),
                TaskOwner = "Owner10",
                StoryDescription = "jjjjjjjjjjj",
                TaskStatus = "in-progress"

            };
            context.Tasks.Add(t);
            context.SaveChanges();
        }
        **/
    }
}
