/********************************************
Name: ImageUtils.cs
Purpose: Utilities for dealing with embedded images
Notes: 
********************************************/

using System;
using System.Collections.Generic;
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
    }
}
