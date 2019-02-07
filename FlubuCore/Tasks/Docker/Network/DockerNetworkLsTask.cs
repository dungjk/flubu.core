
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Network
{
     public partial class DockerNetworkLsTask : ExternalProcessTaskBase<int, DockerNetworkLsTask>
     {
        
        
        public DockerNetworkLsTask()
        {
            ExecutablePath = "docker";
            WithArguments("network ls");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Provide filter values (e.g. 'driver=bridge')
        /// </summary>
        public DockerNetworkLsTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print networks using a Go template
        /// </summary>
        public DockerNetworkLsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Do not truncate the output
        /// </summary>
        public DockerNetworkLsTask NoTrunc()
        {
            WithArguments("no-trunc");
            return this;
        }

        /// <summary>
        /// Only display network IDs
        /// </summary>
        public DockerNetworkLsTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
