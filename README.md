# 🖥️ Pemrograman Visual

[![D3 Teknik Informatika USU](https://img.shields.io/badge/Prodi-D3_Teknik_Informatika_USU-006633?style=for-the-badge\&logo=academic-cap\&logoColor=white)](https://usu.ac.id)
[![Mata Kuliah](https://img.shields.io/badge/Mata_Kuliah-Pemrograman_Visual-8A2BE2?style=for-the-badge)](#)
[![IDE](https://img.shields.io/badge/IDE-Visual_Studio_2022-5C2D91?style=for-the-badge\&logo=visual-studio\&logoColor=white)](https://visualstudio.microsoft.com/)

Repositori ini berisi **catatan, materi, dokumentasi praktikum, dan tugas** dalam mata kuliah **Pemrograman Visual** pada Program Studi **D3 Teknik Informatika, Universitas Sumatera Utara (USU)**.

Materi dalam repositori ini berfokus pada konsep pemrograman berbasis antarmuka grafis (*Graphical User Interface/GUI*), pengembangan aplikasi desktop menggunakan **Microsoft Visual Studio**, serta implementasi menggunakan bahasa pemrograman **Visual Basic .NET (VB.NET)**.

---

## 📌 Identitas Praktikan

| Informasi          | Detail                                                                      |
| :----------------- | :-------------------------------------------------------------------------- |
| **Nama Mahasiswa** | Kabul                                                                       |
| **Repositori**     | [Mcx-XII/pemrograman_visual](https://github.com/Mcx-XII/pemrograman_visual) |
| **Program Studi**  | D3 Teknik Informatika                                                       |
| **Fakultas**       | Vokasi                                                                      |
| **Universitas**    | Universitas Sumatera Utara                                                  |
| **Mata Kuliah**    | Pemrograman Visual                                                          |
| **Tahun Ajaran**   | 2024 / 2025                                                                 |

---

## 📖 Pengantar Pemrograman Visual

**Pemrograman Visual (*Visual Programming*)** merupakan pendekatan dalam pengembangan perangkat lunak yang memanfaatkan elemen visual untuk membantu programmer dalam merancang antarmuka, mengatur komponen aplikasi, serta mengembangkan alur interaksi pengguna.

Berbeda dengan pendekatan pemrograman yang sepenuhnya berfokus pada penulisan kode secara tekstual, pemrograman visual menyediakan lingkungan pengembangan yang memungkinkan berbagai komponen aplikasi dirancang secara langsung melalui **Visual Designer**, seperti form, tombol, kotak teks, label, tabel, dan komponen antarmuka lainnya.

Meskipun demikian, pemrograman visual tidak berarti seluruh proses pengembangan dilakukan tanpa kode. Pada lingkungan seperti Visual Studio, elemen visual digunakan untuk membangun antarmuka, sedangkan **kode program digunakan untuk mengatur logika, proses, dan perilaku aplikasi**.

Salah satu konsep penting dalam pemrograman visual adalah **event-driven programming**, yaitu pendekatan di mana program merespons berbagai kejadian (*event*) yang terjadi selama aplikasi digunakan.

Contohnya:

* Pengguna menekan tombol.
* Pengguna memasukkan data.
* Pengguna memilih suatu menu.
* Pengguna menggerakkan atau mengklik mouse.
* Pengguna menekan tombol pada keyboard.

---

## 🧩 Konsep Dasar Pemrograman Visual

Beberapa konsep utama yang dipelajari dalam pemrograman visual antara lain:

### 1. Graphical User Interface (GUI)

**GUI** merupakan antarmuka yang memungkinkan pengguna berinteraksi dengan aplikasi melalui elemen visual, seperti:

* Button
* Label
* TextBox
* ComboBox
* CheckBox
* RadioButton
* ListBox
* DataGridView
* Menu dan Toolbar

Penggunaan GUI membuat aplikasi lebih mudah digunakan karena pengguna dapat berinteraksi melalui elemen antarmuka tanpa harus menjalankan perintah melalui terminal.

### 2. Event-Driven Programming

Pada pemrograman berbasis event, program akan menjalankan kode tertentu ketika suatu kejadian terjadi.

Sebagai contoh, ketika pengguna menekan tombol **Simpan**, aplikasi dapat menjalankan prosedur untuk memvalidasi dan menyimpan data.

### 3. Visual Designer

Visual Designer memungkinkan developer merancang tampilan aplikasi secara langsung dengan menempatkan komponen pada sebuah form.

Komponen dapat diatur melalui:

* Posisi dan ukuran
* Nama komponen
* Warna
* Font
* Teks
* Properti lainnya

### 4. Properties dan Events

Setiap komponen pada aplikasi umumnya memiliki **Properties** dan **Events**.

**Properties** digunakan untuk mengatur karakteristik komponen, sedangkan **Events** digunakan untuk menentukan tindakan yang dilakukan ketika suatu kejadian terjadi.

Contoh:

```text
Button
├── Properties
│   ├── Name
│   ├── Text
│   ├── Size
│   └── BackColor
│
└── Events
    ├── Click
    └── MouseEnter
```

---

## 💻 Microsoft Visual Studio

**Microsoft Visual Studio** merupakan Integrated Development Environment (**IDE**) yang dikembangkan oleh Microsoft untuk membangun berbagai jenis aplikasi.

Visual Studio menyediakan berbagai fitur yang mendukung proses pengembangan perangkat lunak, seperti:

* Code Editor
* Visual Designer
* Debugger
* IntelliSense
* Project Management
* Integrated Build Tools
* NuGet Package Manager
* Git Integration

Dalam mata kuliah Pemrograman Visual, Visual Studio digunakan sebagai lingkungan pengembangan untuk membuat aplikasi desktop dengan antarmuka grafis.

---

## 🟣 Visual Basic .NET (VB.NET)

**Visual Basic .NET (VB.NET)** merupakan bahasa pemrograman yang dikembangkan oleh Microsoft dan berjalan pada ekosistem **.NET**.

VB.NET memiliki sintaks yang relatif mudah dipahami dan mendukung berbagai konsep pemrograman modern, termasuk:

* Object-Oriented Programming (OOP)
* Class dan Object
* Inheritance
* Encapsulation
* Polymorphism
* Exception Handling
* Event Handling
* Database Connectivity

Dalam pengembangan aplikasi Windows Forms, VB.NET dapat digunakan untuk mengatur logika serta perilaku komponen yang telah dibuat melalui Visual Designer.

Contoh sederhana event pada sebuah tombol:

```vb
Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
    MessageBox.Show("Hello, World!")
End Sub
```

Kode tersebut akan menjalankan `MessageBox.Show()` ketika tombol `btnHello` menerima event **Click**.

---

## 🔗 Hubungan Visual Studio, VB.NET, dan Pemrograman Visual

Ketiga komponen tersebut memiliki peran yang berbeda tetapi saling berkaitan:

```text
┌─────────────────────────────┐
│     Pemrograman Visual      │
│       (Konsep/Paradigma)    │
└──────────────┬──────────────┘
               │
               ▼
┌─────────────────────────────┐
│      Visual Studio          │
│            (IDE)            │
└──────────────┬──────────────┘
               │
               ▼
┌─────────────────────────────┐
│          VB.NET             │
│       (Bahasa Program)      │
└──────────────┬──────────────┘
               │
               ▼
┌─────────────────────────────┐
│     Aplikasi Desktop GUI    │
│      Windows Forms          │
└─────────────────────────────┘
```

Dengan demikian:

> **Pemrograman Visual** merupakan pendekatan pengembangan, **Visual Studio** merupakan lingkungan pengembangan (IDE), sedangkan **VB.NET** merupakan salah satu bahasa pemrograman yang dapat digunakan untuk membangun aplikasinya.

---

## ⚙️ Karakteristik Pemrograman Visual

### 1. Perancangan Antarmuka Secara Visual

Developer dapat menyusun tampilan aplikasi melalui *designer* dengan menempatkan berbagai kontrol pada form.

### 2. Event-Driven

Program merespons tindakan pengguna melalui event seperti `Click`, `Load`, `KeyPress`, dan berbagai event lainnya.

### 3. Component-Based Development

Aplikasi dibangun menggunakan berbagai komponen yang memiliki fungsi dan properti tertentu.

### 4. Integrasi antara Designer dan Code

Perancangan tampilan dilakukan melalui *designer*, sedangkan logika aplikasi dapat dikembangkan melalui kode program.

### 5. Dukungan Debugging

Visual Studio menyediakan fasilitas debugging untuk membantu menemukan dan memperbaiki kesalahan dalam program.

---

## 🎯 Keunggulan dan Keterbatasan

### ✅ Keunggulan

* Mempermudah pembuatan antarmuka aplikasi desktop.
* Mempercepat proses pengembangan aplikasi.
* Memudahkan pemula dalam memahami konsep GUI.
* Menyediakan berbagai komponen antarmuka siap digunakan.
* Mendukung pengembangan berbasis event.
* Dilengkapi fitur debugging dan IntelliSense.
* Mendukung integrasi dengan database dan berbagai library .NET.

### ⚠️ Keterbatasan

* Pengembangan aplikasi tetap membutuhkan pemahaman pemrograman dan logika.
* Ketergantungan pada framework dan lingkungan .NET yang digunakan.
* Aplikasi desktop tertentu memerlukan konfigurasi lingkungan Windows yang sesuai.
* Perancangan visual tidak secara otomatis menjamin struktur kode yang baik.
* Untuk aplikasi berskala besar, diperlukan penerapan arsitektur dan pola desain yang tepat.

---

## 🛠️ Tools dan Platform yang Digunakan

| Tools / Platform          | Fungsi                                         |
| :------------------------ | :--------------------------------------------- |
| **Visual Studio 2022**    | IDE untuk pengembangan aplikasi                |
| **VB.NET**                | Bahasa pemrograman                             |
| **Windows Forms**         | Framework untuk membangun aplikasi GUI desktop |
| **.NET / .NET Framework** | Platform dan runtime aplikasi                  |
| **Git & GitHub**          | Version control dan penyimpanan repositori     |

---

## 📥 Instalasi Visual Studio

Untuk mengikuti praktikum, lingkungan pengembangan dapat disiapkan melalui langkah berikut.

### 1. Unduh Visual Studio

Unduh Visual Studio melalui situs resmi Microsoft:

**https://visualstudio.microsoft.com/**

Disarankan menggunakan **Visual Studio Community** untuk kebutuhan pembelajaran dan pengembangan individu sesuai ketentuan lisensi Microsoft.

### 2. Jalankan Visual Studio Installer

Setelah installer dijalankan, Visual Studio Installer akan menampilkan berbagai *workload* yang tersedia.

### 3. Pilih Workload

Untuk pengembangan aplikasi desktop, pilih:

> **.NET desktop development**

Workload tersebut menyediakan berbagai komponen yang diperlukan untuk pengembangan aplikasi desktop berbasis .NET.

### 4. Pilih Komponen Tambahan

Komponen yang tersedia dapat disesuaikan dengan kebutuhan praktikum, termasuk dukungan terhadap:

* .NET SDK
* Windows Forms
* .NET Framework
* Visual Basic
* Development Tools

### 5. Lakukan Instalasi

Klik **Install** dan tunggu hingga proses instalasi selesai.

### 6. Membuat Project Baru

Setelah Visual Studio terbuka:

1. Pilih **Create a new project**.
2. Pilih bahasa **Visual Basic**.
3. Pilih template aplikasi yang sesuai, seperti **Windows Forms App**.
4. Tentukan nama dan lokasi project.
5. Klik **Create**.

> **Catatan:** Template yang tersedia dapat berbeda tergantung versi Visual Studio, workload, dan .NET yang terpasang. Pastikan template yang digunakan sesuai dengan kebutuhan praktikum.

---

## 📚 Materi yang Dipelajari

Repositori ini akan digunakan untuk mendokumentasikan berbagai materi dan praktikum, antara lain:

* Pengenalan Pemrograman Visual
* Pengenalan Visual Studio
* Dasar-Dasar VB.NET
* Windows Forms
* Properties dan Events
* Control pada Windows Forms
* Variabel dan Tipe Data
* Percabangan
* Perulangan
* Procedure dan Function
* Object-Oriented Programming
* Pengolahan Data
* Database Connectivity
* CRUD (*Create, Read, Update, Delete*)
* Validasi Input
* Exception Handling
* Pembuatan Aplikasi Desktop

---

## 📂 Struktur Repositori

Struktur repositori akan dikembangkan mengikuti materi dan praktikum yang telah dikerjakan.

```text
pemrograman_visual/
│
├── README.md
│
├── Pertemuan/
│   ├── Pertemuan-01/
│   ├── Pertemuan-02/
│   ├── Pertemuan-03/
│   └── ...
│
├── Praktikum/
│   ├── Praktikum-01/
│   ├── Praktikum-02/
│   └── ...
│
└── Tugas/
    ├── Tugas-01/
    ├── Tugas-02/
    └── ...
```

Struktur tersebut dapat disesuaikan kembali berdasarkan pembagian materi dan ketentuan praktikum.

---

## 🎓 Tujuan Pembelajaran

Melalui mata kuliah Pemrograman Visual, mahasiswa diharapkan mampu:

1. Memahami konsep dasar pemrograman visual.
2. Memahami lingkungan pengembangan Microsoft Visual Studio.
3. Menggunakan VB.NET untuk membangun aplikasi.
4. Merancang antarmuka aplikasi berbasis GUI.
5. Menerapkan konsep event-driven programming.
6. Mengimplementasikan logika pemrograman ke dalam aplikasi desktop.
7. Mengembangkan aplikasi yang terstruktur dan mudah digunakan.
8. Mengintegrasikan aplikasi dengan penyimpanan atau database sesuai kebutuhan.

---

## 👨‍💻 Tentang Repositori

Repositori ini merupakan bagian dari dokumentasi pembelajaran **Pemrograman Visual** pada Program Studi **D3 Teknik Informatika, Universitas Sumatera Utara**.

Seluruh materi, source code, tugas, dan hasil praktikum akan dikembangkan serta diperbarui secara bertahap selama proses perkuliahan.

---

<div align="center">

### 📚 Pemrograman Visual — D3 Teknik Informatika USU

*Learning • Developing • Documenting*

**© 2024/2025 Kabul — D3 Teknik Informatika USU**

</div>
