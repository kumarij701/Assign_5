using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Assignment_5
{
    public class Task
    {


        public int TaskId { get; set; } 

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString =@"{0:hh\:mm}")]
        public TimeSpan Time { get; set; }  //TimeSpan
        public string TaskOwner { get; set; } 
        public string TaskStatus { get; set; } 
        public string StoryDescription { get; set; }
    }
    public class TaskssDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public TaskssDbContext():base("Data Source = BYODHSQ5DX2\\MSSQLSERVERNEW; Initial Catalog = db; Integrated Security = True")
        { }
      


    }
}
