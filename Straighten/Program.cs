using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.Util;
using Emgu.CV.Structure;

namespace Straighten
{
    class Program
    {
        static void Main(string[] args)
        {
            Image<Bgra, Byte> img = new Image<Bgra, byte>(args[0]); 
            Image<Gray, Byte> gray = img.Convert<Gray, byte>();
            
            Emgu.CV.Structure.MCvMat bw = new MCvMat();
            CvInvoke.cvCvtColor(image, bw, COLOR_CONVERSION.CV_BGR2GRAY);
        }
    }
}
