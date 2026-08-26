# Komponen Pemrograman Visual



Dalam pengembangan aplikasi berbasis visual, **komponen visual** merupakan bagian-bagian yang digunakan untuk membentuk tampilan antarmuka pengguna atau **User Interface (UI)**. Komponen tersebut dapat terlihat pada jendela aplikasi dan, tergantung jenisnya, dapat menjadi sarana bagi pengguna untuk berinteraksi dengan sistem.



Secara umum, komponen visual memiliki beberapa fungsi, seperti:



* Menyampaikan informasi kepada pengguna.

* Menampung data atau masukan dari pengguna.

* Menjalankan instruksi tertentu.

* Menyediakan pilihan atau opsi.

* Mengatur tampilan dan tata letak aplikasi.

* Menjadi wadah untuk komponen lainnya.



---



# Control



**Control** merupakan elemen yang digunakan untuk menyusun antarmuka pada aplikasi. Setiap control memiliki fungsi tertentu dan dapat digunakan untuk menampilkan informasi, menerima masukan, menjalankan perintah, maupun memberikan fasilitas interaksi kepada pengguna.



Dalam Windows Forms, control dapat dikonfigurasi melalui beberapa bagian utama, yaitu **Property, Method, dan Event**.



## 1. Property



**Property** adalah sekumpulan atribut yang menentukan karakteristik serta kondisi suatu control. Pengaturan property dapat dilakukan ketika aplikasi sedang dirancang maupun melalui kode ketika aplikasi sedang berjalan.



Beberapa contoh property yang sering digunakan:



* **Text** → menentukan tulisan yang ditampilkan pada control.

* **Size** → mengatur dimensi atau ukuran control.

* **BackColor** → menentukan warna bagian latar belakang.

* **Enabled** → menentukan apakah control dapat digunakan oleh pengguna.



## 2. Method



**Method** merupakan fungsi yang dimiliki oleh sebuah control untuk melakukan tindakan tertentu. Method biasanya dijalankan melalui kode program ketika diperlukan perubahan atau tindakan terhadap suatu control.



Contoh method yang umum digunakan:



* **Show()** → menampilkan form atau control.

* **Hide()** → menyembunyikan form atau control.

* **Close()** → menutup form.

* **Focus()** → memberikan fokus kepada control tertentu.



## 3. Event



**Event** adalah suatu kejadian yang terjadi akibat tindakan pengguna maupun proses yang dilakukan oleh sistem. Event memungkinkan program memberikan respons tertentu terhadap kejadian tersebut dengan menjalankan kode yang telah ditentukan.



Beberapa contoh event:



* **Click** → terjadi ketika sebuah control diklik.

* **Load** → terjadi ketika sebuah form mulai dimuat atau dijalankan.

* **TextChanged** → terjadi ketika isi teks pada suatu control mengalami perubahan.



---



# Jenis Control Berdasarkan Fungsinya



Jika dilihat berdasarkan kemampuan dalam menampung control lainnya, control dapat dikelompokkan menjadi dua kategori utama, yaitu **Container** dan **Control Biasa**.



## 1. Container



**Container** adalah jenis control yang berfungsi sebagai tempat untuk meletakkan control lainnya. Dengan adanya container, beberapa elemen antarmuka dapat dikelompokkan sehingga susunan aplikasi menjadi lebih terorganisasi.



### Form



**Form** merupakan salah satu contoh container yang menjadi bagian utama dalam aplikasi **Windows Forms**. Form dapat dipahami sebagai jendela tempat berbagai komponen aplikasi ditempatkan dan diatur.



Di dalam sebuah form, programmer dapat menambahkan berbagai control, misalnya:



* **Label** untuk memberikan keterangan atau informasi.

* **TextBox** untuk menerima data dari pengguna.

* **Button** untuk menjalankan perintah tertentu.



Sebuah aplikasi Windows Forms dapat memiliki satu maupun beberapa form. Form tambahan dapat digunakan untuk berbagai kebutuhan, seperti halaman login, jendela konfirmasi, form pengaturan, atau halaman lainnya.



---



## 2. Control Biasa



**Control biasa** merupakan komponen yang digunakan secara langsung pada antarmuka dan tidak berfungsi sebagai wadah bagi control lainnya. Komponen jenis ini umumnya digunakan untuk memberikan informasi, menerima input, atau memungkinkan pengguna melakukan tindakan tertentu.



Beberapa control yang sering digunakan dalam Windows Forms antara lain:



### Button



**Button** merupakan komponen yang digunakan untuk menjalankan suatu tindakan ketika pengguna menekan atau mengkliknya.



Contohnya:



* OK

* Cancel

* Apply

* Exit



### TextBox



**TextBox** digunakan sebagai tempat pengguna memasukkan data berupa teks. Data yang dimasukkan dapat berupa nama, angka, alamat, kata sandi, dan berbagai jenis informasi lainnya sesuai kebutuhan aplikasi.



### Label



**Label** digunakan untuk memberikan keterangan atau menampilkan informasi pada antarmuka. Isi Label umumnya bersifat informatif dan tidak dapat diubah secara langsung oleh pengguna.



### CheckBox



**CheckBox** digunakan ketika pengguna perlu menentukan pilihan dengan status **dipilih atau tidak dipilih**. Beberapa CheckBox juga dapat digunakan secara bersamaan apabila terdapat lebih dari satu pilihan yang dapat dipilih.



---



# Properti yang Sering Digunakan



Property pada Form maupun control digunakan untuk menentukan karakteristik, tampilan, serta kondisi dari komponen tersebut.



| Property          | Kegunaan                                                                                       |

| :---------------- | :--------------------------------------------------------------------------------------------- |

| **Name**          | Menentukan nama atau identitas komponen yang digunakan ketika komponen dipanggil melalui kode. |

| **Text**          | Mengatur tulisan atau teks yang ditampilkan pada komponen.                                     |

| **StartPosition** | Menentukan lokasi awal Form ketika aplikasi dijalankan.                                        |

| **BackColor**     | Mengatur warna pada bagian latar belakang Form atau control.                                   |

| **ForeColor**     | Menentukan warna teks yang ditampilkan oleh komponen.                                          |

| **Font**          | Mengatur jenis huruf, ukuran tulisan, serta gaya teks.                                         |

| **Enabled**       | Menentukan apakah suatu control dapat digunakan atau menerima interaksi dari pengguna.         |

| **Visible**       | Mengatur apakah sebuah komponen ditampilkan pada layar atau disembunyikan.                     |



> **Catatan:** Nama property yang benar dalam VB.NET adalah **`Enabled`**, bukan `Enable`.

