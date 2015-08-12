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
#endregion

namespace Spectacles.RevitExporter
{
  class UserSettings
  {
    const string _JsonIndent = "JsonIndent";

    const string _error_msg_format
      = "Invalid settings in '{0}':\r\n\r\n{1}"
      + "\r\n\r\nPlease add {2} = {3} or {4}.";

    static bool SyntaxError( string path, string s )
    {
      Util.ErrorMsg( string.Format(
        _error_msg_format, path, s, _JsonIndent,
        Boolean.TrueString, Boolean.FalseString ) );

      return false;
    }

    public static bool JsonIndented
    {
      get
      {
        string path = Assembly.GetExecutingAssembly()
          .Location;

        path = Path.ChangeExtension( path, "txt" );

        if( !File.Exists( path ) )
        {
          File.WriteAllText( path,
            _JsonIndent + "=" + Boolean.TrueString );

          Util.ErrorMsg( string.Format(
            "Created a new user settings file at '{0}'.",
            path ) );
        }

        string s1 = File.ReadAllText( path );

        // Todo: convert the following lines to a 
        // stand-alone helper method GetVariableValue( 
        // s, _JsonIndent, out bool rslt ), cf.
        // Z:\a\src\web\viewer\philippe\AdnGallery\add-ins\Autodesk.ADN.AddIns\Autodesk.ADN.RvtGalleryUploader\Util.cs

        int i = s1.IndexOf( _JsonIndent );

        if( 0 > i )
        {
          return SyntaxError( path, s1 );
        }

        string s = s1.Substring( i
          + _JsonIndent.Length );

        i = s.IndexOf( '=' );

        if( 0 > i )
        {
          return SyntaxError( path, s1 );
        }

        s = s.Substring( i + 1 ).Trim();

        bool rc;

        if( !Util.GetTrueOrFalse( s, out rc ) )
        {
          return SyntaxError( path, s1 );
        }

        return rc;
      }
    }
  }
}
