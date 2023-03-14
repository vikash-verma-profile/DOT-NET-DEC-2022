namespace RuleEngineDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Recording
    {
        public enum RECORDING_VERSIONS
        {
            v1,
            v2
        }
        private RECORDING_VERSIONS version;
        private String Title;
        private String Composer;
        private String Duration;
        private String Aritist;
        private String Lyrics;
    }
}