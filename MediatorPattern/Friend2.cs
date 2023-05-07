namespace MediatorPattern
{
    // Friend2-Second participant
    class Friend2 : Friend
    {
        // Constructor
        public Friend2(IMediator mediator, string name)
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