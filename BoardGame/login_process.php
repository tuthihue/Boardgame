<?php

include 'connect.php';
session_start();

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = mysqli_real_escape_string($conn, $_POST['username']);
    $pass = mysqli_real_escape_string($conn,$_POST['password']);

    $select_query = "SELECT * FROM customers WHERE USERNAME = '$name' AND password = '$pass' ";
    $result = mysqli_query($conn, $select_query);

    if (mysqli_num_rows($result) > 0) {
        $row = mysqli_fetch_array($result);
        session_start();
        $_SESSION['username'] = $row['USERNAME'];
        // Chuyển hướng người dùng đến trang index.php khi đăng nhập thành công
        header('location: index.php');
    } else {
        $error[] = 'Email hoặc mật khẩu không chính xác!';
        include 'login.php';
    }
}
?>