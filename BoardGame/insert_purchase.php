<?php
// Kết nối tới cơ sở dữ liệu
$servername = "localhost";
$username = "root";
$password ="" ;
$dbname = "boardgame";

$conn = mysqli_connect($servername, $username, $password, $dbname);

// Kiểm tra kết nối
if (!$conn) {
    die("Không thể kết nối đến cơ sở dữ liệu: " . mysqli_connect_error());
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {

    $masp = mysqli_real_escape_string($conn, $_POST["code"]);
    $name_product = mysqli_real_escape_string($conn, $_POST["name_product"]);
    $hoten = mysqli_real_escape_string($conn, $_POST["name"]);
    $sdt = mysqli_real_escape_string($conn, $_POST["phone"]);
    $soluong = mysqli_real_escape_string($conn, $_POST["quantity"]);
    $gia = mysqli_real_escape_string($conn, $_POST["price"]);
    $mota = mysqli_real_escape_string($conn, $_POST["describe"]);
    $currentDate = date('Y-m-d'); 
    $existingNumbers = [];

    do {
        $randomNumber = str_pad(rand(0, 9999), 4, '0', STR_PAD_LEFT);
    } while (in_array($randomNumber, $existingNumbers));
    session_start();
    $_SESSION['randomNumber'] = $randomNumber; 
    $sql = "INSERT INTO thue (id_thue,username, ngaythue, tongtien) VALUES ('$randomNumber','$hoten', '$currentDate', '$gia')";
    $insert_tg ="INSERT INTO thuegame (id_thue,masp, tensp,soluong ) VALUES ('$randomNumber','$masp', '$name_product', '$soluong')";
     if (mysqli_query($conn, $sql) && mysqli_query($conn,$insert_tg) ) {
        echo '<script>alert("Thanh toán thành công"); window.location.href = "purchase_infor.php";</script>';
        exit;
    } else {
        echo "Lỗi: " . $sql . "<br>" . mysqli_error($conn);
    }
}

// Đóng kết nối
mysqli_close($conn);
?>
