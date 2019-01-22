using ApiApp.Application.Notifications.Models;
using System.Threading.Tasks;

namespace ApiApp.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
