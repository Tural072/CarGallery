﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarGallery.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=STHQ0126-15;Initial Catalog=CarGalleryDb;User ID=admin;Password=admin" +
            ";Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string CarGalleryDbConnectionString {
            get {
                return ((string)(this["CarGalleryDbConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ROGSTRIX;Initial Catalog=CarGalleryDb;Connect Timeout=30;Encrypt=Fals" +
            "e;TrustServerCertificate=False")]
        public string CarGalleryDbConnectionString1 {
            get {
                return ((string)(this["CarGalleryDbConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ROGSTRIX;Initial Catalog=CarGalleryDb;Integrated Security=True;Connec" +
            "t Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string CarGalleryDbConnectionString2 {
            get {
                return ((string)(this["CarGalleryDbConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=STHQ011A-14;Initial Catalog=CarGalleryDb;User ID=admin;Password=admin" +
            ";Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string CarGalleryDbConnectionString3 {
            get {
                return ((string)(this["CarGalleryDbConnectionString3"]));
            }
        }
    }
}
