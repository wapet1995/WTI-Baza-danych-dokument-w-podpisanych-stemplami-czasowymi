#pragma checksum "..\..\register.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5635F4405103CAF15FE4814C2E1B04AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
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
using WTIStemple;


namespace WTIStemple
{


    /// <summary>
    /// register
    /// </summary>
    public partial class register : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;

#line default
#line hidden


#line 11 "..\..\register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;

#line default
#line hidden


#line 12 "..\..\register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;

#line default
#line hidden


#line 13 "..\..\register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;

#line default
#line hidden


#line 14 "..\..\register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3;

#line default
#line hidden


#line 15 "..\..\register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;

#line default
#line hidden


#line 19 "..\..\register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;

#line default
#line hidden


#line 20 "..\..\register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WTIStemple;component/register.xaml", System.UriKind.Relative);

#line 1 "..\..\register.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.textBlock = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 2:
                    this.label = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.label1 = ((System.Windows.Controls.Label)(target));
                    return;
                case 4:
                    this.label2 = ((System.Windows.Controls.Label)(target));
                    return;
                case 5:
                    this.label3 = ((System.Windows.Controls.Label)(target));
                    return;
                case 6:
                    this.textBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.passwordBox = ((System.Windows.Controls.PasswordBox)(target));
                    return;
                case 8:
                    this.passwordBox1 = ((System.Windows.Controls.PasswordBox)(target));
                    return;
                case 9:
                    this.textBox1 = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 10:
                    this.button = ((System.Windows.Controls.Button)(target));
                    return;
                case 11:
                    this.button1 = ((System.Windows.Controls.Button)(target));

#line 20 "..\..\register.xaml"
                    this.button1.Click += new System.Windows.RoutedEventHandler(this.button1_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox loginTextBox;
        internal System.Windows.Controls.PasswordBox passwordBox;
        internal System.Windows.Controls.TextBox emailTextBox;
    }
}

