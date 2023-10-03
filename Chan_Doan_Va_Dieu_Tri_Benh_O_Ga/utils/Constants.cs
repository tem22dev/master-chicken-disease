using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.utils
{ 
     static class Constants
    {
        public static class Config
        {
            public static readonly string PrologHomeDir = @"D:\App\swipl";
        }
        public static class QuestionList
        {
            public static readonly string Question1 = "Gà của bạn có ủ rủ không?";
            public static readonly string Question2 = "Gà của bạn có uống nhiều nước không?";
            public static readonly string Question3 = "Gà của bạn có lười đi lại không?";
            public static readonly string Question4 = "Gà của bạn có lông xù không?";
            public static readonly string Question5 = "Gà của bạn có sốt cao không?";
            public static readonly string Question6 = "Gà của bạn có bỏ ăn không?";
            public static readonly string Question7 = "Gà của bạn có tiêu chảy phân trắng không?";
            public static readonly string Question8 = "Gà của bạn có màu thâm tím không?";
            public static readonly string Question9 = "Gà của bạn có chậm lớn không?";
            public static readonly string Question10 = "Gà của bạn có thieu máu màu nhợt không?";
            public static readonly string Question11 = "Gà của bạn có mệt mỏi không?";
            public static readonly string Question12 = "Gà của bạn có mắt lim dim không?";
            public static readonly string Question13 = "Gà của bạn có thở khó không?";
            public static readonly string Question14 = "Gà của bạn có chảy nhiều nước mủi không?";
            public static readonly string Question15 = "Gà của bạn có ỉa phân trắng và phân có nhiều chất nhày không?";
            public static readonly string Question16 = "Gà của bạn có nổi nhiều mụng mủ không?";
            public static readonly string Question17 = "Gà của bạn có ăn cám gà có thành phần muối cao không?";

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

        public static class DiseaseList
        {
            public static readonly string Dissease1 = "Cầu trùng";
            public static readonly string Dissease2 = "Tiêu chảy";
            public static readonly string Dissease3 = "Cúm gia cầm";
            public static readonly string Dissease4 = "Giun đũa";
            public static readonly string Dissease5 = "Nấm phổi";
            public static readonly string Dissease6 = "Thương hàng gà";
            public static readonly string Dissease7 = "Đậu gà";
            public static readonly string Dissease8 = "Trúng dọc muối ăn";

            public static string getQuestion(string str)
            {
                str = str.Trim();
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

                return "Không xác định được bệnh!";
            }
        }

        public static class Rresult
        {
            public static readonly string Rresult0 = "Hệ chuyên gia chưa xác định được gà của bạn mắc bệnh gì nên không đưa ra được phương pháp điều trị!!";
            public static readonly string Rresult1 = "Thay đệm lót chuồng, phun thuốc sát trùng 1 ngày/1 lần. Dùng thuốc đặc trị cầu trùng gà (tùy theo màu phân để phân loại cầu trùng manh tràng hay cầu trùng ruột non) cuối cùng cung cấp thuốc bổ và chất điện giải cho gà.";
            public static readonly string Rresult2 = "Vệ sinh môi trường thức ăn nước uống, khử trùng chuồng nuôi và môi trường xung quanh. Dùng một trong các loại thuốc sau: Coli-200, Ampicoli, Gentadox… dùng trong 3-5 ngày liên tục. Bổ sung thuốc trợ sức, trợ lực tăng cường sức đề kháng.";
            public static readonly string Rresult3 = "Tiêu hủy toàn đàn khi phát hiện bệnh. Phòng bệnh là biện pháp duy nhất hạn chế dịch bệnh xảy ra.";
            public static readonly string Rresult4 = "Dùng các thuốc tẩy hỗn hợp Phenothiazin 500mg/kgTT, Mebendazol liều: 0,5g/kgTT, Nova – Levasol liều: 1g/5 – 6kgTT, dùng một liều duy nhất. Trộn vào thức ăn hoặc một ít nước cho uống để điều trị.";
            public static readonly string Rresult5 = "Dùng các hóa chất diệt nấm như: crystal-violet, brillian green, iodua-kali 0,8%, dung dịch CuSO4 1/2000 cho uống làm giảm sự lan truyền bệnh. Không dùng các kháng sinh có nguồn gốc từ nấm: Penicillin, Streptomycin,…";
            public static readonly string Rresult6 = "Dùng các dẫn xuất của Sulfamid 0,2- 0,5% trộn trong thức ăn hay pha trong thức uống. Hoặc có thể dùng các kháng sinh khác như Tetramycin, Collistin, Imequil, Pulmequil, Furazolidon,…";
            public static readonly string Rresult7 = "Cậy vẩy mụn đậu, rửa sạch bằng nước muối loãng. Hàng ngày bôi dung dịch 1%Xanhmetylen lên mụn đậu, sau ít ngày mụn đậu sẽ khô dần và tự bong. Làm sạch các mụn đậu rồi bôi các chất sát trùng nhẹ như Glycerin10%, CuSO4 5%.";
            public static readonly string Rresult8 = "Không có biện pháp can thiệp. Phòng bệnh là biện pháp hữu hiệu nhất. Hạn chế việc phối trộn thức ăn không theo khẩu phần.";

            public static string getRresult(string str)
            {
                str = str.Trim();            

                switch (str)
                {
                    case "cau_trung":
                        return Rresult1;
                    case "tieu_chay":
                        return Rresult2;
                    case "cum_gia_cam":
                        return Rresult3;
                    case "giun_dua":
                        return Rresult4;
                    case "nam_phoi":
                        return Rresult5;
                    case "thuong_han_ga":
                        return Rresult6;
                    case "dau_ga":
                        return Rresult7;
                    case "trung_doc_muoi_an":
                        return Rresult8;     
                }

                return Rresult0;
            }
        }
    }
}
