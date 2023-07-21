<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Chess</title>
    <link rel="stylesheet" href="CSS/categories.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
</head>
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
    <form id="search-form" method="post" action="search.php">
        <input type="text" name="noidung" placeholder="Tìm kiếm">
        <button type="submit" name="btn" id="search-btn">Tìm kiếm</button>
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
  <div id="main">
  <h3>
  <div class="title">
    <p>
    <i class="fa-solid fa-paper-plane"></i>
    <a href="#">Thể loại </a>
    <a href="chess.php">/Chess</a>
    </p>
    </div>
    </h3>
        <div class="container">
            <div class="main-product">
                <div class="products">
                <div class="product">   
                        <div class="image">
                            <a href="/BoardGame/product-details.php?id=31"><img src="Sanpham\gen-42-hive-.webp" alt=""></a>
                        </div>
                        <div class="product-info">
                            <h4>Hive Classic</h4>
                            <span>44.99</span>
                        </div>
                        <p>Mã SP: BG031 </p>
                        <div class="stars">
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-regular fa-star"></i>
                        </div>
                        <div class="pay">
                            <form action="save_to_cart.php" method="post">
                                <input type="hidden" name="name_product" value="Hive Classic">
                                <input type="hidden" name="code" value="BG031">
                                <input type="hidden" name="price" value="44.99">
                                <input type="hidden" name="describe" value="">
                                <input type="hidden" name="quantity" value="1">
                                <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                            </form>
                        </div>
                    </div>

                    <div class="product">   
                        <div class="image">
                            <a href="/BoardGame/product-details.php?id=32"><img src="Sanpham\asmodee-chess-luxury-version.webp" alt=""></a>
                        </div>
                        <div class="product-info">
                            <h4>Chess: Luxury Version</h4>
                            <span>64.99</span>
                        </div>
                        <p>Mã SP: BG032 </p>
                        <div class="stars">
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-regular fa-star"></i>
                        </div>
                        <div class="pay">
                            <form action="save_to_cart.php" method="post">
                                <input type="hidden" name="name_product" value="Chess: Luxury Version">
                                <input type="hidden" name="code" value="BG032">
                                <input type="hidden" name="price" value="64.99">
                                <input type="hidden" name="describe" value="">
                                <input type="hidden" name="quantity" value="1">
                                <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                            </form>
                        </div>
                    </div>

                    <div class="product">   
                        <div class="image">
                            <a href="/BoardGame/product-details.php?id=33"><img src="Sanpham\chessplus-chessplus.jpg" alt=""></a>
                        </div>
                        <div class="product-info">
                            <h4>Chessplus</h4>
                            <span>34.99</span>
                        </div>
                        <p>Mã SP: BG033 </p>
                        <div class="stars">
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-regular fa-star"></i>
                        </div>
                        <div class="pay">
                            <form action="save_to_cart.php" method="post">
                                <input type="hidden" name="name_product" value="Chessplus">
                                <input type="hidden" name="code" value="BG033">
                                <input type="hidden" name="price" value="34.99">
                                <input type="hidden" name="describe" value="">
                                <input type="hidden" name="quantity" value="1">
                                <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                            </form>
                        </div>
                    </div>

                    <div class="product">   
                        <div class="image">
                            <a href="/BoardGame/product-details.php?id=34"><img src="Sanpham\61zmEca6lL._AC_SY300_SX300_.jpg" alt=""></a>
                        </div>
                        <div class="product-info">
                            <h4>Chess and Checkers: Folding Version</h4>
                            <span>44.99</span>
                        </div>
                        <p>Mã SP: BG034 </p>
                        <div class="stars">
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-regular fa-star"></i>
                        </div>
                        <div class="pay">
                            <form action="save_to_cart.php" method="post">
                                <input type="hidden" name="name_product" value="Chess and Checkers: Folding Version">
                                <input type="hidden" name="code" value="BG034">
                                <input type="hidden" name="price" value="44.99">
                                <input type="hidden" name="describe" value="">
                                <input type="hidden" name="quantity" value="1">
                                <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                            </form>
                        </div>
                    </div>

                    <div class="product">   
                        <div class="image">
                            <a href="/BoardGame/product-details.php?id=35"><img src="Sanpham\pic6946703.webp" alt=""></a>
                        </div>
                        <div class="product-info">
                            <h4>Onitama Light & Shadow</h4>
                            <span>21.99</span>
                        </div>
                        <p>Mã SP: BG035 </p>
                        <div class="stars">
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-regular fa-star"></i>
                        </div>
                        <div class="pay">
                            <form action="save_to_cart.php" method="post">
                                <input type="hidden" name="name_product" value="Onitama Light & Shadow">
                                <input type="hidden" name="code" value="BG035">
                                <input type="hidden" name="price" value="21.99">
                                <input type="hidden" name="describe" value="">
                                <input type="hidden" name="quantity" value="1">
                                <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                            </form>
                        </div>
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
         <!-- end foooter -->
         </div>
</body>

</html>
