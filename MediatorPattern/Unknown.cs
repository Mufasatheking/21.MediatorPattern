namespace MediatorPattern
{
    // Friend4-4th participant who will not register himself to the // mediator. Still he will try to send a message.
    class Unknown: Friend
    {
        // Constructor
        public Unknown(IMediator mediator, string name)
            : base(mediator)
        {
            this.Name = name;
        }
        public void Send(string msg)
        {
            mediator.Send(this, msg);
        }
    }
}