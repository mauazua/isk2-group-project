﻿#pragma checksum "..\..\PanelAdministracyjny.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D24B381F397224193BA3F0FAE422BEE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.18408
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using System.Windows.Forms.Integration;
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


namespace Admin {
    
    
    /// <summary>
    /// PanelAdministracyjny
    /// </summary>
    public partial class PanelAdministracyjny : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\PanelAdministracyjny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Rezerwacje;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\PanelAdministracyjny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Wycieczki;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\PanelAdministracyjny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Klienci;
        
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
            System.Uri resourceLocater = new System.Uri("/Admin;component/paneladministracyjny.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PanelAdministracyjny.xaml"
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
            
            #line 12 "..\..\PanelAdministracyjny.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItemOProgramie);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\PanelAdministracyjny.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItemWyloguj);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 21 "..\..\PanelAdministracyjny.xaml"
            ((System.Windows.Controls.TabControl)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TabControl_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Rezerwacje = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.Wycieczki = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            
            #line 52 "..\..\PanelAdministracyjny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonDodajWycieczke);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 53 "..\..\PanelAdministracyjny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonEdytujWycieczke);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 54 "..\..\PanelAdministracyjny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonUsunWycieczke);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Klienci = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            
            #line 71 "..\..\PanelAdministracyjny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonDodajKlienta);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

