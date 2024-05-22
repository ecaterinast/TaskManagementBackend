using TaskManagement.Interfaces;

namespace TaskManagement.Data.DbModels
{
    public class TaskManager : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private BaseTask _currentTask;

        public BaseTask CurrentTask
        {
            get { return _currentTask; }
            set
            {
                _currentTask = value;
                NotifyObservers();
            }
        }
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_currentTask);
            }
        }


    }
}