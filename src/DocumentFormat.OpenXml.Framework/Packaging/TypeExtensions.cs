using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class TypeExtensions : Dictionary<string, string?>
    {
        internal TypeExtensions()
        {
            this["image/unknown"] = ".bin";
            this["image/bmp"] = ".bmp";
            this["image/gif"] = ".gif";
            this["image/png"] = ".png";
            this["image/jp2"] = ".jp2";
            this["image/tif"] = ".tif";
            this["image/tiff"] = ".tiff";
            this["image/xbm"] = ".xbm";
            this["image/x-icon"] = ".ico";
            this["image/x-pcx"] = ".pcx";
            this["image/x-pcz"] = ".pcz";
            this["image/x-emz"] = ".emz";
            this["image/x-wmz"] = ".wmz";
            this["image/jpeg"] = ".jpeg";
            this["image/x-emf"] = ".emf";
            this["image/x-wmf"] = ".wmf";
            this["image/svg+xml"] = ".svg";
        }
    }
}
