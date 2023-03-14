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
        private RECORDING_VERSIONS _version;
        public RECORDING_VERSIONS version { get; set; }
        private String Title;
        private String Composer;
        private String Duration;
        private String Aritist;
        private String Lyrics;
    }
    public class Validator
    {
        private Boolean isBankOrNull()
        {

        }
        public List<string> ValidateRecordings(Recording recording)
        {
            if (recording==null)
            {
                return new List<string>() { "Recording was null"};
            }
            List<string> errors=new List<string>();
            if (Recording.RECORDING_VERSIONS.v1.Equals(recording.version))
            {

            }

        }
    }
}