namespace hangfire_app.Services
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(string email);
    }
}
