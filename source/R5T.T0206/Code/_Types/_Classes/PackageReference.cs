using System;

using R5T.T0142;


namespace R5T.T0206
{
    /// <summary>
    /// The framework-typed package reference data for the Visual Studio (MSBuild) project file.
    /// </summary>
    [DataTypeMarker]
    public class PackageReference
    {
        public string Name { get; set; }
        public Version Version { get; set; }
    }
}
