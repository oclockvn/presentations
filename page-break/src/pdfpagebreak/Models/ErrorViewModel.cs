using System;

namespace pdfpagebreak.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Person
    {
        public string First { get; set; }
        public string Last { get; set; }

        public Person(string first, string last)
        {
            First = first;
            Last = last;
        }
    }
}
