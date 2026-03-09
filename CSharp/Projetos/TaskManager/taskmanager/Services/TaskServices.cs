using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using TaskManager.Models;

namespace TaskManager.Services
{
    public class TaskService
    {
        private readonly string _filePath = "tasks.json";
        private List<TaskItem> _tasks = new();

        public TaskService()
        {
            Load();
        }

        public IEnumerable<TaskItem> GetAll() => _tasks;

        public void Add(string title)
        {
            int nextId = _tasks.Count == 0 ? 1 : _tasks.Max(t => t.Id) + 1;
            _tasks.Add(new TaskItem { Id = nextId, Title = title });
            Save();
        }

        public void Toggle(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = !task.IsCompleted;
                Save();
            }
        }

        public void Remove(int id)
        {
            _tasks.RemoveAll(t => t.Id == id);
            Save();
        }

        private void Save()
        {
            var json = JsonSerializer.Serialize(_tasks, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        private void Load()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                _tasks = JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new();
            }
        }
    }
}
