﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicTacToe.Resources
{
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ResultsStrings
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public ResultsStrings()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TicTacToe.Resources.ResultsStrings", typeof(GameStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        public static string ResultsPageTitle
        {
            get
            {
                return ResourceManager.GetString("ResultsPageTitle", resourceCulture);
            }
        }
        public static string Tie
        {
            get
            {
                return ResourceManager.GetString("Tie", resourceCulture);
            }
        }

        public static string Crosses
        {
            get
            {
                return ResourceManager.GetString("Crosses", resourceCulture);
            }
        }

        public static string Zeros
        {
            get
            {
                return ResourceManager.GetString("Zeros", resourceCulture);
            }
        }

        public static string PlayerColumn
        {
            get
            {
                return ResourceManager.GetString("PlayerColumn", resourceCulture);
            }
        }
        public static string GameSideColumn
        {
            get
            {
                return ResourceManager.GetString("GameSideColumn", resourceCulture);
            }
        }
        public static string ResultTitle
        {
            get
            {
                return ResourceManager.GetString("ResultColumn", resourceCulture);
            }
        }
        public static string StartColumn
        {
            get
            {
                return ResourceManager.GetString("StartColumn", resourceCulture);
            }
        }
        public static string EndColumn
        {
            get
            {
                return ResourceManager.GetString("EndColumn", resourceCulture);
            }
        }

    }
}
