using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace cryptography.Logic
{
    class ImageEncryption
    {
        Image img;

        public ImageEncryption(Image _img)
        {
            img = _img;
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static byte[] of(byte[] arr)
        {
            int i = 0, j = 0;
            byte[] result = new byte[arr.Length];
            bool boo = false;
            for (i = 0; i < arr.Length; i++)
            {
                for(j=i;j<arr.Length;j++){
                    if(i!=j&&arr[i]==arr[j]){
                        boo = true;
                    }
                }
                if (boo) result[i] = arr[i];
            }
            return result;

        }

        public Image code()
        {
            ImageConverter converter = new ImageConverter();
            
            byte[] lqlqlq = ImageToByte(img);
            byte []haa = of(lqlqlq);
            int i = 0;
            int j = 0;
            for (i = 0; i < lqlqlq.Length; i++)
            {
                for (j = 0; j < haa.Length;j++ )
                {
                    if (lqlqlq[i] == haa[j])
                    {
                        lqlqlq[i]=haa[(j+3)%haa.Length];
                    }
                }
            }
            return (Image)converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
