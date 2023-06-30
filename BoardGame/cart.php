<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang chủ | BoardGame</title>
    <link rel="stylesheet" href="cart.css">
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
        <div id="main">
            <br><br><br>
            <div class="title-cart">
                <H2>THÔNG TIN ĐƠN HÀNG </H2>
            </div>
            <?php
                $code = $_POST['code'];
                $name_product = $_POST['name_product'];
                $quantity = $_POST['quantity'];
                $price = $_POST['price'];
                $describe = $_POST['describe'];

    if (empty($code) || empty($name_product) || empty($quantity) || empty($price) || empty($describe)) {
        echo "<div style='text-align: center;'><h2>Bạn chưa thực hiện đơn hàng nào.</h2></div>";
    } else {
    ?>
            <div class="cart">
            <table style="width:100%;">
                    <thead>
                        <tr>
                        <td>Mã sản phẩm</td>
                        <td>Tên Sản Phẩm</td>
                        <td>Số lượng</td>
                        <td>Giá</td>
                        <td>Mô tả</td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                        <td><?php echo $_POST['code']; ?></td>
                        <td><?php echo $_POST['name_product']; ?></td>
                        <td><?php echo $_POST['quantity']; ?></td>
                        <td><?php echo $_POST['price']; ?></td>
                        <td><?php echo $_POST['describe']; ?></td>
                        </tr>
                    </tbody>
                    </table>

            </div>
            <br><br>
            <div>
            <h2>Vui lòng nhập thông tin thanh toán: </h2>
            <form action="insert_purchase.php" method="post">
                <input type="hidden" name="name_product" value="<?php echo $_POST['name_product']; ?>" required>
                <input type="hidden" name="price" value="<?php echo $_POST['price']; ?>" required>
                <input type="hidden" name="code" value="<?php echo $_POST['code']; ?>" required>
                <input type="hidden" name="quantity" value="<?php echo $_POST['quantity']; ?>" required>
                <input type="hidden" name="describe" value="<?php echo $_POST['describe']; ?>" required>
                <div style="border: 1px solid #ccc; padding: 10px;">
                <div style="border-bottom: 1px solid #ccc; padding-bottom: 10px;">
                    <label class="cart" style="width: 50%;">Họ và tên:</label>
                    <input type="text" class="form-control" style="border: none; outline: none; width: 100%;" id="name" name="name" required>
                </div>
                <div style="border-bottom: 1px solid #ccc; padding-bottom: 10px;">
                    <label class="cart" style="width: 50%;">Số điện thoại:</label>
                    <input type="text" class="form-control" style="border: none; outline: none; width: 100%;" id="phone" name="phone" required>
                </div>
                </div>
                <button type="submit" class="btn">Thanh toán <i class="fas fa-shopping-cart"></i></button>
            </form>
            </div>
    </div>  
    <?php
    }
    ?>
</body>

</html>
