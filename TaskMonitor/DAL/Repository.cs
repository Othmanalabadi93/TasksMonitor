using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskMonitor.Helper;
using TaskMonitor.Models;

namespace TaskMonitor.DAL
{
    public class Repository : IRepository
    {
        private List<Task> _Tasks = new List<Task>();

        private string PathDB = Application.StartupPath + "\\db";
        private string PathBackup = Application.StartupPath + "\\backup";

        public Repository()
        {
            InitializeData();
        }

        public void InitializeData()
        {
            _Tasks.Clear();

            try
            {
                //string text = File.ReadAllText(PathDB);
                string text = Security.Decryption(File.ReadAllText(PathDB + "\\tasksdb"));

                JObject root = JObject.Parse(text);
                JArray jTask = root["Tasks"] as JArray;

                _Tasks = jTask.ToObject<List<Task>>();
            }
            catch
            {
                _Tasks = new List<Task>();
            }
        }

        public void Delete(int taskID)
        {
            foreach (var item in _Tasks)
            {
                if (item.ID == taskID)
                {
                    _Tasks.Remove(item);
                    break;
                }
            }
        }

        public List<Task> GetAllTasks()
        {
            return _Tasks;
        }

        public Task GetById(int id)
        {
            Task tt = new Task();
            foreach (var item in _Tasks)
            {
                if (item.ID == id)
                {
                    Task t = new Task { ID = item.ID, Title = item.Title, Content = item.Content, TaskType = item.TaskType, DateStart = item.DateStart, DateExpire = item.DateExpire, IsDateExpire = item.IsDateExpire, Remember = item.Remember };
                    tt = t;
                    break;
                }
            }
            return tt;
        }

        public void Insert(Task task)
        {
            _Tasks.Add(task);
            Save();
        }

        public void Update(Task task)
        {
            foreach (var item in _Tasks)
            {
                if (item.ID == task.ID)
                {
                    item.Title = task.Title;
                    item.Content = task.Content;
                    item.TaskType = task.TaskType;
                    break;
                }
            }
        }

        public void Save()
        {
            RootTask rootTask = new RootTask();
            rootTask.Tasks = _Tasks;
            string text = Security.Encryption(JsonConvert.SerializeObject(rootTask));

            //File.WriteAllText(PathDB, text);

            if (!Directory.Exists(PathDB))
                Directory.CreateDirectory(PathDB);
            if (!Directory.Exists(PathBackup))
                Directory.CreateDirectory(PathBackup);

            string fileFull = PathDB + "\\tasksdb";
            string fillFullBackup= PathBackup + "\\" + DateTime.Now.ToString().Replace(':', '_').Replace('/','-');
            
                if (File.Exists(fileFull))
                File.Move(fileFull, fillFullBackup);

            StreamWriter sw = new StreamWriter(PathDB + "\\tasksdb", false, Encoding.UTF8);
            sw.Write(text);
            sw.Close();
        }

        public int GetMaxId()
        {
            if (_Tasks.Count == 0)
                return 1;
            else
            {
                return _Tasks.Max(i => i.ID) + 1;
            }
        }
    }
}