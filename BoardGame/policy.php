<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Chính sách</title>
    <link rel="stylesheet" href="CSS/policy.css">
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
        <span class="cart-count">
            <?php
              // Kết nối cơ sở dữ liệu và thực hiện truy vấn
              include 'connect.php';
              $query = "SELECT SUM(quantity) AS totalQuantity FROM carts";
              $result = mysqli_query($conn, $query);
              $row = mysqli_fetch_assoc($result);
              $cartItemCount = $row['totalQuantity'];
              
              // Hiển thị tổng số sản phẩm trong giỏ hàng
              echo $cartItemCount;
            ?>
          </span>
      </a>
    </div>
  </header>
  <main>
    <div class="container">
      <h1>Chính sách</h1>
      <section>
        <h2>Chính sách bảo mật</h2>
        <p>
        Chúng tôi cam kết giữ bí mật mọi thông tin cá nhân của bạn. Chúng tôi sẽ không cho thuê, bán 
        hoặc cho bất kỳ nên thứ ba nào tên, địa chỉ, địa chỉ email hoặc bất kỳ thông tin cả nhân nào khác 
        trước khi bạn yêu cầu chúng tôi.
        </p>
      </section>

      <section>
        <h2>Chính sách cho thuê sản phẩm</h2>
        <p>
        Chúng tôi cam kết rằng sản phẩm bạn sử dụng là sản phẩm chính hãng và không có bất kỳ hư hại nào.
        Nếu có bất kỳ hư  hỏng nào bạn hãy liên hệ trực tiếp qua kênh liên hệ của Chúng tôi để sẵn trên website để được đổi.
        Khi thuê sản phẩm của cửa hàng chúng tôi mong muốn bạn sử dụng một cách hợp lý và an toàn. 
        Sản phẩm khi bạn trả cho chúng tôi có vấn đề, hư hỏng khi chúng tôi phát hiện bạn phải đền bù theo quy định của cửa hàng.
        </p>
      </section>
    </div>
  </main>
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
</body>
</html>