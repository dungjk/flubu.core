
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Plugin
{
     public partial class DockerPluginCreateTask : ExternalProcessTaskBase<int, DockerPluginCreateTask>
     {
        private string[] _plugin;

        
        public DockerPluginCreateTask(params string[] plugin)
        {
            ExecutablePath = "docker";
            WithArguments("plugin create");
_plugin = plugin;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Compress the context using gzip
        /// </summary>
        public DockerPluginCreateTask Compress()
        {
            WithArguments("compress");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_plugin);

            return base.DoExecute(context);
        }

     }
}
