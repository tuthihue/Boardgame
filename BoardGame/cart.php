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

        </div>
    </div>  
    <?php
    }
    ?>
</body>

</html>
