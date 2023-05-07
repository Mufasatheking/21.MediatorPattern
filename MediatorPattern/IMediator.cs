namespace MediatorPattern
{
    interface IMediator
    {
        void Register(Friend friend);
        void Send(Friend friend, string msg);
    }
}