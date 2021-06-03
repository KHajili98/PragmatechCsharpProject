using System;
using WinForms.TodoApp.Entities.Abstract;
using WinForms.TodoApp.Enums;

namespace WinForms.TodoApp.Entities.Concrete
{
    public class TodoEntity : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public ImportanceLevel ImportanceLevel { get; set; }
        public Status Status { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
