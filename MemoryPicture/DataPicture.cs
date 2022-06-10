using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryPicture
{
    class DataPicture
    {
        public int i;
       public static Image level11 = Image.FromFile(@"..\..\pictures\\1.png");
       public static Image level12 = Image.FromFile(@"..\..\pictures\\2.jpg");
       public static Image level13 = Image.FromFile(@"..\..\pictures\\3.jpg");
       public static Image level14 = Image.FromFile(@"..\..\pictures\\4.jpg");
       public static Image level15 = Image.FromFile(@"..\..\pictures\\5.jpg");
       public static Image level16 = Image.FromFile(@"..\..\pictures\\6.jpg");
       public static Image level17 = Image.FromFile(@"..\..\pictures\\7.jpg");
       public static Image level18 = Image.FromFile(@"..\..\pictures\\8.jpg");
       public static Image level19 = Image.FromFile(@"..\..\pictures\\9.png");
       public static Image level110 = Image.FromFile(@"..\..\pictures\\1.png");


    //    public static Image level21 = Image.FromFile(@"..\..\pictures\\11.png");
        public static Image level22 = Image.FromFile(@"..\..\pictures\\12.jpg");
        public static Image level23 = Image.FromFile(@"..\..\pictures\\13.jpg");
        public static Image level24 = Image.FromFile(@"..\..\pictures\\14.jpg");
        public static Image level25 = Image.FromFile(@"..\..\pictures\\15.jpg");
        public static Image level26 = Image.FromFile(@"..\..\pictures\\16.jpg");
        public static Image level27 = Image.FromFile(@"..\..\pictures\\17.jpg");
        public static Image level28 = Image.FromFile(@"..\..\pictures\\18.gif");
        public static Image level29 = Image.FromFile(@"..\..\pictures\\19.jpg");
        public static Image level210 = Image.FromFile(@"..\..\pictures\\20.jpg");
                
                
        public static Image level31 = Image.FromFile(@"..\..\pictures\\21.jpg");
        public static Image level32 = Image.FromFile(@"..\..\pictures\\22.png");
        public static Image level33 = Image.FromFile(@"..\..\pictures\\23.jpg");
        public static Image level34 = Image.FromFile(@"..\..\pictures\\24.jpg");
    //    public static Image level35 = Image.FromFile(@"..\..\pictures\\25.jpg");
        public static Image level36 = Image.FromFile(@"..\..\pictures\\26.jpg");
        public static Image level37 = Image.FromFile(@"..\..\pictures\\27.jpg");
        public static Image level38 = Image.FromFile(@"..\..\pictures\\28.jpg");
        public static Image level39 = Image.FromFile(@"..\..\pictures\\29.jpg");
        public static Image level310 = Image.FromFile(@"..\..\pictures\\30.jpg");
                                                                           
        public static Image level41 = Image.FromFile(@"..\..\pictures\\31.jpg");
        public static Image level42 = Image.FromFile(@"..\..\pictures\\32.jpg");
        public static Image level43 = Image.FromFile(@"..\..\pictures\\33.jpg");
        public static Image level44 = Image.FromFile(@"..\..\pictures\\34.jpg");
        public static Image level45 = Image.FromFile(@"..\..\pictures\\35.jpg");
        public static Image level46 = Image.FromFile(@"..\..\pictures\\36.jpg");
        public static Image level47 = Image.FromFile(@"..\..\pictures\\37.jpg");
        public static Image level48 = Image.FromFile(@"..\..\pictures\\38.jpg");
        public static Image level49 = Image.FromFile(@"..\..\pictures\\39.jpg");
   //     public static Image level410 = Image.FromFile(@"..\..\pictures\\40.jpg");
                                                                         
        public static Image level51 = Image.FromFile(@"..\..\pictures\\41.jpg");
        public static Image level52 = Image.FromFile(@"..\..\pictures\\42.jpg");
        public static Image level53 = Image.FromFile(@"..\..\pictures\\43.jpg");
        public static Image level54 = Image.FromFile(@"..\..\pictures\\44.jpg");
        public static Image level55 = Image.FromFile(@"..\..\pictures\\45.jpg");
        public static Image level56 = Image.FromFile(@"..\..\pictures\\46.jpg");
        public static Image level57 = Image.FromFile(@"..\..\pictures\\47.jpg");
        public static Image level58 = Image.FromFile(@"..\..\pictures\\48.jpg");
        public static Image level59 = Image.FromFile(@"..\..\pictures\\49.jpg");
        public static Image level510 = Image.FromFile(@"..\..\pictures\\50.jpg");

        public static Image level61 = Image.FromFile(@"..\..\pictures\\51.jpg");
        public static Image level62 = Image.FromFile(@"..\..\pictures\\52.jpg");
        public static Image level63 = Image.FromFile(@"..\..\pictures\\53.jpg");
        public static Image level64 = Image.FromFile(@"..\..\pictures\\54.jpg");
        public static Image level65 = Image.FromFile(@"..\..\pictures\\55.jpg");
        public static Image level66 = Image.FromFile(@"..\..\pictures\\56.jpg");
        public static Image level67 = Image.FromFile(@"..\..\pictures\\57.png");
        public static Image level68 = Image.FromFile(@"..\..\pictures\\58.jpg");
   //     public static Image level69 = Image.FromFile(@"..\..\pictures\\59.jpg");
        public static Image level610 = Image.FromFile(@"..\..\pictures\\60.jpg");

        public DataPicture(int ii)
        {
            i = ii;
        }

        public DataPicture()
        {
        }

        public Image getPictureLevel1(int i)
        {
            switch (i)
            {
                case 1:
                    return level11;
                case 2:
                    return level12;
                case 3:
                    return level13;
                case 4:
                    return level14;
                case 5:
                    return level15;
                case 6:
                    return level16;
                case 7:
                    return level17;
                case 8:
                    return level18;
                case 9:
                    return level19;
                case 10:
                   return level110;
            }
            return null;
        }
        public Image getPictureLevel2(int i)
        {
            switch (i)
            {
        //        case 1:
       //             return level21;
                case 2:
                    return level22;
                case 3:
                    return level23;
                case 4:
                    return level24;
                case 5:
                    return level25;
                case 6:
                    return level26;
                case 7:
                    return level27;
                case 8:
                    return level28;
                case 9:
                    return level29;
                case 10:
                    return level210;
            }
            return null;
        }
        public Image getPictureLevel3(int i)
        {
            switch (i)
            {
                case 1:
                    return level31;
                case 2:
                    return level32;
                case 3:
                    return level33;
                case 4:
                    return level34;
                case 5:
      //              return level35;
                case 6:
                    return level36;
                case 7:
                    return level37;
                case 8:
                    return level38;
                case 9:
                    return level39;
                case 10:
                    return level310;
            }
            return null;
        }
        public Image getPictureLevel4(int i)
        {
            switch (i)
            {
                case 1:
                    return level41;
                case 2:
                    return level42;
                case 3:
                    return level43;
                    
                case 4:
                    return level44;
                case 5:
                    return level45;
                case 6:
                    return level46;
                case 7:
                    return level47;
                case 8:
                    return level48;
                case 9:
                    return level49;
                //case 10:
         //           return level410;
            }
            return null;
        }
        public  Image getPictureLevel5(int i)
        {
            switch (i)
            {
                case 1:
                    return level51;
                case 2:
                    return level52;
                case 3:
                    return level53;
                case 4:
                    return level54;
                case 5:
                    return level55;
                case 6:
                    return level56;
                case 7:
                    return level57;
                case 8:
                    return level58;
                case 9:
                    return level59;
                case 10:
                    return level610;
            }
            return null;
        }
        public Image getPictureLevel6(int i)
        {
            switch (i)
            {
                case 1:
                    return level61;
                case 2:
                    return level62;
                case 3:
                    return level63;
                case 4:
                    return level64;
                case 5:
                    return level65;
                case 6:
                    return level66;
                case 7:
                    return level67;
                case 8:
                    return level68;
                case 9:
       //             return level69;
                case 10:
                    return level610;
            }
            return null;
        }

    }
}

