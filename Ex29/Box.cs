using System;
using System.Collections.Generic;
using System.Text;

namespace Ex29
{
    class Box
    {

        public static float GetVolume(float width, float height, float depth)
        {
            return width * height * depth;
        }
        public static float GetSurface(float width,float height,float depth)
        {
            return (width * height + height * depth + depth * width) * 2;
        }
    }
}
