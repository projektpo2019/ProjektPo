﻿#pragma checksum "..\..\ZamowienieWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1A194E3618CE5C1DCFA55D4EBC0BB26DDCA60EDC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GUIProjektPo;
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


namespace GUIProjektPo {
    
    
    /// <summary>
    /// ZamowienieWindow
    /// </summary>
    public partial class ZamowienieWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ZamowienieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_numerZamowienia;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ZamowienieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_rodzajPlatnosci;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ZamowienieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem ZaPobraniem;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ZamowienieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem KartaPlatnicza;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ZamowienieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem PrzelewBankowy;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ZamowienieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_sposobWysylki;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ZamowienieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem combobox_kurier;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ZamowienieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem combobox_paczkomat;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ZamowienieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem combobox_odbiorOsobisty;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ZamowienieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem combobox_pocztaPolska;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ZamowienieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_zakoncz;
        
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
            System.Uri resourceLocater = new System.Uri("/GUIProjektPo;component/zamowieniewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ZamowienieWindow.xaml"
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
            this.Label_numerZamowienia = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ComboBox_rodzajPlatnosci = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\ZamowienieWindow.xaml"
            this.ComboBox_rodzajPlatnosci.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ZaPobraniem = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 4:
            this.KartaPlatnicza = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 5:
            this.PrzelewBankowy = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 6:
            this.ComboBox_sposobWysylki = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\ZamowienieWindow.xaml"
            this.ComboBox_sposobWysylki.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_sposobWysylki_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.combobox_kurier = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 8:
            this.combobox_paczkomat = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 9:
            this.combobox_odbiorOsobisty = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 10:
            this.combobox_pocztaPolska = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 11:
            this.Button_zakoncz = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            
            #line 26 "..\..\ZamowienieWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
