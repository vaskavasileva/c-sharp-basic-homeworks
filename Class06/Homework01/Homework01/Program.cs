using System;

namespace Homework01
{
    class PhotoAlbum
    {
        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int specificNumberOfPages)
        {
            numberOfPages = specificNumberOfPages;
        }

        private int numberOfPages;

        public void GetNumberOfPages()
        {
            Console.WriteLine(numberOfPages);
        }

    }

    class BigPhotoAlbum
    {
        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }

        private int numberOfPages;

        public void GetNumberOfPages()
        {
            Console.WriteLine(numberOfPages);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var photoAlbum1 = new PhotoAlbum();
            Console.Write($"The number of pages in the deafult photo album is: ");
            photoAlbum1.GetNumberOfPages();

            var photoAlbum2 = new PhotoAlbum(24);
            Console.Write($"The number of pages in the custom photo album is: ");
            photoAlbum2.GetNumberOfPages();

            var bigPhotoAlbum = new BigPhotoAlbum();
            Console.Write($"The number of pages in the big photo album is: ");
            bigPhotoAlbum.GetNumberOfPages();

        }
    }
}
