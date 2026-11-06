Console.WriteLine("masukan nama pelanggan");
String Namapelanggan = Console.ReadLine()!;
Console.WriteLine("masukan nama dokumen");
string NamaDokumen = Console.ReadLine();

Console.WriteLine("masukan jumlah halaman");
int jumlahHalaman = int.Parse(Console.ReadLine()!);

Console .WriteLine("masukan harga per halaman");
int hargaperhalaman = int.Parse(Console.ReadLine()!);

int biayaadministrasi = 2000;

int subtotal =jumlahHalaman * hargaperhalaman;
int totalbayar = subtotal + biayaadministrasi;

Console.WriteLine($"Nama pelanggan = {Namapelanggan}");
Console.WriteLine($"jumlah halaman = {jumlahHalaman}");
Console.WriteLine($"harga perhalaman = {hargaperhalaman}");
Console.WriteLine($"subtotal = {subtotal}");
Console.WriteLine($"biaya admin = {biayaadministrasi}");
Console.WriteLine($"total bayar = { totalbayar}");
Console.WriteLine($"Nama Dokumen = {NamaDokumen}");