<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang chủ | BoardGame</title>
    <link rel="stylesheet" href="CSS/product.css">
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
        <!-- end header -->
        <br><br>
        <div id="main">
            <div class="page-title">
                <div class="title">
                <p>
                <i class="fa-solid fa-house"></i>
                <a href="/BoardGame/index.php">Trang chủ </a>
                <a href="/BoardGame">/BoardGame</a>
                </p>
                </div>
                <h1 ></h1>
              <div class = "card-wrapper">
                  <div class = "card">
                      <div class="product-imgs">
                        <div class="img-display">
                          <div class = "img-showcase">
                            <img src="" alt="" id="product-image">
                          </div>
                        </div>
                      </div>
                  
                      <div class="product-content">
                      <div>
                          <h2 style="display: inline;">Mã sản phẩm: </h2>
                          <h2 class="product-ID" style="display: inline;"></h2>
                      </div>
                      
                        <h2 class="product-title"></h2>
                        <div class="product-price">
                          <p class="new-price"><span></span></p>
                        </div>
                        <h2>Về sản phẩm: </h2>
                        <p class = "product-detail"> </p>
                        <form action="save_to_cart.php" method="post">
                          <input type="hidden" name="name_product" value="">
                          <input type="hidden" name="code" value="">
                          <input type="hidden" name="price" value="">
                          <input type="hidden" name="describe" value="">
                          <input type="hidden" name="quantity" value="1">
                          
                          <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                        </form>
                      </div>

                    </div>
                    
                    
                  </div>
                  </div>

                  <script>
                    window.onload = function() {
                      const urlParams = new URLSearchParams(window.location.search);
                      const productId = urlParams.get('id');
                      const productData = {
                        32: {
                          name: 'Chess: Luxury Version',
                          price: '64.999đ',
                          code: 'BGO32',
                          image: 'SanPham/asmodee-chess-luxury-version.webp',
                          describe:'Bộ Cờ Tướng Cao Cấp là bộ cờ vua hoàn toàn bằng gỗ cao cấp. Nó có một bảng gỗ hoàn thiện đẹp mắt và các quân cờ bằng gỗ có đáy nhung để bảo vệ bảng và mang lại trải nghiệm chơi thú vị.'
                        },
                        33: {
                          name: 'Chessplus',
                          price: '34.999đ',
                          code: 'BG033',
                          image: 'SanPham/chessplus-chessplus.jpg',
                          describe: `Chessplus, – Đó không phải là cờ vua. Thế tốt hơn rồi!
                          Kết hợp & Chinh phục.Bắt đầu kết hợp ngay từ nước đi đầu tiên của bạn - di chuyển Tượng trên đường chéo lên Tốt. Quân cờ kết hợp mới (Biawn) giờ đây có thể di chuyển dưới dạng Tượng hoặc Tốt, hoặc nó có thể tách ra bằng cách di chuyển một trong hai quân cờ ra xa riêng lẻ.
                            Bạn có thích thăng quân Tốt lên quân Hậu không? Hãy nhanh chóng theo dõi quân Tốt của bạn sang phía bên kia của bàn cờ bằng cách sử dụng Xe hoặc Tượng và WHAM bạn có thêm một QUEEN trên bàn cờ. Nhưng hãy coi chừng nếu bạn mất một quân cờ Kết hợp, bạn sẽ mất hai quân cờ tiêu chuẩn BANG!
                            Kết hợp quân Hậu và quân Mã (Quight) để có quân TỔN THƯƠNG - Quân Hậu THẬT trên chiến mã của mình đang chiến đấu trên bàn cờ, bất cứ lúc nào cô ấy có thể nhảy trở lại bàn cờ để giao chiến với quân Hậu.
                            Một trận chiến thời TRUNG cổ thực sự với quân Tốt CƯỠI NGỰA như KỶ SĨ THẬT và BẮN MŨI TÊN từ các tòa tháp (Xe), và quân Hậu DẪN ĐẦU CHI PHÍ trên những chiến mã dũng mãnh của họ.
                            Các trò chơi Chessplus nhanh hơn, có nhiều nước đi bất ngờ và nhiều hơn theo cấp số nhân, tất cả các chiến lược mới (sẽ được khám phá) và cách chơi dễ dàng hơn khi so sánh với Cờ vua.
                            Trò chơi bảng chiến lược mới dựa trên Cờ vua nơi người chơi có thể KẾT HỢP và TÁCH các quân cờ của họ. Học trong 20 giây để tận hưởng niềm vui và thử thách trọn đời.`
                        },
                      };

                      const productImage = document.getElementById('product-image');
                      productImage.src = productData[productId].image;
                      const form = document.querySelector('form[action="cart.php"]');
                      
                      document.querySelector('.product-title').textContent = productData[productId].name;
                      document.querySelector('.product-ID').textContent = productData[productId].code;
                      document.querySelector('.new-price span').textContent = productData[productId].price;
                      document.querySelector('.product-detail').textContent = productData[productId].describe;
                      document.querySelector('input[name="name_product"]').value =productData[productId].name ;
                      document.querySelector('input[name="code"]').value = productData[productId].code;
                      document.querySelector('input[name="price"]').value = productData[productId].price;
                      document.querySelector('input[name="describe"]').value = productData[productId].describe;
                                        };
                  </script>


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
                </div>
                  </div>
              </div>
        </div>
    </div>
</body>

</html>
