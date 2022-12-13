using System;
using System.Collections.Generic;
using System.Text;

namespace Session_2
{
    class PhotoBook
    {
        protected int numPages;
        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
    }
    class BigPhotoBook:PhotoBook
    {
        public BigPhotoBook()
        {
            numPages = 64;
        }
    }
    class Class2
    {
        public static void Main3()
        {
            PhotoBook p1 = new PhotoBook();
            Console.WriteLine(p1.GetNumberPages());

            PhotoBook p2 = new PhotoBook(24);
            Console.WriteLine(p2.GetNumberPages());

            BigPhotoBook b = new BigPhotoBook();
            Console.WriteLine(b.GetNumberPages());
        }
    }
}
