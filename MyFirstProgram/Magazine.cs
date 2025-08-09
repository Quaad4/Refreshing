using System;

namespace MyFirstProgram
{
    class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, int issueNumber) : base(title)
        {
            IssueNumber = issueNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine [Id: {Id}] - \"{Title}\" Issue #{IssueNumber}");
        }
    }
}
