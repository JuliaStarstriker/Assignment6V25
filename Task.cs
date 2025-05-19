using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment6
{
    internal class Task
    {
        private DateTime date;
        private string description;
        private CategoryType category;


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
        public CategoryType Category
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
        private string GetTimeString()
        {
            return date.ToShortTimeString();
        }

        /// <summary>
        /// returns the string representation of the 'category' field
        /// </summary>
        /// <returns>category.ToString();</returns>
        private string GetPriorityString()
        {
            return category.ToString();
        }

        /// <summary>
        /// This constructor initializes a new Task object with the default category set to "Normal"
        /// </summary>
        public Task()
        {
            //set a default category typ
            category = CategoryType.Revenue;
        }

        /// <summary>
        /// This constructor calls the full constructor, passing the provided 'taskDate',
        /// an empty string for the description, and a default category of "Normal"
        /// </summary>
        /// <param name="taskDate"></param>
        public Task(DateTime taskDate) : this(taskDate, string.Empty, CategoryType.Revenue)
        {

        }

        /// <summary>
        /// Constructor that initializes a Task object with a specified task date, description, and category
        /// This constructor allows full customization of a Task's properties when creating a new instance
        /// </summary>
        /// <param name="taskDate"></param>
        /// <param name="description"></param>
        /// <param name="category"></param>
        public Task(DateTime taskDate, string description, CategoryType category)
        {
            this.date = taskDate;
            this.description = description; 
            this.category = category;
        }

        /// <summary>
        /// Overrides the default ToString() method to provide a custom string representation of the Task object
        /// The returned string includes the task's key details in a neatly formatted layout for easy display
        /// </summary>
        /// <returns>string TextOut</returns>
        public override string ToString()
        {
            string TextOut = string.Format("{0, -25} {1, 10} {2, -16} {3, -20}",
                                            date.ToLongDateString(),
                                            GetTimeString(),
                                            GetPriorityString(),
                                            Description );
            return TextOut;
        }
        
    }
}
