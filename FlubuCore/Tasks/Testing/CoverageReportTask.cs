﻿using System.Collections.Generic;
using FlubuCore.Context;
using FlubuCore.Tasks.Process;
using Microsoft.DotNet.Cli.Utils;

namespace FlubuCore.Tasks.Testing
{
    public class CoverageReportTask : TaskBase<int>
    {
        private readonly List<string> _inputFiles = new List<string>();
        private string _toolPath = "tools/reportgenerator/ReportGenerator.exe";
        private string _workingFolder = ".";
        private string _targetFolder = "coverage";

        public CoverageReportTask(params string[] inputFiles)
        {
            _inputFiles.AddRange(inputFiles);
        }

        public CoverageReportTask TargetFolder(string path)
        {
            _targetFolder = path;
            return this;
        }

        protected override int DoExecute(ITaskContext context)
        {
            RunProgramTask task = new RunProgramTask(new CommandFactory(), _toolPath);

            task
                .WorkingFolder(_workingFolder)
                .WithArguments($"-targetdir:{_targetFolder}", $"-reports:{string.Join(";", _inputFiles)}");

            task.Execute(context);

            return 0;
        }
    }
}
