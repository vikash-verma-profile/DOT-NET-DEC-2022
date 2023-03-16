using Microsoft.CSharp.RuntimeBinder;

namespace RuleEngineDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Validator validator= new Validator();
            validator.ValidateRecordings(new Recording { Aritist="",Composer=""});
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
        private String title;
        public String Title { get; set; }
        private String composer;
        public String Composer { get; set; }
        private String duration;
        public String Duration { get; set; }
        private String aritist;
        public String Aritist { get; set; }
        private String lyrics;
        public String Lyrics { get; set; }
    }
    //public class Validator
    //{
    //    private Boolean isBankOrNull(string str)
    //    {
    //        return str == null || str == "";
    //    }
    //    public List<string> ValidateRecordings(Recording recording)
    //    {
    //        if (recording==null)
    //        {
    //            return new List<string>() { "Recording was null"};
    //        }
    //        List<string> errors=new List<string>();
    //        if (Recording.RECORDING_VERSIONS.v1.Equals(recording.version))
    //        {
    //            if (isBankOrNull(recording.Title))
    //            {
    //                errors.Add("recording title is blank or null");
    //            }
    //            if (isBankOrNull(recording.Aritist))
    //            {
    //                errors.Add("recording aritist is blank or null");
    //            }
    //        }
    //        else if (Recording.RECORDING_VERSIONS.v2.Equals(recording.version))
    //        {
    //            if (isBankOrNull(recording.Title))
    //            {
    //                errors.Add("recording title is blank or null");
    //            }
    //            if (isBankOrNull(recording.Aritist))
    //            {
    //                errors.Add("recording aritist is blank or null");
    //            }
    //            if (isBankOrNull(recording.Composer))
    //            {
    //                errors.Add("recording composer is blank or null");
    //            }
    //        }
    //        else
    //        {
    //            throw new Exception("Unsupported Version Type");
    //        }
    //        return errors;
    //    }
    //}

    public class Validator
    {
        private List<IRule> rules;

        public Validator()
        {
            rules = new List<IRule>() { new VersionOneRules(),new VersionTwoRules()};
        }
        public List<string> ValidateRecordings(Recording recording)
        {
            if (recording==null)
            {
                return new List<string>() { "Recording was null" };
            }
            List<string> errors = new List<string>();
            foreach (var item in rules)
            {
                if (item.shouldRun(recording))
                {
                    errors.AddRange(item.runRule(recording));
                }
            }
            return errors;
        }
    }
}