using ITJob.DomainModels.Identity;

namespace ITJob.ViewModels.Identity.Emails
{
    public class UserProfileUpdateNotificationViewModel : EmailsBase
    {
        public User User { set; get; }
    }
}