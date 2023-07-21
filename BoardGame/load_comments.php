<?php
include 'connect.php';
    // Lấy dữ liệu từ biểu mẫu

    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $noidung = mysqli_real_escape_string($conn, $_POST['noidung']);
        $user_name  = mysqli_real_escape_string($conn, $_POST['USERNAME']);
        $product_id = mysqli_real_escape_string($conn, $_POST['id']);
$sql = " INSERT INTO binhluan( noidung ,id, USERNAME)
VALUES('$noidung','$product_id','$user_name')";

mysqli_query($conn, $sql);

header("location:/BoardGame/product-details.php?id=$product_id");

}
?>
