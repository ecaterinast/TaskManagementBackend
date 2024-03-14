namespace TaskManagement.Data.DbModels
{
    public class Epic : BaseTask
    {
        List <BaseTask> tasks = new List <BaseTask> ();
    }
}
