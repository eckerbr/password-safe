using EckTech.PasswordSafe.Services.Interfaces;

namespace EckTech.PasswordSafe.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
