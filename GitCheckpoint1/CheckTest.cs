using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCheckpoint1
{
    class CheckTest
    {
        public string Message { get; set; }
        public void TestMessage(string testMessage)
        {
            Message = testMessage;
            Message = "Task 2 checked";

        }
    }
}
