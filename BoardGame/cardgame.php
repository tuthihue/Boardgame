<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Card Games</title>
    <link rel="stylesheet" href="categories.css">
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
  <div id="main">
  <h3>
  <div class="title">
    <p>
    <i class="fa-solid fa-paper-plane"></i>
    <a href="#">Thể loại </a>
    <a href="cardgame.php">/Card Games</a>
    </p>
    </div>
    </h3>
        <div class="container">
            <div class="main-product">
                <div class="products">
                <div class="product">   
                        <div class="image">
                            <a href="/BoardGame/product-details.php?id=43"><img src="Sanpham\zygomatic-spot-it-disney-princess.jpg" alt=""></a>
                        </div>
                        <div class="product-info">
                            <h4>Spot It! Disney Princess</h4>
                            <span>19.99</span>
                        </div>
                        <p>Mã SP: BG043 </p>
                        <div class="stars">
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-regular fa-star"></i>
                        </div>
                        <div class="pay">
                            <form action="save_to_cart.php" method="post">
                                <input type="hidden" name="name_product" value="Spot It! Disney Princess">
                                <input type="hidden" name="code" value="BG043">
                                <input type="hidden" name="price" value="19.99">
                                <input type="hidden" name="describe" value="">
                                <input type="hidden" name="quantity" value="1">
                                <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                            </form>
                        </div>
                    </div>

                    <div class="product">   
                        <div class="image">
                            <a href="/BoardGame/product-details.php?id=44"><img src="Sanpham\aeg-smash-up-big-in-japan.jpg" alt=""></a>
                        </div>
                        <div class="product-info">
                            <h4>Smash Up: Big in Japan</h4>
                            <span>24.99</span>
                        </div>
                        <p>Mã SP: BG044 </p>
                        <div class="stars">
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-regular fa-star"></i>
                        </div>
                        <div class="pay">
                            <form action="save_to_cart.php" method="post">
                                <input type="hidden" name="name_product" value="Smash Up: Big in Japan">
                                <input type="hidden" name="code" value="BG044">
                                <input type="hidden" name="price" value="24.99">
                                <input type="hidden" name="describe" value="">
                                <input type="hidden" name="quantity" value="1">
                                <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                            </form>
                        </div>
                    </div>

                    <div class="product">   
                        <div class="image">
                            <a href="/BoardGame/product-details.php?id=45"><img src="Sanpham\steve-jackson-games-munchkin-apocalypse-2-sheep-im.jpg" alt=""></a>
                        </div>
                        <div class="product-info">
                            <h4>Munchkin Apocalypse 2 Sheep Impact Game</h4>
                            <span>19.95</span>
                        </div>
                        <p>Mã SP: BG045 </p>
                        <div class="stars">
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-regular fa-star"></i>
                        </div>
                        <div class="pay">
                            <form action="save_to_cart.php" method="post">
                                <input type="hidden" name="name_product" value="Munchkin Apocalypse 2 Sheep Impact Game">
                                <input type="hidden" name="code" value="BG045">
                                <input type="hidden" name="price" value="19.95">
                                <input type="hidden" name="describe" value="">
                                <input type="hidden" name="quantity" value="1">
                                <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                            </form>
                        </div>
                    </div>

                    <div class="product">   
                        <div class="image">
                            <a href="/BoardGame/product-details.php?id=46"><img src="Sanpham\slugfest-games-the-red-dragon-inn-7-the-tavern-cre.jpg" alt=""></a>
                        </div>
                        <div class="product-info">
                            <h4>The Red Dragon Inn 7: The Tavern Crew</h4>
                            <span>39.99</span>
                        </div>
                        <p>Mã SP: BG046 </p>
                        <div class="stars">
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-regular fa-star"></i>
                        </div>
                        <div class="pay">
                            <form action="save_to_cart.php" method="post">
                                <input type="hidden" name="name_product" value="The Red Dragon Inn 7: The Tavern Crew">
                                <input type="hidden" name="code" value="BG046">
                                <input type="hidden" name="price" value="39.99">
                                <input type="hidden" name="describe" value="">
                                <input type="hidden" name="quantity" value="1">
                                <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                            </form>
                        </div>
                    </div>

                    <div class="product">   
                        <div class="image">
                            <a href="/BoardGame/product-details.php?id=47"><img src="Sanpham\steve-jackson-games-munchkin-russia.jpg" alt=""></a>
                        </div>
                        <div class="product-info">
                            <h4>Munchkin Russia</h4>
                            <span>34.99</span>
                        </div>
                        <p>Mã SP: BG047 </p>
                        <div class="stars">
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-regular fa-star"></i>
                        </div>
                        <div class="pay">
                            <form action="save_to_cart.php" method="post">
                                <input type="hidden" name="name_product" value="Munchkin Russia">
                                <input type="hidden" name="code" value="BG047">
                                <input type="hidden" name="price" value="34.99">
                                <input type="hidden" name="describe" value="">
                                <input type="hidden" name="quantity" value="1">
                                <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                            </form>
                        </div>
                    </div>

                    <div class="product">   
                        <div class="image">
                            <a href="/BoardGame/product-details.php?id=48"><img src="Sanpham\slugfest-games-the-red-dragon-inn-8-the-pub-crawl-1.webp" alt=""></a>
                        </div>
                        <div class="product-info">
                            <h4>The Red Dragon Inn 8: The Pub Crawl</h4>
                            <span>39.99</span>
                        </div>
                        <p>Mã SP: BG048 </p>
                        <div class="stars">
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-regular fa-star"></i>
                        </div>
                        <div class="pay">
                            <form action="save_to_cart.php" method="post">
                                <input type="hidden" name="name_product" value="The Red Dragon Inn 8: The Pub Crawl">
                                <input type="hidden" name="code" value="BG048">
                                <input type="hidden" name="price" value="39.99">
                                <input type="hidden" name="describe" value="">
                                <input type="hidden" name="quantity" value="1">
                                <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                            </form>
                        </div>
                    </div>

                    <div class="product">   
                        <div class="image">
                            <a href="/BoardGame/product-details.php?id=49"><img src="Sanpham\renegade-game-studios-good-omens-an-ineffable-game.webp" alt=""></a>
                        </div>
                        <div class="product-info">
                            <h4>Good Omens: An Ineffable Game</h4>
                            <span>24.99</span>
                        </div>
                        <p>Mã SP: BG049 </p>
                        <div class="stars">
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-regular fa-star"></i>
                        </div>
                        <div class="pay">
                            <form action="save_to_cart.php" method="post">
                                <input type="hidden" name="name_product" value="Good Omens: An Ineffable Game">
                                <input type="hidden" name="code" value="BG049">
                                <input type="hidden" name="price" value="24.99">
                                <input type="hidden" name="describe" value="">
                                <input type="hidden" name="quantity" value="1">
                                <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                            </form>
                        </div>
                    </div>

                    <div class="product">   
                        <div class="image">
                            <a href="/BoardGame/product-details.php?id=50"><img src="Sanpham\van-ryder-games-final-girl-a-knock-at-the-door-int-1.webp" alt=""></a>
                        </div>
                        <div class="product-info">
                            <h4>Final Girl: A Knock at the Door</h4>
                            <span>19.99</span>
                        </div>
                        <p>Mã SP: BG050 </p>
                        <div class="stars">
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-solid fa-star"></i>
                        <i class="fa-regular fa-star"></i>
                        </div>
                        <div class="pay">
                            <form action="save_to_cart.php" method="post">
                                <input type="hidden" name="name_product" value="Final Girl: A Knock at the Door">
                                <input type="hidden" name="code" value="BG050">
                                <input type="hidden" name="price" value="19.99">
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
