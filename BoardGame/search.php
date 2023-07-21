<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang chủ | BoardGame</title>
    <link rel="stylesheet" href="CSS/search.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
</head>
<body>
<header>
    <div class="logo">BOARDGAME</div>
    <nav>
      <ul>
        <li><a href="index.php">Trang chủ</a></li>
        <li><a href="product.php">Sản phẩm</a></li>
        <li>
          <a href="#">Thể loại</a>
          <!-- Thêm danh sách cho mục "Thể loại" -->
          <ul class="sub-menu">
            <li><a href="cardgame.php">Card Games</a></li> 
            <li><a href="dicegame.php">Dice Games</a></li> 
            <li><a href="chess.php">Chess</a></li> 
            <li><a href="family.php">Family</a></li> 
            <li><a href="livingcardgame.php">Living Card Games</a></li> 
            <li><a href="deckbuilders.php">Deckbuilders</a></li> 
            <li><a href="wargame&strategy.php">Wargame & Strategy</a></li> 
            <li><a href="cooperative.php">Cooperative</a></li> 
            <li><a href="dungeoncral&minis.php">Dungeon Crawl & Minis</a></li> 
            <li><a href="partygames.php">Party Games</a></li> 
            <li><a href="starwars.php">Star Wars</a></li> 
          </ul>
        </li>
        <li><a href="contact.php">Liên hệ</a></li>
        <li><a href="account.php">Tài khoản</a></li>
      </ul>
    </nav>
    <div class="search-bar">
    <form id="search-form" method="post">
        <input type="text" name="noidung" placeholder="Tìm kiếm">
        <button type="submit" name="btn">Tìm kiếm</button>
    </form>
    </div>
    <?php 
    session_start();
    $username = isset($_SESSION['username']) ? $_SESSION['username'] : "";
    if ($username != "") { 
?>
<div class="account-icon">
    <i class="fas fa-user"></i>
    <span class="name">Xin chào, <?php echo $username ?></span>
</div>
<?php } else { ?>
<a href="login.php">
    <div class="account-icon">
        <i class="fas fa-user"></i>
    </div>
</a>
<?php } ?>
<div class="cart-icon">
  <a href="cart.php">
    <i class="fas fa-shopping-cart"></i>
    <span class="cart-count">
</header>
<div id="main">
<div class="container">
            <div class="main-product">
            <div class="products">
<?php
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


    <?php
    if (isset($_POST['btn'])) {
        $noidung = $_POST['noidung'];

        // Truy vấn cơ sở dữ liệu
        $sql = "SELECT TENSP, img_src, GIA, MASP, MOTA
                FROM boardgame
                WHERE TENSP LIKE '%$noidung%'";
        $quantity =1 ;
        $result = mysqli_query($conn, $sql);

        if (mysqli_num_rows($result) > 0) {
            while ($row = mysqli_fetch_array($result)) {
                echo '<div class="product">';
                        echo '<div class="image">';
                        echo '<a href="#"><img src="' . $row['img_src'] . '" alt=""></a>';
                        echo '</div>';
                        echo '<div class="product-info">';
                        echo '<h4>' . $row['TENSP'] . '</h4>';
                        echo '<span>' . $row['GIA'] . '</span>';
                        echo '</div>';
                        echo '<p>Mã SP: ' . $row['MASP'] . '</p>';
                        echo '<div class="stars">';
                        echo '<i class="fa-solid fa-star"></i>';
                        echo '<i class="fa-solid fa-star"></i>';
                        echo '<i class="fa-solid fa-star"></i>';
                        echo '<i class="fa-solid fa-star"></i>';
                        echo '<i class="fa-regular fa-star"></i>';
                        echo '</div>';
                        echo '<div class="pay">';
                        echo '<form action="save_to_cart.php" method="post">';
                        echo '<input type="hidden" name="name_product" value="' . $row['TENSP'] . '">';
                        echo '<input type="hidden" name="code" value="' . $row['MASP'] . '">';
                        echo '<input type="hidden" name="price" value="' . $row['GIA'] . '">';
                        echo '<input type="hidden" name="describe" value="' . $row['MOTA'] . '">';
                        echo '<input type="hidden" name="quantity" value="' . $quantity . '">';
                        echo '<button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>';
                        echo '</form>';
                        echo '</div>';
                        echo '</div>';
            }
            echo '<script>document.getElementById("search-results").classList.add("active");</script>';
        } else {
            echo "Không tìm thấy sản phẩm.";
        }
    }
    ?>

<?php
// Đóng kết nối với cơ sở dữ liệu
mysqli_close($conn);
?>
</div>
</div>
</div>
</div>

<div div id="footer">
                <div class="container">
                    <div class="row">
                        <div class="footer-col">
                            <h4>Thông tin</h4>
                            <ul>
                                <li><a href="contact.php">Liên hệ</a></li>
                                <li><a href="policy.php">Chính sách</a></li>
                                <li><a href="https://www.google.com/maps/search/Duong+Hàn+Huyên,+Khu+pho+6,+Phuong+Linh+Trung,+Tp.Thù+Đức,+Tp.HCM"  target="_blank"Đường Hàn Huyên, Khu phố 6, Phường Linh Trung, Tp.Thủ Đức, Tp.HCM>Địa chỉ</a></li>
                                <li><a href="respond.php">Phản hồi</a></li>
                            </ul>
                        </div>
                        <div class="footer-col">
                            <h4>Theo dõi chúng tôi</h4>
                            <div class="social-links">
                                <a href="#"><i class="fab fa-facebook-f"></i></a>
                                <a href="#"><i class="fab fa-twitter"></i></a>
                                <a href="#"><i class="fab fa-instagram"></i></a>
                                <a href="#"><i class="fab fa-linkedin-in"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
        </div>    
    </div>
</body>
</html>