namespace Задания.Classes
{
    public class Human
    {
        public string Name { get; set; }
        public List<string> Hobbies { get; set; }

        public event EventHandler<string> EventSubscription
;

        public Human(string name, List<string> hobbies)
        {
            Name = name;
            Hobbies = hobbies;
            EventSubscription += React; 
        }

        private void React(object sender, string eventName)
        {
            if (Hobbies.Contains(eventName))
            {
                Console.WriteLine($"{Name}: 'Наконец-то! Я так ждал этого!'");
            }
        }

        public void Event(string eventName)
        {
            EventSubscription?.Invoke(this, eventName);
        }
    }
}
