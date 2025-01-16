# Hướng dẫn cài đặt và sử dụng ứng dụng khám phá cơ sở dữ liệu World

## 1. Giới thiệu
Ứng dụng này cho phép người dùng khám phá cơ sở dữ liệu `World` thông qua các dịch vụ SOAP. Cơ sở dữ liệu bao gồm thông tin về các quốc gia và thành phố trên thế giới. Ứng dụng được chia thành hai phần chính:

- **Phía server**: Cung cấp các dịch vụ SOAP để truy xuất dữ liệu từ cơ sở dữ liệu.
- **Phía client**: Ứng dụng Windows Forms để người dùng có thể gọi và hiển thị dữ liệu từ các dịch vụ SOAP.

---

## 2. Yêu cầu hệ thống

### Phần mềm
- SQL Server để quản lý cơ sở dữ liệu.
- Visual Studio (2022 hoặc phiên bản tương tự).
- .NET Framework 4.7.2 hoặc cao hơn.

---

## 3. Cài đặt

### 3.1. Import cơ sở dữ liệu
1. Mở SQL Server Management Studio (SSMS).
2. Tải file `World database for MS SQL Server.sql` đính kèm và mở trong SSMS.
3. Chạy script để tạo cơ sở dữ liệu `World` và các bảng liên quan.

### 3.2. Cài đặt server-side
1. Tạo một project **ASP.NET Web Service** trong Visual Studio.
2. Thêm file kết nối cơ sở dữ liệu (connection string) trong `Web.config`.
3. Tạo các dịch vụ SOAP với các chức năng:
    - **Lấy danh sách tất cả các quốc gia**.
    - **Tìm quốc gia theo mã quốc gia**.
    - **Tìm thành phố theo tên**.
    - **Lấy danh sách thành phố của một quốc gia**.
    - **Các dịch vụ khác (nếu cần)**.
4. Chạy ứng dụng để kiểm tra các dịch vụ hoạt động chính xác.

### 3.3. Cài đặt client-side
1. Tạo một project **Windows Forms Application** trong Visual Studio.
2. Thêm tham chiếu (Service Reference) đến các dịch vụ SOAP từ server.
3. Tạo giao diện người dùng với các chức năng:
    - Hiển thị danh sách quốc gia trong DataGridView.
    - Hiển thị thông tin quốc gia theo mã quốc gia.
    - Hiển thị thông tin thành phố theo tên.
    - Hiển thị danh sách thành phố của một quốc gia.
4. Triển khai và kiểm tra ứng dụng.

---

## 4. Hướng dẫn sử dụng
1. Chạy ứng dụng server (SOAP services).
2. Mở ứng dụng client (Windows Forms Application).
3. Sử dụng các nút chức năng trên giao diện:
    - **Lấy danh sách quốc gia**: Nhấn nút "Get All Countries".
    - **Tìm quốc gia theo mã**: Nhập mã quốc gia và nhấn "Get Country By Code".
    - **Tìm thành phố theo tên**: Nhập tên thành phố và nhấn "Get City By Name".
    - **Lấy danh sách thành phố của quốc gia**: Nhập mã quốc gia và nhấn "Get Cities By Country Code".

---

## 5. Cấu trúc dự án

### Server-side
- **App_Code**: Chứa các lớp xử lý nghiệp vụ.
- **Web.config**: Cấu hình ứng dụng và kết nối cơ sở dữ liệu.
- **WorldService.asmx**: Tập tin chứa các dịch vụ SOAP.

### Client-side
- **Form1.cs**: Mã nguồn cho giao diện chính.
- **Service References**: Tham chiếu đến các dịch vụ SOAP từ server.
- **DataGridView**: Hiển thị dữ liệu quốc gia và thành phố.

---

## 6. Ghi chú
- Đảm bảo cấu hình kết nối cơ sở dữ liệu trong server chính xác.
- Kiểm tra server đã chạy trước khi sử dụng ứng dụng client.

---

