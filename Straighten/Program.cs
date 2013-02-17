using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.Util;
using Emgu.CV.Structure;

// https://github.com/bsdnoobz/opencv-code/blob/master/quad-segmentation.cpp
// for help

namespace Straighten
{
    class Program
    {
        static void Main(string[] args)
        {
            Image<Bgra, Byte> img = new Image<Bgra, byte>(args[0]);
            Image<Gray, Byte> bw = img.Convert<Gray, byte>();
            CvInvoke.cvSmooth(bw, bw, SMOOTH_TYPE.CV_BLUR);
            CvInvoke.cvCanny(bw, bw, 100, 100, 3);
            
        }
    }
}
