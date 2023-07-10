<?php
// Thay đổi các thông số sau để phù hợp với cấu hình của bạn
$host = 'localhost'; // Địa chỉ host của MySQL
$user = 'root'; // Tên đăng nhập MySQL
$password = ''; // Mật khẩu đăng nhập MySQL
$database = 'boardgame'; 

// Kết nối tới cơ sở dữ liệu
$conn = mysqli_connect($host, $user, $password, $database);

// Kiểm tra kết nối
if (!$conn) {
    die("Kết nối không thành công: " . mysqli_connect_error());
}
?>
