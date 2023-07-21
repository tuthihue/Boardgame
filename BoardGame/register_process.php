<?php

include 'connect.php';

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = mysqli_real_escape_string($conn, $_POST['username']);
    $email = mysqli_real_escape_string($conn, $_POST['email']);
    $password = mysqli_real_escape_string($conn,$_POST['password']);

    // Kiểm tra xem email đã tồn tại trong cơ sở dữ liệu hay chưa
    $select_query = "SELECT * FROM customers WHERE email = '$email' ";
    $result = mysqli_query($conn, $select_query);

    if (mysqli_num_rows($result) > 0) {
        $error[] = 'Email đã tồn tại!';
    } else {
        // Thêm người dùng vào cơ sở dữ liệu
        $insert_query = "INSERT INTO customers (username, email, password) VALUES ('$name', '$email', '$password')";
        mysqli_query($conn, $insert_query);

        // Chuyển hướng người dùng đến trang đăng nhập sau khi đăng ký thành công
        header('location: login.php');
        exit();
    }
}

?>
