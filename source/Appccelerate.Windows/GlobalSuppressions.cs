﻿//-------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Appccelerate">
//   Copyright (c) 2008-2013
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "Appccelerate.Windows.ApplicationHelper+NativeMethods.ShowWindowAsync(System.IntPtr,System.Int32)", Scope = "member", Target = "Appccelerate.Windows.ApplicationHelper.#CheckApplicationAlreadyRunning(System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1414:MarkBooleanPInvokeArgumentsWithMarshalAs", Scope = "member", Target = "Appccelerate.Windows.ApplicationHelper+NativeMethods.#IsWindowVisible(System.IntPtr)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1414:MarkBooleanPInvokeArgumentsWithMarshalAs", Scope = "member", Target = "Appccelerate.Windows.ApplicationHelper+NativeMethods.#SwitchToThisWindow(System.IntPtr,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "Appccelerate.Windows.GraphicHelper+NativeMethods.ReleaseDC(System.IntPtr,System.IntPtr)", Scope = "member", Target = "Appccelerate.Windows.GraphicHelper.#GetDpi()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Appccelerate.Windows.GraphicHelper.#GetDpi()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#AdjustTokenPrivileges(System.Int32,System.Int32,Appccelerate.Windows.WindowsHelper+TOKEN_PRIVILEGES&,System.Int32,System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", MessageId = "0", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#AdjustTokenPrivileges(System.Int32,System.Int32,Appccelerate.Windows.WindowsHelper+TOKEN_PRIVILEGES&,System.Int32,System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", MessageId = "4", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#AdjustTokenPrivileges(System.Int32,System.Int32,Appccelerate.Windows.WindowsHelper+TOKEN_PRIVILEGES&,System.Int32,System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", MessageId = "5", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#AdjustTokenPrivileges(System.Int32,System.Int32,Appccelerate.Windows.WindowsHelper+TOKEN_PRIVILEGES&,System.Int32,System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "Appccelerate.Windows.WindowsHelper.AdjustTokenPrivileges(System.Int32,System.Int32,Appccelerate.Windows.WindowsHelper+TOKEN_PRIVILEGES@,System.Int32,System.Int32,System.Int32)", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#ExitSystem(Appccelerate.Windows.WindowsHelper+EWX_ENUM)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "value", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#ExitSystem(Appccelerate.Windows.WindowsHelper+EWX_ENUM)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ewx", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#ExitSystem(Appccelerate.Windows.WindowsHelper+EWX_ENUM)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#ExitSystem(Appccelerate.Windows.WindowsHelper+EWX_ENUM)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1414:MarkBooleanPInvokeArgumentsWithMarshalAs", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#ExitwindowsEx(System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#ExitwindowsEx(System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1400:PInvokeEntryPointsShouldExist", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#ExitwindowsEx(System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#GetCurrentProcess()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1414:MarkBooleanPInvokeArgumentsWithMarshalAs", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#LookupPrivilegeValue(System.String,System.String,Appccelerate.Windows.WindowsHelper+LUID&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#LookupPrivilegeValue(System.String,System.String,Appccelerate.Windows.WindowsHelper+LUID&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "0", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#LookupPrivilegeValue(System.String,System.String,Appccelerate.Windows.WindowsHelper+LUID&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "1", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#LookupPrivilegeValue(System.String,System.String,Appccelerate.Windows.WindowsHelper+LUID&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1414:MarkBooleanPInvokeArgumentsWithMarshalAs", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#OpenProcessToken(System.Int32,System.UInt32,System.Int32&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#OpenProcessToken(System.Int32,System.UInt32,System.Int32&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", MessageId = "0", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper.#OpenProcessToken(System.Int32,System.UInt32,System.Int32&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1714:FlagsEnumsShouldHavePluralNames", Scope = "type", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ENUM", Scope = "type", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "type", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "type", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCE")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FORCE", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCE")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCE")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNG")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FORCEIFHUNG", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNG")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNG")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNGLOGOFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FORCEIFHUNGLOGOFF", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNGLOGOFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNGLOGOFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNGPOWEROFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FORCEIFHUNGPOWEROFF", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNGPOWEROFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNGPOWEROFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNGREBOOT")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FORCEIFHUNGREBOOT", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNGREBOOT")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNGREBOOT")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNGSHUTDOWN")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FORCEIFHUNGSHUTDOWN", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNGSHUTDOWN")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEIFHUNGSHUTDOWN")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCELOGOFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FORCELOGOFF", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCELOGOFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCELOGOFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEPOWEROFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FORCEPOWEROFF", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEPOWEROFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEPOWEROFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEREBOOT")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FORCEREBOOT", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEREBOOT")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCEREBOOT")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCESHUTDOWN")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FORCESHUTDOWN", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCESHUTDOWN")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_FORCESHUTDOWN")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "LOGOFF", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_LOGOFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_LOGOFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LOGOFF", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_LOGOFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_LOGOFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_POWEROFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "POWEROFF", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_POWEROFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_POWEROFF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_REBOOT")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "REBOOT", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_REBOOT")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_REBOOT")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SHUTDOWN", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_SHUTDOWN")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_SHUTDOWN")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EWX", Scope = "member", Target = "Appccelerate.Windows.WindowsHelper+EWX_ENUM.#EWX_SHUTDOWN")]
