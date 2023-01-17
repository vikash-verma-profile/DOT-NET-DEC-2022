using System.Diagnostics;
using System.Runtime;

namespace InducedCollections
{
    public class Worker
    {
        public int WorkedId { get; set; }
        public List<double> DataPoints { get; set; }
        public Worker(int workerId, List<double> dataPoints)
        {
            WorkedId = workerId;
            DataPoints = dataPoints;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentLatecenyMode = GCSettings.LatencyMode;
            GCSettings.LatencyMode = GCLatencyMode.LowLatency;
            var watch = new Stopwatch();
            var numberTasksToRun = 4;
            var numberItems = 20000;
            var random = new Random((int)DateTime.Now.Ticks);
            var datapoints = Enumerable.Range(1,numberItems).Select(x=>random.NextDouble()).ToList();
            var workers = new List<Worker>();
            for (int i = 1; i <= numberTasksToRun; i++)
            {
                workers.Add(new Worker(i,datapoints));
            }
            watch.Restart();

            if (workers.Any())
            {
                var processorcount = Environment.ProcessorCount;
                var parallelOptions = new ParallelOptions { MaxDegreeOfParallelism = processorcount };
                Parallel.ForEach(workers,parallelOptions, DoWork);
            }
            watch.Stop();
            GCSettings.LatencyMode = currentLatecenyMode;
            Console.WriteLine($"Time to complete in milliseconds: {watch.ElapsedMilliseconds}");
        }
        public static void DoWork(Worker worker)
        {
            Console.WriteLine($"WorkerID: {worker.WorkedId} -->new tasks with thread id : {Thread.CurrentThread.ManagedThreadId}");
            var pos = 0;
            foreach (var item in worker.DataPoints)
            {
                var subset = worker.DataPoints.Skip(pos).Take(worker.DataPoints.Count-pos).ToList();
                pos++;
            }
        }
    }
}