using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkAbstractClassAndInterface.Interfaces
{
    interface IUser
    {
        int ID { get; set; }
        string Username { get; set; }
        int Password { get; set; }

        void PrintUser();
    }
}
