﻿#pragma checksum "..\..\..\windows\FindDish.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9C8F09D4205EEF9D807344D47D8DD594"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using RCookBookDB;
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


namespace RCookBookDB {
    
    
    /// <summary>
    /// FindDish
    /// </summary>
    public partial class FindDish : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\windows\FindDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l_wyszukaj;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\windows\FindDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Name;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\windows\FindDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l_danie;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\windows\FindDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbox_Meat;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\windows\FindDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l_lista;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\windows\FindDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_Dishes;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\windows\FindDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Close;
        
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
            System.Uri resourceLocater = new System.Uri("/RevCookBook;component/windows/finddish.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\FindDish.xaml"
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
            
            #line 9 "..\..\..\windows\FindDish.xaml"
            ((RCookBookDB.FindDish)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.l_wyszukaj = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.tb_Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\windows\FindDish.xaml"
            this.tb_Name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_Name_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.l_danie = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.cbox_Meat = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\..\windows\FindDish.xaml"
            this.cbox_Meat.Checked += new System.Windows.RoutedEventHandler(this.cbox_Meat_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.l_lista = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lv_Dishes = ((System.Windows.Controls.ListView)(target));
            
            #line 30 "..\..\..\windows\FindDish.xaml"
            this.lv_Dishes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lv_Dishes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_Close = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\windows\FindDish.xaml"
            this.btn_Close.Click += new System.Windows.RoutedEventHandler(this.btn_Close_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

