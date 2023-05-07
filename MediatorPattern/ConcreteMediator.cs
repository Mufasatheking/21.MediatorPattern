namespace MediatorPattern
{
    class ConcreteMediator : IMediator
    {
        //private Friend friend1,friend2,boss;
        List<Friend> participants = new List<Friend>();
        public void Register(Friend friend)
        {
            participants.Add(friend);
        }
        public void DisplayDetails()
        {
            Console.WriteLine("At present, registered Participants are:");
            foreach (Friend friend in participants)
            {
                Console.WriteLine("{0}", friend.Name);
            }
        }
        public void Send(Friend friend, string msg)
        {
            if (participants.Contains(friend))
            {
                Console.WriteLine(String.Format("[{0}] posts: {1} Last message posted {2}", friend.Name, msg, DateTime.Now));
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("An outsider named {0} trying to send some messages", friend.Name);
            }
        }
    }
}