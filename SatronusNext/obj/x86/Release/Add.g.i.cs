﻿#pragma checksum "..\..\..\Add.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "14B46950BB3C89DE4F93575C746714C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SatronusNext;
using SatronusNext.viewModel;
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
using System.Windows.Shell;


namespace SatronusNext {
    
    
    /// <summary>
    /// AddNote
    /// </summary>
    public partial class AddNote : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backinMainMenuButton1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tryToregisterButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ChangeNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ChangeTextTextBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DateTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label registrationNameLabel;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label registrationEMailLabel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DataChangeLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/SatronusNext;component/add.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Add.xaml"
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
            this.backinMainMenuButton1 = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Add.xaml"
            this.backinMainMenuButton1.Click += new System.Windows.RoutedEventHandler(this.Close);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tryToregisterButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Add.xaml"
            this.tryToregisterButton.Click += new System.Windows.RoutedEventHandler(this.Cont);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ChangeNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ChangeTextTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DateTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.registrationNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.registrationEMailLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.DataChangeLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

