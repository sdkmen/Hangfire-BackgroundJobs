namespace hangfire_app.Services
{
    public class EmailService : IEmailService
    {

        public async Task<bool> SendEmailAsync(string email)
        {
            Console.WriteLine("email sent to: " + email + " time: " + DateTime.Now);

            await Task.Delay(1000);
            return true;
        }
    }
}
