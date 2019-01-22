using ApiApp.Application.Interfaces;
using ApiApp.Application.Notifications.Models;
using System.Threading.Tasks;

namespace ApiApp.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(Message message)
        {
            return Task.CompletedTask;
        }
    }
}
