using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;

namespace Assigment6
{
    internal class FileManager
    {
        /// <summary>
        /// string.Join combines all strings in the collection into a single string
        /// Environment.NewLine creates a new line between each task
        /// task.Tostring creates a string of each task
        /// taskList.Select crates a list of tasks that are strings with help of task.Tostring
        /// </summary>
        /// <param name="taskList"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool SaveTaskListToFile(List<Task> taskList, string fileName)
        {
            string content = string.Join(Environment.NewLine, taskList.Select(task => task.ToString()));
            
            try
            {
                // Skriv strängen till filen
                File.WriteAllText(fileName, content);

                Console.WriteLine("Texten har skrivits till filen: " + fileName);
            }
            catch (Exception ex)
            {
                // Hantera eventuella fel
                Console.WriteLine("Ett fel inträffade: " + ex.Message);
            }
            return true;
        }

        public bool ReadTaskListFrFile(List<Task> taskList, string fileName)
        {

            if (File.Exists(fileName))
            {
                // Read the file content
                string[] lines = File.ReadAllLines(fileName);

                // Clear the current task list to avoid duplications
                taskList.Clear();
                CategoryType category;

                // Process each line and create Task objects
                foreach (string line in lines)
                {
                    //Read date and time
                    //Format it to fit the task
                    string datePart = line.Substring(0, 25).Trim();
                    string dateTimestr1 = line.Substring(25, 11).Trim();
                    string format = "dddd, d MMMM yyyy HH:mm";
                    DateTime dateTime = new DateTime(2025, 1, 1);
                    //MessageBox.Show(datePart + " " + dateTimestr1);
                    //dateTime = DateTime.TryParseExact(datePart + " " + dateTimestr1, format, CultureInfo.InvariantCulture);
                    //bool successDatetime = DateTime.TryParse(datePart + " " + dateTimestr1, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
                    bool successDatetime = DateTime.TryParse(datePart + " " + dateTimestr1, CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTime);
                    

                    //Read category
                    //Parse the string "categorystr" into an enumeration value of type "category"
                    string categorystr = line.Substring(37, 16).Trim();
                    
                    //MessageBox.Show("Prio:" + categorystr + ".");
                    bool success = Enum.TryParse(categorystr, out category);
                    string description = line.Substring(51).Trim();

                    if (successDatetime && success)
                    {
                        //MessageBox.Show("Parsed Date: " + dateTime);
                        //Add values to task and add task to list
                        Task task = new Task(dateTime, description, category);
                        taskList.Add(task);
                    }
                    else
                    {
                        MessageBox.Show("Invalid date format.");
                    }

                    
                }
                return true;
            }
            else
                return false;
        }

    }
}
