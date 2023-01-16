using System.Runtime.CompilerServices;

namespace Event_Delegate
{
    internal class Program
    {
        //STep 1:- Defining a delegate
        public delegate void WorkPerformedHandler(int hours,WorkType workType);
        //step-2 define one private field of type delegate
        private WorkPerformedHandler _WorkPerformedHandler;
        //STep 3:- Defining a event
        public event WorkPerformedHandler WorkPerformed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            add {
                _WorkPerformedHandler = (WorkPerformedHandler)Delegate.Combine(_WorkPerformedHandler, value);
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove {
                _WorkPerformedHandler = (WorkPerformedHandler)Delegate.Remove(_WorkPerformedHandler, value);
            }
        }
    }

    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }
}