
# Print Voucher Application

Aplikasi Print Voucher adalah sebuah aplikasi berbasis Windows yang digunakan untuk mencetak voucher dari server. Aplikasi ini secara otomatis mengambil data voucher dari server, mendekode file PDF dari Base64, dan mencetaknya ke printer yang telah ditentukan. 

## Fitur Utama

- Menampilkan daftar voucher yang diambil dari server.
- Mencetak voucher secara otomatis jika opsi Auto Print diaktifkan.
- Menyimpan dan memuat konfigurasi aplikasi dari file `config.ini`.
- Menampilkan notifikasi di system tray dan bisa diakses melalui double-click.
- Memiliki pengaturan untuk memilih printer, ukuran kertas, dan orientasi cetak.

## Persyaratan Sistem

- Windows OS
- .NET Framework
- Koneksi Internet

## Instalasi

1. Unduh dan instal [Git Bash](https://git-scm.com/downloads) jika belum terinstal.
2. Klon repository ini dengan perintah:
   ```bash
   git clone https://github.com/YuiKasumii/YuiPrinter_RemotePrint.git
   cd YuiPrinter_RemotePrint
   ```
3. Buka folder proyek dan bangun aplikasi menggunakan Visual Studio atau .NET CLI.

## Konfigurasi

1. Setelah menjalankan aplikasi, buka menu pengaturan dan tentukan printer, ukuran kertas, dan orientasi cetak yang diinginkan.
2. Simpan konfigurasi dengan menekan tombol `Save Configuration`.
3. Konfigurasi akan disimpan dalam file `config.ini` di direktori aplikasi.

## Penggunaan

1. Jalankan aplikasi dengan mengklik dua kali file executable.
2. Aplikasi akan secara otomatis mengambil data voucher dari server yang telah dikonfigurasi.
3. Voucher akan ditampilkan dalam DataGridView pada antarmuka aplikasi.
4. Jika opsi `Auto Print` diaktifkan, voucher akan dicetak secara otomatis.
5. Anda dapat mencetak voucher secara manual dengan memilih voucher dari daftar dan menekan tombol `Print`.

## Contoh Respons JSON

Contoh respons JSON dari URL server:

```json
[
    {
        "id": 1,
        "name": "Voucher A",
        "doc_url": "http://example.com/voucherA.pdf",
        "files_base64": "JVBERi0xLjcKJYGBgYEKC...",
        "downloaded": 0,
        "print": 0,
        "print_date": "2024-06-01"
    },
    {
        "id": 2,
        "name": "Voucher B",
        "doc_url": "http://example.com/voucherB.pdf",
        "files_base64": "JVBERi0xLjcKJYGBgYEKC...",
        "downloaded": 1,
        "print": 1,
        "print_date": "2024-06-02"
    }
]
```

## Komponen Utama

### Form1.vb

- `Form1_Load`: Inisialisasi aplikasi dan memuat konfigurasi awal.
- `Form1_Shown`: Menyembunyikan form ke system tray saat pertama kali dijalankan.
- `InitializeRefreshTimer`: Menginisialisasi dan mengatur timer untuk refresh otomatis.
- `LoadDataAsync`: Memuat data voucher dari server secara asinkron.
- `BtnPrint_Click`: Mencetak voucher yang dipilih.
- `SaveConfiguration` dan `LoadConfiguration`: Menyimpan dan memuat konfigurasi dari `config.ini`.
- `LogError`: Mencatat kesalahan ke file `error.log`.

### PdfPrinterHelper.vb

- Modul ini berfungsi untuk mencetak file PDF menggunakan printer yang telah dipilih.

## Troubleshooting

- Jika aplikasi tidak dapat menghubungi server, pastikan URL server benar dan terdapat koneksi internet.
- Jika terjadi kesalahan, periksa file `error.log` di direktori aplikasi untuk informasi lebih lanjut.
- Pastikan printer yang dipilih tersedia dan terhubung dengan komputer.

## Lisensi

Aplikasi ini dilisensikan di bawah [MIT License](LICENSE).

## Kontribusi

Kontribusi terbuka bagi siapa saja. Silakan buat pull request atau buka issue untuk perbaikan atau penambahan fitur.

---

Jika ada pertanyaan lebih lanjut, silakan hubungi [Yui Kasumi](https://YuiKasumii.github.io).
