using System;

namespace Todo.Domain.Entities
{
    public class TodoItem : Entity
    {
        public TodoItem(string title,string refUser, DateTime date)
        {
            Title = title;
            Done = false;
            Date = date;
            RefUser = refUser;
        }

        public string Title { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string RefUser { get; private set; }

        public void MarkAsDone()
        {
            Done = false;
        }

        public void updateTitle(string title)
        {
            Title = title;
        }
    }
}