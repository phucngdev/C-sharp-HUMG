using System;

namespace Humg_23_10_lab_41
{
    //  Định nghĩa một interface để trừu tượng hóa dependency.
    // Interface này mô tả hành vi gửi tin nhắn (send message).
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    // Lớp EmailService dùng để gửi email, triển khai phương thức SendMessage.
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Gửi email với nội dung: {message}");
        }
    }

    // Một lớp khác là SmsService dùng để gửi tin nhắn SMS, cũng triển khai interface IMessageService.
    public class SmsService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Gửi SMS với nội dung: {message}");
        }
    }

    // Lớp Notification sử dụng interface IMessageService để gửi thông báo.
    public class Notification
    {
        private readonly IMessageService _messageService;

        // Điều này giúp lớp Notification không cần biết chi tiết về cách gửi tin nhắn (email, sms).
        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        // Phương thức Notify sẽ sử dụng dịch vụ gửi tin nhắn đã được inject.
        public void Notify(string message)
        {
            _messageService.SendMessage(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Bước 4: Tạo một đối tượng cụ thể và inject nó vào lớp Notification.
            
            // Dependency Injectio thông qua constructor.
            IMessageService emailService = new EmailService(); // Ở đây ta sử dụng dịch vụ Email.
            Notification notification = new Notification(emailService); // Inject emailService vào Notification.
            notification.Notify("Xin chào qua Email!"); // Gửi thông báo qua email.

            // Chuyển sang sử dụng dịch vụ SMS mà không cần thay đổi lớp Notification.
            IMessageService smsService = new SmsService(); // Dịch vụ gửi tin nhắn SMS.
            Notification smsNotification = new Notification(smsService); // Inject smsService vào Notification.
            smsNotification.Notify("Xin chào qua SMS!"); // Gửi thông báo qua SMS.
        }
    }
}
