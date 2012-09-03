using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoLib;

namespace Client
{
	public class TaskListViewModel
	{
		private TaskList _taskList;

		public IEnumerable<TaskViewModel> Tasks { get; set; }

		public string TaskText { get; set; }

		public TaskListViewModel()
		{

		}
	}
}
