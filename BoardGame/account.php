<?php

include 'connect.php';
session_start();
// Kiểm tra đăng nhập
if (!isset($_SESSION['username'])) {
    header('location: login.php');
    exit;
}

$uname = $_SESSION['username'];

// Lấy thông tin cá nhân của người dùng
$select_query = "SELECT * FROM customers WHERE USERNAME= '$uname'";
$result = mysqli_query($conn, $select_query);

if (mysqli_num_rows($result) > 0) {
    $userInfo= mysqli_fetch_array($result);
}

// Xử lý dữ liệu gửi từ form
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $name = mysqli_real_escape_string($conn, $_POST['name']);
  $email = mysqli_real_escape_string($conn, $_POST['email']);
  $phone = mysqli_real_escape_string($conn,$_POST['phone']);
  $password = mysqli_real_escape_string($conn,$_POST['password']);
 
  // Cập nhật thông tin vào CSDL
  $sql = "UPDATE customers SET HOTEN='$name', email='$email', sdt='$phone', password='$password' WHERE username='$uname'";
}
?>

<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang quản lý tài khoản cá nhân</title>
    <link rel="stylesheet" href="account.css">
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
            <li><a href="#">Card Games</a></li> 
            <li><a href="#">Dice Games</a></li> 
            <li><a href="#">Chess</a></li> 
            <li><a href="#">Family</a></li> 
            <li><a href="#">Living Card Games</a></li> 
            <li><a href="#">Deckbuilders</a></li> 
            <li><a href="#">Wargame & Strategy</a></li> 
            <li><a href="#">Cooperative</a></li> 
            <li><a href="#">Dungeon Crawl & Minis</a></li> 
            <li><a href="#">Party Games</a></li> 
            <li><a href="#">Star Wars</a></li> 
          </ul>
        </li>
        <li><a href="contact.php">Liên hệ</a></li>
        <li><a href="account.php">Tài khoản</a></li>
      </ul>
    </nav>
    <div class="search-bar">
      <input type="text" placeholder="Tìm kiếm">
      <button type="submit">Tìm kiếm</button>
    </div>
    <?php 
    $username = isset($_SESSION['username']) ? $_SESSION['username'] : "";
    if ($username != "") { ?>
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
            <span class="cart-count">0</span>
          </a>
          </div>
  </header>
  <div class="container">
        <div class="account-sidebar">
            <ul>
                <li class="menu-item" data-content="history"><a href="#">Lịch sử đặt hàng</a></li>
                <li class="menu-item" data-content="personal-info"><a href="#">Thông tin cá nhân</a></li>
                <li class="menu-item" data-content="edit-info"><a href="#">Sửa đổi thông tin cá nhân</a></li>
                <li class="menu-item" data-content="points"><a href="#">Xem tích điểm cá nhân</a></li>
                <li class="menu-item" data-content="logout"><a href="#">Đăng xuất</a></li>
            </ul>
        </div>
  
            <div id="edit-info" class="content-item">
            <!-- Nội dung cho Sửa đổi thông tin cá nhân -->
            <h2>Sửa đổi thông tin cá nhân</h2>
            <form action="" method="post">
              <div class="form-group">
                <label for="name">Họ và tên:</label>
                <input type="text" id="name" name="name" value="<?php echo $userInfo['HOTEN']; ?>" required>
              </div>
                <div class="form-group">
                  <label for="username">Tên người dùng:</label>
                  <input type="text" id="username" name="username" value="<?php echo $userInfo['USERNAME']; ?>" required readonly>
                </div>

                <div class="form-group">
                  <label for="email">Email:</label>
                  <input type="email" id="email" name="email" value="<?php echo $userInfo['email']; ?>" required>
                </div>

                <div class="form-group">
                  <label for="phone">Số điện thoại:</label>
                  <input type="tel" id="phone" name="phone" value="<?php echo $userInfo['sdt']; ?>" required>
                </div>

                <div class="form-group">
                  <label for="password">Mật khẩu:</label>
                  <input type="password" id="password" name="password" required>
                </div>
                <button type="submit" class="btn-submit">Cập nhật thông tin</button>
              </form>
            </div>

    </div> 
    <script src="account.js"></script>
</body>

</html>
