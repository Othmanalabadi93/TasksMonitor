using System;
using System.Collections.Generic;
using System.Text;
using TaskMonitor.Models;

namespace TaskMonitor.DAL
{
    public interface IRepository
    {
        List<Task> GetAllTasks();
        Task GetById(int taskId);
        void Insert(Task task);
        void Update(Task task);
        void Delete(int taskId);
        int GetMaxId();
        void Save();
    }
}