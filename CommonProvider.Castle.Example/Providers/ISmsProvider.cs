
namespace CommonProvider.Castle.Example.Providers
{
    public interface ISmsProvider : IProvider
    {
        string SendSms(Message message);
    }
}
