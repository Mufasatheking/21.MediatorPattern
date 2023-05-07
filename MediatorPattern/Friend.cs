namespace MediatorPattern
{
    // Friend
    abstract class Friend
    {
        protected IMediator mediator;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Constructor
        public Friend(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}