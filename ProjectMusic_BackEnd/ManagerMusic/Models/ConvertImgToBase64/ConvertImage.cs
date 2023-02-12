using System;

namespace ManagerMusic.Models.ConvertImgToBase64
{
    public class ConvertImage
    {
        //conver Image Bye -> File Staff
        public static byte[] ConverByeToImage(string sBase64string)
        {
            byte[] bytes = null;
            if (sBase64string != null)
            {
                bytes = Convert.FromBase64String(sBase64string);

            }
            return bytes;
        }
    }
}
