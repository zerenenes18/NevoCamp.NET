using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class Messages
    {
        public static string AddedProduct { get; set; } = "ürün başarıyla eklendi..";
        public static string DeletedProduct { get; set; } = "ürün başarıyla silindi..";

        public static string Error { get; set; } = "İşlem sırasında bir hata oluştu...";
    }
}
