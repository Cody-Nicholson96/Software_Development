﻿

#pragma checksum "D:\Visual CSharp Step By Step\Chapter 13\Windows 8.1\Drawing - Complete\Drawing\DrawingPad.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BE8F9EF823F41DDC2361173717D9F800"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Drawing
{
    partial class DrawingPad : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 21 "..\..\DrawingPad.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.drawingCanvas_Tapped;
                 #line default
                 #line hidden
                #line 21 "..\..\DrawingPad.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).RightTapped += this.drawingCanvas_RightTapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

