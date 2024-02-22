namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            EmailService emailService = new EmailService();

            user.SendReport(emailService);

            Console.WriteLine();
            Console.WriteLine("-- PostService with adapter --");
            /*
             * PostService doesnt implement ISendEmail interface
             */

            PostService postService = new PostService();
            EmailAdapter emailAdapter = new EmailAdapter(postService);


            user.SendReport(emailAdapter);
        }
    }
}
