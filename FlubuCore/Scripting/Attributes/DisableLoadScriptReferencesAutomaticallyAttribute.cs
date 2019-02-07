﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FlubuCore.Scripting.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DisableLoadScriptReferencesAutomaticallyAttribute : Attribute
    {
    }
}
