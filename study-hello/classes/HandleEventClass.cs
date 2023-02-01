using System;

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
