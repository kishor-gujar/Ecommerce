using System.Threading.Tasks;

namespace EcommerceServer.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
