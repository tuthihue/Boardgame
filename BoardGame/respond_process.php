<?php

include 'connect.php';
$dateTime = new DateTime();
$currentDateTime = $dateTime->format("Y-m-d H:i:s");
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = mysqli_real_escape_string($conn, $_POST['name']);
    $email = mysqli_real_escape_string($conn, $_POST['email']);
    $message = mysqli_real_escape_string($conn,$_POST['message']);
     // Thêm phản hồi vào cơ sở dữ liệu
    $insert_query = "INSERT INTO phan_hoi (HOTEN, email, noidung) VALUES ('$name', '$email', '$message')";
    mysqli_query($conn, $insert_query); 

    // Chuyển hướng người dùng về lại trang respond.php sau khi gửi thành công  
    header('location: respond.php');
    exit();
     
}
?>
