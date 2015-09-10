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
using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

using Spectacles.RevitExporter.Properties;

#endregion

namespace Spectacles.RevitExporter
{
  class App : IExternalApplication
  {
    /// <summary>
    /// Add buttons for our command
    /// to the ribbon panel.
    /// </summary>
    void PopulatePanel( RibbonPanel p )
    {
      string path = Assembly.GetExecutingAssembly()
        .Location;

        //new push button for exporter
      PushButtonData pbd = new PushButtonData(
          "Spectacles Exporter", "Spectacles \r\n Exporter",
          path, "Spectacles.RevitExporter.Command" );

        //add tooltip
      pbd.ToolTip = "Export the current 3D view as a Spectacles.json file, which can be viewed with the Spectacles Web Viewer.";

        //add icons
      try
      {
          pbd.LargeImage = LoadPngImgSource("Spectacles.RevitExporter.Resources.SPECTACLES_file_32px.png");
      }
      catch { }


        //add button to panel
        p.AddItem( pbd );


        //new push button for viewer
        PushButtonData viewerPdb = new PushButtonData("Spectacles Viewer", "Spectacles \r\n Viewer",
          path, "Spectacles.RevitExporter.Command_Viewer");

        viewerPdb.ToolTip = "Launch the Spectacles Web Viewer.";

        try
        {
            viewerPdb.LargeImage = LoadPngImgSource("Spectacles.RevitExporter.Resources.SPECTACLES_browser_32px.png");
        }
        catch (Exception)
        {}

        p.AddItem(viewerPdb);

    }

    /// <summary>
    /// Load an Embedded Resource Image
    /// </summary>
    /// <param name="SourceName">String path to Resource Image</param>
    /// <returns></returns>
    /// <remarks></remarks>
    private ImageSource LoadPngImgSource(string SourceName)
    {

        try
        {

            // Assembly
            Assembly m_assembly = Assembly.GetExecutingAssembly();

            // Stream
            Stream m_icon = m_assembly.GetManifestResourceStream(SourceName);

            // Decoder
            PngBitmapDecoder m_decoder = new PngBitmapDecoder(m_icon,
                             BitmapCreateOptions.PreservePixelFormat,
                             BitmapCacheOption.Default);

            // Source
            ImageSource m_source = m_decoder.Frames[0];
            return (m_source);

        }
        catch
        {
        }

        // Fail
        return null;

    }

    public Result OnStartup( UIControlledApplication a )
    {
      PopulatePanel(
        a.CreateRibbonPanel(
          "Spectacles" ) );

      return Result.Succeeded;
    }

    public Result OnShutdown( UIControlledApplication a )
    {
      return Result.Succeeded;
    }
  }
}
