using System;
using System.ComponentModel;
using WinForms.TodoApp.Entities.Abstract;
using WinForms.TodoApp.Enums;

namespace WinForms.TodoApp.Entities.Concrete
{
    public class TodoEntity : BaseEntity<Guid>
    {
        public string Title { get; set; }

        [DisplayName("Short Description")]
        public string ShortDescription { get; set; }

        public string Description { get; set; }

        [DisplayName("Importance Level")]
        public ImportanceLevel ImportanceLevel { get; set; }

        public Status Status { get; set; }

        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
    }
}
