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

namespace RvtVa3c
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

        //new push button
      PushButtonData pbd = new PushButtonData(
          "Spectacles Exporter", "Spectacles \r\n Exporter",
          path, "RvtVa3c.Command" );

        //add tooltip
      pbd.ToolTip = "Export the current 3D view as a Spectacles.json file, which can be viewed with the Spectacles Web Viewer.";

        //add icons
      try
      {
          pbd.Image = LoadPngImgSource("Spectacles.RevitExporter.Resources.SPECTACLES_16px.png");
      }
      catch {}
      try
      {
          pbd.LargeImage = LoadPngImgSource("Spectacles.RevitExporter.Resources.SPECTACLES_32px.png");
      }
      catch { }


        //add button to panel
        p.AddItem( pbd );
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
          "Spectacles Exporter" ) );

      return Result.Succeeded;
    }

    public Result OnShutdown( UIControlledApplication a )
    {
      return Result.Succeeded;
    }
  }
}
