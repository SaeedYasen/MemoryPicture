using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryPicture
{
   public class GetDataPicture
    {
        public int i;
      public Image level11 = Image.FromFile(@"..\..\pictures\\ 1.png");
      public Image level12 = Image.FromFile(@"..\..\pictures\\2.png");
      public Image level13 = Image.FromFile(@"..\..\pictures\\3.png");
      public Image level14 = Image.FromFile(@"..\..\pictures\\4.png");
      public Image level15 = Image.FromFile(@"..\..\pictures\\5.png");
      public Image level16 = Image.FromFile(@"..\..\pictures\\6.png");
      public Image level17 = Image.FromFile(@"..\..\pictures\\7.png");
      public Image level18 = Image.FromFile(@"..\..\pictures\\8.png");
      public Image level19 = Image.FromFile(@"..\..\pictures\\9.png");
      public Image level110 = Image.FromFile(@"..\..\pictures\\10.png");


      public Image level11 = Image.FromFile(@"..\..\pictures\\11.png");
      public Image level12 = Image.FromFile(@"..\..\pictures\\12.png");
      public Image level13 = Image.FromFile(@"..\..\pictures\\13.png");
      public Image level14 = Image.FromFile(@"..\..\pictures\\14.png");
      public Image level15 = Image.FromFile(@"..\..\pictures\\15.png");
      public Image level16 = Image.FromFile(@"..\..\pictures\\16.png");
      public Image level17 = Image.FromFile(@"..\..\pictures\\17.png");
      public Image level18 = Image.FromFile(@"..\..\pictures\\18.png");
      public Image level19 = Image.FromFile(@"..\..\pictures\\19.png");
        public Image level110 = Image.FromFile(@"..\..\pictures\\20.png");


       public Image level21 = Image.FromFile(@"..\..\pictures\\21.png");
       public Image level22 = Image.FromFile(@"..\..\pictures\\22.png");
       public Image level23 = Image.FromFile(@"..\..\pictures\\23.png");
       public Image level24 = Image.FromFile(@"..\..\pictures\\24.png");
       public Image level25 = Image.FromFile(@"..\..\pictures\\25.png");
       public Image level26 = Image.FromFile(@"..\..\pictures\\26.png");
       public Image level27 = Image.FromFile(@"..\..\pictures\\27.png");
       public Image level28 = Image.FromFile(@"..\..\pictures\\28.png");
       public Image level29 = Image.FromFile(@"..\..\pictures\\29.png");
        public Image level210 = Image.FromFile(@"..\..\pictures\\30.png");

      public Image level31 = Image.FromFile(@"..\..\pictures\\31.png");
      public Image level32 = Image.FromFile(@"..\..\pictures\\32.png");
      public Image level33 = Image.FromFile(@"..\..\pictures\\33.png");
      public Image level34 = Image.FromFile(@"..\..\pictures\\34.png");
      public Image level35 = Image.FromFile(@"..\..\pictures\\35.png");
      public Image level36 = Image.FromFile(@"..\..\pictures\\36.png");
      public Image level37 = Image.FromFile(@"..\..\pictures\\37.png");
      public Image level38 = Image.FromFile(@"..\..\pictures\\38.png");
      public Image level39 = Image.FromFile(@"..\..\pictures\\39.png");
        public Image level310 = Image.FromFile(@"..\..\pictures\\40.png");

      public Image level41 = Image.FromFile(@"..\..\pictures\\41.png");
      public Image level42 = Image.FromFile(@"..\..\pictures\\42.png");
      public Image level43 = Image.FromFile(@"..\..\pictures\\43.png");
      public Image level44 = Image.FromFile(@"..\..\pictures\\44.png");
      public Image level45 = Image.FromFile(@"..\..\pictures\\45.png");
      public Image level46 = Image.FromFile(@"..\..\pictures\\46.png");
      public Image level47 = Image.FromFile(@"..\..\pictures\\47.png");
      public Image level48 = Image.FromFile(@"..\..\pictures\\48.png");
      public Image level49 = Image.FromFile(@"..\..\pictures\\49.png");
      public Image level410 = Image.FromFile(@"..\..\pictures\\50.png");
      public Image level51 = Image.FromFile(@"..\..\pictures\\51.png");
      public Image level52 = Image.FromFile(@"..\..\pictures\\52.png");
      public Image level53 = Image.FromFile(@"..\..\pictures\\53.png");
      public Image level54 = Image.FromFile(@"..\..\pictures\\54.png");
      public Image level55 = Image.FromFile(@"..\..\pictures\\55.png");
      public Image level56 = Image.FromFile(@"..\..\pictures\\56.png");
      public Image level57 = Image.FromFile(@"..\..\pictures\\57.png");
      public Image level58 = Image.FromFile(@"..\..\pictures\\58.png");
      public Image level59 = Image.FromFile(@"..\..\pictures\\59.png");
      public Image level510 = Image.FromFile(@"..\..\pictures\\60.png");

        public GetDataPicture(int ii)
        {
            i = ii;
        }
        public static Image getPictureLevel1(int i)
        {
            switch(i)
            {
                case 1:
                    return level11;
                    break;
                case 2:
                    return level12;
                    break;
                case 3:
                    return level13;
                    break;
                case 4:
                    return level14;
                    break;
                case 5:
                    return level15;
                    break;
                case 6:
                    return level16;
                    break;
                case 7:
                    return level17;
                    break;
                case 8:
                    return level18;
                    break;
                case 9:
                    return level19;
                    break;
                case 10:
                    return level110;
                    break;
            }
            return null;
        }
        public static Image getPictureLevel2(int i)
        {
            switch (i)
            {
                case 1:
                    return level21;
                    break;
                case 2:
                    return level22;
                    break;
                case 3:
                    return level23;
                    break;
                case 4:
                    return level24;
                    break;
                case 5:
                    return level25;
                    break;
                case 6:
                    return level26;
                    break;
                case 7:
                    return level27;
                    break;
                case 8:
                    return level28;
                    break;
                case 9:
                    return level29;
                    break;
                case 10:
                    return level210;
                    break;
            }
            return null;
        }
        public static Image getPictureLevel3(int i)
        {
            switch (i)
            {
                case 1:
                    return level31;
                    break;
                case 2:
                    return level132;
                    break;
                case 3:
                    return level33;
                    break;
                case 4:
                    return level34;
                    break;
                case 5:
                    return level35;
                    break;
                case 6:
                    return level36;
                    break;
                case 7:
                    return level37;
                    break;
                case 8:
                    return level38;
                    break;
                case 9:
                    return level39;
                    break;
                case 10:
                    return level310;
                    break;
            }
            return null;
        }
        public static Image getPictureLevel4(int i)
        {
            switch (i)
            {
                case 1:
                    return level41;
                    break;
                case 2:
                    return level42;
                    break;
                case 3:
                    return level43;
                    break;
                case 4:
                    return level44;
                    break;
                case 5:
                    return level45;
                    break;
                case 6:
                    return level46;
                    break;
                case 7:
                    return level47;
                    break;
                case 8:
                    return level48;
                    break;
                case 9:
                    return level49;
                    break;
                case 10:
                    return level410;
                    break;
            }
            return null;
        }
        public static Image getPictureLevel5(int i)
        {
            switch (i)
            {
                case 1:
                    return level51;
                    break;
                case 2:
                    return level52;
                    break;
                case 3:
                    return level53;
                    break;
                case 4:
                    return level54;
                    break;
                case 5:
                    return level55;
                    break;
                case 6:
                    return level56;
                    break;
                case 7:
                    return level57;
                    break;
                case 8:
                    return level58;
                    break;
                case 9:
                    return level59;
                    break;
                case 10:
                    return level610;
                    break;
            }
            return null;
        }
        public static Image getPictureLevel6(int i)
        {
            switch (i)
            {
                case 1:
                    return level61;
                    break;
                case 2:
                    return level62;
                    break;
                case 3:
                    return level63;
                    break;
                case 4:
                    return level64;
                    break;
                case 5:
                    return level65;
                    break;
                case 6:
                    return level66;
                    break;
                case 7:
                    return level67;
                    break;
                case 8:
                    return level68;
                    break;
                case 9:
                    return level69;
                    break;
                case 10:
                    return level610;
                    break;
            }
            return null;
        }

    }
}
