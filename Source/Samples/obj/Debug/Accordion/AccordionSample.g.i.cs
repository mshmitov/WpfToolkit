﻿#pragma checksum "..\..\..\Accordion\AccordionSample.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "94D7B57365BB2CC4D081D5482C42DDBC"
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
    /// AccordionSample
    /// </summary>
    public partial class AccordionSample : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Accordion\AccordionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Accordion acc;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Accordion\AccordionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSelectionMode;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Accordion\AccordionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbExpandDirection;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Accordion\AccordionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSelectionSequence;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Accordion\AccordionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl icSelectedIndices;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Accordion\AccordionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSelectedIndex;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFToolkitSamples;component/accordion/accordionsample.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Accordion\AccordionSample.xaml"
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
            this.acc = ((System.Windows.Controls.Accordion)(target));
            return;
            case 2:
            this.cbSelectionMode = ((System.Windows.Controls.ComboBox)(target));
            
            #line 54 "..\..\..\Accordion\AccordionSample.xaml"
            this.cbSelectionMode.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectionModeChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbExpandDirection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 66 "..\..\..\Accordion\AccordionSample.xaml"
            this.cbExpandDirection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ExpandDirectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbSelectionSequence = ((System.Windows.Controls.ComboBox)(target));
            
            #line 79 "..\..\..\Accordion\AccordionSample.xaml"
            this.cbSelectionSequence.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectionSequenceChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 86 "..\..\..\Accordion\AccordionSample.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SelectAll);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 87 "..\..\..\Accordion\AccordionSample.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UnselectAll);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 91 "..\..\..\Accordion\AccordionSample.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SetHeight);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 92 "..\..\..\Accordion\AccordionSample.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveHeight);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 96 "..\..\..\Accordion\AccordionSample.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SetWidth);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 97 "..\..\..\Accordion\AccordionSample.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveWidth);
            
            #line default
            #line hidden
            return;
            case 11:
            this.icSelectedIndices = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 12:
            this.tbSelectedIndex = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

