﻿#pragma checksum "..\..\DodajWycieczke.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "45DC6BFCD58A0BE81D9F9BE6E552863F"
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
    /// DodajWycieczke
    /// </summary>
    public partial class DodajWycieczke : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\DodajWycieczke.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxNazwaWycieczki;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\DodajWycieczke.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerDataRozpoczecia;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\DodajWycieczke.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerDataZakonczenia;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\DodajWycieczke.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxMiasto;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\DodajWycieczke.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxKraj;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\DodajWycieczke.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxCenaZaOsobe;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\DodajWycieczke.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLiczbaMiejsc;
        
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
            System.Uri resourceLocater = new System.Uri("/Admin;component/dodajwycieczke.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DodajWycieczke.xaml"
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
            
            #line 6 "..\..\DodajWycieczke.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonCofnij);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxNazwaWycieczki = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DatePickerDataRozpoczecia = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.DatePickerDataZakonczenia = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.TextBoxMiasto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TextBoxKraj = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TextBoxCenaZaOsobe = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TextBoxLiczbaMiejsc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 21 "..\..\DodajWycieczke.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonDodaj);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

