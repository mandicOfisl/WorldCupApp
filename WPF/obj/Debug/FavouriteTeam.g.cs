﻿#pragma checksum "..\..\FavouriteTeam.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "132115AC5D9737767F57D6E76B51BFF0C4178A2349AD86A05C59289C90CF4C6E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Shell;
using WPF;
using WPF.Properties;


namespace WPF {
    
    
    /// <summary>
    /// FavouriteTeam
    /// </summary>
    public partial class FavouriteTeam : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\FavouriteTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSettings;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\FavouriteTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTeams;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\FavouriteTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnFirstTeamInfo;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\FavouriteTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTeamsSecond;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\FavouriteTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSecondTeamInfo;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\FavouriteTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnContinue;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF;component/favouriteteam.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FavouriteTeam.xaml"
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
            
            #line 12 "..\..\FavouriteTeam.xaml"
            ((WPF.FavouriteTeam)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnSettings = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\FavouriteTeam.xaml"
            this.BtnSettings.Click += new System.Windows.RoutedEventHandler(this.BtnSettings_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbTeams = ((System.Windows.Controls.ComboBox)(target));
            
            #line 50 "..\..\FavouriteTeam.xaml"
            this.cbTeams.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbTeamsFirst_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnFirstTeamInfo = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\FavouriteTeam.xaml"
            this.BtnFirstTeamInfo.Click += new System.Windows.RoutedEventHandler(this.BtnTeamInfo_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbTeamsSecond = ((System.Windows.Controls.ComboBox)(target));
            
            #line 73 "..\..\FavouriteTeam.xaml"
            this.cbTeamsSecond.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbTeamsSecond_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnSecondTeamInfo = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\FavouriteTeam.xaml"
            this.BtnSecondTeamInfo.Click += new System.Windows.RoutedEventHandler(this.BtnTeamInfo_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnContinue = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\FavouriteTeam.xaml"
            this.BtnContinue.Click += new System.Windows.RoutedEventHandler(this.BtnContinue_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

