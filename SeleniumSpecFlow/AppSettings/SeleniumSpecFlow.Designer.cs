﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeleniumSpecFlow.AppSettings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
	public sealed partial class SeleniumSpecFlow : global::System.Configuration.ApplicationSettingsBase {
        
		private static SeleniumSpecFlow defaultInstance = ((SeleniumSpecFlow)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new SeleniumSpecFlow())));
        
		public static SeleniumSpecFlow Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.goole.co.uk")]
        public string BaseUrl {
            get {
                return ((string)(this["BaseUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("chrome")]
        public string Browser {
            get {
                return ((string)(this["Browser"]));
            }
            set {
                this["Browser"] = value;
            }
        }
    }
}
