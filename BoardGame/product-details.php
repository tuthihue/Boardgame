<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang chủ | BoardGame</title>
    <link rel="stylesheet" href="product.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
</head>
<body>
    <div id="menu">
        <div id="header">
            <div class="container">
                <div class="logo">
                    <img src="logo-boardgame.png" alt="">
                </div>
                <div class="search-bar">
                    <i class="fa-solid fa-magnifying-glass"></i>
                    <input type="search" placeholder="Tìm kiếm">
                </div>
                <div class="button">
                <a href="/BoardGame/cart.php"><button class="btn">Giỏ hàng <i class="fa-solid fa-cart-shopping"></i></button></a>
                <a href="/BoardGame/register.php"><p class="link"><i class="fa-solid fa-right-to-bracket"></i> Đăng nhập/Đăng Ký</p></a>
            </div>
            </div>
            <div id="menu">
              <div class="container">
              <div class="menu-area">
                  <ul>
                      <li><a href="/BoardGame/index.php">Trang chủ</a></li>
                  </ul>
              </div>
          </div>
      </div>
          </div>
      </div>
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
                        <form action="cart.php" method="post">
                          <input type="hidden" name="name_product" value="">
                          <input type="hidden" name="code" value="">
                          <input type="hidden" name="price" value="">
                          <input type="hidden" name="describe" value="">
                          <input type="hidden" name="quantity" value="1">
                          
                          <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                        </form>
                        <!-- <button type = "button" class = "btn">Thanh toán</button> -->
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
                          name: 'Chess: Luxury Version',
                          price: '64.999đ',
                          code: 'BGOO1',
                          image: 'SanPham/asmodee-chess-luxury-version.webp',
                          describe:'Bộ Cờ Tướng Cao Cấp là bộ cờ vua hoàn toàn bằng gỗ cao cấp. Nó có một bảng gỗ hoàn thiện đẹp mắt và các quân cờ bằng gỗ có đáy nhung để bảo vệ bảng và mang lại trải nghiệm chơi thú vị.'
                        },
                        2: {
                          name: 'Chessplus',
                          price: '34.999đ',
                          code: 'BG002',
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
          
                    <div class = "social-links">
                      <p>Chia sẻ: </p>
                      <a href = "#">
                        <i class = "fab fa-facebook-f"></i>
                      </a>
                      <a href = "#">
                        <i class = "fab fa-twitter"></i>
                      </a>
                      <a href = "#">
                        <i class = "fab fa-instagram"></i>
                      </a>
                      <a href = "#">
                        <i class = "fab fa-whatsapp"></i>
                      </a>
                      <a href = "#">
                        <i class = "fab fa-pinterest"></i>
                      </a>
                    </div>
                  </div>
                </div>
                  </div>
              </div>
        </div>
    </div>
</body>

</html>
