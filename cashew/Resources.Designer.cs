﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace cashew {
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [DebuggerNonUserCode()]
    [CompilerGenerated()]
    internal class Resources {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager {
            get {
                if (ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("cashew.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] IronPythonBCL {
            get {
                object obj = ResourceManager.GetObject("IronPythonBCL", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;packages&gt;
        ///  &lt;package id=&quot;CC-Functions.Misc&quot; version=&quot;1.0.2&quot; targetFramework=&quot;net461&quot; /&gt;
        ///  &lt;package id=&quot;DynamicLanguageRuntime&quot; version=&quot;1.2.2&quot; targetFramework=&quot;net461&quot; /&gt;
        ///  &lt;package id=&quot;Humanizer.Core&quot; version=&quot;2.7.9&quot; targetFramework=&quot;net472&quot; /&gt;
        ///  &lt;package id=&quot;ICSharpCode.Decompiler&quot; version=&quot;5.0.2.5153&quot; targetFramework=&quot;net472&quot; /&gt;
        ///  &lt;package id=&quot;ICSharpCode.NRefactory&quot; version=&quot;5.5.1&quot; targetFramework=&quot;net472&quot; /&gt;
        ///  &lt;package id=&quot;ICSharpCode.TextEditor.Extended&quot;  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string packages {
            get {
                return ResourceManager.GetString("packages", resourceCulture);
            }
        }
    }
}
