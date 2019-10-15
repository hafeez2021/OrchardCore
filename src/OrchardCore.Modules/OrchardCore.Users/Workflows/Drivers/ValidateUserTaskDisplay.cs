using OrchardCore.Users.Workflows.Activities;
using OrchardCore.Users.Workflows.ViewModels;
using OrchardCore.Workflows.Display;

namespace OrchardCore.Users.Workflows.Drivers
{
    public class ValidateUserTaskDisplay : ActivityDisplayDriver<ValidateUserTask, ValidateUserTaskViewModel>
    {
        protected override void EditActivity(ValidateUserTask activity, ValidateUserTaskViewModel model)
        {
            model.RoleNames = activity.RoleNames;
            model.SetUser = activity.SetUser;
        }

        protected override void UpdateActivity(ValidateUserTaskViewModel model, ValidateUserTask activity)
        {
            activity.RoleNames = model.RoleNames;
            activity.SetUser = model.SetUser;
        }
    }
}
