using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment6
{
    internal class TaskManager
    {
        List<Task> taskList;

        /// <summary>
        /// constructor creates a new empty list of tasks (taskList) to hold and manage Task objects
        /// </summary>
        public TaskManager()
        {
            taskList = new List<Task>();
        }

        /// <summary>
        /// Adds a new task to the taskList if the provided task is not null
        /// </summary>
        /// <param name="newTask"></param>
        /// <returns>bool ok</returns>
        public bool AddNewTask(Task newTask)
        {
            bool ok = true;

            if (newTask != null)
            {
                taskList.Add(newTask);
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// generates an array of strings representing the information of all tasks in the taskList
        /// </summary>
        /// <returns>string[] infoStrings</returns>
        public string[] GetInfoStringsList()
        {
            string[] infoStrings = new string[taskList.Count];

            for (int i = 0; i < infoStrings.Length; i++)
            {
                infoStrings[i] = taskList[i].ToString();
            }
            return infoStrings;
        }

        /// <summary>
        /// writes the current list of tasks (taskList) to a file specified by "fileName"
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>fileManager.SaveTaskListToFile(taskList, fileName);</returns>
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTaskListToFile(taskList, fileName);
        }

        /// <summary>
        /// reads task data from a file specified by 'fileName' and loads it into the taskList
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>fileManager.ReadTaskListFrFile(taskList, fileName);</returns>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();
         
            return fileManager.ReadTaskListFrFile(taskList, fileName);
        }
    }
}
