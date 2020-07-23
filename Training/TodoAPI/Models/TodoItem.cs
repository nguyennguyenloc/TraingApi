using System;

namespace TodoAPI.Models {
    public class TodoItem {
        public TodoItem () { }
        public TodoItem (int id, string content) {
            Id = id;
            Content = content;
        }

        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}