<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang chủ | BoardGame</title>
    <link rel="stylesheet" href="CSS/purchase.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
</head>
<body>
<div id="wrapper">
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
                <form action="cart.php" method="post">
                          <input type="hidden" name="name_product" value="">
                          <input type="hidden" name="code" value="">
                          <input type="hidden" name="price" value="">
                          <input type="hidden" name="describe" value="">
                          <input type="hidden" name="quantity" value="1">
                          
                          <button type="submit" class="btn">Giỏ hàng <i class="fa-solid fa-shopping-cart"></i></button>
                        </form>
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
            <?php
            // Kết nối tới cơ sở dữ liệu
            $servername = "localhost";
            $username = "root";
            $password ="" ;
            $dbname = "boardgame";

            $conn = mysqli_connect($servername, $username, $password, $dbname);

            // Kiểm tra kết nối
            if (!$conn) {
                die("Không thể kết nối đến cơ sở dữ liệu: " . mysqli_connect_error());
            }

            session_start();
            $randomNumber = $_SESSION['randomNumber'];
            $sql = "SELECT t.ID_THUE,t.USERNAME,t.NGAYTHUE,t.TONGTIEN,tg.TENSP,tg.SOLUONG FROM THUE t JOIN THUEGAME tg ON t.ID_THUE=tg.ID_THUE  WHERE t.id_thue='$randomNumber'";

            $result = mysqli_query($conn, $sql);
            if ($result) {
                if (mysqli_num_rows($result) > 0) { ?>
                <br><br><br>
                <div>
                    <h2>Thông tin hóa đơn (vui lòng chụp lại mang theo để xác nhận):</h2>
                    <table class="invoice-table">
                    <thead>
                    <tr>
                    <th>Mã Hóa Đơn</th>
                    <th>Họ Và Tên</th>
                    <th>Ngày Thuê</th>
                    <th>Tổng tiền</th>
                    <th>Tên Sản Phẩm</th>
                    <th>Số lượng</th>
                    </tr>
                    </thead>
                    <tbody>
                <div>
                <?php
                    while ($row = mysqli_fetch_assoc($result)) {
                        echo '<tr>';
                        echo '<td>' . $row['ID_THUE'] . '</td>';
                        echo '<td>' . $row['USERNAME'] . '</td>';
                        $ngayThue = date('d-m-Y', strtotime($row['NGAYTHUE']));
                        echo '<td>' . $ngayThue . '</td>';
                        echo '<td>' . $row['TONGTIEN'] . '.000VND</td>';
                        echo '<td>' . $row['TENSP'] . '</td>';
                        echo '<td>' . $row['SOLUONG'] . '</td>';
                        echo '</tr>';
                    }
                
                    echo '</tbody>';
                    echo '</table>';
                } else {
                    echo '<p>Không tìm thấy dữ liệu.</p>';
                }
                
            } else {
                echo 'Lỗi: ' . mysqli_error($conn);
            }

            // Đóng kết nối
            mysqli_close($conn);
            ?>
        </div>
</body>

</html>

