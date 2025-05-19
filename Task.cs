using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assigment6.MainForm;

namespace Assigment6
{
    internal class Task
    {
        private DateTime date;
        private string description;
        private Category category;


        /// <summary>
        /// Get and Set property for Date and Time
        /// </summary>
        public DateTime DateAndTime
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// Get and Set property for description
        /// </summary>
        public string Description
        {
            get { return description; }
            set 
            { 
                if(!string.IsNullOrEmpty(value))
                    description = value;
            }
        }

        /// <summary>
        /// Get and Set property for category
        /// </summary>
        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        /// <summary>
        /// Get and Set property for task date
        /// </summary>
        public DateTime TaskDate
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// returns the time portion of the 'date' field in a short time format
        /// </summary>
        /// <returns>date.ToShortTimeString();</returns>
        //private string GetTimeString()
        //{
        //    return date.ToShortTimeString();
        //}

        private string GetTimeString()
        {
            return $"{date:HH:mm}          ";
        }

        /// <summary>
        /// returns the string representation of the 'category' field
        /// </summary>
        /// <returns>category.ToString();</returns>
        private string GetPriorityString()
        {
            //return category.ToString();
            return $"{category.Name} ({category.Type})";
        }

        /// <summary>
        /// This constructor initializes a new Task object with the default category set to "Normal"
        /// </summary>
        public Task(DateTime taskDate, Category category, string description)
        {
            this.date = taskDate;
            this.category = category;
            this.description = description;
        }

        /// <summary>
        /// This constructor calls the full constructor, passing the provided 'taskDate',
        /// an empty string for the description, and a default category of "Normal"
        /// </summary>
        /// <param name="taskDate"></param>
        public Task(DateTime taskDate) : this(taskDate, new Category("Default", CategoryType.Revenue), string.Empty)
        {
        }

        /// <summary>
        /// Overrides the default ToString() method to provide a custom string representation of the Task object
        /// The returned string includes the task's key details in a neatly formatted layout for easy display
        /// </summary>
        /// <returns>string TextOut</returns>
        public override string ToString()
        {
            string TextOut = string.Format("{0, -20} {1, 20} {2, -20} {3, -20}",
                                            date.ToLongDateString(),
                                            GetTimeString(),
                                            GetPriorityString(),
                                            Description);
            return TextOut;
        }
        
    }
}
