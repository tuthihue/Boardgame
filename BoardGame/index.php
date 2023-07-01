<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang chủ | BoardGame</title>
    <link rel="stylesheet" href="home.css">
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
        <!-- end header -->
        <div id="main">
            <div class="container">
                    <div class="banner">
                        <img src="banner.jpg" alt="">
                    </div>
                 <div class="main-product">
                    <div class="title">
                    </div>
                    <div class="products"> 
                        <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=1"><img src="SanPham\asmodee-chess-luxury-version.webp" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Chess: Luxury Version</h4>
                                <span>64.999đ</span>
                            </div>
                            <p>Mã SP: BGOO1 </p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                        <div class="product">
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=2"><img src="SanPham\chessplus-chessplus.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Chessplus</h4>
                                <span>34.999đ</span>
                            </div>
                            <p>Mã SP: BG002 </p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                        <div class="product">
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=3"><img src=" SanPham\cmon-marvel-united-guardians-of-the-galaxy-remix.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Marvel United: Guardians of the Galaxy Remix</h4>
                                <span>34.999đ</span>
                            </div>
                            <p>Mã SP: BG003 </p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                        
                    </div>
                </div>
            <!-- BG2 -->
                <div class="main-product">
                    <div class="products"> 
                        <div class="product">
                            <div class="image">
                                <a href="/DoAnTKWeb/product-details"><img src=" SanPham\cmon-masters-of-the-universe-the-board-game-clash.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Masters of the Universe: The Board Game - Clash For Eternia</h4>
                                <span>109.999đ</span>
                            </div>
                            <p>Mã SP: BG004 </p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                        <div class="product">
                            <div class="image">
                                <a href="/DoAnTKWeb/product-details"><img src=" SanPham\cryptozoic-entertainment-epic-spell-wars-of-the-ba.webp" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Epic Spell Wars of the Battle Wizards: Rumble at Castle Tentakill</h4>
                                <span>34.999₫</span>
                            </div>
                            <p>Mã SP: BG005 </p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                        <div class="product">
                            <div class="image">
                                <a href="/DoAnTKWeb/product-details"><img src=" SanPham\devir-americas-mille-fiori.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Mille Fiori</h4>
                                <span>49.999đ</span>
                            </div>
                            <p>Mã SP: BG006 </p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                    </div>
                </div> 
                <div class="main-product">
                    <div class="products"> 
                        <div class="product">
                            <div class="image">
                                <a href="/DoAnTKWeb/product-details"><img src=" SanPham\fantasy-flight-games-agot-lcg-2nd-ed-for-family-ho.png" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>AGOT LCG 2nd Ed: For Family Honor</h4>
                                <span>14.999₫</span>
                            </div>
                            <p>Mã SP: BG007</p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                        <div class="product">
                            <div class="image">
                                <a href="/DoAnTKWeb/product-details"><img src=" SanPham\fantasy-flight-games-arkham-horror-final-hour.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Arkham Horror: The Card Game - Fortune and Folly Scenario Pack</h4>
                                <span>24.999₫</span>
                            </div>
                            <p>Mã SP: BG008 </p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                        <div class="product">
                            <div class="image">
                                <a href="/DoAnTKWeb/product-details"><img src=" SanPham\gen-42-hive-.webp" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Hive Classic</h4>
                                <span>49.999₫</span>
                            </div>
                            <p>Mã SP: BG009 </p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                    </div>
                </div> 
                <div class="main-product">
                    <div class="products"> 
                        <div class="product">
                            <div class="image">
                                <a href="/DoAnTKWeb/product-details"><img src=" SanPham\hasbro-d-d-bedlam-in-neverwinter.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>D&D: Bedlam in Neverwinter</h4>
                                <span>49.999đ</span>
                            </div>
                            <p>Mã SP: BG010</p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                        <div class="product">
                            <div class="image">
                                <a href="/DoAnTKWeb/product-details"><img src=" SanPham\aeg-smash-up-big-in-japan.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Smash Up: Big in Japan</h4>
                                <span>24.999đ</span>
                            </div>
                            <p>Mã SP: BG011 </p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                        <div class="product">
                            <div class="image">
                                <a href="/DoAnTKWeb/product-details"><img src=" SanPham\horrible-guild-game-studios-railroad-ink-challenge.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Railroad Ink: Challenge: Shining Yellow</h4>
                                <span>26.990₫</span>
                            </div>
                            <p>Mã SP: BG012 </p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                        
                    </div>
                </div>
                <div class="main-product">
                    <div class="products"> 
                        <div class="product">
                            <div class="image">
                                <a href="/DoAnTKWeb/product-details"><img src=" SanPham\plaid-hat-games-abomination-the-heir-of-frankenste.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Abomination: The Heir of Frankenstein</h4>
                                <span>64.999₫</span>
                            </div>
                            <p>Mã SP: BG013 </p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                        <div class="product">
                            <div class="image">
                                <a href="/DoAnTKWeb/product-details"><img src=" SanPham\steve-jackson-games-munchkin-apocalypse-2-sheep-im.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Munchkin Apocalypse 2 Sheep Impact Game</h4>
                                <span>19.999₫</span>
                            </div>
                            <p>Mã SP: BG014 </p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                        <div class="product">
                            <div class="image">
                                <a href="/DoAnTKWeb/product-details"><img src=" SanPham\thames-kosmos-high-score.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>High Score</h4>
                                <span>14.999₫</span>
                            </div>
                            <p>Mã SP: BG015 </p>
                            <div class="stars">
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                                <i class="fa-solid fa-star"></i>
                            </div>
                            <div class="pay">
                                <button>Thêm vào giỏ <i class="fa-solid fa-cart-shopping"></i></button>
                            </div>
                        </div>
                        
                    </div>
                </div>
            </div>
            </div>
        </div>
        <!-- end main -->
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
         <!-- end foooter -->
    </div>
</body>

</html>
