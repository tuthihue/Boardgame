<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Log in</title>
    <link rel="stylesheet" href="CSS/login.css">
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
        <li><a href="#">Liên hệ</a></li>
      </ul>
    </nav>
    <div class="search-bar">
    <form id="search-form" method="post" action="search.php">
        <input type="text" name="noidung" placeholder="Tìm kiếm">
        <button type="submit" name="btn" id="search-btn">Tìm kiếm</button>
    </form>
    </div>
    <a href="login.php">
      <div class="account-icon">
        <i class="fas fa-user"></i>
      </div>
    </a>
    <div class="cart-icon">
      <a href="cart.php">
        <i class="fas fa-shopping-cart"></i>
        <span class="cart-count">0</span>
      </a>
    </div>
  </header>
  <div class="login-container">
    <div class="login-box">
      <h2>Đăng nhập</h2>
      <?php
      if (isset($error)) {
          foreach ($error as $error_msg) {
              echo '<p class="error">' . $error_msg . '</p>';
          }
      }
      ?>
      <form method="POST" action="login_process.php">
        <label for="username">Tên đăng nhập:</label>
        <input type="text" id="username" name="username" required>

        <label for="password">Mật khẩu:</label>
        <input type="password" id="password" name="password" required>

        <button type="submit">Đăng nhập</button>
      </form>
      <div class="signup-link">
        Chưa có tài khoản? <a href="register.php">Đăng ký ngay</a>
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
                                <li><a href="address.php">Địa chỉ</a></li>
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
</body>
</html>
