﻿#pragma checksum "..\..\..\AutoCompleteBox\CustomEvents.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "04FA765C6CC78513E5EC139B0CF9120F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace System.Windows.Controls.Samples {
    
    
    /// <summary>
    /// CustomEvents
    /// </summary>
    public partial class CustomEvents : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\AutoCompleteBox\CustomEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox NowAutoComplete;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\AutoCompleteBox\CustomEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentPresenter Value1;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\AutoCompleteBox\CustomEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox LaterAutoComplete;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\AutoCompleteBox\CustomEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentPresenter Value2;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\AutoCompleteBox\CustomEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox NowAutoComplete2;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\AutoCompleteBox\CustomEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentPresenter Value3;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\AutoCompleteBox\CustomEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox LaterAutoComplete2;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\AutoCompleteBox\CustomEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentPresenter Value4;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFToolkitSamples;component/autocompletebox/customevents.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AutoCompleteBox\CustomEvents.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NowAutoComplete = ((System.Windows.Controls.AutoCompleteBox)(target));
            
            #line 45 "..\..\..\AutoCompleteBox\CustomEvents.xaml"
            this.NowAutoComplete.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Value1 = ((System.Windows.Controls.ContentPresenter)(target));
            return;
            case 3:
            this.LaterAutoComplete = ((System.Windows.Controls.AutoCompleteBox)(target));
            
            #line 58 "..\..\..\AutoCompleteBox\CustomEvents.xaml"
            this.LaterAutoComplete.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Value2 = ((System.Windows.Controls.ContentPresenter)(target));
            return;
            case 5:
            this.NowAutoComplete2 = ((System.Windows.Controls.AutoCompleteBox)(target));
            
            #line 84 "..\..\..\AutoCompleteBox\CustomEvents.xaml"
            this.NowAutoComplete2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Value3 = ((System.Windows.Controls.ContentPresenter)(target));
            return;
            case 7:
            this.LaterAutoComplete2 = ((System.Windows.Controls.AutoCompleteBox)(target));
            
            #line 97 "..\..\..\AutoCompleteBox\CustomEvents.xaml"
            this.LaterAutoComplete2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Value4 = ((System.Windows.Controls.ContentPresenter)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
