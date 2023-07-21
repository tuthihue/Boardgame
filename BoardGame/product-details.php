

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
        <!-- end header -->
        <div>
        <div class="main">
            <div class="page-title">
                <div class="title">
                <p>
                <i class="fa-solid fa-house"></i>
                <a href="/BoardGame/index.php">Trang chủ </a>
                <a href="/BoardGame">/BoardGame</a>
                </p>
                </div>
                </div>
              <div class = "card-wrapper">
                  <div class = "card">
                      <div class="product-imgs">
                        <div class="img-display">
                          <div class = "img-showcase">
                            <img src="" alt="" id="product-image">
                          </div>
                        </div>
                      </div>
                    </div>
                    </div>
                      <div class="product-content">
                      <div>
                          <h2 style="display: inline;">Mã sản phẩm: </h2>
                          <h2 class="product-ID" ></h2>
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
                  </div>
                  <script>
                    window.onload = function() {
                      const urlParams = new URLSearchParams(window.location.search);
                      const productId = urlParams.get('id');
                      const productData = {
                        1: {

                            name: 'Outer Rim',
                            price: '74.999',
                            code: 'BG001',
                            image: 'Sanpham/fantasy-flight-games-star-wars-outer-rim.jpg',
                            hreference: '/BoardGame/product-details.php?id=1',
                            describe: `Bay tới các vì sao và trở thành huyền thoại sống trong Star Wars: Outer Rim, một trò chơi về thợ săn tiền thưởng, lính đánh thuê và buôn lậu dành cho 1-4 người chơi!

Trong Outer Rim, bạn đảm nhận vai trò của một cư dân thế giới ngầm, bắt đầu ghi dấu ấn của mình trên thiên hà. Bạn sẽ du hành vòng ngoài trên con tàu cá nhân của mình, thuê các nhân vật huyền thoại trong Chiến tranh giữa các vì sao tham gia vào phi hành đoàn của mình và cố gắng trở thành kẻ sống ngoài vòng pháp luật nổi tiếng (hoặc khét tiếng) nhất trong thiên hà!

Nhưng sẽ không dễ dàng gì vì các phe phái tham chiến của thiên hà lang thang khắp vành đai bên ngoài, săn lùng những kẻ cặn bã đã được chứng minh là cái gai đối với họ và những kẻ vô lại khác đang tìm cách ghi dấu ấn của chúng, coi bạn là mục tiêu hoàn hảo để hạ bệ. xuống để củng cố danh tiếng của chính họ. Bạn có những gì nó cần để tồn tại ở vành ngoài và trở thành một huyền thoại sống?

Chi tiết hơn, trò chơi Outer Rim diễn ra trong một loạt lượt, trong đó người chơi nhận các công việc nguy hiểm, truy tìm tiền thưởng, nâng cấp tàu của họ, v.v., tất cả đều nhằm mục đích đạt được ngày càng nhiều danh tiếng. Bất kể bạn đi theo con đường nào để đến đó, mục tiêu của bạn là đạt được mười danh tiếng, có thể đến từ nhiều nguồn khác nhau, chẳng hạn như hoàn thành mục tiêu cá nhân của nhân vật, thu thập tiền thưởng và công việc, vận chuyển hàng hóa bất hợp pháp, hạ gục các đội tuần tra từ các phe phái khác nhau đang tranh giành thiên hà và tận hưởng những điều tốt đẹp hơn trong cuộc sống bằng cách mua những món đồ xa xỉ bằng các khoản tín dụng khó kiếm được của bạn.

Mặc dù con đường dẫn đến chiến thắng có thể khác đối với những kẻ vô lại đang tìm đường đến Vòng ngoài, nhưng mọi người đều bắt đầu từ dưới lên với một phi thuyền đơn giản. Bảng người chơi của bạn không chỉ theo dõi tiến trình nổi tiếng của bạn mà còn chứa các vị trí dành cho tàu, thẻ nhân vật, thiết bị, danh tiếng, sửa đổi, công việc và tiền thưởng của bạn.`
                    },

                2: {
                        name: 'Not That Movie',
                        price: '24.999',
                        code: 'BG002',
                        image: 'Sanpham/pic6961520.webp',
                        hreference: '/BoardGame/product-details.php?id=2',
                        describe: `Pizza, đi văng và bạn bè: bạn chỉ cần một bộ phim hay! Như mọi khi, bạn không thể quyết định xem cái nào cùng nhau. Dựa vào các bài đánh giá, tưởng tượng cốt truyện phim và chọn tiêu đề hoàn hảo! Bạn sẽ thảo luận cả đêm hay đi đến một thỏa thuận?

Trong trò chơi nhóm hợp tác Not That Movie! bạn phải chọn phim trong danh sách các tựa phim kỳ lạ — nhưng đây có thể là một quyết định khó khăn nếu bạn chỉ biết một vài bài đánh giá ngắn!

Chi tiết hơn, người chơi phải chọn một bộ phim cho một "đêm phim" cùng bạn bè. Tiêu đề nào phù hợp nhất với thẻ đánh giá? Người chơi có thể chọn phim từ danh sách tám tựa phim "bị hỏng" bao gồm hai tựa phim trộn lẫn với nhau. Kết quả của những sự kết hợp này có thể rất xuất sắc, kỳ lạ và thậm chí kỳ lạ: bảo đảm sẽ có tiếng cười!

Sau khi bí mật chọn, người chơi lần lượt đặt mã thông báo "Không" gần tiêu đề mà họ cho rằng không có ai chọn. Mỗi mã thông báo được đặt đúng sẽ ghi được một điểm và bạn có một lỗi miễn phí mỗi vòng. Nếu bạn không phạm sai lầm, bạn sẽ ghi được điểm thưởng. Bạn chơi năm vòng và cố gắng đánh bại số điểm trước đó của mình và ghi tên mình vào bảng điểm. Bạn có bao giờ đạt được tối đa 40 điểm, với số lượng người chơi khác nhau không?

Chơi với hơn 25.000 tựa phim chưa ai từng xem!

(Lưu ý: Thiết kế này ban đầu được công bố là Movie Night nhưng trong quá trình phát triển, biến thể hợp tác của trò chơi đã được hoàn thiện để trở thành phiên bản chính thức duy nhất.)`
                    },

                3: {
                        name: 'Best of Werewolves of Millers Hollow',
                        price: '21.999',
                        code: 'BG003',
                        image: 'Sanpham/zygomatic-best-of-werewolves-of-millers-hollow_2.png',
                        hreference: '/BoardGame/product-details.php?id=3',
                        describe: `Để tôn vinh Người sói ở Thung lũng Miller và di sản đáng sợ của nó, các nhà thiết kế ban đầu đã quyết định kết hợp tất cả các nhân vật yêu thích của họ và mang đến cho bạn. Với các nhân vật được lấy từ tất cả các bản mở rộng — Trăng non, Nhân vật, Hiệp ước — và đặt trong một hộp, giờ đây, việc kết hợp một trò chơi đáng sợ với Best of Werewolves của Miller's Hollow trở nên dễ dàng hơn bao giờ hết.`
                    },

                4: {
                        name: 'Dixit: Odyssey Expansion',
                        price: '34.99',
                        code: 'BG004',
                        image: 'Sanpham/lucky-duck-games-nimalia.webp',
                        hreference: '/BoardGame/product-details.php?id=4',
                        describe: `Dixit Odyssey là bản mở rộng (Dixit: Odyssey (expansion)) cho Dixit của Jean-Louis Roubira, đã giành giải Spiel des Jahres của Đức năm 2010.

Cách chơi trong Dixit Odyssey khớp với cách chơi của Dixit: Mỗi lượt một người chơi là người kể chuyện. Người chơi này bí mật chọn một lá bài trên tay, sau đó đưa ra một từ hoặc câu để mô tả lá bài này—nhưng không quá rõ ràng. Mỗi người chơi khác chọn một thẻ trên tay khớp với từ/câu này và đưa thẻ đó cho người kể chuyện. Sau đó, người kể chuyện sẽ phát các thẻ và tất cả những người chơi khác sẽ bỏ phiếu xem thẻ nào thuộc về người kể chuyện. Nếu không ai hoặc tất cả mọi người đoán thẻ của người kể chuyện, thì người kể chuyện không nhận được điểm và tất cả người chơi nhận được hai điểm; mặt khác, người kể chuyện và (những) người đoán đúng, mỗi người nhận được ba điểm. Người chơi ghi được một điểm cho mỗi phiếu bầu mà hình ảnh của họ nhận được. Người chơi nạp tiền vào tay và người chơi tiếp theo trở thành người kể chuyện. Khi bộ bài hết, người chơi có nhiều điểm nhất sẽ thắng.

Dixit Odyssey chứa 84 thẻ mới, mỗi thẻ có một hình ảnh độc đáo do Piero vẽ và được tô màu bởi Marie Cardouat, nghệ sĩ của Dixit và Dixit 2. Phiên bản độc lập cũng bao gồm một bảng trò chơi gấp, 6 mã thông báo ghi điểm thỏ mới (tổng cộng 12) và một hộp đủ lớn để chứa tất cả các thẻ Dixit đã phát hành cho đến nay. Phiên bản độc lập của Dixit Odyssey bao gồm đủ các thành phần cho tối đa 12 người chơi và cũng có các quy tắc biến thể để chơi theo nhóm và các cách mới để chơi với các thẻ.`
                    },

                5: {
                        name: 'Skull',
                        price: '24.99',
                        code: 'BG005',
                        image: 'Sanpham/space-cowboys-skull.jpg',
                        hreference: '/BoardGame/product-details.php?id=5',
                        describe: `Một trò chơi cổ xưa gồm những chiếc đầu lâu được trang trí công phu và những bông hồng nguy hiểm, Skull rất dễ học nhưng rất khó để giành chiến thắng. Bạn phải bịp bợm, nói dối và xuyên thủng những trò lừa bịp để vạch trần những bông hồng. Tuy nhiên, hãy cảnh giác - nếu bạn tình cờ gặp một hộp sọ, hậu quả sẽ rất thảm khốc! Người chơi sẽ giữ ba thẻ hoa hồng và một đầu lâu. Thêm một thẻ vào đống trước mặt bạn và khi bạn cảm thấy may mắn, hãy thông báo thử thách của bạn và tuyên bố bạn sẽ lật được bao nhiêu thẻ. Các quân bài có hình hoa hồng là an toàn, nhưng nếu bạn để lộ hộp sọ ẩn của đối thủ, bạn sẽ mất một quân bài của chính mình. Giữ quân bài của bạn đến cùng để giành chiến thắng trong trò chơi đánh lừa và nhận thức thông minh này!`
                    },

                6: {
                        name: 'The Werewolves of Millers Hollow: The Pact',
                        price: '49.99',
                        code: 'BG006',
                        image: 'Sanpham/zygomatic-the-werewolves-of-millers-hollow-the-pac.jpg',
                        hreference: '/BoardGame/product-details.php?id=6',
                        describe: `The Werewolves of Miller's Hollow: The Pact bao gồm trò chơi cơ bản The Werewolves of Miller's Hollow cũng như ba bản mở rộng hiện có cho trò chơi đó kể từ năm 2014: New Moon, Characters và The Village.`
                    },

                7: {
                        name: 'Squid Game',
                        price: '29.990 ',
                        code: 'BG007',
                        image: 'Sanpham/mixlore-squid-game.jpg',
                        hreference: '/BoardGame/product-details.php?id=7',
                        describe: `Ai sống sót trong trò chơi Mực? Trò chơi tiệc tùng thú vị này dựa trên loạt phim cùng tên của Netflix. Với đội cá nhân của bạn, bạn phải cạnh tranh với các đội của đối thủ. Thông qua các chiến thuật vô tội vạ, may mắn nhưng cũng khó khăn, bạn phải sống sót qua sáu trò chơi bài dựa trên các vòng đấu chết người trong sê-ri. Ai đứng cuối cùng ở cuối sẽ thắng Trò chơi mực!`
                    },

                8: {
                        name: 'HeroQuest: The Mage of the Mirror',
                        price: '49.99',
                        code: 'BG008',
                        image: 'Sanpham/hasbro-heroquest-the-mage-of-the-mirror.jpg',
                        hreference: '/BoardGame/product-details.php?id=8',
                        describe: `Cuộc phiêu lưu này chứng kiến những rắc rối đang diễn ra ở vương quốc yêu tinh, và một yêu tinh dũng cảm trước tiên phải vượt qua các nhiệm vụ một mình nguy hiểm trước khi gia nhập lại nhóm của họ để đối đầu với pháp sư ma quỷ, Sinestra.

Mage of the Mirror bao gồm một Sách nhiệm vụ gồm 10 nhiệm vụ, 33 mô hình thu nhỏ chi tiết tinh xảo và 35 thẻ trò chơi sẽ mở rộng trò chơi cho cả Zargon và các anh hùng.`
                    },

                9: {
                        name: 'Marvel United: Guardians of the Galaxy Remix',
                        price: '34.99',
                        code: 'BG009',
                        image: 'Sanpham/cmon-marvel-united-guardians-of-the-galaxy-remix.jpg',
                        hreference: '/BoardGame/product-details.php?id=9',
                        describe: `Những người bảo vệ thiên hà đã tạo nên tên tuổi của họ khi du hành các vì sao, đấu tranh cho những người bất lực, sửa sai và đôi khi sai một vài quyền. Nhưng nhìn chung, những việc làm tốt của họ lấn át những điều xấu, và Ronan the Accuser đã chịu đủ rồi! Những Người bảo vệ đã can thiệp vào người của Ronan, người Kree, trong cuộc chiến chính nghĩa tự xưng của họ lần cuối cùng!

Ronan được xếp vào hàng những nhân vật phản diện ghê gớm nhất mà các Vệ binh từng đối mặt, và kế hoạch tổng thể của anh ta đơn giản nhất có thể: chấm dứt vĩnh viễn các Vệ binh. Trong trận chiến cá nhân, ngay cả bộ ba Star-Lord, Rocket Raccoon và Groot cũng có rất ít cơ hội chống lại The Accuser đang sử dụng Universal Weapon thần thánh của mình. Họ phải tranh giành con đường của mình từ ngôi sao này sang ngôi sao khác, giúp đỡ mọi nơi có thể và ngăn chặn tay sai của Ronan bất cứ khi nào có thể.

Không có nơi nào an toàn cho những Người bảo vệ chừng nào Ronan còn theo dõi dấu vết của họ. Hy vọng duy nhất của họ là tập hợp đủ sức mạnh để cuối cùng đánh bại Ronan, hoặc làm thất bại kế hoạch của anh ta đủ lâu để từ bỏ cuộc săn lùng. Dù bằng cách nào, Guardians of the Galaxy đang chạy đua với thời gian!`
                    },

                10: {
                        name: 'Masters of the Universe: The Board Game - Clash For Eternia',
                        price: '109.99',
                        code: 'BG010',
                        image: 'Sanpham/cmon-masters-of-the-universe-the-board-game-clash.jpg',
                        hreference: '/BoardGame/product-details.php?id=10',
                        describe: `Masters of the Universe: The Board Game - Clash for Eternia là một trò chơi mang tính cạnh tranh so với nhiều người hoặc trò chơi trên bàn dựa trên hành động hợp tác hoàn toàn. Chọn chơi với tư cách là Chiến binh Anh hùng hoặc Ác ma, sử dụng các khả năng độc đáo trên chiến trường, nâng cấp kỹ năng và bằng sức mạnh của Grayskull, giành chiến thắng trong cuộc chiến vì Eternia!`
                    },

                11: {
                        name: 'Beast',
                        price: '69.99',
                        code: 'BG011',
                        image: 'Sanpham/pegasus-spiele-beast.jpg',
                        hreference: '/BoardGame/product-details.php?id=11',
                        describe: `Chào mừng bạn đến với Northern Expanse, một nơi mà thiên nhiên vẫn chưa được khám phá, huyền bí và nguy hiểm. Khi con người lần đầu tiên đến, họ nghĩ rằng họ đã tìm thấy một thiên đường hoang sơ, tràn ngập những khu rừng bội thu, những hồ cá bơi lội và nước ngọt lạnh chảy từ núi. Nhưng khi các khu định cư của họ mở rộng và các khu rừng xung quanh ngày càng thưa thớt, thì chính thiên nhiên đã bị đẩy lùi. Những sinh vật vĩ đại được gọi là Quái thú xuất hiện, và với răng nanh, móng vuốt và sức mạnh thần bí, chúng đã chứng tỏ là một mối đe dọa đáng kinh ngạc đối với loài người. Để bảo vệ các khu định cư, con người đã chiêu mộ những thợ săn chuyên biệt, được giao nhiệm vụ theo dõi và tiêu diệt Quái thú trước khi quá nhiều đồng loại của chúng bị diệt vong.

Quái thú sử dụng một bộ bài định hướng để di chuyển qua các khu rừng, đầm lầy và hang động, sử dụng mưu mẹo và sự lừa dối để che giấu dấu vết của nó khỏi những người thợ săn. Tuy nhiên, bất cứ khi nào thợ săn di chuyển qua vị trí mà Quái thú đã ở trước đó, một dấu vết sẽ xuất hiện. Chỉ khi một thợ săn tìm kiếm một địa điểm hoặc chính Quái thú tấn công một mục tiêu không ngờ tới thì vị trí thực sự của Quái thú mới được tiết lộ. Hơn nữa, mỗi thợ săn chỉ có một cơ hội tìm kiếm mỗi vòng, khiến nó trở thành một quyết định căng thẳng và khó khăn. Các thợ săn hiếm khi có đầy đủ thông tin liệu con đường mà họ đang theo đuổi có chứa vị trí thực tế của Quái thú hay con đường đó đã nguội lạnh.

Mỗi hành động bạn thực hiện trong trò chơi này được thực hiện bằng cách đánh một lá bài từ tay của bạn (tối đa hai lá bài mỗi lượt). Điều này có nghĩa là nếu người chơi muốn tìm kiếm, tấn công hoặc di chuyển, họ cần phải có một lá bài trên tay cho phép họ làm điều đó. Trước mỗi vòng, cả thợ săn và Quái thú đều tham gia thảo luận để tìm những quân bài quan trọng nhất. Tất cả các thẻ hành động đều có thể được sử dụng bởi cả Beast và thợ săn.

Để chiến thắng trò chơi này, bạn cần phải phối hợp ăn ý trong từng bước nếu vào vai thợ săn, hoặc khéo léo vượt qua đối thủ nếu vào vai Beast. Về bản thân, thợ săn không bao giờ mạnh hơn Quái thú. Chỉ khi những người thợ săn giao tiếp, lập chiến lược và kết hợp hành động, họ mới có thể hạ gục Beast trước khi quá muộn.`
                    },

                12: {
                        name: 'Arkham Horror: Final Hour',
                        price: '39.99',
                        code: 'BG012',
                        image: 'Sanpham/fantasy-flight-games-arkham-horror-final-hour.jpg',
                        hreference: '/BoardGame/product-details.php?id=12',
                        describe: `Bạn đến quá muộn để ngăn chặn nghi thức ghê tởm, và một Ancient One quái dị, xuyên không gian xuyên qua thực tại. Một vết nứt óng ánh rạch ngang bầu trời tối đen, báo trước những sinh vật ác mộng tràn vào các tòa nhà thần thánh của Đại học Miskatonic. Khi những tiếng hú và la hét xuyên suốt màn đêm, chỉ còn một con đường duy nhất cho những điều tra viên gan dạ của bạn—hãy kìm hãm đám đông đủ lâu để bằng cách nào đó đảo ngược lệnh triệu tập.

Arkham Horror: Final Hour là một trò chơi hội đồng có nhịp độ nhanh, hoàn toàn hợp tác dành cho một đến bốn người chơi. Một làn sóng quái vật vô tận quét qua khuôn viên Đại học Miskatonic, và bạn phải kìm hãm chúng lại, đồng thời tìm kiếm các thành phần nghi lễ mà bạn cần để chấm dứt sự điên rồ này một cách tuyệt vọng. Có thể chơi trong vòng chưa đầy 60 phút, số phận của bạn phụ thuộc vào sự hợp tác giữa bạn và các điều tra viên đồng nghiệp. Tỷ lệ cược chống lại bạn là rất lớn, nhưng nếu bạn không thành công, đây thực sự sẽ là giờ cuối cùng của Arkham...và thế giới.`
                    },

                13: {
                        name: 'Legacy of Yu',
                        price: '59.99',
                        code: 'BG013',
                        image: 'Sanpham/renegade-game-studios-legacy-of-yu-1.webp',
                        hreference: '/BoardGame/product-details.php?id=13',
                        describe: `Legacy of Yu là trò chơi chiến dịch phi tuyến tính, hoàn toàn có thể thiết lập lại, chỉ chơi một mình, trong đó bạn nhập vai người anh hùng huyền thoại của triều đại nhà Hạ, Yu Đại đế. Công việc của bạn là xây dựng các kênh đào trước trận lụt sắp xảy ra, đồng thời bảo vệ ngôi làng đang phát triển của mình trước các bộ lạc man rợ lân cận. Với mỗi trò chơi, những câu chuyện sẽ được chia sẻ và các yếu tố chơi trò chơi mới được thêm vào. Chiến dịch có một hệ thống tự cân bằng thích ứng với mức độ bạn đang làm. Chiến dịch kết thúc khi bạn thắng hoặc thua bảy ván.`
                    },

                14: {
                        name: 'Earth',
                        price: '49.99',
                        code: 'BG014',
                        image: 'Sanpham/inside-up-games-earth.jpg',
                        hreference: '/BoardGame/product-details.php?id=14',
                        describe: `Trải qua hàng triệu năm tiến hóa và thích nghi, hệ thực vật và động vật của hành tinh độc đáo này đã phát triển và phát triển thành những dạng sống tuyệt vời, tạo nên hệ sinh thái cộng sinh tuyệt đẹp và môi trường sống đa dạng. Đã đến lúc tạo hòn đảo của bạn: một hoạt cảnh 4x4 về tăng trưởng, mở rộng và cung cấp tự hỗ trợ, trong đó ngay cả những thẻ bạn không cần cũng trở thành phân trộn để đạt được trong tương lai. Earth là một công cụ xây dựng thế giới mở dành cho 1 đến 5 người chơi với các quy tắc đơn giản nhưng nhiều khả năng chiến lược.`
                    },

                15: {
                        name: 'My Fathers Work',
                        price: '124.99',
                        code: 'BG015',
                        image: 'Sanpham/renegade-game-studios-my-fathers-work-1.png',
                        hreference: '/BoardGame/product-details.php?id=15',
                        describe: `Trong My Father's Work, 2-4 người chơi đóng vai các nhà khoa học điên cạnh tranh nhau được giao một trang trong nhật ký của cha họ, cùng với một khu đất rộng lớn để thực hiện các thí nghiệm quỷ quyệt của họ. Người chơi kiếm điểm bằng cách hoàn thành Thử nghiệm, hỗ trợ Thị trấn trong nỗ lực của mình và hy vọng hoàn thành Công việc của Cha họ trong trò chơi tường thuật phân nhánh dựa trên ứng dụng này.`
                    },

                16: {
                        name: 'Twilight Imperium: Prophecy of Kings',
                        price: '99.95',
                        code: 'BG016',
                        image: 'Sanpham/fantasy-flight-games-twilight-imperium-prophecy-of.webp',
                        hreference: '/BoardGame/product-details.php?id=16',
                        describe: `Lần đầu tiên sau nhiều năm, một lượng lớn nội dung mới đến với Twilight Imperium với bản mở rộng Prophecy of Kings, mang đến nội dung bổ sung cho gần như mọi phần của trò chơi. Hai người chơi bổ sung hiện có thể tham gia cuộc chiến thiên hà, nâng tổng số người chơi lên tám người. Với bảy phe phái chưa từng thấy và 40 hệ thống mới và các ô siêu tuyến, có nhiều thứ để chiến đấu hơn bao giờ hết.

Các phe phái hiện có của trò chơi cũng có nhiều lợi ích từ Lời tiên tri của các vị vua với việc giới thiệu 74 thủ lĩnh và các đơn vị cơ giáp mới. Tiền giấy mới, di tích, thẻ khám phá, thẻ hành động, thẻ chương trình nghị sự, thẻ mục tiêu, v.v. khiến đây trở thành bản mở rộng không thể bỏ qua đối với bất kỳ người chơi Twilight Imperium nào.`
                    },

                17: {
                        name: 'Abomination: The Heir of Frankenstein',
                        price: '64.99',
                        code: 'BG017',
                        image: 'Sanpham/plaid-hat-games-abomination-the-heir-of-frankenste.jpg',
                        hreference: '/BoardGame/product-details.php?id=17',
                        describe: `Đã hai mươi năm kể từ khi Victor Frankenstein chết trên một con tàu ở Bắc Cực, nhưng sinh vật đầy thù hận của anh ta vẫn sống, Robert Walton, thuyền trưởng hàng hải đã thề sẽ giết chết tên ác quỷ trước khi nhân từ buông tay. Bây giờ là năm 1819, và một bóng tối nham hiểm giáng xuống thành phố Paris. Một nhà hảo tâm bí ẩn có tầm vóc khổng lồ đã xuất hiện trong cộng đồng khoa học, không bao giờ lộ mặt, tuyên bố sở hữu nghiên cứu của Frankenstein quá cố. Anh ấy tài trợ cho một cuộc thi lớn, trao giải thưởng còn lớn hơn: giải mã bí ẩn về cái chết!

Các nhà khoa học nổi tiếng từ khắp nơi trên thế giới đến tham gia: một số được yêu cầu giải câu đố muôn thuở này, những người khác bị ép buộc chống lại ý muốn của họ. Nhưng một thuyền trưởng nào đó cũng đến, một người hết sức nghi ngờ người bảo trợ bí mật, hy vọng cuối cùng sẽ thực hiện được lời thề của mình.

Abomination: The Heir of Frankenstein là một trò chơi cạnh tranh xây dựng quái vật chiến lược dành cho 2-4 người chơi, lấy cảm hứng từ cuốn tiểu thuyết kinh dị kinh dị kiểu gothic của Mary Shelley. Trong trò chơi, sinh vật này cần sự giúp đỡ của bạn để hoàn thành điều mà người tạo ra nó không làm: mang đến sự sống cho một kẻ gớm ghiếc như chính nó, một người bạn đồng hành để chấm dứt sự cô độc khốn khổ của nó. Thông qua việc bố trí công nhân và quản lý cẩn thận các tài nguyên phân hủy, bạn sẽ thu thập tài liệu từ các nghĩa trang và nhà xác quanh thành phố, tiến hành nghiên cứu có giá trị tại Học viện Khoa học, thuê những cộng sự kém uy tín và làm việc cực nhọc trong phòng thí nghiệm của mình — tất cả chỉ trong một nỗ lực để tập hợp một dạng sống mới và truyền cho nó một "tia sáng của sự tồn tại". Làm tốt và sinh vật có thể thưởng cho bạn trong một trong những chuyến thăm bất ngờ của nó; làm kém, và bạn có thể hối hận vì đã không nỗ lực nhiều hơn. Các yếu tố tường thuật phát huy tác dụng trong suốt trò chơi, được hướng dẫn bởi các quyết định của bạn, dẫn đến những kết quả không mấy tốt đẹp.

Trò chơi kết thúc khi bạn thành công trong việc đưa tác phẩm của mình vào cuộc sống hoặc khi Thuyền trưởng giết chết sinh vật đó, tùy theo điều kiện nào xảy ra trước. Sau đó, người chơi có nhiều điểm nhất sẽ hoàn thành di sản đen tối của Frankenstein, trở thành người thừa kế của ông ta, dù tốt hay xấu...`
                    },

                18: {
                        name: 'Mille Fiori',
                        price: '49.99',
                        code: 'BG018',
                        image: 'Sanpham/devir-americas-mille-fiori.jpg',
                        hreference: '/BoardGame/product-details.php?id=18',
                        describe: `Giúp làm nên lịch sử, chế tạo đồ thủy tinh, buôn bán và đảm bảo sự hỗ trợ của cư dân vùng đầm phá. Tìm hiểu những bí mật của việc chế tạo thủy tinh và tìm ra sự kết hợp thành công nhất giữa chiến lược và chiến thuật để làm nên vận may của bạn với tư cách là nhà sản xuất thủy tinh nổi tiếng nhất của vùng đầm phá.`
                    },

                19: {
                        name: 'Transformers Deck-Building Game',
                        price: '44.99',
                        code: 'BG019',
                        image: 'Sanpham/renegade-game-studios-transformers-deck-building-g-1.webp',
                        hreference: '/BoardGame/product-details.php?id=19',
                        describe: `Chuyển đổi và triển khai!

Autobots là những chiến binh robot dũng cảm đến từ hành tinh Cybertron. Nhiệm vụ của họ? Để ngăn chặn Decepticons thực hiện các âm mưu xấu xa của chúng trên Trái đất.

Trong trò chơi xây dựng boong tàu này, bạn sẽ đảm nhận vai trò của một trong những Autobot hùng mạnh. Du hành và khám phá Ma trận và chuyển đổi giữa các chế độ khác nhau của bạn khi bạn có được đồng minh, tìm di tích và có được công nghệ để chiến đấu với Decepticons. Nhưng được cảnh báo! Khi bộ bài của bạn phát triển, các Decepticons mạnh hơn sẽ xuất hiện để thách thức bạn.

Trò chơi Xây dựng Bộ bài Transformers có thể được chơi một cách cạnh tranh hoặc dưới dạng một trải nghiệm hợp tác. Bộ lõi này sẽ bắt đầu bộ sưu tập của bạn với mọi thứ cần thiết để chơi, nhưng trận chiến còn lâu mới kết thúc vì Decepticons có thể chơi được đang trên đường mở rộng trò chơi của bạn.`
                    },

                20: {
                        name: 'Epic Spell Wars of the Battle Wizards: Rumble at Castle Tentakill',
                        price: '34.99',
                        code: 'BG020',
                        image: 'Sanpham/cryptozoic-entertainment-epic-spell-wars-of-the-ba.webp',
                        hreference: '/BoardGame/product-details.php?id=20',
                        describe: `Kẻ ngủ quên đã thức tỉnh! Epic Spell Wars of the Battle Wizards: Rumble at Castle Tentakill cuối cùng đã xuất hiện và nó chứa đầy những cách hoàn toàn mới để mang đến cái chết như khói cho tất cả những kẻ chống lại bạn. Trò chơi độc lập này cũng tương thích 100% với trò chơi gốc, cho phép người chơi biến một trò chơi vốn đã hoành tráng thành một trò chơi EPIC. Epic Spell Wars tiếp tục nhiệm vụ hoành tráng của nó sau khi phát sóng trên TableTop trên Geek and Sundry! Với thiết kế trò chơi và nghệ thuật hoàn toàn mới từ nhóm sáng tạo ban đầu gồm Cory Jones, Rob Heinsoo và Nick Edwards.`
                    },

                21: {
                        name: 'G.I. JOE Deck-Building Game',
                        price: '45',
                        code: 'BG021',
                        image: 'Sanpham/renegade-game-studios-gi-joe-deck-building-game.jpg',
                        hreference: '/BoardGame/product-details.php?id=21',
                        describe: `Rơi vào! Tổ chức độc ác Cobra đe dọa thế giới bằng những âm mưu của chúng và bạn phải ngăn chặn chúng!

Trong trò chơi Xây dựng boong tàu này, bạn và những người chơi khác sẽ lãnh đạo các đội G.I. Những người lính Joe làm nhiệm vụ ngăn chặn kế hoạch đê tiện của Cobra! Mỗi người chơi bắt đầu trò chơi với một bộ bài ít ỏi sẽ trở nên mạnh mẽ hơn khi bạn chiêu mộ các cựu chiến binh từ G.I. Đội Joe, thiết bị trưng dụng và phương tiện mới. Trò chơi hợp tác hoàn toàn này giúp bạn chống lại các nhiệm vụ ngày càng nguy hiểm để cứu thế giới. Bộ cốt lõi này bắt đầu hành trình của bạn với mọi thứ cần thiết để chơi, nhưng hãy chuẩn bị cho nhiều Joes và nhiệm vụ sắp tới!`
                    },

                22: {
                        name: 'AGOT LCG 2nd Ed: For Family Honor',
                        price: '14.99',
                        code: 'BG022',
                        image: 'Sanpham/fantasy-flight-games-agot-lcg-2nd-ed-for-family-ho.png',
                        hreference: '/BoardGame/product-details.php?id=22',
                        describe: `Vì danh dự gia đình là Gói chương thứ hai trong chu kỳ Cuộc chiến năm vị vua cho A Game of Thrones: The Card Game. Xuyên suốt Gói Chương này, bạn sẽ tìm thấy rất nhiều thẻ bài mới hỗ trợ các chủ đề chính của chu kỳ khi bạn tiếp tục theo dõi cốt truyện của A Clash of Kings. New Kings and Crowns mời bạn đặt cược yêu sách của riêng bạn đối với Iron Throne, ngay cả khi các lá bài khác nâng cao tầm quan trọng của các lá bài trung thành—những nhân vật mà bạn có thể thực sự tin tưởng, những địa điểm sẽ không bao giờ thất thủ, những sự kiện và chiến thuật mà bạn hoàn toàn kiểm soát. Cuối cùng, For Family Honor giới thiệu các nhân vật mang tính biểu tượng tham gia trò chơi, bao gồm Ser Edmure Tully, phiên bản House Tyrell của Renly Baratheon và Hot Pie.`
                    },

                23: {
                        name: 'Arkham Horror: The Card Game - Fortune and Folly Scenario Pack',
                        price: '24.99',
                        code: 'BG023',
                        image: 'Sanpham/fantasy-flight-games-arkham-horror-the-card-game-f.jpg',
                        hreference: '/BoardGame/product-details.php?id=23',
                        describe: `Một sòng bạc ở Monte Carlo đang vận may theo hướng có lợi cho mình, thu được khối tài sản khổng lồ nhưng cũng gây nguy hiểm cho những khách hàng quen của nó. Bạn và các điều tra viên đồng nghiệp của mình phải đánh cắp nguồn sức mạnh của sòng bạc và ngăn chặn công việc bất chính của họ, nhưng làm như vậy sẽ không phải là nhiệm vụ dễ dàng. Vận may sẽ ủng hộ những người táo bạo? Hay may mắn của bạn sẽ hết?

Trong Fortune and Folly, một đến bốn điều tra viên lên kế hoạch và thực hiện một vụ trộm sòng bạc táo bạo. Mục tiêu của họ: Wellspring of Fortune, một di tích bí ẩn cho phép sòng bạc sắp xếp các tỷ lệ cược có lợi cho nó (theo nghĩa đen). Là một gói kịch bản, Fortune and Folly có thể được chơi độc lập hoặc được đưa vào chiến dịch dưới dạng câu chuyện phụ. Nó thậm chí còn có một vài tính năng bổ sung nếu được sử dụng như một câu chuyện phụ trong chiến dịch The Scarlet Keys!

Người chơi chỉ cần một bản sao của Arkham Horror: The Card Game Revised Core Set để đi sâu vào kịch bản. Kiểm tra vận may của bạn và xem vận may có ủng hộ bạn không nhé!`
                    },

                24: {
                        name: 'Marvel Champions LCG: Scarlet Witch Hero Pack',
                        price: '19.99',
                        code: 'BG024',
                        image: 'Sanpham/fantasy-flight-games-marvel-champions-lcg-scarlet.jpg',
                        hreference: '/BoardGame/product-details.php?id=24',
                        describe: `Lạc lối và lang thang khắp châu Âu trong nhiều năm cùng anh trai Pietro, Wanda Maximoff không biết nhiều về sức mạnh bí ẩn được trao cho mình—cho đến khi cô giải phóng phép thuật hỗn loạn làm biến dạng thực tại của mình để bảo vệ những người vô tội. Bây giờ trong lốt Scarlet Witch, Wanda đã gia nhập Avengers, chiến đấu bên cạnh anh trai mình!

Giống như các Gói Anh hùng trước đây, Gói Anh hùng Scarlet Witch dành cho Marvel Champions: The Card Game mở ra một anh hùng hoàn toàn mới cho các trò chơi của bạn, đi kèm với bộ bài Công lý 40 lá được xây dựng sẵn và sẵn sàng để chơi. Bên cạnh bộ bài tạo sẵn này, bạn sẽ tìm thấy nhiều loại thẻ dành cho các khía cạnh khác của trò chơi, cung cấp cho bạn nhiều tùy chọn để điều chỉnh bộ bài Scarlet Witch hoặc thay đổi bất kỳ bộ bài nào khác trong bộ sưu tập của bạn. Chuẩn bị cho thực tế xoắn và uốn cong xung quanh bạn với Hero Pack mới này!`
                    },

                25: {
                        name: 'Marvel Champions LCG: Vision Hero Pack',
                        price: '19.99',
                        code: 'BG025',
                        image: 'Sanpham/fantasy-flight-games-marvel-champions-lcg-vision-h.jpg',
                        hreference: '/BoardGame/product-details.php?id=25',
                        describe: `Là người máy cuối cùng, Vision bay vào Marvel Champions trong gói mở rộng này, giới thiệu anh ta như một anh hùng hoàn toàn mới, cùng với 15 thẻ chữ ký của anh ta. Vision được đóng gói với bộ bài Bảo vệ dựng sẵn sẵn sàng chơi ngay từ khi bạn mở hộp. Lối chơi của anh ấy xoay quanh cơ chế điều khiển mật độ độc đáo của anh ấy, điều này khiến anh ấy trở thành một anh hùng chiến lược với độ bền ấn tượng.`
                    },

                26: {
                        name: 'Marvel Champions: Rogue Hero Pack',
                        price: '19.99',
                        code: 'BG026',
                        image: 'Sanpham/fantasy-flight-games-marvel-champions-rogue-hero-p.webp',
                        hreference: '/BoardGame/product-details.php?id=26',
                        describe: `Bị nguyền rủa với khả năng không thể kiểm soát khiến cô hấp thụ sức mạnh và ký ức của bất kỳ ai cô chạm vào, Anna Marie bỏ nhà đi khi còn là một thiếu niên. Giáo sư X đã đề nghị cho cô một suất tại trường của ông, nơi cô có thể học cách kiểm soát sức mạnh của mình. Bây giờ cô ấy chiến đấu vì công lý với tư cách là một thành viên của X-Men, Rogue, và cô ấy đang lẻn vào các trò chơi Marvel Champions: The Card Game của bạn! Bằng cách gắn bản nâng cấp Touched độc đáo của mình với các nhân vật khác, Rogue có thể nhận được nhiều loại khả năng, bao gồm cả việc mượn sức mạnh từ các anh hùng đồng nghiệp của mình. Với Gói anh hùng này, bạn sẽ tìm thấy Rogue, mười sáu thẻ chữ ký của cô ấy và đủ loại thẻ Bảo vệ mời bạn bảo vệ đồng minh của mình khỏi bị tổn hại. Gói này cũng bao gồm một bộ cuộc gặp gỡ mô-đun bổ sung có Reavers được tăng cường điều khiển học!

Đối với những người chơi muốn thách đấu với Magneto và Brotherhood of Mutants của anh ta, họ có thể bắt đầu với Rogue Hero Pack! Bản mở rộng này đi kèm với bộ bài dựng sẵn gồm 40 quân bài, giúp người chơi có cơ hội bắt đầu chơi ngay lập tức`
                    },

                27: {
                        name: 'Carcassonne Exp 6: Count, King & Robber',
                        price: '21.99',
                        code: 'BG027',
                        image: 'Sanpham/z-man-games-carcassonne-exp-6-count-king-robber-1.jpg',
                        hreference: '/BoardGame/product-details.php?id=27',
                        describe: `Bản mở rộng lớn thứ sáu cho Carcassonne được phát hành ở Châu Âu bởi Hans im Glück thực sự là một bản tổng hợp của ba bản mở rộng nhỏ hiện có và một bản mở rộng mới. Trước khi Z-Man Games lấy giấy phép Carcassonne, phần tổng hợp này chỉ có sẵn ở Hoa Kỳ từ Rio Grande Games như một phần của Big Box 2 hoặc từng bản mở rộng nhỏ có sẵn riêng lẻ.`
                    },

                28: {
                        name: 'D&D: Bedlam in Neverwinter',
                        price: '49.99',
                        code: 'BG028',
                        image: 'Sanpham/hasbro-d-d-bedlam-in-neverwinter.jpg',
                        hreference: '/BoardGame/product-details.php?id=28',
                        describe: `Tham gia cùng một nhóm các nhà thám hiểm điều tra hàng loạt vụ mất tích đáng báo động ở Icewind Dale trong trò chơi giải thoát D&D một lần dành cho 2-6 người chơi này.

Cuộc phiêu lưu gồm 3 phần khó khăn này có thể được chia thành 3 phiên trò chơi hoặc chơi trong 1 lần ngồi anh hùng. Bắt đầu bằng cách tạo nhân vật của bạn. Sau đó khám phá một quán rượu khiêm tốn, chiến đấu trong những trận chiến hoành tráng chống lại những con quái vật D&D mang tính biểu tượng, và tham gia vào một cuộc rượt đuổi hoang dã xuyên qua Underdark theo đuôi của một pháp sư độc ác và giáo phái nguy hiểm của hắn để làm sáng tỏ bí ẩn về kế hoạch tồi tệ của chúng.

Cách duy nhất để tìm những người mất tích và thoát khỏi các chướng ngại vật là khám phá các căn phòng, hoàn thành các câu đố và thu thập manh mối để giải quyết bí ẩn ở cuối mỗi hành động.`
                    },

                29: {
                        name: 'Nimalia',
                        price: '21.99',
                        code: 'BG029',
                        image: 'Sanpham/lucky-duck-games-nimalia.webp',
                        hreference: '/BoardGame/product-details.php?id=29',
                        describe: `Thiết kế Khu bảo tồn Động vật tốt nhất khi chơi 5 vòng.

Mỗi vòng, người chơi sẽ rút 3 lá bài, đặt một lá bài và chuyển phần còn lại (giai đoạn rút bài đơn giản). Mỗi thẻ bao gồm 4 quần xã, mỗi quần xã chứa một loài động vật. Khi bạn đặt một thẻ, bạn phải phủ ÍT NHẤT một quần xã. Toàn bộ Thánh địa không được vượt quá 6 x 6.

Mỗi trò chơi sẽ có một nhóm mục tiêu ghi điểm khác nhau. Mỗi vòng sẽ chỉ tính một số mục tiêu được chọn cho trò chơi, vì vậy bạn sẽ phải sửa đổi khu bảo tồn của mình trong suốt trò chơi để ghi được nhiều điểm nhất.

Khi kết thúc 5 vòng, người chơi kiếm được nhiều điểm hơn sẽ trở thành người chiến thắng!`
                    },

                30: {
                        name: 'Dorfromantik: The Board Game',
                        price: '44.99',
                        code: 'BG030',
                        image: 'Sanpham/pegasus-spiele-dorfromantik-the-board-game.jpg',
                        hreference: '/BoardGame/product-details.php?id=30',
                        describe: `Những dòng sông gợn sóng, những cánh rừng xào xạc, những cánh đồng lúa mì đung đưa trong gió và đây đó một ngôi làng nhỏ dễ thương - đó chính là Dorfromantik! Trò chơi điện tử của studio phát triển nhỏ Toukana Interactive đã gây xúc động cho cộng đồng game thủ kể từ khi ra mắt Early Access vào tháng 3 năm 2021 và đã giành được đủ loại giải thưởng danh giá. Giờ đây, Michael Palm và Lukas Zach đang biến trò chơi giải đố và chiến lược xây dựng phổ biến thành một trò chơi gia đình dành cho người già và trẻ với Dorfromantik: The Board Game.

Trong Dorfromantik: The Board Game, tối đa sáu người chơi cùng nhau xếp các ô hình lục giác để tạo cảnh quan đẹp mắt và cố gắng thực hiện mệnh lệnh của dân chúng, đồng thời xếp một con đường dài và một dòng sông càng dài càng tốt, mà còn tính đến các cờ cung cấp điểm trong các khu vực kèm theo. Người chơi quản lý để làm điều này càng tốt, họ càng có thể ghi được nhiều điểm hơn khi kết thúc. Trong quá trình diễn ra chiến dịch có thể chơi lại, số điểm kiếm được có thể được sử dụng để mở khóa các ô mới được ẩn trong các hộp bị khóa ban đầu. Những nhiệm vụ này đặt ra những nhiệm vụ mới, bổ sung cho người chơi và giúp nâng cao điểm số ngày càng cao.`
                    },

                31: {
                        name: 'Hive Classic',
                        price: '44.99',
                        code: 'BG031',
                        image: 'Sanpham/gen-42-hive-.webp',
                        hreference: '/BoardGame/product-details.php?id=31',
                        describe: `Hive là một trò chơi chiến lược dành cho hai người chơi không bị giới hạn bởi bàn cờ và có thể chơi ở mọi nơi trên mọi bề mặt phẳng. Tổ ong được tạo thành từ 22 mảnh, 11 mảnh màu đen và 11 mảnh màu trắng, giống như nhiều loại sinh vật khác nhau, mỗi mảnh có cách di chuyển độc đáo.

Không cần thiết lập, trò chơi bắt đầu khi mảnh đầu tiên được đặt xuống. Khi các quân cờ tiếp theo được đặt, điều này tạo thành một mô hình trở thành bề mặt chơi (bản thân các quân cờ trở thành bàn cờ). Không giống như các trò chơi tương tự khác, các quân cờ không bao giờ bị loại bỏ và không phải chơi tất cả. Mục tiêu của trò chơi là bao vây hoàn toàn quân hậu của đối thủ, đồng thời cố gắng ngăn cản đối thủ làm điều tương tự với quân hậu của bạn. Người chơi bao vây hoàn toàn nữ hoàng của đối thủ sẽ thắng trò chơi.`
                    },

                32: {
                        name: 'Chess: Luxury Version',
                        price: '64.99',
                        code: 'BG032',
                        image: 'Sanpham/asmodee-chess-luxury-version.webp',
                        hreference: '/BoardGame/product-details.php?id=32',
                        describe: `Bộ Cờ Tướng Cao Cấp là bộ cờ vua hoàn toàn bằng gỗ cao cấp. Nó có một bảng gỗ hoàn thiện đẹp mắt và các quân cờ bằng gỗ có đáy nhung để bảo vệ bảng và mang lại trải nghiệm chơi thú vị.`
                    },

                33: {
                        name: 'Chessplus',
                        price: '34.99',
                        code: 'BG033',
                        image: 'Sanpham/chessplus-chessplus.jpg',
                        hreference: '/BoardGame/product-details.php?id=33',
                        describe: `Chessplus, – Đó không phải là cờ vua. Thế tốt hơn rồi!
Kết hợp & Chinh phục.
Bắt đầu kết hợp ngay từ nước đi đầu tiên của bạn - di chuyển Tượng trên đường chéo lên Tốt. Quân cờ kết hợp mới (Biawn) giờ đây có thể di chuyển dưới dạng Tượng hoặc Tốt, hoặc nó có thể tách ra bằng cách di chuyển một trong hai quân cờ ra xa riêng lẻ.
Bạn có thích thăng quân Tốt lên quân Hậu không? Hãy nhanh chóng theo dõi quân Tốt của bạn sang phía bên kia của bàn cờ bằng cách sử dụng Xe hoặc Tượng và WHAM bạn có thêm một QUEEN trên bàn cờ. Nhưng hãy coi chừng nếu bạn mất một quân cờ Kết hợp, bạn sẽ mất hai quân cờ tiêu chuẩn BANG!
Kết hợp quân Hậu và quân Mã (Quight) để có quân TỔN THƯƠNG - Quân Hậu THẬT trên chiến mã của mình đang chiến đấu trên bàn cờ, bất cứ lúc nào cô ấy có thể nhảy trở lại bàn cờ để giao chiến với quân Hậu.
Một trận chiến thời TRUNG cổ thực sự với quân Tốt CƯỠI NGỰA như KỶ SĨ THẬT và BẮN MŨI TÊN từ các tòa tháp (Xe), và quân Hậu DẪN ĐẦU CHI PHÍ trên những chiến mã dũng mãnh của họ.
Các trò chơi Chessplus nhanh hơn, có nhiều nước đi bất ngờ và nhiều hơn theo cấp số nhân, tất cả các chiến lược mới (sẽ được khám phá) và cách chơi dễ dàng hơn khi so sánh với Cờ vua.
Trò chơi bảng chiến lược mới dựa trên Cờ vua nơi người chơi có thể KẾT HỢP và TÁCH các quân cờ của họ. Học trong 20 giây để tận hưởng niềm vui và thử thách trọn đời.`
                    },

                34: {
                        name: 'Chess and Checkers: Folding Version',
                        price: '44.99',
                        code: 'BG034',
                        image: 'Sanpham/61zmEca6lL._AC_SY300_SX300_.jpg',
                        hreference: '/BoardGame/product-details.php?id=34',
                        describe: `Hai trò chơi cổ điển trong một gói được sản xuất đẹp mắt! Bộ cờ vua và cờ đam hoàn toàn bằng gỗ này mang đến cho người chơi trải nghiệm chơi cao cấp cho cả cờ vua và cờ đam. Tất cả các quân cờ của trò chơi đều bằng gỗ và phần đáy rỗng của ván gỗ cho phép nó gập lại một nửa để cất giữ, đồng thời tạo ra một hộp gỗ để đựng các quân cờ của trò chơi. Cũng bao gồm túi kraft để giữ các mảnh.`
                    },

                35: {
                        name: 'Onitama Light & Shadow',
                        price: '21.99',
                        code: 'BG035',
                        image: 'Sanpham/pic6946703.webp',
                        hreference: '/BoardGame/product-details.php?id=35',
                        describe: `Bản mở rộng thứ ba cho Onitama, Light and Shadow mang đến một cách mới để khám phá trò chơi chiến thuật võ thuật đơn giản và tao nhã bằng cách giới thiệu một loại quân tốt mới: Ninja! Không giống như những con tốt khác, Ninja di chuyển bí mật, ẩn khỏi tầm nhìn của đối thủ cho đến khi họ sẵn sàng tấn công...

Có hai cách để chơi Ánh sáng và Bóng tối:

- Way of the Shadow là một trò chơi đối xứng, trong đó mỗi người chơi triển khai Ninja của riêng mình.

- Way of the Light là một trò chơi bất đối xứng, trong đó một người chơi Ninja đấu với một người chơi Onitama Master và Học sinh truyền thống.`
                    },

                36: {
                        name: 'Railroad Ink: Blazing Red',
                        price: '26.99',
                        code: 'BG036',
                        image: 'Sanpham/luma-imports-railroad-ink-blazing-red.jpg',
                        hreference: '/BoardGame/product-details.php?id=36',
                        describe: `Trong trò chơi giải đố nhiều người chơi Railroad Ink, mục tiêu của bạn là kết nối càng nhiều lối thoát hiểm trên bảng càng tốt. Mỗi vòng, một bộ xúc xắc được tung ra ở giữa bàn, xác định loại đường bộ và đường sắt nào dành cho tất cả người chơi. Bạn phải vẽ các tuyến đường này trên bảng có thể xóa được của mình để tạo các tuyến giao thông và kết nối các lối ra của mình, cố gắng tối ưu hóa các biểu tượng có sẵn tốt hơn đối thủ của bạn.

Bạn kết nối càng nhiều lối thoát, bạn càng ghi được nhiều điểm vào cuối trò chơi, nhưng bạn sẽ mất điểm cho mỗi tuyến đường chưa hoàn thành, vì vậy hãy lên kế hoạch cẩn thận! Bạn sẽ tận dụng vận may của mình và cố gắng mở rộng mạng lưới giao thông của mình đến lối ra tiếp theo hay bạn sẽ chơi an toàn và bắt đầu một tuyến đường mới, đơn giản hơn để quản lý?

Railroad Ink có hai phiên bản, mỗi phiên bản bao gồm hai bản mở rộng với các bộ xúc xắc bổ sung bổ sung các quy tắc đặc biệt cho trò chơi của bạn. Phiên bản Blazing Red bao gồm các bản mở rộng Lava và Meteor. Cố gắng hạn chế dung nham đến từ núi lửa đang phun trào trước khi nó phá hủy các tuyến đường của bạn, hoặc đối phó với sự tàn phá do các cuộc tấn công của thiên thạch và khai thác các miệng núi lửa để lấy quặng quý. Những quy tắc đặc biệt này có thể thêm gia vị cho mọi thứ và làm cho mỗi trò chơi chơi và cảm thấy khác nhau.

Mỗi hộp cho phép bạn chơi từ 1 đến 6 người chơi và nếu bạn kết hợp nhiều hộp hơn, bạn có thể chơi với tối đa 12 người chơi (hoặc hơn). Giới hạn duy nhất về số lượng người chơi là số lượng bảng bạn có!`
                    },

                37: {
                        name: 'Railroad Ink: Challenge: Shining Yellow',
                        price: '26.99',
                        code: 'BG037',
                        image: 'Sanpham/horrible-guild-game-studios-railroad-ink-challenge.jpg',
                        hreference: '/BoardGame/product-details.php?id=37',
                        describe: `Railroad Ink Challenge là một trò chơi cuộn và viết nhanh dành cho 1 đến 4 người chơi. Hãy lấy một tấm bảng và một cây bút lông có thể tẩy được, và sẵn sàng để đạt đến đỉnh cao của mạng lưới kết nối! Tung xúc xắc và vẽ các tuyến đường để kết nối các lối thoát xung quanh bàn cờ của bạn. Mở rộng mạng lưới của bạn với đường sắt, đường cao tốc và nhà ga để thu thập điểm, nhưng bạn sẽ bị phạt vì bất kỳ kết nối mở nào, vì vậy hãy lên kế hoạch cẩn thận!

Railroad Ink Challenge có mọi thứ bạn yêu thích từ các trò chơi Railroad Ink ban đầu và hơn thế nữa, với trọng tâm hoàn toàn mới là tương tác với người chơi nhờ các mục tiêu trong trò chơi! Chỉ những người đạt được chúng trước mới nhận được phần thưởng, vì vậy bạn phải theo dõi xem đối thủ của mình đang làm gì và cố gắng hoàn thành mục tiêu trước khi họ làm! Mỗi lần có một bộ mục tiêu khác nhau, vì vậy sẽ không có hai trò chơi nào giống nhau!

Nhưng xin chờ chút nữa! Vẽ các cấu hình tuyến đường uốn cong tâm trí chưa từng có nhờ xúc xắc mới! Kết nối các cấu trúc đặc biệt với mạng của bạn để kích hoạt các hiệu ứng mới: các nhà máy cho phép bạn nhân đôi một con súc sắc, các ngôi làng cho điểm thưởng nếu họ ở gần nhà ga, các trường đại học mở khóa thêm các tuyến đường đặc biệt — hãy sử dụng các hiệu ứng này một cách khôn ngoan và bạn sẽ ghi điểm lớn!

Railroad Ink Challenge có hai phiên bản, mỗi phiên bản bao gồm một bản mở rộng với một bộ xúc xắc bổ sung bổ sung các quy tắc đặc biệt mới cho trò chơi của bạn. Sử dụng ốc đảo để bảo vệ cây xương rồng của bạn khỏi khí hậu sa mạc khô cằn trong Shining Yellow Edition!`
                    },

                38: {
                        name: 'High Score',
                        price: '14.99',
                        code: 'BG038',
                        image: 'Sanpham/thames-kosmos-high-score.jpg',
                        hreference: '/BoardGame/product-details.php?id=38',
                        describe: `High Score là một trò chơi xúc xắc khéo léo với những thử thách độc đáo. Việc lật một thẻ thử thách mới sẽ cho người chơi biết cách ghi điểm trong vòng này và cách bạn có thể gieo lại xúc xắc của mình. Liệu số chẵn có bị 0 điểm vòng này? Vòng xoáy này sẽ có tác dụng gì?

Sau khi người chơi đầu tiên kết thúc lượt của mình, những người chơi khác có thể cố gắng đánh bại số điểm của họ, nhưng mạo hiểm quá nhiều và bạn có thể ra về tay trắng. Ai có nhiều điểm nhất sau bảy vòng sẽ thắng.`
                    },

                39: {
                        name: 'Sakura Heroes',
                        price: '24.99',
                        code: 'BG039',
                        image: 'Sanpham/ravensburger-sakura-heroes.jpg',
                        hreference: '/BoardGame/product-details.php?id=39',
                        describe: `Ai sẽ làm chủ những thử thách của ngọn núi ma thuật?

Trong Sakura Heroes, bạn phải đối mặt với các nhiệm vụ xúc xắc ngày càng trở nên khó khăn hơn khi bạn tiến lên. Thu thập hoa và bùa may mắn để hoàn thành các thử thách. Mọi người tung xúc xắc của mình cùng một lúc và cố gắng lấy đúng biểu tượng bằng xúc xắc của mình càng nhanh càng tốt để tiến lên cấp độ tiếp theo. Thu thập những viên kim cương có giá trị nhất trên đường lên đỉnh ngọn núi ma thuật để đăng quang người chiến thắng anh hùng!`
                    },

                40: {
                        name: 'Pinata Blast',
                        price: '14.99',
                        code: 'BG040',
                        image: 'Sanpham/ravensburger-pinata-blast.jpg',
                        hreference: '/BoardGame/product-details.php?id=40',
                        describe: `Mỗi vòng trong Piñata Blast, một người nào đó thả xúc xắc, sau đó mọi người cố gắng lấy viên xúc xắc phù hợp với quân bài của mình trước, đồng thời không lấy kẹo thối. Kiếm được nhiều điểm nhất để giành chiến thắng!`
                    },

                41: {
                        name: 'Drawn to Adventure',
                        price: '29.99',
                        code: 'BG041',
                        image: 'Sanpham/final-frontier-games-drawn-to-adventure.jpg',
                        hreference: '/BoardGame/product-details.php?id=41',
                        describe: `Trong Drawn to Adventure, bạn và tối đa ba nhà thám hiểm khác sẽ bắt đầu một cuộc hành trình hoành tráng qua Năm cõi, nơi bạn có thể sử dụng các kỹ năng và khả năng của mình để tiêu diệt quái vật và hoàn thành các nhiệm vụ. Bạn sẽ có cơ hội kiếm được nhiều phần thưởng, chẳng hạn như mana để kích hoạt sức mạnh đặc biệt; kinh nghiệm để tăng cấp cho nhân vật của bạn; và—tất nhiên—kho báu huy hoàng!

Drawn to Adventure là một trò chơi cuộn và viết dựa trên chiến dịch. Mỗi người chơi sử dụng một cuốn sách lật khô có chứa sáu bản đồ lưới lục giác khác nhau. Các chiến dịch được chơi trên ba trong số sáu bản đồ. Sau khi bản đồ thứ ba kết thúc, người chơi có nhiều kho báu nhất sẽ thắng. Vì vậy, hãy lấy cây bút mạnh mẽ của bạn và đi cùng; danh vọng và vận may đang chờ đợi những người thực sự bị cuốn hút vào cuộc phiêu lưu!`
                    },

                42: {
                        name: 'Twilight Inscription',
                        price: '69.99',
                        code: 'BG042',
                        image: 'Sanpham/fantasy-flight-games-twilight-inscription.jpg',
                        hreference: '/BoardGame/product-details.php?id=42',
                        describe: `Đế chế Lazax đã bị đốt cháy thành tro bụi, bị các đối tượng của nó chối bỏ. Hậu quả là bi kịch và xung đột nhỏ, một thời gian mất mát và kiệt sức. Trong Những năm đen tối sau đó, các phe phái của thiên hà đã rút lui và phục hồi sức mạnh của họ. Giờ đây, họ nhìn lên những vì sao và nhìn thấy một cơ hội—một cơ hội để lấy lại những gì đã mất. Một cơ hội để xác định lại nền văn minh thiên hà. Một cơ hội để lại dấu ấn của họ trên các vì sao.

Twilight Inscription, một trò chơi cuộn và viết hoành tráng dành cho một đến tám người chơi, mang đến trải nghiệm không giống bất kỳ trò chơi Fantasy Flight nào đã từng làm trước đây. Với nguồn tài nguyên hạn chế tùy ý sử dụng, bạn sẽ cần quản lý cẩn thận Điều hướng, Mở rộng, Công nghiệp và Chiến tranh khi bạn tích lũy điểm chiến thắng và giành quyền lên ngôi trên Mecatol Rex. Phe của bạn sẽ trở thành những người cai trị mới của thiên hà? Hay đế chế non trẻ của bạn sẽ chìm vào quên lãng? Bất cứ điều gì cũng có thể xảy ra trong trò chơi chiến lược, có thể chơi lại vô tận này!`
                    },

                43: {
                        name: 'Spot It! Disney Princess',
                        price: '19.99',
                        code: 'BG043',
                        image: 'Sanpham/zygomatic-spot-it-disney-princess.jpg',
                        hreference: '/BoardGame/product-details.php?id=43',
                        describe: `Phát hiện nó! Là một trò chơi quan sát và phản xạ nhanh chóng cho tất cả! Luôn luôn chỉ có 1 biểu tượng phù hợp giữa 2 thẻ! Phát hiện nó đầu tiên và bạn giành chiến thắng! Phát hiện nó! Có 5 cách chơi khác nhau và phiên bản spot này có các biểu tượng, vật phẩm và nhân vật cổ điển liên quan đến các Công chúa Disney được yêu mến.`
                    },

                44: {
                        name: 'Smash Up: Big in Japan',
                        price: '24.99',
                        code: 'BG044',
                        image: 'Sanpham/aeg-smash-up-big-in-japan.jpg',
                        hreference: '/BoardGame/product-details.php?id=44',
                        describe: `Smash Up: Big in Japan mang đến màn đập phá cơ sở dễ thương nhất mà bạn từng thấy ở Smash Up, với bốn phe phái được sinh ra từ văn hóa đại chúng Nhật Bản: các cô gái chiến đấu trong anime, những sinh vật sưu tập dễ thương hoàn toàn không phải Pokémon, những chiến binh đầy màu sắc không phải là cách Power Rangers và Godzilla.`
                    },

                45: {
                        name: 'Munchkin Apocalypse 2 Sheep Impact Game',
                        price: '19.95',
                        code: 'BG045',
                        image: 'Sanpham/steve-jackson-games-munchkin-apocalypse-2-sheep-im.jpg',
                        hreference: '/BoardGame/product-details.php?id=45',
                        describe: `Đó là sự kết thúc của thế giới ... một lần nữa. Munchkin Apocalypse 2: Sheep Impact là bản mở rộng gồm 106 lá bài cho Munchkin Apocalypse. Giờ đây, bạn có thể trang bị cho người sống sót cứng cỏi của mình với "Rìu ái quốc" và "Khí sốt cà chua" để đối đầu với "Đế chế tan băng"! Hãy tự bảo vệ mình bằng "Bom Suit" và "Sổ tay sinh tồn", nếu không "Phương tiện chống đối xã hội" sẽ kết liễu bạn sớm! Coi chừng "Thảm họa! Velocirapture!" và những Phong ấn mới đáng sợ như "The Singularity"! Chơi một Lớp mới - Daredevil - và coi thường hiểm họa tận thế!`
                    },

                46: {
                        name: 'The Red Dragon Inn 7: The Tavern Crew',
                        price: '39.99',
                        code: 'BG046',
                        image: 'Sanpham/slugfest-games-the-red-dragon-inn-7-the-tavern-cre.jpg',
                        hreference: '/BoardGame/product-details.php?id=46',
                        describe: `Tất cả các anh hùng (cuối cùng) đã xuất hiện trong đêm, vì vậy đã đến lúc quay trở lại với một cốc bia, một nắm xúc xắc và những chiếc túi lót bằng vàng của các nhà thám hiểm! Wench tham gia bữa tiệc tại The Red Dragon Inn và cô ấy mang theo những người còn lại trong nhóm quán rượu - Jasper the Bouncer, Molly the Stablehand và Warthorn Redbeard - cùng với cô ấy!

Red Dragon Inn 7 là một bản mở rộng độc lập mới dành cho 2-4 người chơi cho loạt trò chơi The Red Dragon Inn. Trong trò chơi này, bạn và tối đa ba người bạn của mình sẽ vào vai nhân viên của quán rượu thân yêu của chúng ta, tận hưởng buổi tối sau khi tất cả những vị khách quen trong cuộc phiêu lưu đã bất tỉnh trong phòng (hoặc chuồng) của họ. Tất nhiên đây sẽ không phải là một đêm thư giãn yên tĩnh! Đánh bạc, ẩu đả và uống rượu suốt đêm khi bạn chứng minh rằng bạn có những gì cần thiết để theo kịp những anh hùng mà bạn xử lý đêm này qua đêm khác. Red Dragon Inn 7 có thể được kết hợp với tất cả các phiên bản trước của chúng tôi, cho phép bạn kết hợp các nhân vật (và tình trạng lộn xộn) cho các trò chơi có bốn người chơi trở lên!`
                    },

                47: {
                        name: 'Munchkin Russia',
                        price: '34.99',
                        code: 'BG047',
                        image: 'Sanpham/steve-jackson-games-munchkin-russia.jpg',
                        hreference: '/BoardGame/product-details.php?id=47',
                        describe: `Chào mừng bạn đến với Munchkin Russia, nơi những câu chuyện cười đưa bạn đến! Chiến đấu với Troll Factory, KGBirds, Rasputin hoặc Hangover đáng sợ với Chó săn Nga và Balalaika bên cạnh bạn. Khi bạn giành chiến lợi phẩm và trở thành Hacker, Oligarch, Vận động viên hoặc Cossak trên đường lên Cấp 10, hãy coi chừng Cuộc cách mạng và nỗi kinh hoàng của Ca sĩ Eurovision. Và hãy chắc chắn để thưởng thức các mùa đẹp: xuân, hạ, thu, đông, đông, đông ...`
                    },

                48: {
                        name: 'The Red Dragon Inn 8: The Pub Crawl',
                        price: '39.99',
                        code: 'BG048',
                        image: 'Sanpham/slugfest-games-the-red-dragon-inn-8-the-pub-crawl-1.webp',
                        hreference: '/BoardGame/product-details.php?id=48',
                        describe: `Một bản mở rộng độc lập mới cho sê-ri từng đoạt giải thưởng! Những anh hùng lừng lẫy của chúng ta đã dành nhiều giờ đồng hồ (và rất nhiều xu!) tại quán rượu huyền thoại của Greyport, Red Dragon Inn. Nhưng ngay cả những khách hàng trung thành nhất thỉnh thoảng cũng muốn thay đổi khung cảnh... Vậy các anh hùng của chúng ta sẽ làm gì khi bốn bức tường quán rượu giống nhau đang trở nên hơi buồn tẻ? Thu thập quán rượu!

Red Dragon Inn 8 giới thiệu năm nhân vật mới — chủ sở hữu của năm quán rượu hoàn toàn mới, cộng với một biến thể chơi mới nơi người chơi có thể đi vòng quanh nhiều quán rượu thay vì ở lại Red Dragon Inn.`
                    },

                49: {
                        name: 'Good Omens: An Ineffable Game',
                        price: '24.99',
                        code: 'BG049',
                        image: 'Sanpham/renegade-game-studios-good-omens-an-ineffable-game.webp',
                        hreference: '/BoardGame/product-details.php?id=49',
                        describe: `Chào mừng đến với Tadfield! Các lực lượng của lời tiên tri, Thiên đường và Địa ngục đã tập hợp lại để bắt đầu Ha-ma-ghê-đôn. Các thiên thần và ác quỷ đang chuẩn bị cho trận chiến và chỉ có một nhóm kẻ gian dũng cảm mới có thể ngăn chặn nó. Đó là nơi bạn đến. Trong trò chơi này, bạn sẽ tìm thấy một số trò chơi xúc xắc và bài khác nhau có chủ đề xoay quanh các cuộc đối đầu diễn ra trong chương cuối cùng (hiện tại) của câu chuyện Good Omens. Nhiều trò chơi có sự kết hợp giữa xúc xắc và thẻ. Tại sao thẻ? Bởi vì các lá bài có trong bộ truyện và trong đặc tính của Good Omens. Toàn bộ sự tồn tại này giống như một trò chơi lớn đối với những người giật dây…`
                    },

                50: {
                        name: 'Final Girl: A Knock at the Door',
                        price: '19.99',
                        code: 'BG050',
                        image: 'Sanpham/van-ryder-games-final-girl-a-knock-at-the-door-int-1.webp',
                        hreference: '/BoardGame/product-details.php?id=50',
                        describe: `Hộp phim Cô gái cuối cùng

Không có gì giống như một cuộc hội ngộ tại Wingard Cottage yên tĩnh và tách biệt. Mọi người đang có một thời gian tuyệt vời. Rượu đang chảy và bữa tiệc đã bắt đầu. Rồi có tiếng gõ cửa. Liếc nhanh quanh phòng cho bạn biết tất cả những người lẽ ra đã ở đây rồi... Bạn đến gần cửa và từ từ mở nó ra, nhìn trộm quanh mép cửa. Không có ai ở đó. Nhưng ai đó đã... câu hỏi là, ai?

Trò chơi kinh dị nào sẽ hoàn thành nếu không có cuộc xâm lược tại nhà? Những kẻ xâm nhập đang ở đây. Đối mặt không phải một, không phải hai, mà là BA kẻ giết người. Bạn nghĩ rằng một cái là khó, nhưng bạn thực sự sẽ phải kiễng chân trước những mối đe dọa giết người này.

Wingard Cottage mang đến thử thách mới với các sự kiện độc đáo và cơ chế chế tạo mới cho phép bạn lấy các vật phẩm thông thường và biến chúng thành vũ khí sử thi. Dùng con dao đó hay nhặt một ít gỗ và đinh để chế tạo The Obliterator? Nó sẽ tùy thuộc vào bạn, chỉ cần thực hiện cuộc gọi trước khi quá muộn!

Hộp Lõi, khi được kết hợp với một trong các Hộp Phim truyện của chúng tôi, sẽ có mọi thứ bạn cần để chơi trò chơi. Mỗi Hộp phim truyện có một Kẻ giết người độc đáo và Địa điểm mang tính biểu tượng, đồng thời bạn càng có nhiều Phim truyện, bạn càng có thể trải nghiệm nhiều sự kết hợp giữa kẻ giết người/địa điểm!

Mỗi Hộp phim truyện đều có hai mặt, với các bìa được minh họa tuyệt đẹp ở mặt trước VÀ mặt sau. Không chỉ vậy, các nắp hộp được gắn từ tính còn có thể tháo rời, với mặt sau của mỗi nắp có chức năng tương ứng là bảng Kẻ giết người và Bảng vị trí.`
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


                    <!-- Phần các sản phẩm có thể bạn quan tâm -->
                    <h4>CÓ THỂ BẠN QUAN TÂM</h4>
                                
                                  
                    <div class="row px-1"> 
                        <!-- <div class = "col-md-10"> -->
                             <div class="card">
                                          <?php 
                                              $a=1;
                                              $select_query = "SELECT * FROM `boardgame`LIMIT 4";
                                              $result_query = mysqli_query($conn,$select_query);
                                              while($row = mysqli_fetch_assoc($result_query)){
                                                $MASP = $row['MASP'];
                                                $TENSP = $row['TENSP'];
                                                $GIA = $row['GIA'];
                                                $THELOAI = $row['THELOAI'];
                                                $SOLUONG = $row['SOLUONG'];
                                                $MOTA = $row['MOTA'];
                                                $BG_image = $row['img_src'];
                                                echo"
                                                <div class='product'>
                                                <div class='image'>
                                                <a href='/BoardGame/product-details.php?id=$a' > <img src='./$BG_image' style='width:250px; height: 250px' class='card-img-top' alt='$TENSP'></a>   
                                                </div>
                                                <div class='product-info'>
                                                <h4>$TENSP</h4>
                                                <span>$GIA</span>
                                                </div>
                                                <p>Mã SP: $MASP </p>
                                                <div class='stars'>
                                                <i class='fa-solid fa-star'></i>
                                                <i class='fa-solid fa-star'></i>
                                                <i class='fa-solid fa-star'></i>
                                                <i class='fa-solid fa-star'></i>
                                                <i class='fa-regular fa-star'></i>
                                                </div>
                                                <div class='pay'>
                                                <form action='save_to_cart.php' method='post'>
                                                <input type='hidden' name='name_product' value= $TENSP>
                                                <input type='hidden' name='code' value=$MASP>
                                                <input type='hidden' name='price' value=$GIA>
                                                <input type='hidden' name='describe' value= $MOTA>
                                                <input type='hidden' name='quantity' value= $SOLUONG>
                                                <button type='submit' class='btn'>Thêm vào giỏ <i class='fas fa-shopping-cart'></i></button>
                                                </form>
                                                </div>
                                                </div>
                                                
                                                ";
                                                $a++;                       
                                              }
                                              
                                          ?> 
                             </div>
                        <!-- </div> -->
                    </div> 
                   
                   
                    <!-- Kết thúc phần các sản phẩm có thể bạn quan tâm -->



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
