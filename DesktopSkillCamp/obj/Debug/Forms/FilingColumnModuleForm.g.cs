﻿#pragma checksum "..\..\..\Forms\FilingColumnModuleForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "10FF2995449D535CFC95BDBFF9E510D089485A1635D6B00092FDFE9B7EB05374"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DesktopSkillCamp.Forms;
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


namespace DesktopSkillCamp.Forms {
    
    
    /// <summary>
    /// FilingColumnModuleForm
    /// </summary>
    public partial class FilingColumnModuleForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Forms\FilingColumnModuleForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock mainText;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Forms\FilingColumnModuleForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbAZS;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Forms\FilingColumnModuleForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spZapravka;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Forms\FilingColumnModuleForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbViewT;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Forms\FilingColumnModuleForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbMode;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Forms\FilingColumnModuleForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPayment;
        
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
            System.Uri resourceLocater = new System.Uri("/DesktopSkillCamp;component/forms/filingcolumnmoduleform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Forms\FilingColumnModuleForm.xaml"
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
            this.mainText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.tbAZS = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.spZapravka = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.cbViewT = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cbMode = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cbPayment = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 29 "..\..\..\Forms\FilingColumnModuleForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clPayment);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 32 "..\..\..\Forms\FilingColumnModuleForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clBegin);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

