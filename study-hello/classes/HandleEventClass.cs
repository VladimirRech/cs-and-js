using System;
//
// Shows how to handle events
// Links:
// 1. https://learn.microsoft.com/en-us/dotnet/standard/events/
// 2. https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler?view=net-7.0
// 3. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/event
//

namespace study_hello.classes
{
    public class HandleEventClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CurrentTime { get { return DateTime.Now.ToString("dd/MM/yyyy- HH:mm:ss"); }}
        
        public delegate void EventHandler(object sender, string text);
        public event EventHandler EventTrigger;
         
        public HandleEventClass()
        {
        }
        
        public void Run(int iterations)
        {
            for(int i = 0; i < iterations; i++)
            {
                EventTrigger?.Invoke(this, $"Id: {Id.ToString("0000")}, Name: Name-{i.ToString("0000")}");
            }
        }   
    }
}
