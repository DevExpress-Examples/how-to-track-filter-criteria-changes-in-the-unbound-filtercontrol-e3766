﻿// Developer Express Code Central Example:
// How to track filter criteria changes in the unbound FilterControl
// 
// By default, the FilterControl's FilterCriteria
// (ms-help://DevExpress.NETv11.1/DevExpress.Wpf/DevExpressXpfEditorsFilteringFilterControl_FilterCriteriatopic.htm)
// property is updated only after the ApplyFilter method has been called, while the
// ActualFilterCriteria
// (ms-help://DevExpress.NETv11.1/DevExpress.Wpf/DevExpressXpfEditorsFilteringFilterControl_ActualFilterCriteriatopic.htm)
// property does not send notifications when the user changes the filter.
// 
// This
// sample project shows how to force an unbound FilterControl to update its
// FilterCriteria property and bind another control or a view model to this
// property.
// 
// This is a temporary solution until the ID S135378, 'FilterControl
// criteria changed event' suggestion is implemented.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3766

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DXSample.Properties {


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
    }
}