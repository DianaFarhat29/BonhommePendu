﻿#pragma checksum "..\..\Preferences.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "116F67D206803F1697A442CA85C8B97CBA39C5DB3E9AF995FCC7FECD9AB6E8F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Pendu_Projet_Final;
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


namespace Pendu_Projet_Final {
    
    
    /// <summary>
    /// Preferences
    /// </summary>
    public partial class Preferences : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_btn_francais;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_btn_anglais;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_btn_moyen;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_btn_difficile;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_btn_facile;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_dictionnaire;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_enregistrer;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_accueil;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Preferences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_quitter;
        
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
            System.Uri resourceLocater = new System.Uri("/Pendu_Projet_Final;component/preferences.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Preferences.xaml"
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
            this.radio_btn_francais = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.radio_btn_anglais = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.radio_btn_moyen = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.radio_btn_difficile = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.radio_btn_facile = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.btn_dictionnaire = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\Preferences.xaml"
            this.btn_dictionnaire.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_enregistrer = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\Preferences.xaml"
            this.btn_enregistrer.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_accueil = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\Preferences.xaml"
            this.btn_accueil.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_quitter = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\Preferences.xaml"
            this.btn_quitter.Click += new System.Windows.RoutedEventHandler(this.btn_quitter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

