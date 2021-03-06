﻿using System.IO;
using BBPalCalc.Interfaces;
using BBPalCalc.PictureFormats;

namespace BBPalCalc
{
    public static class PictureFactory
    {
        public static IPicture GetPicture(string filename)
        {
            var ext = Path.GetExtension(filename).ToLowerInvariant();
            IPicture picture = null;
            if (ext == ".pi1") picture = new Pi1Picture();
            if (ext == ".iff") picture = new IffPicture();
            if (picture != null && picture.Load(filename)) return picture;
            return null;
        }
    }
}
