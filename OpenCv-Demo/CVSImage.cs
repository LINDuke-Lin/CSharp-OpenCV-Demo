using OpenCvSharp;

namespace OpenCv_Demo
{
    public class CVSImage
    {
        private Mat SrcImg { get; }

        public CVSImage(string imgPath, int readMode = 1)
        {
            SrcImg = Cv2.ImRead(imgPath, (ImreadModes)readMode);
        }

        public void ShowImage(string winName, int windowType = 1, int showTime = 0)
        {
            WindowMode mode = (WindowMode)windowType;
            Cv2.NamedWindow(winName, mode);
            Cv2.ImShow(winName, SrcImg);
            Cv2.WaitKey(showTime);
        }
    }
}
