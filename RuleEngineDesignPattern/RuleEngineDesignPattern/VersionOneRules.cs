﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineDesignPattern
{
    internal class VersionOneRules : IRule
    {
        public List<string> runRule(Recording recording)
        {
            List<string> errors = new List<string>();
            if (RulesUtilites.isBankOrNull(recording.Title))
            {
                errors.Add("recording title is blank or null");
            }
            if (RulesUtilites.isBankOrNull(recording.Aritist))
            {
                errors.Add("recording aritist is blank or null");
            }
            return errors;
        }

        public bool shouldRun(Recording recording)
        {
            return Recording.RECORDING_VERSIONS.v1.Equals(recording.version);
        }
    }
}
