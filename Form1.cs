using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g;
        // float W, H, w, h, /*x0, y0,*/ k;

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawBack()
        {
            // Начало работы
/*            
#region Масштабирование

            double W = ClientSize.Width;
            double H = ClientSize.Height;
            double w = ClientSize.Height;
            double h = ClientSize.Height;
            double k;

            if ((W / 16 * 9) < H)
            {
                w = 1;
                int t = Convert.ToInt32(Math.Round(W / 16)) * 16;
                while (w % 16 != 0)
                {
                    if (t < W) { W--; }
                    else if (t > W) { W++; }
                    else if (t == W) { w = W; }
                }

                k = w / 16;
                h = k * 9;
            }
            if ((W / 16 * 9) > H)
            {
                h = 1;
                int t = Convert.ToInt32(Math.Round(H / 9)) * 9;
                while (h % 9 != 0)
                {
                    if (t < H) { H--; }
                    else if (t > H) { H++; }
                    else if (t == H) { h = H; }
                }

                k = h / 9;
                w = k * 16;
            }

            //x0 = (W - w) / 2;
            //y0 = (H - h) / 2;
            
            // Коэфициент масштаба объектов
            //k = 0; 

#endregion
*/            
            g = CreateGraphics();
            g.Clear(Color.White);
#region Облака
            
            // Фон (Облака 0)
            SolidBrush background = new SolidBrush(Color.FromArgb(140, 165, 189));
            g.FillRectangle(background, 0, 0, 1280, 720);

            // Кисти для облаков
            SolidBrush cl1 = new SolidBrush(Color.FromArgb(99, 119, 148));
            SolidBrush cl2 = new SolidBrush(Color.FromArgb(66, 81, 112));
            SolidBrush cl3 = new SolidBrush(Color.FromArgb(41, 50, 86));
            SolidBrush cl4 = new SolidBrush(Color.FromArgb(20, 28, 66));
            SolidBrush cl5 = new SolidBrush(Color.FromArgb(8, 12, 52));



            // Облака 1
            g.FillEllipse(cl1, -16, -2, 34, 34);
            g.FillEllipse(cl1, -41, -4, 195, 116);
            g.FillEllipse(cl1, 117, 21, 104, 93);
            g.FillEllipse(cl1, 199, 5, 76, 74);
            g.FillEllipse(cl1, 260, 0, 72, 69);
            g.FillEllipse(cl1, 287, 15, 87, 77);
            g.FillEllipse(cl1, 358, 36, 98, 75);
            g.FillEllipse(cl1, 452, 65, 49, 42);
            g.FillEllipse(cl1, 474, 48, 61, 56);
            g.FillEllipse(cl1, 517, 29, 88, 80);
            g.FillEllipse(cl1, 598, 53, 56, 54);
            g.FillEllipse(cl1, 652, 63, 41, 41);
            g.FillEllipse(cl1, 662, 24, 56, 54);
            g.FillEllipse(cl1, 703, 13, 88, 58);
            g.FillEllipse(cl1, 767, 13, 24, 23);
            g.FillEllipse(cl1, 779, 10, 88, 72);
            g.FillEllipse(cl1, 865, 28, 42, 43);
            g.FillEllipse(cl1, 884, 1, 81, 83);
            g.FillEllipse(cl1, 936, -9, 44, 47);

            g.FillRectangle(cl1, 117, 50, 325, 90);
            g.FillRectangle(cl1, 442, 75, 180, 70);
            g.FillRectangle(cl1, 690, 50, 180, 47);
            g.FillRectangle(cl1, 900, 50, 180, 50);
            g.FillRectangle(cl1, 950, 0, 300, 50);


            // Облака 2
            g.FillEllipse(cl2, -23, 89, 92, 59);
            g.FillEllipse(cl2, 52, 72, 105, 88);
            g.FillEllipse(cl2, 135, 64, 87, 78);
            g.FillEllipse(cl2, 184, 79, 86, 83);
            g.FillEllipse(cl2, 256, 99, 105, 84);
            g.FillEllipse(cl2, 344, 131, 86, 83);
            g.FillEllipse(cl2, 377, 113, 83, 83);
            g.FillEllipse(cl2, 428, 94, 97, 89);
            g.FillEllipse(cl2, 514, 123, 62, 60);
            g.FillEllipse(cl2, 573, 134, 37, 36);
            g.FillEllipse(cl2, 582, 93, 58, 54);
            g.FillEllipse(cl2, 622, 83, 79, 42);
            g.FillEllipse(cl2, 695, 78, 36, 31);
            g.FillEllipse(cl2, 724, 72, 54, 43);
            g.FillEllipse(cl2, 768, 88, 41, 37);
            g.FillEllipse(cl2, 802, 84, 64, 51);
            g.FillEllipse(cl2, 847, 58, 102, 83);
            g.FillEllipse(cl2, 945, 78, 68, 55);
            g.FillEllipse(cl2, 1009, 83, 58, 64);
            g.FillEllipse(cl2, 1019, 31, 97, 79);
            g.FillEllipse(cl2, 1083, 5, 139, 76);
            g.FillEllipse(cl2, 1200, -2, 123, 83);

            g.FillRectangle(cl2, 0, 130, 350, 90);
            g.FillRectangle(cl2, 570, 150, 350, 35);
            g.FillRectangle(cl2, 600, 100, 600, 60);
            g.FillRectangle(cl2, 1090, 50, 190, 60);


            //Облака 3
            g.FillEllipse(cl3, -58, 160, 146, 76);
            g.FillEllipse(cl3, 71, 176, 95, 83);
            g.FillEllipse(cl3, 146, 154, 87, 83);
            g.FillEllipse(cl3, 216, 141, 83, 75);
            g.FillEllipse(cl3, 249, 148, 90, 88);
            g.FillEllipse(cl3, 326, 166, 103, 83);
            g.FillEllipse(cl3, 420, 174, 95, 83);
            g.FillEllipse(cl3, 487, 156, 96, 101);
            g.FillEllipse(cl3, 573, 173, 55, 59);
            g.FillEllipse(cl3, 621, 138, 106, 103);
            g.FillEllipse(cl3, 705, 138, 58, 52);
            g.FillEllipse(cl3, 756, 146, 59, 55);
            g.FillEllipse(cl3, 808, 164, 31, 34);
            g.FillEllipse(cl3, 827, 166, 60, 41);
            g.FillEllipse(cl3, 858, 144, 86, 83);
            g.FillEllipse(cl3, 905, 116, 128, 113);
            g.FillEllipse(cl3, 1010, 138, 95, 86);
            g.FillEllipse(cl3, 1090, 156, 32, 30);
            g.FillEllipse(cl3, 1114, 77, 184, 147);

            g.FillRectangle(cl3, 0, 200, 1280, 90);
            g.FillRectangle(cl3, 700, 170, 300, 80);
            g.FillRectangle(cl3, 1000, 160, 280, 50);


            // Облака 4
            g.FillEllipse(cl4, 9, 264, 146, 76);
            g.FillEllipse(cl4, 127, 271, 95, 83);
            g.FillEllipse(cl4, 199, 246, 87, 83);
            g.FillEllipse(cl4, 259, 213, 113, 94);
            g.FillEllipse(cl4, 334, 246, 90, 88);
            g.FillEllipse(cl4, 397, 248, 76, 67);
            g.FillEllipse(cl4, 452, 269, 43, 42);
            g.FillEllipse(cl4, 483, 248, 73, 77);
            g.FillEllipse(cl4, 528, 229, 91, 89);
            g.FillEllipse(cl4, 613, 254, 58, 58);
            g.FillEllipse(cl4, 664, 264, 62, 64);
            g.FillEllipse(cl4, 678, 223, 59, 60);
            g.FillEllipse(cl4, 710, 213, 103, 94);
            g.FillEllipse(cl4, 762, 219, 60, 54);
            g.FillEllipse(cl4, 792, 220, 102, 88);
            g.FillEllipse(cl4, 888, 242, 67, 59);
            g.FillEllipse(cl4, 900, 225, 103, 100);
            g.FillEllipse(cl4, 961, 198, 125, 97);
            g.FillEllipse(cl4, 1072, 229, 103, 93);
            g.FillEllipse(cl4, 1155, 242, 41, 35);
            g.FillEllipse(cl4, 1175, 183, 95, 83);

            g.FillRectangle(cl4, 300, 275, 800, 95);

            // Облака 5
            g.FillEllipse(cl5, 387, 339, 85, 72);
            g.FillEllipse(cl5, 446, 326, 91, 79);
            g.FillEllipse(cl5, 533, 351, 59, 55);
            g.FillEllipse(cl5, 583, 357, 57, 59);
            g.FillEllipse(cl5, 622, 327, 59, 61);
            g.FillEllipse(cl5, 659, 300, 60, 65);
            g.FillEllipse(cl5, 701, 314, 63, 65);
            g.FillEllipse(cl5, 741, 339, 58, 65);
            g.FillEllipse(cl5, 781, 349, 43, 44);
            g.FillEllipse(cl5, 818, 325, 57, 59);

            g.FillRectangle(cl5, 300, 370, 800, 150);
            g.FillRectangle(cl5, 600, 360, 130, 150);
            #endregion
            
#region Горы
            // Кисти для Гор
            SolidBrush mo1 = new SolidBrush(Color.FromArgb(23, 11, 24));
            SolidBrush mo2 = new SolidBrush(Color.FromArgb(35, 20, 30));
            SolidBrush mo3 = new SolidBrush(Color.FromArgb(69, 34, 48));
            SolidBrush mo4 = new SolidBrush(Color.FromArgb(51, 25, 32));

    #region Горы 1
            Point[] m1 = new Point[22];

            m1[0] = new Point(0, 720);
            m1[1] = new Point(0, 276);
            m1[2] = new Point(55, 376);
            m1[3] = new Point(524, 468);
            m1[4] = new Point(546, 448);
            m1[5] = new Point(560, 488);
            m1[6] = new Point(585, 455);
            m1[7] = new Point(604, 489);
            m1[8] = new Point(620, 416);
            m1[9] = new Point(643, 471);
            m1[10] = new Point(702, 463);
            m1[11] = new Point(656, 344);
            m1[12] = new Point(839, 478);
            m1[13] = new Point(1069, 384);
            m1[14] = new Point(1022, 243);
            m1[15] = new Point(1105, 311);
            m1[16] = new Point(1099, 287);
            m1[17] = new Point(1141, 304);
            m1[18] = new Point(1111, 233);
            m1[19] = new Point(1186, 251);
            m1[20] = new Point(1280, 42);
            m1[21] = new Point(1280, 720);

            g.FillPolygon(mo1, m1);
            #endregion

    #region Горы 2
            Point[] m2 = new Point[62];

            m2[0] = new Point(0, 276);
            m2[1] = new Point(54, 204);
            m2[2] = new Point(49, 306);
            m2[3] = new Point(165, 266);
            m2[4] = new Point(210, 335);
            m2[5] = new Point(353, 169);
            m2[6] = new Point(318, 285);
            m2[7] = new Point(328, 344);
            m2[8] = new Point(511, 64);
            m2[9] = new Point(431, 372);
            m2[10] = new Point(483, 347);
            m2[11] = new Point(479, 431);
            m2[12] = new Point(521, 413);
            m2[13] = new Point(517, 505);
            m2[14] = new Point(578, 520);
            m2[15] = new Point(588, 543);
            m2[16] = new Point(746, 577);
            m2[17] = new Point(726, 641);
            m2[18] = new Point(905, 636);
            m2[19] = new Point(901, 584);
            m2[20] = new Point(830, 541);
            m2[21] = new Point(818, 598);
            m2[22] = new Point(680, 535);
            m2[23] = new Point(644, 472);
            m2[24] = new Point(661, 430);
            m2[25] = new Point(678, 440);
            m2[26] = new Point(688, 413);
            m2[27] = new Point(727, 430);
            m2[28] = new Point(718, 290);
            m2[29] = new Point(804, 375);
            m2[30] = new Point(797, 347);
            m2[31] = new Point(860, 381);
            m2[32] = new Point(862, 357);
            m2[33] = new Point(982, 427);
            m2[34] = new Point(907, 269);
            m2[35] = new Point(1150, 339);
            m2[36] = new Point(1110, 468);
            m2[37] = new Point(1088, 450);
            m2[38] = new Point(1006, 720);
            m2[39] = new Point(938, 720);
            m2[40] = new Point(895, 704);
            m2[41] = new Point(880, 720);
            m2[42] = new Point(806, 720);
            m2[43] = new Point(726, 641);
            m2[44] = new Point(687, 711);
            m2[45] = new Point(659, 692);
            m2[46] = new Point(650, 720);
            m2[47] = new Point(561, 720);
            m2[48] = new Point(339, 631);
            m2[49] = new Point(292, 661);
            m2[50] = new Point(237, 605);
            m2[51] = new Point(217, 656);
            m2[52] = new Point(155, 528);
            m2[53] = new Point(136, 587);
            m2[54] = new Point(122, 574);
            m2[55] = new Point(109, 603);
            m2[56] = new Point(0, 470);
            m2[57] = new Point(0, 276);
            m2[58] = new Point(522, 543);
            m2[59] = new Point(540, 525);
            m2[60] = new Point(580, 553);
            m2[61] = new Point(522, 543);

            g.FillPolygon(mo2, m2);
            #endregion

    #region Горы 3
            Point[] m3 = new Point[38];

            m3[0] = new Point(0, 374);
            m3[1] = new Point(67, 332);
            m3[2] = new Point(72, 347);
            m3[3] = new Point(155, 339);
            m3[4] = new Point(169, 386);
            m3[5] = new Point(293, 333);
            m3[6] = new Point(303, 389);
            m3[7] = new Point(380, 309);
            m3[8] = new Point(389, 462);
            m3[9] = new Point(456, 436);
            m3[10] = new Point(484, 526);
            m3[11] = new Point(726, 641);
            m3[12] = new Point(852, 649);
            m3[13] = new Point(886, 637);
            m3[14] = new Point(810, 448);
            m3[15] = new Point(1001, 542);
            m3[16] = new Point(791, 248);
            m3[17] = new Point(1125, 422);
            m3[18] = new Point(1110, 468);
            m3[19] = new Point(1088, 450);
            m3[20] = new Point(1035, 625);
            m3[21] = new Point(1000, 654);
            m3[22] = new Point(921, 654);
            m3[23] = new Point(886, 637);
            m3[24] = new Point(852, 649);
            m3[25] = new Point(726, 641);
            m3[26] = new Point(484, 526);
            m3[27] = new Point(212, 502);
            m3[28] = new Point(191, 437);
            m3[29] = new Point(146, 499);
            m3[30] = new Point(128, 465);
            m3[31] = new Point(103, 482);
            m3[32] = new Point(127, 388);
            m3[33] = new Point(57, 442);
            m3[34] = new Point(45, 421);
            m3[35] = new Point(21, 430);
            m3[36] = new Point(64, 384);
            m3[37] = new Point(0, 421);

            g.FillPolygon(mo3, m3);
            #endregion

    #region Горы 4
            Point[] m4 = new Point[31];

            m4[0] = new Point(212, 502);
            m4[1] = new Point(237, 479);
            m4[2] = new Point(261, 504);
            m4[3] = new Point(317, 466);
            m4[4] = new Point(403, 515);
            m4[5] = new Point(416, 490);
            m4[6] = new Point(472, 523);
            m4[7] = new Point(482, 516);
            m4[8] = new Point(522, 543);
            m4[9] = new Point(739, 580);
            m4[10] = new Point(603, 530);
            m4[11] = new Point(666, 500);
            m4[12] = new Point(691, 535);
            m4[13] = new Point(793, 507);
            m4[14] = new Point(842, 527);
            m4[15] = new Point(860, 571);
            m4[16] = new Point(830, 541);
            m4[17] = new Point(818, 595);
            m4[18] = new Point(880, 612);
            m4[19] = new Point(831, 606);
            m4[20] = new Point(855, 637);
            m4[21] = new Point(743, 657);
            m4[22] = new Point(726, 641);
            m4[23] = new Point(712, 666);
            m4[24] = new Point(676, 655);
            m4[25] = new Point(598, 673);
            m4[26] = new Point(566, 645);
            m4[27] = new Point(448, 643);
            m4[28] = new Point(432, 612);
            m4[29] = new Point(356, 602);
            m4[30] = new Point(337, 558);

            g.FillPolygon(mo4, m4);

            #endregion

#endregion

#region Очистка
            background.Dispose();

            cl1.Dispose();
            cl2.Dispose();
            cl3.Dispose();
            cl4.Dispose();
            cl5.Dispose();

            mo1.Dispose();
            mo2.Dispose();
            mo3.Dispose();
            mo4.Dispose();

            g.Dispose();
            g.Dispose();
            g.Dispose();
            g.Dispose();
#endregion
          
        }

        private void DrawRiver()
        {
            g = CreateGraphics();

#region Река
            SolidBrush ri = new SolidBrush(Color.FromArgb(17, 15, 55));

            Point[] r = new Point[14];

            r[0] = new Point(613, 525);
            r[1] = new Point(620, 560);
            r[2] = new Point(930, 560);
            r[3] = new Point(790, 650);
            r[4] = new Point(743, 657);
            r[5] = new Point(726, 641);
            r[6] = new Point(712, 666);
            r[7] = new Point(676, 655);
            r[8] = new Point(598, 673);
            r[9] = new Point(566, 645);
            r[10] = new Point(559, 645);
            r[11] = new Point(850, 620);
            r[12] = new Point(590, 549);
            r[13] = new Point(580, 525);

            byte[] typeR = new byte[14];

            typeR[0] = (byte)PathPointType.Start;
            typeR[1] = (byte)PathPointType.Bezier;
            typeR[2] = (byte)PathPointType.Bezier;
            typeR[3] = (byte)PathPointType.Bezier;
            typeR[4] = (byte)PathPointType.Line;
            typeR[5] = (byte)PathPointType.Line;
            typeR[6] = (byte)PathPointType.Line;
            typeR[7] = (byte)PathPointType.Line;
            typeR[8] = (byte)PathPointType.Line;
            typeR[9] = (byte)PathPointType.Line;
            typeR[10] = (byte)PathPointType.Bezier;
            typeR[11] = (byte)PathPointType.Bezier;
            typeR[12] = (byte)PathPointType.Bezier;
            typeR[13] = (byte)PathPointType.Line;

            GraphicsPath river = new GraphicsPath(r, typeR);

            g.FillPath(ri, river);
            #endregion

#region Горы поверх
            //Горы поверх 
            SolidBrush mo2 = new SolidBrush(Color.FromArgb(35, 20, 30));

            Point[] m2 = new Point[3];

            m2[0] = new Point(588, 543);
            m2[1] = new Point(675, 577);
            m2[2] = new Point(580, 553);

            g.FillPolygon(mo2, m2);
            #endregion

            mo2.Dispose();
            ri.Dispose();
        }

        private void DrawDemon()
        {
            g = CreateGraphics();

#region Заливка
            SolidBrush de1 = new SolidBrush(Color.Black);

            #region Тело
            Point[] d1 = new Point[8];

            d1[0] = new Point(690, 360);
            d1[1] = new Point(715, 422);
            d1[2] = new Point(715, 461);
            d1[3] = new Point(685, 533);
            d1[4] = new Point(605, 533);
            d1[5] = new Point(575, 461);
            d1[6] = new Point(575, 422);
            d1[7] = new Point(603, 360);

            byte[] typeD1 = new byte[8];

            typeD1[0] = (byte)PathPointType.Start;
            typeD1[1] = (byte)PathPointType.Bezier;
            typeD1[2] = (byte)PathPointType.Bezier;
            typeD1[3] = (byte)PathPointType.Bezier;
            typeD1[4] = (byte)PathPointType.Line;
            typeD1[5] = (byte)PathPointType.Bezier;
            typeD1[6] = (byte)PathPointType.Bezier;
            typeD1[7] = (byte)PathPointType.Bezier;

            GraphicsPath d1p = new GraphicsPath(d1, typeD1);

            g.FillEllipse(de1, 596, 269, 98, 329);
            g.FillEllipse(de1, 569, 214, 158, 163);
            g.FillPath(de1, d1p);
            #endregion

            #region Крылья
            byte[] typeD12 = new byte[20];

            typeD12[0] = (byte)PathPointType.Start;
            typeD12[1] = (byte)PathPointType.Bezier;
            typeD12[2] = (byte)PathPointType.Bezier;
            typeD12[3] = (byte)PathPointType.Bezier;
            typeD12[4] = (byte)PathPointType.Line;
            typeD12[5] = (byte)PathPointType.Line;
            typeD12[6] = (byte)PathPointType.Bezier;
            typeD12[7] = (byte)PathPointType.Bezier;
            typeD12[8] = (byte)PathPointType.Bezier;
            typeD12[9] = (byte)PathPointType.Line;
            typeD12[10] = (byte)PathPointType.Line;
            typeD12[11] = (byte)PathPointType.Line;
            typeD12[12] = (byte)PathPointType.Line;
            typeD12[13] = (byte)PathPointType.Line;
            typeD12[14] = (byte)PathPointType.Line;
            typeD12[15] = (byte)PathPointType.Line;
            typeD12[16] = (byte)PathPointType.Line;
            typeD12[17] = (byte)PathPointType.Line;
            typeD12[18] = (byte)PathPointType.Line;
            typeD12[19] = (byte)PathPointType.Line;


            //Крыло 1
            Point[] d11 = new Point[20];

            d11[0] = new Point(682, 368);
            d11[1] = new Point(737, 360);
            d11[2] = new Point(776, 340);

            d11[3] = new Point(799, 288);
            d11[4] = new Point(788, 272);

            d11[5] = new Point(807, 278);
            d11[6] = new Point(880, 308);
            d11[7] = new Point(930, 375);

            d11[8] = new Point(836, 530);
            d11[9] = new Point(835, 462);
            d11[10] = new Point(824, 468);
            d11[11] = new Point(816, 447);
            d11[12] = new Point(788, 484);
            d11[13] = new Point(774, 436);
            d11[14] = new Point(744, 464);
            d11[15] = new Point(740, 439);
            d11[16] = new Point(730, 455);
            d11[17] = new Point(722, 435);
            d11[18] = new Point(706, 443);
            d11[19] = new Point(690, 430);

            GraphicsPath d11p = new GraphicsPath(d11, typeD12);

            g.FillPath(de1, d11p);

            //Крыло 2
            Point[] d12 = new Point[20];

            d12[0] = new Point(605, 368);
            d12[1] = new Point(539, 360);
            d12[2] = new Point(500, 340);

            d12[3] = new Point(460, 288);
            d12[4] = new Point(480, 272);

            d12[5] = new Point(450, 278);
            d12[6] = new Point(371, 308);
            d12[7] = new Point(321, 400);

            d12[8] = new Point(450, 530);
            d12[9] = new Point(445, 465);
            d12[10] = new Point(460, 478);
            d12[11] = new Point(466, 452);
            d12[12] = new Point(488, 483);
            d12[13] = new Point(492, 462);
            d12[14] = new Point(510, 476);
            d12[15] = new Point(519, 440);
            d12[16] = new Point(537, 455);
            d12[17] = new Point(553, 430);
            d12[18] = new Point(571, 446);
            d12[19] = new Point(596, 430);

            GraphicsPath d12p = new GraphicsPath(d12, typeD12);

            g.FillPath(de1, d12p);

            #endregion

            de1.Dispose();
            #endregion

#region Контуры
            Pen de21 = new Pen(Color.FromArgb(141, 0, 0), 3);
            Pen de22 = new Pen(Color.FromArgb(40, 0, 0), 3);
            SolidBrush de23 = new SolidBrush(Color.FromArgb(70, 3, 0));
            SolidBrush de24 = new SolidBrush(Color.FromArgb(255, 128, 43));
            Pen de25 = new Pen(Color.FromArgb(90, 0, 0), 3);

            #region Лицо
            //Рога
            Point[] d21 = new Point[3];

            d21[0] = new Point(624, 219);
            d21[1] = new Point(618, 173);
            d21[2] = new Point(579, 255);

            g.FillPolygon(de23, d21);
            g.DrawPolygon(de22, d21);


            d21[0] = new Point(672, 219);
            d21[1] = new Point(678, 173);
            d21[2] = new Point(716, 255);

            g.FillPolygon(de23, d21);
            g.DrawPolygon(de22, d21);

            //Глаза
            Point[] d22 = new Point[5];

            d22[0] = new Point(632, 299);
            d22[1] = new Point(622, 330);
            d22[2] = new Point(577, 316);
            d22[3] = new Point(589, 276);
            d22[4] = new Point(638, 299);

            byte[] typeD22 = new byte[5];

            typeD22[0] = (byte)PathPointType.Start;
            typeD22[1] = (byte)PathPointType.Bezier;
            typeD22[2] = (byte)PathPointType.Bezier;
            typeD22[3] = (byte)PathPointType.Bezier;
            typeD22[4] = (byte)PathPointType.Line;

            GraphicsPath d221p = new GraphicsPath(d22, typeD22);

            g.FillPath(de23, d221p);
            g.FillEllipse(de24, 606, 285, 5, 22);
            g.DrawPath(de21, d221p);

            d22[0] = new Point(661, 299);
            d22[1] = new Point(674, 330);
            d22[2] = new Point(718, 316);
            d22[3] = new Point(705, 276);
            d22[4] = new Point(656, 299);

            GraphicsPath d222p = new GraphicsPath(d22, typeD22);

            g.FillPath(de23, d222p);
            g.FillEllipse(de24, 681, 285, 5, 22);
            g.DrawPath(de21, d222p);

            //Рот
            Point[] d23 = new Point[4];

            d23[0] = new Point(630, 335);
            d23[1] = new Point(637, 343);
            d23[2] = new Point(644, 335);
            d23[3] = new Point(660, 335);

            byte[] typeD23 = new byte[4];

            typeD23[0] = (byte)PathPointType.Start;
            typeD23[1] = (byte)PathPointType.Line;
            typeD23[2] = (byte)PathPointType.Line;
            typeD23[3] = (byte)PathPointType.Line;

            GraphicsPath d23p = new GraphicsPath(d23, typeD23);

            g.DrawPath(de21, d23p);


            #endregion

            #region Тело
            //Пузико
            Point[] d24 = new Point[4];

            d24[0] = new Point(613, 424);
            d24[1] = new Point(610, 452);
            d24[2] = new Point(610, 480);
            d24[3] = new Point(617, 503);

            g.DrawBeziers(de25, d24);

            d24[0] = new Point(676, 400);
            d24[1] = new Point(680, 415);
            d24[2] = new Point(681, 441);
            d24[3] = new Point(679, 463);

            g.DrawBeziers(de25, d24);

            g.DrawLine(de25, 646, 530, 646, 590);

            #endregion

            #region Крылья
            //Крыло 1
            Point[] d251 = new Point[4];

            d251[0] = new Point(555, 430);
            d251[1] = new Point(539, 420);
            d251[2] = new Point(525, 409);
            d251[3] = new Point(510, 389);

            g.DrawBeziers(de22, d251);

            d251[0] = new Point(450, 300);
            d251[1] = new Point(472, 349);
            d251[2] = new Point(485, 387);
            d251[3] = new Point(518, 423);

            g.DrawBeziers(de22, d251);

            d251[0] = new Point(460, 356);
            d251[1] = new Point(465, 392);
            d251[2] = new Point(477, 426);
            d251[3] = new Point(492, 453);

            g.DrawBeziers(de22, d251);

            d251[0] = new Point(450, 300);
            d251[1] = new Point(448, 371);
            d251[2] = new Point(453, 412);
            d251[3] = new Point(464, 445);

            g.DrawBeziers(de22, d251);

            Point[] d251b = new Point[7];

            d251b[0] = new Point(612, 370);
            d251b[1] = new Point(555, 374);
            d251b[2] = new Point(504, 347);
            d251b[3] = new Point(458, 301);
            d251b[4] = new Point(433, 300);
            d251b[5] = new Point(400, 337);
            d251b[6] = new Point(450, 525);

            byte[] typeD251b = new byte[7];

            typeD251b[0] = (byte)PathPointType.Start;
            typeD251b[1] = (byte)PathPointType.Bezier;
            typeD251b[2] = (byte)PathPointType.Bezier;
            typeD251b[3] = (byte)PathPointType.Bezier;
            typeD251b[4] = (byte)PathPointType.Bezier;
            typeD251b[5] = (byte)PathPointType.Bezier;
            typeD251b[6] = (byte)PathPointType.Bezier;

            GraphicsPath d251bp = new GraphicsPath(d251b, typeD251b);

            g.DrawPath(de25, d251bp);

            //Крыло 2
            Point[] d252 = new Point[4];

            d252[0] = new Point(757, 385);
            d252[1] = new Point(749, 404);
            d252[2] = new Point(739, 415);
            d252[3] = new Point(728, 425);

            g.DrawBeziers(de22, d252);

            d252[0] = new Point(808, 324);
            d252[1] = new Point(796, 360);
            d252[2] = new Point(778, 399);
            d252[3] = new Point(743, 433);

            g.DrawBeziers(de22, d252);

            d252[0] = new Point(809, 349);
            d252[1] = new Point(802, 380);
            d252[2] = new Point(795, 407);
            d252[3] = new Point(780, 430);

            g.DrawBeziers(de22, d252);

            d252[0] = new Point(814, 295);
            d252[1] = new Point(825, 346);
            d252[2] = new Point(827, 396);
            d252[3] = new Point(816, 446);

            g.DrawBeziers(de22, d252);

            Point[] d252b = new Point[7];

            d252b[0] = new Point(680, 370);
            d252b[1] = new Point(744, 366);
            d252b[2] = new Point(786, 335);
            d252b[3] = new Point(808, 295);
            d252b[4] = new Point(830, 300);
            d252b[5] = new Point(868, 337);
            d252b[6] = new Point(837, 525);

            byte[] typed252b = new byte[7];

            typed252b[0] = (byte)PathPointType.Start;
            typed252b[1] = (byte)PathPointType.Bezier;
            typed252b[2] = (byte)PathPointType.Bezier;
            typed252b[3] = (byte)PathPointType.Bezier;
            typed252b[4] = (byte)PathPointType.Bezier;
            typed252b[5] = (byte)PathPointType.Bezier;
            typed252b[6] = (byte)PathPointType.Bezier;

            GraphicsPath d252bp = new GraphicsPath(d252b, typed252b);

            g.DrawPath(de25, d252bp);
            #endregion

            #endregion
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawBack();
            DrawRiver();
            DrawDemon();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            DrawBack();
            DrawRiver();
            DrawDemon();
        }
    }
}