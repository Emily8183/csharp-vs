using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    public class Choice
    {
        public string Content {  get; set; }
        public bool IsCorrect {  get; set; }

        public Choice(string content, bool isCorrect)
        {
            Content = content;
            IsCorrect = isCorrect;
        }

        public Choice(string content)
            : this(content, false) { }
    }
}
