using System;

namespace MyFirstProgram
{
    class DVD : BorrowableItem
    {
        public int DurationInMinutes { get; set; }

        public DVD(string title, int durationInMinutes) : base(title)
        {
            DurationInMinutes = durationInMinutes;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"DVD [Id: {Id}] - \"{Title}\" - Duration: {DurationInMinutes} minutes");
        }
    }
}