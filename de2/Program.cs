// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace de2
{
    class Program
    {
        static List<SanPham> danhSachSanPham = new List<SanPham>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("==========MENU=========");
                Console.WriteLine("1. Nhap thong tin");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Sap xep");
                Console.WriteLine("4.Thoat");
                string luachon = Console.ReadLine();
                switch (luachon)
                {
                    case "1":
                        Nhap();
                        break;
                    case "2":
                        HienThi();
                        break;
                    case "3":
                        SapXep();
                        break;
                    case "4":
                        Console.WriteLine("Chuong trinh ket thuc");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le");
                        break;
                }
            }
        }
        static void Nhap()
        {

        }
    }
}