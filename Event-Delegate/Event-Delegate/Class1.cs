using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Delegate
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    public class Worker
    {

        //Step-2 Define one event to notify the work progress using any custom delegate
        public event WorkPerformedHandler workPerformed;

        //Step-2:Define another event to notify when the work is completed using build in EventHandler delegate
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            //Raising Events

            //if (workPerformed != null)
            //{
            //    workPerformed(8, WorkType.GenerateReports);
            //}
            //workPerformed?.Invoke(8, WorkType.GenerateReports);


            //WorkPerformedHandler work1 = workPerformed as WorkPerformedHandler;
            //if (work1!=null)
            //{
            //    work1.Invoke(8, WorkType.GenerateReports);
            //}

            ////
            //if(workPerformed is WorkPerformedHandler work2)
            //{
            //    work2.Invoke(8, WorkType.GenerateReports);
            //}

            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i+1, workType);
                Thread.Sleep(3000);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours,WorkType workType)
        {
            if (workPerformed is WorkPerformedHandler work2)
            {
                work2(8,WorkType.GenerateReports);
            }
        }
        protected virtual void OnWorkCompleted()
        {
            if (WorkCompleted is EventHandler work)
            {
                work(this, EventArgs.Empty);
            }
        }
    }
    internal class Class1
    {
        


    }
}
