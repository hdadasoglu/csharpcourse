using System;
using System.Collections.Generic;

namespace ToDoList
{
    public class Cards
    {
        private string title;
        private string content;
        private Person assignedPerson;
        private Sizes sizes;

        private Status status = Status.TODO;

        public Cards(){

        }
        public Cards(string title, string content, Person assignedPerson, Sizes size, Status status)
        {
            Title = title;
            Content = content;
            AssignedPerson = assignedPerson;
            Sizes = size;
            Status = status;
        }

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public Person AssignedPerson { get => assignedPerson; set => assignedPerson = value; }
        public Sizes Sizes { get => sizes; set => sizes = value; }
        public Status Status { get => status; set => status = value; }
    }
}