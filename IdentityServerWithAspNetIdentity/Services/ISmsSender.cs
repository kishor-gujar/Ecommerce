using System.Threading.Tasks;

namespace EcommerceServer.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
