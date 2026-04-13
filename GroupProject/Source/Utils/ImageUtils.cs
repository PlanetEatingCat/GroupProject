/********************************************
Name: ImageUtils.cs
Purpose: Utilities for dealing with embedded images
Notes: Authored by Daniel
********************************************/

using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public static class ImageUtils
    {
        public static Image LoadPng(byte[] data)
        {
            using (var ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        public static Image TintImage(Image original, Color tint)
        {
            float r = tint.R / 255f;
            float g = tint.G / 255f;
            float b = tint.B / 255f;

            var colorMatrix = new ColorMatrix(new float[][]
            {
                new float[] { r, 0, 0, 0, 0 },
                new float[] { 0, g, 0, 0, 0 },
                new float[] { 0, 0, b, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { 0, 0, 0, 0, 1 }
            });

            var attributes = new ImageAttributes();
            attributes.SetColorMatrix(colorMatrix);

            var tinted = new Bitmap(original.Width, original.Height);

            using (var g2 = Graphics.FromImage(tinted))
            {
                g2.DrawImage(
                    original,
                    new Rectangle(0, 0, original.Width, original.Height),
                    0, 0, original.Width, original.Height,
                    GraphicsUnit.Pixel,
                    attributes
                );
            }

            return tinted;
        }

    }
}
