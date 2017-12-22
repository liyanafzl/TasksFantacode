using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo
{
    class Member
    {
        public string text { get; set; }
        public DateTime time { get; set; }

        public Member(string text, DateTime time)
        {
            text = this.text;
            time = this.time;
        }
        public Member Adder(string text, DateTime time)
        {
            Member mem = new Member(text, time);
            return mem;
        }
    }
}
