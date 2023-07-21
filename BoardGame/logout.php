<?php
session_start();
// Xóa các biến phiên làm việc nếu có
session_unset();
// Hủy phiên làm việc
session_destroy();
// Chuyển hướng về trang đăng nhập sau khi đăng xuất
header('Location: login.php');
exit;
?>