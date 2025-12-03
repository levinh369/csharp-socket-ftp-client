# 📂 C# Socket FTP Client

Đây là ứng dụng **FTP Client** được xây dựng bằng **C# WinForms** và kỹ thuật **Lập trình Socket thuần (Raw Socket Programming - TCP/IP)**.
Dự án mô phỏng lại cơ chế hoạt động cốt lõi của giao thức FTP (File Transfer Protocol) mà không sử dụng các thư viện hỗ trợ sẵn ở tầng cao như `FtpWebRequest`.

![Demo Screenshot](demo.png)
*(Hãy thay `demo.png` bằng ảnh chụp màn hình thực tế của ứng dụng)*

## 🚀 Tính năng nổi bật

* **Giao tiếp qua Socket:** Tự xử lý việc thiết lập kết nối TCP và các luồng dữ liệu (Data Streams) bằng thư viện `System.Net.Sockets`.
* **Triển khai giao thức FTP:**
    * **Gửi/Nhận lệnh:** Hỗ trợ các lệnh chuẩn như `USER`, `PASS`, `LIST`, `PWD`, `CWD`, `MKD`, `RMD`, `DELE`, `RNFR/RNTO`.
    * **Truyền tải dữ liệu:** Tự triển khai chế độ **PASV (Passive Mode)** để xử lý các cổng dữ liệu động (Dynamic Data Ports).
* **Quản lý File:**
    * Upload và Download file sử dụng xử lý luồng nhị phân (Binary Stream) để đảm bảo toàn vẹn dữ liệu.
    * Tạo, Đổi tên, Xóa thư mục/tập tin trên Server từ xa.
* **Tự động load ổ đĩa:** Tự động phát hiện và hiển thị danh sách các ổ đĩa (Logical Drives) trên máy tính người dùng.

## 🛠️ Công nghệ sử dụng

* **Ngôn ngữ:** C# (.NET Core / .NET Framework)
* **Giao diện (UI):** Windows Forms (WinForms)
* **Mạng (Networking):** `System.Net.Sockets.TcpClient`, `System.Net.Sockets.NetworkStream`
* **Đa luồng (Multithreading):** Xử lý giao diện và truyền tải dữ liệu mượt mà, không bị treo UI.

## ⚙️ Cơ chế hoạt động (Điểm nhấn kỹ thuật)

Khác với các ứng dụng FTP thông thường sử dụng thư viện có sẵn, dự án này xử lý thủ công chu trình **Request/Response**:

1.  **Kết nối điều khiển (Control Connection - Port 21):** Gửi các lệnh dạng văn bản (Text-based) và phân tích mã trạng thái trả về từ Server (ví dụ: `220`, `331`, `227`).
2.  **Kết nối dữ liệu (Data Connection - Dynamic Port):**
    * Gửi lệnh `PASV` để yêu cầu chế độ thụ động.
    * Phân tích chuỗi phản hồi từ Server dạng `(h1,h2,h3,h4,p1,p2)` để tính toán Port dữ liệu theo công thức: `(p1 * 256) + p2`.
    * Mở một kết nối Socket thứ hai (Data Socket) đến Port vừa tính được để truyền nội dung file hoặc danh sách thư mục.

## 📦 Cài đặt & Hướng dẫn sử dụng

1.  **Yêu cầu:**
    * Cài đặt **FileZilla Server** (hoặc bất kỳ FTP Server nào) trên máy cục bộ (`localhost` / `127.0.0.1`) để test.
    * Tạo một tài khoản User (ví dụ: User: `admin`, Pass: `123`) trên FileZilla Server và cấp quyền đọc/ghi.
2.  **Chạy ứng dụng:**
    * Clone repository này về máy: `git clone https://github.com/levinh369/csharp-socket-ftp-client`
    * Mở Solution bằng **Visual Studio**.
    * Nhấn **Start** để chạy.
3.  **Kết nối:**
    * Nhập địa chỉ Host (ví dụ: `127.0.0.1`), Username và Password đã tạo.
    * Nhấn nút **Connect**.

## 📸 Ảnh chụp màn hình

| Màn hình Đăng nhập | Quản lý File |
| :---: | :---: |
| ![Login](link-anh-1) | ![Explorer](link-anh-2) |

---
**Author:** [Tên của bạn]