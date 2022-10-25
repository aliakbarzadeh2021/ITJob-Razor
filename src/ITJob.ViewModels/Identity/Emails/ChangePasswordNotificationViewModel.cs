using ITJob.DomainModels.Identity;

namespace ITJob.ViewModels.Identity.Emails
{
    public class ChangePasswordNotificationViewModel : EmailsBase
    {
        public User User { set; get; }
    }
}