namespace MediatorPattern
{
    /* Friend3-Third Participant.He is the boss.*/
    class Boss : Friend
    {
        // Constructor
        public Boss(IMediator mediator, string name)
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