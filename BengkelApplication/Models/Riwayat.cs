namespace BengkelApplication.Models
{
    public class Riwayat
    {

        public int id_riwayat { get; set; }
        public string ktp_pelanggan { get; set; }
        public string nama_pelanggan { get; set; }

        public int id_kendaraan { get; set; }
        public string no_pol { get; set; }
        public string merk { get; set; }
        public string tipe { get; set; }
        public int kapasitas { get; set; }
        public string tahun { get; set; }
        public string nama_kendaraan { get; set; }

        public DateTime tanggal { get; set; }
        public string ktp_admin { get; set; }
        public string nama_admin { get; set; }

        public string keluhan { get; set; }
        public string catatan { get; set; }
        public int total_harga { get; set; }
        public string status { get; set; }
        public byte[] statusImg { get; set; }

    }
}
