namespace TaskManagement.Interfaces
{
    public interface IBaseTask
    {
        void AddDescription();
        public abstract void Create();
        int CalculateTotalHours();
    }
}
