
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerRmiTask : ExternalProcessTaskBase<int, DockerRmiTask>
     {
        private string[] _image;

        
        public DockerRmiTask(params string[] image)
        {
            ExecutablePath = "docker";
            WithArguments("rmi");
_image = image;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Force removal of the image
        /// </summary>
        public DockerRmiTask Force()
        {
            WithArguments("force");
            return this;
        }

        /// <summary>
        /// Do not delete untagged parents
        /// </summary>
        public DockerRmiTask NoPrune()
        {
            WithArguments("no-prune");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_image);

            return base.DoExecute(context);
        }

     }
}
