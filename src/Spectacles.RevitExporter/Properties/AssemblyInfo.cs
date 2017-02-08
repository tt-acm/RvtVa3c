//The MIT License (MIT)

//Those portions created by va3c authors are provided with the following copyright:

//Copyright (c) 2014 va3c

//Those portions created by Thornton Tomasetti employees are provided with the following copyright:

//Copyright (c) 2015 Thornton Tomasetti

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

#region Namespaces
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#endregion // Namespaces

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Spectacles.RevitExporter")]
[assembly: AssemblyDescription("Revit custom exporter add-in generating JSON output for the Spectacles viewer")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Thornton Tomasetti")]
[assembly: AssemblyProduct("Spectacles.RevitExporter")]
[assembly: AssemblyCopyright("Copyright 2015-2017 © Thornton Tomasetti, et al.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("81E6DA01-3B56-443A-8AEC-1FC8A38CB674")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
//
// va3c release History:
// 2014-09-02 2015.0.0.19 minor cleanup before removing scene definition
// 2014-09-03 2015.0.0.20 fixed bug in SelectFile, need to determine full output path
// 2014-09-03 2015.0.0.21 replace top level json container Scene for Object3D
// 2014-09-04 2015.0.0.23 added new models, theo confirmed it works, added name property to materials
// 2014-09-22 2015.0.0.24 added all six standard revit sample models
// 2014-10-28 2015.0.0.25 added support for runtime reading of user settings and switch between indented JSON or not to optionally reduce file size
// 2014-10-29 2015.0.0.26 user setting enhancements
// 2014-11-24 2015.0.0.27 skip elements with null category
// 2014-11-25 2015.0.0.28 skip elements with null category in OnElementEnd as well
// 2015-02-15 2015.0.0.29 incremented copyright year
//
[assembly: AssemblyVersion("0.1.0.4")]
[assembly: AssemblyFileVersion("0.1.0.4")]