<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Phản hồi</title>
    <link rel="stylesheet" href="respond.css">
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
      <span class="cart-count">0</span>
    </a>
    </div>
</header> 
<div class="form-container">
        <h1>Phản hồi</h1>

        <form id="contactForm" method="POST" action="respond_process.php">
            <label for="name">Họ và tên:</label>
            <input type="text" id="name" name="name" required>

            <label for="email">Email:</label>
            <input type="email" id="email" name="email" required>

            <label for="message">Nội dung:</label>
            <textarea id="message" name="message" required></textarea>

            <button type="submit">Gửi</button>
        </form>
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
