using System;
using System.Collections.ObjectModel;
using static System.Math;

namespace Raschet_peredachi
{
    public partial class Form1 : Form
    {
        struct table1Struct
        {
            string _zv;
            string _x;
            string _yf;

            public table1Struct(string zv, string x, string yf)
            {
                _zv = zv;
                _x = x;
                _yf = yf;
            }
            public string ZV { get { return _zv; } }
            public string X { get { return _x; } }
            public string YF { get { return _yf; } }
        }
        struct table2Struct
        {
            string _psi_bd;
            string _vidOpor;
            string _hb;
            string _kfb;

            public table2Struct(string psibd, string vidOpor, string hb, string kfb)
            {
                _psi_bd = psibd;
                _vidOpor = vidOpor;
                _hb = hb;
                _kfb = kfb;
            }
            public string PSI_BD { get { return _psi_bd; } }
            public string VIDOPOR { get { return _vidOpor; } }
            public string HB { get { return _hb; } }
            public string KFB { get { return _kfb; } }
        }
        struct table3Struct
        {
            string _psi_bd;
            string _ld;
            string _hb;
            string _kfb;

            public table3Struct(string psibd, string ld, string hb, string kfb)
            {
                _psi_bd = psibd;
                _ld = ld;
                _hb = hb;
                _kfb = kfb;
            }
            public string PSI_BD { get { return _psi_bd; } }
            public string LD { get { return _ld; } }
            public string HB { get { return _hb; } }
            public string KFB { get { return _kfb; } }
        }
        struct table4Struct
        {
            string _m;
            string _tochnost_n;
            string _g0;

            public table4Struct(string m, string tochnost_n, string g0)
            {
                _m = m;
                _tochnost_n = tochnost_n;
                _g0 = g0;
            }
            public string M { get { return _m; } }
            public string TOCHNOST_N { get { return _tochnost_n; } }
            public string G0 { get { return _g0; } }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YF.Text = "";
            Ye.Text = "";
            Yb.Text = "";
            Ft.Text = "";
            e_beta.Text = "";
            KFa.Text = "";
            e_a.Text = "";
            psi_bd.Text = "";
            KFb.Text = "";
            deltaF.Text = "";
            g0.Text = "";
            u.Text = "";
            wFv.Text = "";
            KFv.Text = "";
            wFt.Text = "";
            sigma_F.Text = "";
            delta.Text = "";

            IList<table1Struct> table1 = new ReadOnlyCollection<table1Struct>
            (new[] {
                new table1Struct ("14",   "0,7", "3,12"),
                new table1Struct ("14",   "0,5", "3,42"),
                new table1Struct ("14",   "0,3", "3,78"),

                new table1Struct ("16",   "0,7", "3,15"),
                new table1Struct ("16",   "0,5", "3,40"),
                new table1Struct ("16",   "0,3", "3,72"),

                new table1Struct ("17",   "0,7", "3,16"),
                new table1Struct ("17",   "0,5", "3,40"),
                new table1Struct ("17",   "0,3", "3,67"),
                new table1Struct ("17",   "0,1", "4,03"),
                new table1Struct ("17",   "0", "4,26"),

                new table1Struct ("18",   "0,7", "3,17"),
                new table1Struct ("18",   "0,5", "3,39"),
                new table1Struct ("18",   "0,3", "3,64"),
                new table1Struct ("18",   "0,1", "3,97"),
                new table1Struct ("18",   "0", "4,20"),

                new table1Struct ("19",   "0,7", "3,18"),
                new table1Struct ("19",   "0,5", "3,39"),
                new table1Struct ("19",   "0,3", "3,62"),
                new table1Struct ("19",   "0,1", "3,92"),
                new table1Struct ("19",   "0", "4,11"),
                new table1Struct ("19",   "-0,1", "4,32"),

                new table1Struct ("20",   "0,7", "3,19"),
                new table1Struct ("20",   "0,5", "3,39"),
                new table1Struct ("20",   "0,3", "3,61"),
                new table1Struct ("20",   "0,1", "3,89"),
                new table1Struct ("20",   "0", "4,08"),
                new table1Struct ("20",   "-0,1", "4,28"),

                new table1Struct ("21",   "0,7", "3,20"),
                new table1Struct ("21",   "0,5", "3,39"),
                new table1Struct ("21",   "0,3", "3,60"),
                new table1Struct ("21",   "0,1", "3,85"),
                new table1Struct ("21",   "0", "4,01"),
                new table1Struct ("21",   "-0,1", "4,22"),

                new table1Struct ("22",   "0,7", "3,21"),
                new table1Struct ("22",   "0,5", "3,39"),
                new table1Struct ("22",   "0,3", "3,59"),
                new table1Struct ("22",   "0,1", "3,82"),
                new table1Struct ("22",   "0", "4,00"),
                new table1Struct ("22",   "-0,1", "4,20"),

                new table1Struct ("24",   "0,7", "3,23"),
                new table1Struct ("24",   "0,5", "3,39"),
                new table1Struct ("24",   "0,3", "3,58"),
                new table1Struct ("24",   "0,1", "3,79"),
                new table1Struct ("24",   "0", "3,92"),
                new table1Struct ("24",   "-0,1", "4,10"),

                new table1Struct ("25",   "0,7", "3,24"),
                new table1Struct ("25",   "0,5", "3,39"),
                new table1Struct ("25",   "0,3", "3,57"),
                new table1Struct ("25",   "0,1", "3,77"),
                new table1Struct ("25",   "0", "3,90"),
                new table1Struct ("25",   "-0,1", "4,05"),
                new table1Struct ("25",   "-0,3", "4,28"),

                new table1Struct ("28",   "0,7", "3,27"),
                new table1Struct ("28",   "0,5", "3,40"),
                new table1Struct ("28",   "0,3", "3,56"),
                new table1Struct ("28",   "0,1", "3,72"),
                new table1Struct ("28",   "0", "3,82"),
                new table1Struct ("28",   "-0,1", "3,95"),
                new table1Struct ("28",   "-0,3", "4,22"),

                new table1Struct ("30",   "0,7", "3,28"),
                new table1Struct ("30",   "0,5", "3,40"),
                new table1Struct ("30",   "0,3", "3,54"),
                new table1Struct ("30",   "0,1", "3,70"),
                new table1Struct ("30",   "0", "3,80"),
                new table1Struct ("30",   "-0,1", "3,90"),
                new table1Struct ("30",   "-0,3", "4,14"),

                new table1Struct ("32",   "0,7", "3,29"),
                new table1Struct ("32",   "0,5", "3,51"),
                new table1Struct ("32",   "0,3", "3,54"),
                new table1Struct ("32",   "0,1", "3,69"),
                new table1Struct ("32",   "0", "3,78"),
                new table1Struct ("32",   "-0,1", "3,87"),
                new table1Struct ("32",   "-0,3", "4,08"),
                new table1Struct ("32",   "-0,5", "4,45"),

                new table1Struct ("37",   "0,7", "3,32"),
                new table1Struct ("37",   "0,5", "3,42"),
                new table1Struct ("37",   "0,3", "3,53"),
                new table1Struct ("37",   "0,1", "3,64"),
                new table1Struct ("37",   "0", "3,71"),
                new table1Struct ("37",   "-0,1", "3,80"),
                new table1Struct ("37",   "-0,3", "3,96"),
                new table1Struct ("37",   "-0,5", "4,20"),

                new table1Struct ("40",   "0,7", "3,33"),
                new table1Struct ("40",   "0,5", "3,42"),
                new table1Struct ("40",   "0,3", "3,53"),
                new table1Struct ("40",   "0,1", "3,63"),
                new table1Struct ("40",   "0", "3,70"),
                new table1Struct ("40",   "-0,1", "3,77"),
                new table1Struct ("40",   "-0,3", "3,92"),
                new table1Struct ("40",   "-0,5", "4,13"),

                new table1Struct ("45",   "0,7", "3,36"),
                new table1Struct ("45",   "0,5", "3,43"),
                new table1Struct ("45",   "0,3", "3,52"),
                new table1Struct ("45",   "0,1", "3,62"),
                new table1Struct ("45",   "0", "3,68"),
                new table1Struct ("45",   "-0,1", "3,72"),
                new table1Struct ("45",   "-0,3", "3,86"),
                new table1Struct ("45",   "-0,5", "4,02"),

                new table1Struct ("50",   "0,7", "3,38"),
                new table1Struct ("50",   "0,5", "3,44"),
                new table1Struct ("50",   "0,3", "3,52"),
                new table1Struct ("50",   "0,1", "3,60"),
                new table1Struct ("50",   "0", "3,65"),
                new table1Struct ("50",   "-0,1", "3,70"),
                new table1Struct ("50",   "-0,3", "3,81"),
                new table1Struct ("50",   "-0,5", "3,96"),

                new table1Struct ("60",   "0,7", "3,41"),
                new table1Struct ("60",   "0,5", "3,47"),
                new table1Struct ("60",   "0,3", "3,53"),
                new table1Struct ("60",   "0,1", "3,59"),
                new table1Struct ("60",   "0", "3,62"),
                new table1Struct ("60",   "-0,1", "3,67"),
                new table1Struct ("60",   "-0,3", "3,74"),
                new table1Struct ("60",   "-0,5", "3,84"),

                new table1Struct ("80",   "0,7", "3,45"),
                new table1Struct ("80",   "0,5", "3,50"),
                new table1Struct ("80",   "0,3", "3,54"),
                new table1Struct ("80",   "0,1", "3,58"),
                new table1Struct ("80",   "0", "3,61"),
                new table1Struct ("80",   "-0,1", "3,62"),
                new table1Struct ("80",   "-0,3", "3,68"),
                new table1Struct ("80",   "-0,5", "3,73"),

                new table1Struct ("100",   "0,7", "3,49"),
                new table1Struct ("100",   "0,5", "3,52"),
                new table1Struct ("100",   "0,3", "3,55"),
                new table1Struct ("100",   "0,1", "3,58"),
                new table1Struct ("100",   "0", "3,60"),
                new table1Struct ("100",   "-0,1", "3,61"),
                new table1Struct ("100",   "-0,3", "3,65"),
                new table1Struct ("100",   "-0,5", "3,68"),

                new table1Struct ("150",   "0", "3,60"),
                new table1Struct ("150",   "-0,1", "3,63"),
                new table1Struct ("150",   "-0,3", "3,63"),
                new table1Struct ("150",   "-0,5", "3,63"),

                new table1Struct ("Рейка",   "0", "3,63")

            });
            IList<table2Struct> table2 = new ReadOnlyCollection<table2Struct>
            (new[] {
                new table2Struct ("0,2", "Симметричное расположение шестерни относительно опор", ">350", "1,0"),
                new table2Struct ("0,2", "Симметричное расположение шестерни относительно опор", "<350", "1,0"),
                new table2Struct ("0,4", "Симметричное расположение шестерни относительно опор", ">350", "1,03"),
                new table2Struct ("0,4", "Симметричное расположение шестерни относительно опор", "<350", "1,01"),
                new table2Struct ("0,6", "Симметричное расположение шестерни относительно опор", ">350", "1,05"),
                new table2Struct ("0,6", "Симметричное расположение шестерни относительно опор", "<350", "1,02"),
                new table2Struct ("0,8", "Симметричное расположение шестерни относительно опор", ">350", "1,08"),
                new table2Struct ("0,8", "Симметричное расположение шестерни относительно опор", "<350", "1,05"),
                new table2Struct ("1", "Симметричное расположение шестерни относительно опор", ">350", "1,15"),
                new table2Struct ("1", "Симметричное расположение шестерни относительно опор", "<350", "1,08"),
                new table2Struct ("1,2", "Симметричное расположение шестерни относительно опор", ">350", "1,18"),
                new table2Struct ("1,2", "Симметричное расположение шестерни относительно опор", "<350", "1,10"),
                new table2Struct ("1,4", "Симметричное расположение шестерни относительно опор", ">350", "1,23"),
                new table2Struct ("1,4", "Симметричное расположение шестерни относительно опор", "<350", "1,13"),
                new table2Struct ("1,6", "Симметричное расположение шестерни относительно опор", ">350", "1,25"),
                new table2Struct ("1,6", "Симметричное расположение шестерни относительно опор", "<350", "1,16"),
                new table2Struct ("0,2", "Консольное расположение одного из колёс", ">350", "1,25"),
                new table2Struct ("0,2", "Консольное расположение одного из колёс", "<350", "1,13"),
                new table2Struct ("0,4", "Консольное расположение одного из колёс", ">350", "1,03"),
                new table2Struct ("0,4", "Консольное расположение одного из колёс", "<350", "1,55"),
                new table2Struct ("0,6", "Консольное расположение одного из колёс", ">350", "1,28"),
                new table2Struct ("0,6", "Консольное расположение одного из колёс", "<350", "1,90"),
                new table2Struct ("0,8", "Консольное расположение одного из колёс", ">350", "2,30"),
                new table2Struct ("0,8", "Консольное расположение одного из колёс", "<350", "1,70")
            });
            IList<table3Struct> table3 = new ReadOnlyCollection<table3Struct>
            (new[] {
                new table3Struct ("0,2", "<=6", ">350", "1,02"),
                new table3Struct ("0,2", "<=6", "<350", "1,01"),
                new table3Struct ("0,4", "<=6", ">350", "1,07"),
                new table3Struct ("0,4", "<=6", "<350", "1,04"),
                new table3Struct ("0,6", "<=6", ">350", "1,13"),
                new table3Struct ("0,6", "<=6", "<350", "1,07"),
                new table3Struct ("0,8", "<=6", ">350", "1,20"),
                new table3Struct ("0,8", "<=6", "<350", "1,11"),
                new table3Struct ("1", "<=6", ">350", "1,27"),
                new table3Struct ("1", "<=6", "<350", "1,15"),
                new table3Struct ("1,2", "<=6", ">350", "1,37"),
                new table3Struct ("1,2", "<=6", "<350", "1,20"),
                new table3Struct ("1,4", "<=6", ">350", "1,50"),
                new table3Struct ("1,4", "<=6", "<350", "1,60"),
                new table3Struct ("1,6", "<=6", ">350", "1,60"),
                new table3Struct ("1,6", "<=6", "<350", "1,32"),

                new table3Struct ("0,2", ">6", ">350", "1,10"),
                new table3Struct ("0,2", ">6", "<350", "1,05"),
                new table3Struct ("0,4", ">6", ">350", "1,20"),
                new table3Struct ("0,4", ">6", "<350", "1,12"),
                new table3Struct ("0,6", ">6", ">350", "1,30"),
                new table3Struct ("0,6", ">6", "<350", "1,17"),
                new table3Struct ("0,8", ">6", ">350", "1,44"),
                new table3Struct ("0,8", ">6", "<350", "1,23"),
                new table3Struct ("1", ">6", ">350", "1,57"),
                new table3Struct ("1", ">6", "<350", "1,32"),
                new table3Struct ("1,2", ">6", ">350", "1,72"),
                new table3Struct ("1,2", ">6", "<350", "1,40"),
                new table3Struct ("1,4", ">6", ">350", "1,85"),
                new table3Struct ("1,4", ">6", "<350", "1,50"),
                new table3Struct ("1,6", ">6", "<350", "1,60")
            });
            IList<table4Struct> table4 = new ReadOnlyCollection<table4Struct>
            (new[] {
                new table4Struct ("<3,5", "4", "17"),
                new table4Struct ("3,5..10", "4", "22"),

                new table4Struct ("<3,5", "5", "28"),
                new table4Struct ("3,5..10", "5", "31"),
                new table4Struct (">10", "5", "37"),

                new table4Struct ("<3,5", "6", "38"),
                new table4Struct ("3,5..10", "6", "42"),
                new table4Struct (">10", "6", "48"),

                new table4Struct ("<3,5", "7", "47"),
                new table4Struct ("3,5..10", "7", "53"),
                new table4Struct (">10", "7", "64"),

                new table4Struct ("<3,5", "8", "56"),
                new table4Struct ("3,5..10", "8", "61"),
                new table4Struct (">10", "8", "73"),

                new table4Struct ("<3,5", "9", "73"),
                new table4Struct ("3,5..10", "9", "82"),
                new table4Struct (">10", "9", "100"),
            });
            if (zv.Text == "")
            {
                YF.Text = "Нет значения zv";
                goto end;
            }
            if (x.Text == "")
            {
                YF.Text = "Нет значения x";
                goto end;
            }
            //YF
            YF.Text = "Нет значения";
            foreach (table1Struct item in table1)
            {
                if ((item.ZV == zv.Text) && (item.X == x.Text))
                {
                    YF.Text = item.YF;
                }
            }
            if (YF.Text == "Нет значения для zv и x") goto end;

            if (TypPeredach.Text == "")
            {
                Ye.Text = "Нет типа передачи";
                Yb.Text = "Нет типа передачи";
                goto end;
            }
            //Ye
            Ye.Text = "1";

            if (beta.Text == "" && TypPeredach.Text != "Прямозубая")
            {
                Yb.Text = "Не указан угол";
                goto end;
            }
            //Yb
            if (TypPeredach.Text == "Прямозубая")
                Yb.Text = "1";
            if (TypPeredach.Text == "Косозубая" || TypPeredach.Text == "Шевронная")
            {
                Yb.Text = Convert.ToString(1 - Convert.ToDouble(beta.Text) / 140);
            }

            if (m.Text == "")
            {
                sigma_F.Text = "Нет модуля";
                goto end;
            }
            if (bw.Text == "")
            {
                wFt.Text = "Нет ширины венца";
                goto end;
            }
            if (T1.Text == "")
            {
                Ft.Text = "Нет значения T1";
                wFt.Text = "Нет посчитано Ft";
                goto end;
            }

            if (dw.Text == "")
            {
                Ft.Text = "Нет значения dw";
                wFt.Text = "Нет посчитано Ft";
                goto end;
            }

            //Ft
            Ft.Text = Convert.ToString(2.0 * 1000.0 * Convert.ToSingle(T1.Text) / Convert.ToSingle(dw.Text));

            if (TypPeredach.Text == "Прямозубая")
                beta.Text = "90";
            //e_beta
            e_beta.Text = Convert.ToString(Convert.ToSingle(bw.Text) * Sin((Convert.ToSingle(beta.Text))) / (3.14 * Convert.ToSingle(m.Text)));
            //KFa
            if (TypPeredach.Text == "Прямозубая" || (TypPeredach.Text == "Косозубая" && Convert.ToDouble(e_beta.Text) <= 1))
                KFa.Text = "1";
            else
            {
                if (tochnost_n.Text == "")
                {
                    KFa.Text = "Не указана точность";
                    goto end;
                }
                if (z1.Text == "")
                {
                    e_a.Text = "Не указан z1";
                    KFa.Text = "Не посчитан e_a";
                    goto end;
                }
                if (z2.Text == "")
                {
                    e_a.Text = "Не указан z2";
                    KFa.Text = "Не посчитан e_a";
                    goto end;
                }
                if (VidZacep.Text == "")
                {
                    e_a.Text = "Не указан вид зацепления";
                    KFa.Text = "Не посчитан e_a";
                    goto end;
                }
                e_a.Text = Convert.ToString((1.88 - 3.2 * (1/Convert.ToSingle(z1.Text) - 1/ Convert.ToSingle(z2.Text))) * Cos(Convert.ToSingle(beta.Text)));
                KFa.Text = Convert.ToString(4 + (Convert.ToSingle(e_a.Text) - 1) * (Convert.ToSingle(tochnost_n.Text) - 5) / (4 * Convert.ToSingle(e_a.Text)));
            }

            //KFb
            psi_bd.Text = Convert.ToString(Convert.ToSingle(bw.Text)/ Convert.ToSingle(dw.Text));
            float delta_psi = 10;
            float new_psi_bd = 0.2f;
            for (float i = 0.2f; i < 1.7; i += 0.2f)
                if (delta_psi > Abs(Convert.ToSingle(psi_bd.Text) - i))
                {
                    delta_psi = Abs(Convert.ToSingle(psi_bd.Text) - i);
                    new_psi_bd = i;
                }
            psi_bd.Text = Convert.ToString(Round(new_psi_bd, 1));
            //bw.Text = Convert.ToString(Round(new_psi_bd * Convert.ToSingle(dw.Text), 1));

            if (HB.Text == "")
            {
                KFb.Text = "Не указана HB";
                goto end;
            }
            if (VidOpor.Text == "")
            {
                KFb.Text = "Не указан вид опор";
                goto end;
            }
            if (d_opor.Text == "")
            {
                KFb.Text = "Не указан диаметр вала";
                goto end;
            }
            if (L.Text == "")
            {
                KFb.Text = "Не указано расстояние между опорами";
                goto end;
            }

            float div_ld = Convert.ToSingle(L.Text) / Convert.ToSingle(d_opor.Text);
            string str_div_ld;

            if (div_ld <= 6)
                str_div_ld = "<=6";
            else
                str_div_ld = ">6";

            KFb.Text = "Нет значения для KFb";
            if (VidOpor.Text == "Шестерня расположена несимметрично относительно опор")
            {
                foreach (table3Struct item in table3)
                {
                    if ((item.PSI_BD == psi_bd.Text) && (item.LD == str_div_ld) && (item.HB == HB.Text))
                    {
                        KFb.Text = item.KFB;
                    }
                }
            }
            else
                foreach (table2Struct item in table2)
                {
                    if ((item.PSI_BD == psi_bd.Text) && (item.VIDOPOR == VidOpor.Text) && (item.HB == HB.Text))
                    {
                        KFb.Text = item.KFB;
                    }
                }
            if (KFb.Text == "Нет значения для KFb") goto end;

            //KFv
            if (TypPeredach.Text == "Косозубая" || TypPeredach.Text == "Шевронная")
                deltaF.Text = "0,006";
            else
            {
                if (modGolov.Checked)
                    deltaF.Text = "0,011";
                else
                    deltaF.Text = "0,016";
            }

            string m_str = "";
            if (Convert.ToSingle(m.Text) >= 3.5 && Convert.ToSingle(m.Text) <= 10)
                m_str = "3,5..10";
            else
            {
                if (Convert.ToSingle(m.Text) < 3.5)
                    m_str = "<3,5";
                else
                    m_str = ">10";                    
            }

            g0.Text = "Нет значения для g0";
            foreach (table4Struct item in table4)
            {
                if ((item.M == m_str) && (item.TOCHNOST_N == tochnost_n.Text))
                {
                    g0.Text = item.G0;
                }
            }
            if (g0.Text == "Нет значения для g0") goto end;

            u.Text = Convert.ToString(Convert.ToSingle(z2.Text) / Convert.ToSingle(z1.Text));

            if (v.Text == "")
            {
                wFv.Text = "Не указана v";
                KFv.Text = "Не посчитана wFv";
                goto end;
            }

            if (aw.Text == "")
            {
                wFv.Text = "Не указан aw";
                KFv.Text = "Не посчитана wFv";
                goto end;
            }

            wFv.Text = Convert.ToString(Convert.ToSingle(deltaF.Text) * Convert.ToSingle(g0.Text) * Convert.ToSingle(v.Text) * Sqrt(Convert.ToSingle(aw.Text) / Convert.ToSingle(u.Text)));

            KFv.Text = Convert.ToString(1 + Convert.ToSingle(wFv.Text) * Convert.ToSingle(bw.Text) / (Convert.ToSingle(Ft.Text) * Convert.ToSingle(KFa.Text) * Convert.ToSingle(KFb.Text)));

            wFt.Text = Convert.ToString(Convert.ToSingle(Ft.Text) / Convert.ToSingle(bw.Text) * Convert.ToSingle(KFa.Text) * Convert.ToSingle(KFb.Text) * Convert.ToSingle(KFv.Text));

            sigma_F.Text = Convert.ToString(Convert.ToSingle(YF.Text) * Convert.ToSingle(Ye.Text) * Convert.ToSingle(Yb.Text) * Convert.ToSingle(wFt.Text) / Convert.ToSingle(m.Text));

            if (sigma_FP.Text == "")
            {
                delta.Text = "Не указано sigma_FP";
                goto end;
            }

            delta.Text = Convert.ToString(Convert.ToSingle(sigma_FP.Text) - Convert.ToSingle(sigma_F.Text));

            if (Convert.ToSingle(delta.Text) > 0)
                Answer.Text += "+";
            else
                Answer.Text += "-";

        end:
            ;
        }
    }
}