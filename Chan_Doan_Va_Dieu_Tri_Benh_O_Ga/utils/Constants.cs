using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.utils
{
    static class Constants
    {
        static class QuestionList
        {
            public static string Question1 = "Gà của bạn có ủ rủ không?";
            public static string Question2 = "Gà của bạn có uống nhiều nước không?";
            public static string Question3 = "Gà của bạn có lười đi lại không?";
            public static string Question4 = "Gà của bạn có lông xù không?";
            public static string Question5 = "Gà của bạn có sốt cao không?";
            public static string Question6 = "Gà của bạn có bỏ ăn không?";
            public static string Question7 = "Gà của bạn có tiêu chảy phân trắng không?";
            public static string Question8 = "Gà của bạn có màu thâm tím không?";
            public static string Question9 = "Gà của bạn có chậm lớn không?";
            public static string Question10 = "Gà của bạn có thieu máu màu nhợt không?";
            public static string Question11 = "Gà của bạn có mệt mỏi không?";
            public static string Question12 = "Gà của bạn có mắt lim dim không?";
            public static string Question13 = "Gà của bạn có thở khó không?";
            public static string Question14 = "Gà của bạn có chảy nhiều nước mủi không?";
            public static string Question15 = "Gà của bạn có ỉa phân trắng và phân có nhiều chất nhày không?";
            public static string Question16 = "Gà của bạn có nổi nhiều mụng mủ không?";
            public static string Question17 = "Gà của bạn có ăn cám gà có thành phần muối cao không?";

            public static string getQuestion(int n)
            {
                switch(n)
                {
                    case 1:
                        return Question1;
                    case 2:
                        return Question2;
                    case 3:
                        return Question3;
                    case 4:
                        return Question4;
                    case 5:
                        return Question5;
                    case 6:
                        return Question6;
                    case 7:
                        return Question7;
                    case 8:
                        return Question8;
                    case 9:
                        return Question9;
                    case 10:
                        return Question10;
                    case 11:
                        return Question11;
                    case 12:
                        return Question12;
                    case 13:
                        return Question13;
                    case 14:
                        return Question14;
                    case 15:
                        return Question15;
                    case 16:
                        return Question16;
                    case 17:
                        return Question17;
                }

                return "false";
            }
        }

        static class DiseaseList
        {
            public static string Dissease1 = "Cầu trùng";
            public static string Dissease2 = "Tiêu chảy";
            public static string Dissease3 = "Cúm gia cầm";
            public static string Dissease4 = "Giun đũa";
            public static string Dissease5 = "Nấm phổi";
            public static string Dissease6 = "Thương hàng gà";
            public static string Dissease7 = "Đậu gà";
            public static string Dissease8 = "Trúng dọc muối ăn";

            public static string getQuestion(string str)
            {
                switch (str)
                {
                    case "cau_trung":
                        return Dissease1;
                    case "tieu_chay":
                        return Dissease2;
                    case "cum_gia_cam":
                        return Dissease3;
                    case "giun_dua":
                        return Dissease4;
                    case "nam_phoi":
                        return Dissease5;
                    case "thuong_han_ga":
                        return Dissease6;
                    case "dau_ga":
                        return Dissease7;
                    case "trung_doc_muoi_an":
                        return Dissease8;
                }

                return "false";
            }
        }
    }
}
