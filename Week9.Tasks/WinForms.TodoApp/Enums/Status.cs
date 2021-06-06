using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.TodoApp.Enums
{
    public enum Status : byte
    {
        Pending = 1,
        Completed = 2,
        InCompleted = 3,
        Canceled = 4,
        Suspended = 5
    }
}