<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sản phẩm</title>
    <link rel="stylesheet" href="CSS/product_shop.css">
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
    <i class="fa-solid fa-house"></i>
    <a href="/BoardGame/index.php">Trang chủ </a>
    <a href="product.php">/Sản phẩm</a>
    </p>
    </div>
    </h3>
        <div class="container">
            <div class="main-product">
                <div class="products">
                    <?php
                    // Danh sách sản phẩm
                    $products = [                         
                        [   
                            'code' => 'BG001',
                            'name' => 'Outer Rim',
                            'price' => '74.999',
                            'image' => 'Sanpham\fantasy-flight-games-star-wars-outer-rim.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=1'
                        ],

                        [   
                            'code' => 'BG002',
                            'name' => 'Not That Movie',
                            'price' => '24.999',
                            'image' => 'Sanpham\pic6961520.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=2'
                        ],

                        [   
                            'code' => 'BG003',
                            'name' => 'Best of Werewolves of Millers Hollow',
                            'price' => '21.999',
                            'image' => 'Sanpham\zygomatic-best-of-werewolves-of-millers-hollow_2.png',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=3'
                        ],

                        [   
                            'code' => 'BG004',
                            'name' => 'Dixit: Odyssey Expansion',
                            'price' => '34.99',
                            'image' => 'Sanpham\lucky-duck-games-nimalia.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=4'
                        ],

                        [   
                            'code' => 'BG005',
                            'name' => 'Skull',
                            'price' => '24.99',
                            'image' => 'Sanpham\space-cowboys-skull.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=5'
                        ],

                        [   
                            'code' => 'BG006',
                            'name' => 'The Werewolves of Millers Hollow: The Pact',
                            'price' => '49.99',
                            'image' => 'Sanpham\zygomatic-the-werewolves-of-millers-hollow-the-pac.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=6'
                        ],

                        [   
                            'code' => 'BG007',
                            'name' => 'Squid Game',
                            'price' => '29.990 ',
                            'image' => 'Sanpham\mixlore-squid-game.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=7'
                        ],

                        [   
                            'code' => 'BG008',
                            'name' => 'HeroQuest: The Mage of the Mirror',
                            'price' => '49.99',
                            'image' => 'Sanpham\hasbro-heroquest-the-mage-of-the-mirror.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=8'
                        ],

                        [   
                            'code' => 'BG009',
                            'name' => 'Marvel United: Guardians of the Galaxy Remix',
                            'price' => '34.99',
                            'image' => 'Sanpham\cmon-marvel-united-guardians-of-the-galaxy-remix.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=9'
                        ],

                        [   
                            'code' => 'BG010',
                            'name' => 'Masters of the Universe: The Board Game - Clash For Eternia',
                            'price' => '109.99',
                            'image' => 'Sanpham\cmon-masters-of-the-universe-the-board-game-clash.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=10'
                        ],

                        [   
                            'code' => 'BG011',
                            'name' => 'Beast',
                            'price' => '69.99',
                            'image' => 'Sanpham\pegasus-spiele-beast.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=11'
                        ],

                        [   
                            'code' => 'BG012',
                            'name' => 'Arkham Horror: Final Hour',
                            'price' => '39.99',
                            'image' => 'Sanpham\fantasy-flight-games-arkham-horror-final-hour.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=12'
                        ],

                        [   
                            'code' => 'BG013',
                            'name' => 'Legacy of Yu',
                            'price' => '59.99',
                            'image' => 'Sanpham\renegade-game-studios-legacy-of-yu-1.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=13'
                        ],

                        [   
                            'code' => 'BG014',
                            'name' => 'Earth',
                            'price' => '49.99',
                            'image' => 'Sanpham\inside-up-games-earth.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=14'
                        ],

                        [   
                            'code' => 'BG015',
                            'name' => 'My Fathers Work',
                            'price' => '124.99',
                            'image' => 'Sanpham\renegade-game-studios-my-fathers-work-1.png',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=15'
                        ],

                        [   
                            'code' => 'BG016',
                            'name' => 'Twilight Imperium: Prophecy of Kings',
                            'price' => '99.95',
                            'image' => 'Sanpham\fantasy-flight-games-twilight-imperium-prophecy-of.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=16'
                        ],

                        [   
                            'code' => 'BG017',
                            'name' => 'Abomination: The Heir of Frankenstein',
                            'price' => '64.99',
                            'image' => 'Sanpham\plaid-hat-games-abomination-the-heir-of-frankenste.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=17'
                        ],

                        [   
                            'code' => 'BG018',
                            'name' => 'Mille Fiori',
                            'price' => '49.99',
                            'image' => 'Sanpham\devir-americas-mille-fiori.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=18'
                        ],

                        [   
                            'code' => 'BG019',
                            'name' => 'Transformers Deck-Building Game',
                            'price' => '44.99',
                            'image' => 'Sanpham\renegade-game-studios-transformers-deck-building-g-1.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=19'
                        ],

                        [   
                            'code' => 'BG020',
                            'name' => 'Epic Spell Wars of the Battle Wizards: Rumble at Castle Tentakill',
                            'price' => '34.99',
                            'image' => 'Sanpham\cryptozoic-entertainment-epic-spell-wars-of-the-ba.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=20'
                        ],

                        [   
                            'code' => 'BG021',
                            'name' => 'G.I. JOE Deck-Building Game',
                            'price' => '45',
                            'image' => 'Sanpham\renegade-game-studios-gi-joe-deck-building-game.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=21'
                        ],

                        [   
                            'code' => 'BG022',
                            'name' => 'AGOT LCG 2nd Ed: For Family Honor',
                            'price' => '14.99',
                            'image' => 'Sanpham\fantasy-flight-games-agot-lcg-2nd-ed-for-family-ho.png',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=22'
                        ],

                        [   
                            'code' => 'BG023',
                            'name' => 'Arkham Horror: The Card Game - Fortune and Folly Scenario Pack',
                            'price' => '24.99',
                            'image' => 'Sanpham\fantasy-flight-games-arkham-horror-the-card-game-f.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=23'
                        ],

                        [   
                            'code' => 'BG024',
                            'name' => 'Marvel Champions LCG: Scarlet Witch Hero Pack',
                            'price' => '19.99',
                            'image' => 'Sanpham\fantasy-flight-games-marvel-champions-lcg-scarlet.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=24'
                        ],

                        [   
                            'code' => 'BG025',
                            'name' => 'Marvel Champions LCG: Vision Hero Pack',
                            'price' => '19.99',
                            'image' => 'Sanpham\fantasy-flight-games-marvel-champions-lcg-vision-h.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=25'
                        ],

                        [   
                            'code' => 'BG026',
                            'name' => 'Marvel Champions: Rogue Hero Pack',
                            'price' => '19.99',
                            'image' => 'Sanpham\fantasy-flight-games-marvel-champions-rogue-hero-p.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=26'
                        ],

                        [   
                            'code' => 'BG027',
                            'name' => 'Carcassonne Exp 6: Count, King & Robber',
                            'price' => '21.99',
                            'image' => 'Sanpham\z-man-games-carcassonne-exp-6-count-king-robber-1.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=27'
                        ],

                        [   
                            'code' => 'BG028',
                            'name' => 'D&D: Bedlam in Neverwinter',
                            'price' => '49.99',
                            'image' => 'Sanpham\hasbro-d-d-bedlam-in-neverwinter.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=28'
                        ],

                        [   
                            'code' => 'BG029',
                            'name' => 'Nimalia',
                            'price' => '21.99',
                            'image' => 'Sanpham\lucky-duck-games-nimalia.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=29'
                        ],

                        [   
                            'code' => 'BG030',
                            'name' => 'Dorfromantik: The Board Game',
                            'price' => '44.99',
                            'image' => 'Sanpham\pegasus-spiele-dorfromantik-the-board-game.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=30'
                        ],

                        [   
                            'code' => 'BG031',
                            'name' => 'Hive Classic',
                            'price' => '44.99',
                            'image' => 'Sanpham\gen-42-hive-.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=31'
                        ],

                        [   
                            'code' => 'BG032',
                            'name' => 'Chess: Luxury Version',
                            'price' => '64.99',
                            'image' => 'Sanpham\asmodee-chess-luxury-version.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=32'
                        ],

                        [   
                            'code' => 'BG033',
                            'name' => 'Chessplus',
                            'price' => '34.99',
                            'image' => 'Sanpham\chessplus-chessplus.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=33'
                        ],

                        [   
                            'code' => 'BG034',
                            'name' => 'Chess and Checkers: Folding Version',
                            'price' => '44.99',
                            'image' => 'Sanpham\61zmEca6lL._AC_SY300_SX300_.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=34'
                        ],

                        [   
                            'code' => 'BG035',
                            'name' => 'Onitama Light & Shadow',
                            'price' => '21.99',
                            'image' => 'Sanpham\pic6946703.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=35'
                        ],

                        [   
                            'code' => 'BG036',
                            'name' => 'Railroad Ink: Blazing Red',
                            'price' => '26.99',
                            'image' => 'Sanpham\luma-imports-railroad-ink-blazing-red.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=36'
                        ],

                        [   
                            'code' => 'BG037',
                            'name' => 'Railroad Ink: Challenge: Shining Yellow',
                            'price' => '26.99',
                            'image' => 'Sanpham\horrible-guild-game-studios-railroad-ink-challenge.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=37'
                        ],

                        [   
                            'code' => 'BG038',
                            'name' => 'High Score',
                            'price' => '14.99',
                            'image' => 'Sanpham\thames-kosmos-high-score.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=38'
                        ],

                        [   
                            'code' => 'BG039',
                            'name' => 'Sakura Heroes',
                            'price' => '24.99',
                            'image' => 'Sanpham\ravensburger-sakura-heroes.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=39'
                        ],

                        [   
                            'code' => 'BG040',
                            'name' => 'Pinata Blast',
                            'price' => '14.99',
                            'image' => 'Sanpham\ravensburger-pinata-blast.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=40'
                        ],

                        [   
                            'code' => 'BG041',
                            'name' => 'Drawn to Adventure',
                            'price' => '29.99',
                            'image' => 'Sanpham\final-frontier-games-drawn-to-adventure.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=41'
                        ],

                        [   
                            'code' => 'BG042',
                            'name' => 'Twilight Inscription',
                            'price' => '69.99',
                            'image' => 'Sanpham\fantasy-flight-games-twilight-inscription.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=42'
                        ],

                        [   
                            'code' => 'BG043',
                            'name' => 'Spot It! Disney Princess',
                            'price' => '19.99',
                            'image' => 'Sanpham\zygomatic-spot-it-disney-princess.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=43'
                        ],

                        [   
                            'code' => 'BG044',
                            'name' => 'Smash Up: Big in Japan',
                            'price' => '24.99',
                            'image' => 'Sanpham\aeg-smash-up-big-in-japan.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=44'
                        ],

                        [   
                            'code' => 'BG045',
                            'name' => 'Munchkin Apocalypse 2 Sheep Impact Game',
                            'price' => '19.95',
                            'image' => 'Sanpham\steve-jackson-games-munchkin-apocalypse-2-sheep-im.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=45'
                        ],

                        [   
                            'code' => 'BG046',
                            'name' => 'The Red Dragon Inn 7: The Tavern Crew',
                            'price' => '39.99',
                            'image' => 'Sanpham\slugfest-games-the-red-dragon-inn-7-the-tavern-cre.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=46'
                        ],

                        [   
                            'code' => 'BG047',
                            'name' => 'Munchkin Russia',
                            'price' => '34.99',
                            'image' => 'Sanpham\steve-jackson-games-munchkin-russia.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=47'
                        ],

                        [   
                            'code' => 'BG048',
                            'name' => 'The Red Dragon Inn 8: The Pub Crawl',
                            'price' => '39.99',
                            'image' => 'Sanpham\slugfest-games-the-red-dragon-inn-8-the-pub-crawl-1.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=48'
                        ],

                        [   
                            'code' => 'BG049',
                            'name' => 'Good Omens: An Ineffable Game',
                            'price' => '24.99',
                            'image' => 'Sanpham\renegade-game-studios-good-omens-an-ineffable-game.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=49'
                        ],

                        [   
                            'code' => 'BG050',
                            'name' => 'Final Girl: A Knock at the Door',
                            'price' => '19.99',
                            'image' => 'Sanpham\van-ryder-games-final-girl-a-knock-at-the-door-int-1.webp',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=50'
                        ],
                        [   
                            'code' => 'BG051',
                            'name' => 'Munchkin Apocalypse 2 Sheep Impact Game',
                            'price' => '19.95',
                            'image' => 'Sanpham\steve-jackson-games-munchkin-apocalypse-2-sheep-im.jpg',
                            'describe' => '',
                            'quantity' => '1',
                            'hreference' => '/BoardGame/product-details.php?id=45'
                        ],

                     
                    ];

                        // Hàm so sánh giá tăng dần
                        function comparePriceAsc($a, $b) {
                            return $a['price'] <=> $b['price'];
                        }

                        // Hàm so sánh giá giảm dần
                        function comparePriceDesc($a, $b) {
                            return $b['price'] <=> $a['price'];
                        }

                        // Kiểm tra và gán giá trị cho biến $currentPage
                        if (isset($_GET['page'])) {
                            $currentPage = intval($_GET['page']);
                        } else {
                            $currentPage = 1;
                        }

                        // Số lượng sản phẩm trên mỗi trang
                        $productsPerPage = 9;

                        // Tính toán chỉ mục bắt đầu và chỉ mục kết thúc của sản phẩm trên trang hiện tại
                        $startIndex = ($currentPage - 1) * $productsPerPage;
                        $endIndex = $startIndex + $productsPerPage - 1;

                        // Lựa chọn hàm so sánh dựa trên tham số 'sort' truyền vào từ URL
                        $sort = isset($_GET['sort']) ? $_GET['sort'] : '';
                        if ($sort === 'asc') {
                            usort($products, 'comparePriceAsc');
                        } elseif ($sort === 'desc') {
                            usort($products, 'comparePriceDesc');
                        }
                        // Lặp qua các sản phẩm trên trang hiện tại và hiển thị
                        for ($i = $startIndex; $i <= $endIndex && $i < count($products); $i++) {
                        $product = $products[$i];
                        echo '<div class="product">';
                        echo '<div class="image">';
                        echo '<a href="' . $product['hreference'] . '"><img src="' . $product['image'] . '" alt=""></a>';
                        echo '</div>';
                        echo '<div class="product-info">';
                        echo '<h4>' . $product['name'] . '</h4>';
                        echo '<span>' . $product['price'] . '</span>';
                        echo '</div>';
                        echo '<p>Mã SP: ' . $product['code'] . '</p>';
                        echo '<div class="stars">';
                        echo '<i class="fa-solid fa-star"></i>';
                        echo '<i class="fa-solid fa-star"></i>';
                        echo '<i class="fa-solid fa-star"></i>';
                        echo '<i class="fa-solid fa-star"></i>';
                        echo '<i class="fa-regular fa-star"></i>';
                        echo '</div>';
                        echo '<div class="pay">';
                        echo '<form action="save_to_cart.php" method="post">';
                        echo '<input type="hidden" name="name_product" value="' . $product['name'] . '">';
                        echo '<input type="hidden" name="code" value="' . $product['code'] . '">';
                        echo '<input type="hidden" name="price" value="' . $product['price'] . '">';
                        echo '<input type="hidden" name="describe" value="' . $product['describe'] . '">';
                        echo '<input type="hidden" name="quantity" value="' . $product['quantity'] . '">';
                        echo '<button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>';
                        echo '</form>';
                        echo '</div>';
                        echo '</div>';
                    }
                    
                    // Tạo link sắp xếp tăng dần và giảm dần theo giá
                    $currentSort = isset($_GET['sort']) ? $_GET['sort'] : 'asc';
                    $sortAscUrl = '?page=' . $currentPage . '&sort=asc';
                    $sortDescUrl = '?page=' . $currentPage . '&sort=desc';

                    // Hiển thị link sắp xếp
                    echo '<div class="sort-links">';
                    echo '<a href="' . $sortAscUrl . '">GIÁ THẤP ĐẾN CAO</a>';
                    echo '<a href="' . $sortDescUrl . '">GIÁ CAO ĐẾN THẤP</a>';
                    echo '</div>';

                    // Hiển thị phân trang
                    echo '<div class="pagination">';
                    for ($page = 1; $page <= 6; $page++) {
                        echo '<a href="?page=' . $page . '&sort=' . $currentSort . '">' . $page . '</a>';
                    }
                    echo '</div>';
                    ?>
                </div>
            </div>
        </div>
    </div>
    <script src="home.js"></script>
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