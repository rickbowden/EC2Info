﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EC2Info.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>eu-west-1</string>
  <string>eu-central-1</string>
  <string>us-east-1</string>
  <string>us-west-1</string>
  <string>us-west-2</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AWSRegion {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AWSRegion"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("eu-west-1")]
        public string AWSDefaultRegion {
            get {
                return ((string)(this["AWSDefaultRegion"]));
            }
            set {
                this["AWSDefaultRegion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>atocrarsdev|arn:aws:iam::640467343547:role/CA_KCOM_ADM|arn:aws:iam::049793823615:mfa/rbowden.kcom.adm</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection Roles {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Roles"]));
            }
            set {
                this["Roles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("arn:aws:iam::049793823615:mfa/rbowden.kcom.adm")]
        public string MFADevice {
            get {
                return ((string)(this["MFADevice"]));
            }
            set {
                this["MFADevice"] = value;
            }
        }
    }
}
