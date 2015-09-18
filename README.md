Spectacles for Revit
=======

A Revit custom exporter add-in generating JSON output for the [Spectacles](http://tt-acm.github.io/Spectacles.WebViewer/) three.js web viewer.

First implemented as part of the vA3C project by Matt Mason and Jeremy Tammik at the New York AEC Hackathon in May 2014, continuing support of Spectacles by Thornton Tomasetti's [CORE studio](http://core.thorntontomasetti.com/).


Installation Instructions
---------------
- Download the latest build from [here](https://www.google.com/) --- update this once the download is available.
- Right click the downloaded .zip file > properties > click unblock button, then Apply, then OK.
- copy the Spectacles.RevitExporter.addin and Spectacles.RevitExporter.dll files into either of these two directories:
  - C:\Users\<yourUserName>\AppData\Roaming\Autodesk\Revit\Addins\<yourRevitVersion>
  - C:\ProgramData\Autodesk\Revit\Addins\<yourRevitVersion>  
- Restart Revit, then look for the Spectacles icon in the Addins tab in Revit's ribbon.


Tools and Technologies
----------------------

* [three.js JavaScript 3D Library](https://github.com/mrdoob/three.js)
* [Spectacles three.js AEC Viewer](http://tt-acm.github.io/Spectacles.WebViewer/)


Further Reading
---------------

* [AEC Hackathon – From the Midst of the Fray](http://thebuildingcoder.typepad.com/blog/2014/05/aec-hackathon-from-the-midst-of-the-fray.html)
* [RvtVa3c – Revit Va3c Generic AEC Viewer JSON Export](http://thebuildingcoder.typepad.com/blog/2014/05/rvtva3c-revit-va3c-generic-aec-viewer-json-export.html)
* [RvtVa3c Assembly Resolver](http://thebuildingcoder.typepad.com/blog/2014/05/rvtva3c-assembly-resolver.html)


Wishlist
--------

* Texture support
* Improved handling of normals to gracefully display non-planar surfaces
