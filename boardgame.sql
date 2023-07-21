-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 21, 2023 at 05:11 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `boardgame`
--

-- --------------------------------------------------------

--
-- Table structure for table `admins`
--

CREATE TABLE `admins` (
  `ID` int(11) NOT NULL,
  `UserName` varchar(100) DEFAULT NULL,
  `HOTEN` varchar(100) NOT NULL,
  `PassWord` varchar(255) NOT NULL,
  `sdt` varchar(12) NOT NULL,
  `email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admins`
--

INSERT INTO `admins` (`ID`, `UserName`, `HOTEN`, `PassWord`, `sdt`, `email`) VALUES
(1, '21522106', 'Hoàng Ngọc Hồng', '06082003', '0366928921', '21522106@gm.uit.edu.vn'),
(2, '21522159', 'Nguyễn Thành Huy', 'huy1234', '0123456789', 'thanhhuy@gmail.com'),
(3, '21522592', 'Nguyễn Trần Hội Thắng', 'thang1234', '098712245', 'thang@gmail.com'),
(4, '21522109', 'Từ Thì Huệ', 'hue1234', '023658558', 'hue@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `binhluan`
--

CREATE TABLE `binhluan` (
  `id_comment` int(255) NOT NULL,
  `noidung` varchar(255) NOT NULL,
  `id` int(255) NOT NULL,
  `USERNAME` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `binhluan`
--

INSERT INTO `binhluan` (`id_comment`, `noidung`, `id`, `USERNAME`) VALUES
(1, 'Game tạm ổn', 2, 'hoangngochong'),
(2, 'Game hay ', 4, 'my'),
(10, 'game cũng được ', 3, 'hoangngochong'),
(11, 'Game khá là đắt', 3, 'Red2003');

-- --------------------------------------------------------

--
-- Table structure for table `boardgame`
--

CREATE TABLE `boardgame` (
  `MASP` varchar(100) NOT NULL,
  `TENSP` varchar(100) NOT NULL,
  `GIA` float NOT NULL,
  `THELOAI` varchar(100) DEFAULT NULL,
  `SOLUONG` int(11) DEFAULT NULL,
  `MOTA` text DEFAULT NULL,
  `img_src` text DEFAULT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `boardgame`
--

INSERT INTO `boardgame` (`MASP`, `TENSP`, `GIA`, `THELOAI`, `SOLUONG`, `MOTA`, `img_src`, `id`) VALUES
('BG001', 'Outer Rim', 75, 'Star Wars', 5, 'Bay tới các vì sao và trở thành huyền thoại sống trong Star Wars: Outer Rim, một trò chơi về thợ săn tiền thưởng, lính đánh thuê và buôn lậu dành cho 1-4 người chơi!\r\n\r\nTrong Outer Rim, bạn đảm nhận vai trò của một cư dân thế giới ngầm, bắt đầu ghi dấu ấn của mình trên thiên hà. Bạn sẽ du hành vòng ngoài trên con tàu cá nhân của mình, thuê các nhân vật huyền thoại trong Chiến tranh giữa các vì sao tham gia vào phi hành đoàn của mình và cố gắng trở thành kẻ sống ngoài vòng pháp luật nổi tiếng (hoặc khét tiếng) nhất trong thiên hà!\r\n\r\nNhưng sẽ không dễ dàng gì vì các phe phái tham chiến của thiên hà lang thang khắp vành đai bên ngoài, săn lùng những kẻ cặn bã đã được chứng minh là cái gai đối với họ và những kẻ vô lại khác đang tìm cách ghi dấu ấn của chúng, coi bạn là mục tiêu hoàn hảo để hạ bệ. xuống để củng cố danh tiếng của chính họ. Bạn có những gì nó cần để tồn tại ở vành ngoài và trở thành một huyền thoại sống?\r\n\r\nChi tiết hơn, trò chơi Outer Rim diễn ra trong một loạt lượt, trong đó người chơi nhận các công việc nguy hiểm, truy tìm tiền thưởng, nâng cấp tàu của họ, v.v., tất cả đều nhằm mục đích đạt được ngày càng nhiều danh tiếng. Bất kể bạn đi theo con đường nào để đến đó, mục tiêu của bạn là đạt được mười danh tiếng, có thể đến từ nhiều nguồn khác nhau, chẳng hạn như hoàn thành mục tiêu cá nhân của nhân vật, thu thập tiền thưởng và công việc, vận chuyển hàng hóa bất hợp pháp, hạ gục các đội tuần tra từ các phe phái khác nhau đang tranh giành thiên hà và tận hưởng những điều tốt đẹp hơn trong cuộc sống bằng cách mua những món đồ xa xỉ bằng các khoản tín dụng khó kiếm được của bạn.\r\n\r\nMặc dù con đường dẫn đến chiến thắng có thể khác đối với những kẻ vô lại đang tìm đường đến Vòng ngoài, nhưng mọi người đều bắt đầu từ dưới lên với một phi thuyền đơn giản. Bảng người chơi của bạn không chỉ theo dõi tiến trình nổi tiếng của bạn mà còn chứa các vị trí dành cho tàu, thẻ nhân vật, thiết bị, danh tiếng, sửa đổi, công việc và tiền thưởng của bạn', 'Sanpham/fantasy-flight-games-star-wars-outer-rim.jpg', 1),
('BG002', 'Not That Movie', 25, 'Party Games ', 4, 'Pizza, đi văng và bạn bè: bạn chỉ cần một bộ phim hay! Như mọi khi, bạn không thể quyết định xem cái nào cùng nhau. Dựa vào các bài đánh giá, tưởng tượng cốt truyện phim và chọn tiêu đề hoàn hảo! Bạn sẽ thảo luận cả đêm hay đi đến một thỏa thuận?\r\n\r\nTrong trò chơi nhóm hợp tác Not That Movie! bạn phải chọn phim trong danh sách các tựa phim kỳ lạ — nhưng đây có thể là một quyết định khó khăn nếu bạn chỉ biết một vài bài đánh giá ngắn!\r\n\r\nChi tiết hơn, người chơi phải chọn một bộ phim cho một \"\"đêm phim\"\" cùng bạn bè. Tiêu đề nào phù hợp nhất với thẻ đánh giá? Người chơi có thể chọn phim từ danh sách tám tựa phim \"\"bị hỏng\"\" bao gồm hai tựa phim trộn lẫn với nhau. Kết quả của những sự kết hợp này có thể rất xuất sắc, kỳ lạ và thậm chí kỳ lạ: bảo đảm sẽ có tiếng cười!\r\n\r\nSau khi bí mật chọn, người chơi lần lượt đặt mã thông báo \"\"Không\"\" gần tiêu đề mà họ cho rằng không có ai chọn. Mỗi mã thông báo được đặt đúng sẽ ghi được một điểm và bạn có một lỗi miễn phí mỗi vòng. Nếu bạn không phạm sai lầm, bạn sẽ ghi được điểm thưởng. Bạn chơi năm vòng và cố gắng đánh bại số điểm trước đó của mình và ghi tên mình vào bảng điểm. Bạn có bao giờ đạt được tối đa 40 điểm, với số lượng người chơi khác nhau không?\r\n\r\nChơi với hơn 25.000 tựa phim chưa ai từng xem!\r\n\r\n(Lưu ý: Thiết kế này ban đầu được công bố là Movie Night nhưng trong quá trình phát triển, biến thể hợp tác của trò chơi đã được hoàn thiện để trở thành phiên bản chính thức duy nhất.)', 'Sanpham/pic6961520.webp', 2),
('BG003', 'Best of Werewolves of Millers Hollow', 22, 'Party Games ', 6, 'Để tôn vinh Người sói ở Thung lũng Miller và di sản đáng sợ của nó, các nhà thiết kế ban đầu đã quyết định kết hợp tất cả các nhân vật yêu thích của họ và mang đến cho bạn. Với các nhân vật được lấy từ tất cả các bản mở rộng — Trăng non, Nhân vật, Hiệp ước — và đặt trong một hộp, giờ đây, việc kết hợp một trò chơi đáng sợ với Best of Werewolves của Millers Hollow trở nên dễ dàng hơn bao giờ hết.', 'Sanpham/zygomatic-best-of-werewolves-of-millers-hollow_2.png', 3),
('BG004', 'Dixit: Odyssey Expansion', 35, 'Party Games ', 5, 'Dixit Odyssey là bản mở rộng (Dixit: Odyssey (expansion)) cho Dixit của Jean-Louis Roubira, đã giành giải Spiel des Jahres của Đức năm 2010.\r\n\r\nCách chơi trong Dixit Odyssey khớp với cách chơi của Dixit: Mỗi lượt một người chơi là người kể chuyện. Người chơi này bí mật chọn một lá bài trên tay, sau đó đưa ra một từ hoặc câu để mô tả lá bài này—nhưng không quá rõ ràng. Mỗi người chơi khác chọn một thẻ trên tay khớp với từ/câu này và đưa thẻ đó cho người kể chuyện. Sau đó, người kể chuyện sẽ phát các thẻ và tất cả những người chơi khác sẽ bỏ phiếu xem thẻ nào thuộc về người kể chuyện. Nếu không ai hoặc tất cả mọi người đoán thẻ của người kể chuyện, thì người kể chuyện không nhận được điểm và tất cả người chơi nhận được hai điểm; mặt khác, người kể chuyện và (những) người đoán đúng, mỗi người nhận được ba điểm. Người chơi ghi được một điểm cho mỗi phiếu bầu mà hình ảnh của họ nhận được. Người chơi nạp tiền vào tay và người chơi tiếp theo trở thành người kể chuyện. Khi bộ bài hết, người chơi có nhiều điểm nhất sẽ thắng.\r\n\r\nDixit Odyssey chứa 84 thẻ mới, mỗi thẻ có một hình ảnh độc đáo do Piero vẽ và được tô màu bởi Marie Cardouat, nghệ sĩ của Dixit và Dixit 2. Phiên bản độc lập cũng bao gồm một bảng trò chơi gấp, 6 mã thông báo ghi điểm thỏ mới (tổng cộng 12) và một hộp đủ lớn để chứa tất cả các thẻ Dixit đã phát hành cho đến nay. Phiên bản độc lập của Dixit Odyssey bao gồm đủ các thành phần cho tối đa 12 người chơi và cũng có các quy tắc biến thể để chơi theo nhóm và các cách mới để chơi với các thẻ.', 'Sanpham/lucky-duck-games-nimalia.webp', 4),
('BG005', 'Skull', 25, 'Party Games ', 6, 'Một trò chơi cổ xưa gồm những chiếc đầu lâu được trang trí công phu và những bông hồng nguy hiểm, Skull rất dễ học nhưng rất khó để giành chiến thắng. Bạn phải bịp bợm, nói dối và xuyên thủng những trò lừa bịp để vạch trần những bông hồng. Tuy nhiên, hãy cảnh giác - nếu bạn tình cờ gặp một hộp sọ, hậu quả sẽ rất thảm khốc! Người chơi sẽ giữ ba thẻ hoa hồng và một đầu lâu. Thêm một thẻ vào đống trước mặt bạn và khi bạn cảm thấy may mắn, hãy thông báo thử thách của bạn và tuyên bố bạn sẽ lật được bao nhiêu thẻ. Các quân bài có hình hoa hồng là an toàn, nhưng nếu bạn để lộ hộp sọ ẩn của đối thủ, bạn sẽ mất một quân bài của chính mình. Giữ quân bài của bạn đến cùng để giành chiến thắng trong trò chơi đánh lừa và nhận thức thông minh này!', 'Sanpham/space-cowboys-skull.jpg', 5),
('BG006', 'The Werewolves of Millers Hollow: The Pact', 50, 'Party Games ', 7, 'The Werewolves of Millers Hollow: The Pact bao gồm trò chơi cơ bản The Werewolves of Millers Hollow cũng như ba bản mở rộng hiện có cho trò chơi đó kể từ năm 2014: New Moon, Characters và The Village.', 'Sanpham/zygomatic-the-werewolves-of-millers-hollow-the-pac.jpg', 6),
('BG007', 'Squid Game', 30, 'Party Games ', 10, 'Ai sống sót trong trò chơi Mực? Trò chơi tiệc tùng thú vị này dựa trên loạt phim cùng tên của Netflix. Với đội cá nhân của bạn, bạn phải cạnh tranh với các đội của đối thủ. Thông qua các chiến thuật vô tội vạ, may mắn nhưng cũng khó khăn, bạn phải sống sót qua sáu trò chơi bài dựa trên các vòng đấu chết người trong sê-ri. Ai đứng cuối cùng ở cuối sẽ thắng Trò chơi mực!', 'Sanpham/mixlore-squid-game.jpg', 7),
('BG008', 'HeroQuest: The Mage of the Mirror', 50, 'Dungeon Crawl & Minis', 23, 'Cuộc phiêu lưu này chứng kiến những rắc rối đang diễn ra ở vương quốc yêu tinh, và một yêu tinh dũng cảm trước tiên phải vượt qua các nhiệm vụ một mình nguy hiểm trước khi gia nhập lại nhóm của họ để đối đầu với pháp sư ma quỷ, Sinestra.\r\n\r\nMage of the Mirror bao gồm một Sách nhiệm vụ gồm 10 nhiệm vụ, 33 mô hình thu nhỏ chi tiết tinh xảo và 35 thẻ trò chơi sẽ mở rộng trò chơi cho cả Zargon và các anh hùng.', 'Sanpham/hasbro-heroquest-the-mage-of-the-mirror.jpg', 8),
('BG009', 'Marvel United: Guardians of the Galaxy Remix', 35, 'Dungeon Crawl & Minis', 15, 'Những người bảo vệ thiên hà đã tạo nên tên tuổi của họ khi du hành các vì sao, đấu tranh cho những người bất lực, sửa sai và đôi khi sai một vài quyền. Nhưng nhìn chung, những việc làm tốt của họ lấn át những điều xấu, và Ronan the Accuser đã chịu đủ rồi! Những Người bảo vệ đã can thiệp vào người của Ronan, người Kree, trong cuộc chiến chính nghĩa tự xưng của họ lần cuối cùng!\r\n\r\nRonan được xếp vào hàng những nhân vật phản diện ghê gớm nhất mà các Vệ binh từng đối mặt, và kế hoạch tổng thể của anh ta đơn giản nhất có thể: chấm dứt vĩnh viễn các Vệ binh. Trong trận chiến cá nhân, ngay cả bộ ba Star-Lord, Rocket Raccoon và Groot cũng có rất ít cơ hội chống lại The Accuser đang sử dụng Universal Weapon thần thánh của mình. Họ phải tranh giành con đường của mình từ ngôi sao này sang ngôi sao khác, giúp đỡ mọi nơi có thể và ngăn chặn tay sai của Ronan bất cứ khi nào có thể.\r\n\r\nKhông có nơi nào an toàn cho những Người bảo vệ chừng nào Ronan còn theo dõi dấu vết của họ. Hy vọng duy nhất của họ là tập hợp đủ sức mạnh để cuối cùng đánh bại Ronan, hoặc làm thất bại kế hoạch của anh ta đủ lâu để từ bỏ cuộc săn lùng. Dù bằng cách nào, Guardians of the Galaxy đang chạy đua với thời gian!', 'Sanpham/cmon-marvel-united-guardians-of-the-galaxy-remix.jpg', 9),
('BG010', 'Masters of the Universe: The Board Game - Clash For Eternia', 110, 'Dungeon Crawl & Minis', 12, 'Masters of the Universe: The Board Game - Clash for Eternia là một trò chơi mang tính cạnh tranh so với nhiều người hoặc trò chơi trên bàn dựa trên hành động hợp tác hoàn toàn. Chọn chơi với tư cách là Chiến binh Anh hùng hoặc Ác ma, sử dụng các khả năng độc đáo trên chiến trường, nâng cấp kỹ năng và bằng sức mạnh của Grayskull, giành chiến thắng trong cuộc chiến vì Eternia!', 'Sanpham/cmon-masters-of-the-universe-the-board-game-clash.jpg', 10),
('BG011', 'Beast', 70, 'Cooperative ', 14, 'Chào mừng bạn đến với Northern Expanse, một nơi mà thiên nhiên vẫn chưa được khám phá, huyền bí và nguy hiểm. Khi con người lần đầu tiên đến, họ nghĩ rằng họ đã tìm thấy một thiên đường hoang sơ, tràn ngập những khu rừng bội thu, những hồ cá bơi lội và nước ngọt lạnh chảy từ núi. Nhưng khi các khu định cư của họ mở rộng và các khu rừng xung quanh ngày càng thưa thớt, thì chính thiên nhiên đã bị đẩy lùi. Những sinh vật vĩ đại được gọi là Quái thú xuất hiện, và với răng nanh, móng vuốt và sức mạnh thần bí, chúng đã chứng tỏ là một mối đe dọa đáng kinh ngạc đối với loài người. Để bảo vệ các khu định cư, con người đã chiêu mộ những thợ săn chuyên biệt, được giao nhiệm vụ theo dõi và tiêu diệt Quái thú trước khi quá nhiều đồng loại của chúng bị diệt vong.\r\n\r\nQuái thú sử dụng một bộ bài định hướng để di chuyển qua các khu rừng, đầm lầy và hang động, sử dụng mưu mẹo và sự lừa dối để che giấu dấu vết của nó khỏi những người thợ săn. Tuy nhiên, bất cứ khi nào thợ săn di chuyển qua vị trí mà Quái thú đã ở trước đó, một dấu vết sẽ xuất hiện. Chỉ khi một thợ săn tìm kiếm một địa điểm hoặc chính Quái thú tấn công một mục tiêu không ngờ tới thì vị trí thực sự của Quái thú mới được tiết lộ. Hơn nữa, mỗi thợ săn chỉ có một cơ hội tìm kiếm mỗi vòng, khiến nó trở thành một quyết định căng thẳng và khó khăn. Các thợ săn hiếm khi có đầy đủ thông tin liệu con đường mà họ đang theo đuổi có chứa vị trí thực tế của Quái thú hay con đường đó đã nguội lạnh.\r\n\r\nMỗi hành động bạn thực hiện trong trò chơi này được thực hiện bằng cách đánh một lá bài từ tay của bạn (tối đa hai lá bài mỗi lượt). Điều này có nghĩa là nếu người chơi muốn tìm kiếm, tấn công hoặc di chuyển, họ cần phải có một lá bài trên tay cho phép họ làm điều đó. Trước mỗi vòng, cả thợ săn và Quái thú đều tham gia thảo luận để tìm những quân bài quan trọng nhất. Tất cả các thẻ hành động đều có thể được sử dụng bởi cả Beast và thợ săn.\r\n\r\nĐể chiến thắng trò chơi này, bạn cần phải phối hợp ăn ý trong từng bước nếu vào vai thợ săn, hoặc khéo léo vượt qua đối thủ nếu vào vai Beast. Về bản thân, thợ săn không bao giờ mạnh hơn Quái thú. Chỉ khi những người thợ săn giao tiếp, lập chiến lược và kết hợp hành động, họ mới có thể hạ gục Beast trước khi quá muộn.', 'Sanpham/pegasus-spiele-beast.jpg', 11),
('BG012', 'Arkham Horror: Final Hour', 40, 'Cooperative ', 16, 'Bạn đến quá muộn để ngăn chặn nghi thức ghê tởm, và một Ancient One quái dị, xuyên không gian xuyên qua thực tại. Một vết nứt óng ánh rạch ngang bầu trời tối đen, báo trước những sinh vật ác mộng tràn vào các tòa nhà thần thánh của Đại học Miskatonic. Khi những tiếng hú và la hét xuyên suốt màn đêm, chỉ còn một con đường duy nhất cho những điều tra viên gan dạ của bạn—hãy kìm hãm đám đông đủ lâu để bằng cách nào đó đảo ngược lệnh triệu tập.\r\n\r\nArkham Horror: Final Hour là một trò chơi hội đồng có nhịp độ nhanh, hoàn toàn hợp tác dành cho một đến bốn người chơi. Một làn sóng quái vật vô tận quét qua khuôn viên Đại học Miskatonic, và bạn phải kìm hãm chúng lại, đồng thời tìm kiếm các thành phần nghi lễ mà bạn cần để chấm dứt sự điên rồ này một cách tuyệt vọng. Có thể chơi trong vòng chưa đầy 60 phút, số phận của bạn phụ thuộc vào sự hợp tác giữa bạn và các điều tra viên đồng nghiệp. Tỷ lệ cược chống lại bạn là rất lớn, nhưng nếu bạn không thành công, đây thực sự sẽ là giờ cuối cùng của Arkham...và thế giới.', 'Sanpham/fantasy-flight-games-arkham-horror-final-hour.jpg', 12),
('BG013', 'Legacy of Yu', 60, 'Cooperative ', 13, 'Legacy of Yu là trò chơi chiến dịch phi tuyến tính, hoàn toàn có thể thiết lập lại, chỉ chơi một mình, trong đó bạn nhập vai người anh hùng huyền thoại của triều đại nhà Hạ, Yu Đại đế. Công việc của bạn là xây dựng các kênh đào trước trận lụt sắp xảy ra, đồng thời bảo vệ ngôi làng đang phát triển của mình trước các bộ lạc man rợ lân cận. Với mỗi trò chơi, những câu chuyện sẽ được chia sẻ và các yếu tố chơi trò chơi mới được thêm vào. Chiến dịch có một hệ thống tự cân bằng thích ứng với mức độ bạn đang làm. Chiến dịch kết thúc khi bạn thắng hoặc thua bảy ván.', 'Sanpham/renegade-game-studios-legacy-of-yu-1.webp', 13),
('BG014', 'Earth', 50, 'Wargame & Strategy ', 18, 'Trải qua hàng triệu năm tiến hóa và thích nghi, hệ thực vật và động vật của hành tinh độc đáo này đã phát triển và phát triển thành những dạng sống tuyệt vời, tạo nên hệ sinh thái cộng sinh tuyệt đẹp và môi trường sống đa dạng. Đã đến lúc tạo hòn đảo của bạn: một hoạt cảnh 4x4 về tăng trưởng, mở rộng và cung cấp tự hỗ trợ, trong đó ngay cả những thẻ bạn không cần cũng trở thành phân trộn để đạt được trong tương lai. Earth là một công cụ xây dựng thế giới mở dành cho 1 đến 5 người chơi với các quy tắc đơn giản nhưng nhiều khả năng chiến lược.', 'Sanpham/inside-up-games-earth.jpg', 14),
('BG015', 'My Fathers Work', 125, 'Wargame & Strategy ', 7, 'Trong My Fathers Work, 2-4 người chơi đóng vai các nhà khoa học điên cạnh tranh nhau được giao một trang trong nhật ký của cha họ, cùng với một khu đất rộng lớn để thực hiện các thí nghiệm quỷ quyệt của họ. Người chơi kiếm điểm bằng cách hoàn thành Thử nghiệm, hỗ trợ Thị trấn trong nỗ lực của mình và hy vọng hoàn thành Công việc của Cha họ trong trò chơi tường thuật phân nhánh dựa trên ứng dụng này.', 'Sanpham/renegade-game-studios-my-fathers-work-1.png', 15),
('BG016', 'Twilight Imperium: Prophecy of Kings', 100, 'Wargame & Strategy ', 9, 'Lần đầu tiên sau nhiều năm, một lượng lớn nội dung mới đến với Twilight Imperium với bản mở rộng Prophecy of Kings, mang đến nội dung bổ sung cho gần như mọi phần của trò chơi. Hai người chơi bổ sung hiện có thể tham gia cuộc chiến thiên hà, nâng tổng số người chơi lên tám người. Với bảy phe phái chưa từng thấy và 40 hệ thống mới và các ô siêu tuyến, có nhiều thứ để chiến đấu hơn bao giờ hết.\r\n\r\nCác phe phái hiện có của trò chơi cũng có nhiều lợi ích từ Lời tiên tri của các vị vua với việc giới thiệu 74 thủ lĩnh và các đơn vị cơ giáp mới. Tiền giấy mới, di tích, thẻ khám phá, thẻ hành động, thẻ chương trình nghị sự, thẻ mục tiêu, v.v. khiến đây trở thành bản mở rộng không thể bỏ qua đối với bất kỳ người chơi Twilight Imperium nào.', 'Sanpham/fantasy-flight-games-twilight-imperium-prophecy-of.webp', 16),
('BG017', 'Abomination: The Heir of Frankenstein', 65, 'Wargame & Strategy ', 10, 'Đã hai mươi năm kể từ khi Victor Frankenstein chết trên một con tàu ở Bắc Cực, nhưng sinh vật đầy thù hận của anh ta vẫn sống, Robert Walton, thuyền trưởng hàng hải đã thề sẽ giết chết tên ác quỷ trước khi nhân từ buông tay. Bây giờ là năm 1819, và một bóng tối nham hiểm giáng xuống thành phố Paris. Một nhà hảo tâm bí ẩn có tầm vóc khổng lồ đã xuất hiện trong cộng đồng khoa học, không bao giờ lộ mặt, tuyên bố sở hữu nghiên cứu của Frankenstein quá cố. Anh ấy tài trợ cho một cuộc thi lớn, trao giải thưởng còn lớn hơn: giải mã bí ẩn về cái chết!\r\n\r\nCác nhà khoa học nổi tiếng từ khắp nơi trên thế giới đến tham gia: một số được yêu cầu giải câu đố muôn thuở này, những người khác bị ép buộc chống lại ý muốn của họ. Nhưng một thuyền trưởng nào đó cũng đến, một người hết sức nghi ngờ người bảo trợ bí mật, hy vọng cuối cùng sẽ thực hiện được lời thề của mình.\r\n\r\nAbomination: The Heir of Frankenstein là một trò chơi cạnh tranh xây dựng quái vật chiến lược dành cho 2-4 người chơi, lấy cảm hứng từ cuốn tiểu thuyết kinh dị kinh dị kiểu gothic của Mary Shelley. Trong trò chơi, sinh vật này cần sự giúp đỡ của bạn để hoàn thành điều mà người tạo ra nó không làm: mang đến sự sống cho một kẻ gớm ghiếc như chính nó, một người bạn đồng hành để chấm dứt sự cô độc khốn khổ của nó. Thông qua việc bố trí công nhân và quản lý cẩn thận các tài nguyên phân hủy, bạn sẽ thu thập tài liệu từ các nghĩa trang và nhà xác quanh thành phố, tiến hành nghiên cứu có giá trị tại Học viện Khoa học, thuê những cộng sự kém uy tín và làm việc cực nhọc trong phòng thí nghiệm của mình — tất cả chỉ trong một nỗ lực để tập hợp một dạng sống mới và truyền cho nó một \"\"tia sáng của sự tồn tại\"\". Làm tốt và sinh vật có thể thưởng cho bạn trong một trong những chuyến thăm bất ngờ của nó; làm kém, và bạn có thể hối hận vì đã không nỗ lực nhiều hơn. Các yếu tố tường thuật phát huy tác dụng trong suốt trò chơi, được hướng dẫn bởi các quyết định của bạn, dẫn đến những kết quả không mấy tốt đẹp.\r\n\r\nTrò chơi kết thúc khi bạn thành công trong việc đưa tác phẩm của mình vào cuộc sống hoặc khi Thuyền trưởng giết chết sinh vật đó, tùy theo điều kiện nào xảy ra trước. Sau đó, người chơi có nhiều điểm nhất sẽ hoàn thành di sản đen tối của Frankenstein, trở thành người thừa kế của ông ta, dù tốt hay xấu...', 'Sanpham/plaid-hat-games-abomination-the-heir-of-frankenste.jpg', 17),
('BG018', 'Mille Fiori', 50, 'Wargame & Strategy ', 21, 'Giúp làm nên lịch sử, chế tạo đồ thủy tinh, buôn bán và đảm bảo sự hỗ trợ của cư dân vùng đầm phá. Tìm hiểu những bí mật của việc chế tạo thủy tinh và tìm ra sự kết hợp thành công nhất giữa chiến lược và chiến thuật để làm nên vận may của bạn với tư cách là nhà sản xuất thủy tinh nổi tiếng nhất của vùng đầm phá.', 'Sanpham/devir-americas-mille-fiori.jpg', 18),
('BG019', 'Transformers Deck-Building Game', 45, 'Deckbuilders', 22, 'Chuyển đổi và triển khai!\r\n\r\nAutobots là những chiến binh robot dũng cảm đến từ hành tinh Cybertron. Nhiệm vụ của họ? Để ngăn chặn Decepticons thực hiện các âm mưu xấu xa của chúng trên Trái đất.\r\n\r\nTrong trò chơi xây dựng boong tàu này, bạn sẽ đảm nhận vai trò của một trong những Autobot hùng mạnh. Du hành và khám phá Ma trận và chuyển đổi giữa các chế độ khác nhau của bạn khi bạn có được đồng minh, tìm di tích và có được công nghệ để chiến đấu với Decepticons. Nhưng được cảnh báo! Khi bộ bài của bạn phát triển, các Decepticons mạnh hơn sẽ xuất hiện để thách thức bạn.\r\n\r\nTrò chơi Xây dựng Bộ bài Transformers có thể được chơi một cách cạnh tranh hoặc dưới dạng một trải nghiệm hợp tác. Bộ lõi này sẽ bắt đầu bộ sưu tập của bạn với mọi thứ cần thiết để chơi, nhưng trận chiến còn lâu mới kết thúc vì Decepticons có thể chơi được đang trên đường mở rộng trò chơi của bạn.', 'Sanpham/renegade-game-studios-transformers-deck-building-g-1.webp', 19),
('BG020', 'Epic Spell Wars of the Battle Wizards: Rumble at Castle Tentakill', 35, 'Deckbuilders', 19, 'Kẻ ngủ quên đã thức tỉnh! Epic Spell Wars of the Battle Wizards: Rumble at Castle Tentakill cuối cùng đã xuất hiện và nó chứa đầy những cách hoàn toàn mới để mang đến cái chết như khói cho tất cả những kẻ chống lại bạn. Trò chơi độc lập này cũng tương thích 100% với trò chơi gốc, cho phép người chơi biến một trò chơi vốn đã hoành tráng thành một trò chơi EPIC. Epic Spell Wars tiếp tục nhiệm vụ hoành tráng của nó sau khi phát sóng trên TableTop trên Geek and Sundry! Với thiết kế trò chơi và nghệ thuật hoàn toàn mới từ nhóm sáng tạo ban đầu gồm Cory Jones, Rob Heinsoo và Nick Edwards.', 'Sanpham/cryptozoic-entertainment-epic-spell-wars-of-the-ba.webp', 20),
('BG021', 'G.I. JOE Deck-Building Game', 45, 'Deckbuilders', 16, 'Rơi vào! Tổ chức độc ác Cobra đe dọa thế giới bằng những âm mưu của chúng và bạn phải ngăn chặn chúng!\r\n\r\nTrong trò chơi Xây dựng boong tàu này, bạn và những người chơi khác sẽ lãnh đạo các đội G.I. Những người lính Joe làm nhiệm vụ ngăn chặn kế hoạch đê tiện của Cobra! Mỗi người chơi bắt đầu trò chơi với một bộ bài ít ỏi sẽ trở nên mạnh mẽ hơn khi bạn chiêu mộ các cựu chiến binh từ G.I. Đội Joe, thiết bị trưng dụng và phương tiện mới. Trò chơi hợp tác hoàn toàn này giúp bạn chống lại các nhiệm vụ ngày càng nguy hiểm để cứu thế giới. Bộ cốt lõi này bắt đầu hành trình của bạn với mọi thứ cần thiết để chơi, nhưng hãy chuẩn bị cho nhiều Joes và nhiệm vụ sắp tới!', 'Sanpham/renegade-game-studios-gi-joe-deck-building-game.jpg', 21),
('BG022', 'AGOT LCG 2nd Ed: For Family Honor', 15, 'Living Card Games ', 22, 'Vì danh dự gia đình là Gói chương thứ hai trong chu kỳ Cuộc chiến năm vị vua cho A Game of Thrones: The Card Game. Xuyên suốt Gói Chương này, bạn sẽ tìm thấy rất nhiều thẻ bài mới hỗ trợ các chủ đề chính của chu kỳ khi bạn tiếp tục theo dõi cốt truyện của A Clash of Kings. New Kings and Crowns mời bạn đặt cược yêu sách của riêng bạn đối với Iron Throne, ngay cả khi các lá bài khác nâng cao tầm quan trọng của các lá bài trung thành—những nhân vật mà bạn có thể thực sự tin tưởng, những địa điểm sẽ không bao giờ thất thủ, những sự kiện và chiến thuật mà bạn hoàn toàn kiểm soát. Cuối cùng, For Family Honor giới thiệu các nhân vật mang tính biểu tượng tham gia trò chơi, bao gồm Ser Edmure Tully, phiên bản House Tyrell của Renly Baratheon và Hot Pie.', 'Sanpham/fantasy-flight-games-agot-lcg-2nd-ed-for-family-ho.png', 22),
('BG023', 'Arkham Horror: The Card Game - Fortune and Folly Scenario Pack', 25, 'Living Card Games ', 18, 'Một sòng bạc ở Monte Carlo đang vận may theo hướng có lợi cho mình, thu được khối tài sản khổng lồ nhưng cũng gây nguy hiểm cho những khách hàng quen của nó. Bạn và các điều tra viên đồng nghiệp của mình phải đánh cắp nguồn sức mạnh của sòng bạc và ngăn chặn công việc bất chính của họ, nhưng làm như vậy sẽ không phải là nhiệm vụ dễ dàng. Vận may sẽ ủng hộ những người táo bạo? Hay may mắn của bạn sẽ hết?\r\n\r\nTrong Fortune and Folly, một đến bốn điều tra viên lên kế hoạch và thực hiện một vụ trộm sòng bạc táo bạo. Mục tiêu của họ: Wellspring of Fortune, một di tích bí ẩn cho phép sòng bạc sắp xếp các tỷ lệ cược có lợi cho nó (theo nghĩa đen). Là một gói kịch bản, Fortune and Folly có thể được chơi độc lập hoặc được đưa vào chiến dịch dưới dạng câu chuyện phụ. Nó thậm chí còn có một vài tính năng bổ sung nếu được sử dụng như một câu chuyện phụ trong chiến dịch The Scarlet Keys!\r\n\r\nNgười chơi chỉ cần một bản sao của Arkham Horror: The Card Game Revised Core Set để đi sâu vào kịch bản. Kiểm tra vận may của bạn và xem vận may có ủng hộ bạn không nhé!', 'Sanpham/fantasy-flight-games-arkham-horror-the-card-game-f.jpg', 23),
('BG024', 'Marvel Champions LCG: Scarlet Witch Hero Pack', 20, 'Living Card Games ', 14, 'Lạc lối và lang thang khắp châu Âu trong nhiều năm cùng anh trai Pietro, Wanda Maximoff không biết nhiều về sức mạnh bí ẩn được trao cho mình—cho đến khi cô giải phóng phép thuật hỗn loạn làm biến dạng thực tại của mình để bảo vệ những người vô tội. Bây giờ trong lốt Scarlet Witch, Wanda đã gia nhập Avengers, chiến đấu bên cạnh anh trai mình!\r\n\r\nGiống như các Gói Anh hùng trước đây, Gói Anh hùng Scarlet Witch dành cho Marvel Champions: The Card Game mở ra một anh hùng hoàn toàn mới cho các trò chơi của bạn, đi kèm với bộ bài Công lý 40 lá được xây dựng sẵn và sẵn sàng để chơi. Bên cạnh bộ bài tạo sẵn này, bạn sẽ tìm thấy nhiều loại thẻ dành cho các khía cạnh khác của trò chơi, cung cấp cho bạn nhiều tùy chọn để điều chỉnh bộ bài Scarlet Witch hoặc thay đổi bất kỳ bộ bài nào khác trong bộ sưu tập của bạn. Chuẩn bị cho thực tế xoắn và uốn cong xung quanh bạn với Hero Pack mới này!', 'Sanpham/fantasy-flight-games-marvel-champions-lcg-scarlet.jpg', 24),
('BG025', 'Marvel Champions LCG: Vision Hero Pack', 20, 'Living Card Games ', 13, 'Là người máy cuối cùng, Vision bay vào Marvel Champions trong gói mở rộng này, giới thiệu anh ta như một anh hùng hoàn toàn mới, cùng với 15 thẻ chữ ký của anh ta. Vision được đóng gói với bộ bài Bảo vệ dựng sẵn sẵn sàng chơi ngay từ khi bạn mở hộp. Lối chơi của anh ấy xoay quanh cơ chế điều khiển mật độ độc đáo của anh ấy, điều này khiến anh ấy trở thành một anh hùng chiến lược với độ bền ấn tượng.', 'Sanpham/fantasy-flight-games-marvel-champions-lcg-vision-h.jpg', 25),
('BG026', 'Marvel Champions: Rogue Hero Pack', 20, 'Living Card Games ', 12, 'Bị nguyền rủa với khả năng không thể kiểm soát khiến cô hấp thụ sức mạnh và ký ức của bất kỳ ai cô chạm vào, Anna Marie bỏ nhà đi khi còn là một thiếu niên. Giáo sư X đã đề nghị cho cô một suất tại trường của ông, nơi cô có thể học cách kiểm soát sức mạnh của mình. Bây giờ cô ấy chiến đấu vì công lý với tư cách là một thành viên của X-Men, Rogue, và cô ấy đang lẻn vào các trò chơi Marvel Champions: The Card Game của bạn! Bằng cách gắn bản nâng cấp Touched độc đáo của mình với các nhân vật khác, Rogue có thể nhận được nhiều loại khả năng, bao gồm cả việc mượn sức mạnh từ các anh hùng đồng nghiệp của mình. Với Gói anh hùng này, bạn sẽ tìm thấy Rogue, mười sáu thẻ chữ ký của cô ấy và đủ loại thẻ Bảo vệ mời bạn bảo vệ đồng minh của mình khỏi bị tổn hại. Gói này cũng bao gồm một bộ cuộc gặp gỡ mô-đun bổ sung có Reavers được tăng cường điều khiển học!\r\n\r\nĐối với những người chơi muốn thách đấu với Magneto và Brotherhood of Mutants của anh ta, họ có thể bắt đầu với Rogue Hero Pack! Bản mở rộng này đi kèm với bộ bài dựng sẵn gồm 40 quân bài, giúp người chơi có cơ hội bắt đầu chơi ngay lập tức', 'Sanpham/fantasy-flight-games-marvel-champions-rogue-hero-p.webp', 26),
('BG027', 'Carcassonne Exp 6: Count, King & Robber', 22, 'Family', 11, 'Bản mở rộng lớn thứ sáu cho Carcassonne được phát hành ở Châu Âu bởi Hans im Glück thực sự là một bản tổng hợp của ba bản mở rộng nhỏ hiện có và một bản mở rộng mới. Trước khi Z-Man Games lấy giấy phép Carcassonne, phần tổng hợp này chỉ có sẵn ở Hoa Kỳ từ Rio Grande Games như một phần của Big Box 2 hoặc từng bản mở rộng nhỏ có sẵn riêng lẻ.', 'Sanpham/z-man-games-carcassonne-exp-6-count-king-robber-1.jpg', 27),
('BG028', 'D&D: Bedlam in Neverwinter', 50, 'Family', 16, 'Tham gia cùng một nhóm các nhà thám hiểm điều tra hàng loạt vụ mất tích đáng báo động ở Icewind Dale trong trò chơi giải thoát D&D một lần dành cho 2-6 người chơi này.\r\n\r\nCuộc phiêu lưu gồm 3 phần khó khăn này có thể được chia thành 3 phiên trò chơi hoặc chơi trong 1 lần ngồi anh hùng. Bắt đầu bằng cách tạo nhân vật của bạn. Sau đó khám phá một quán rượu khiêm tốn, chiến đấu trong những trận chiến hoành tráng chống lại những con quái vật D&D mang tính biểu tượng, và tham gia vào một cuộc rượt đuổi hoang dã xuyên qua Underdark theo đuôi của một pháp sư độc ác và giáo phái nguy hiểm của hắn để làm sáng tỏ bí ẩn về kế hoạch tồi tệ của chúng.\r\n\r\nCách duy nhất để tìm những người mất tích và thoát khỏi các chướng ngại vật là khám phá các căn phòng, hoàn thành các câu đố và thu thập manh mối để giải quyết bí ẩn ở cuối mỗi hành động.', 'Sanpham/hasbro-d-d-bedlam-in-neverwinter.jpg', 28),
('BG029', 'Nimalia', 22, 'Family', 24, 'Thiết kế Khu bảo tồn Động vật tốt nhất khi chơi 5 vòng.\r\n\r\nMỗi vòng, người chơi sẽ rút 3 lá bài, đặt một lá bài và chuyển phần còn lại (giai đoạn rút bài đơn giản). Mỗi thẻ bao gồm 4 quần xã, mỗi quần xã chứa một loài động vật. Khi bạn đặt một thẻ, bạn phải phủ ÍT NHẤT một quần xã. Toàn bộ Thánh địa không được vượt quá 6 x 6.\r\n\r\nMỗi trò chơi sẽ có một nhóm mục tiêu ghi điểm khác nhau. Mỗi vòng sẽ chỉ tính một số mục tiêu được chọn cho trò chơi, vì vậy bạn sẽ phải sửa đổi khu bảo tồn của mình trong suốt trò chơi để ghi được nhiều điểm nhất.\r\n\r\nKhi kết thúc 5 vòng, người chơi kiếm được nhiều điểm hơn sẽ trở thành người chiến thắng!', 'Sanpham/lucky-duck-games-nimalia.webp', 29),
('BG030', 'Dorfromantik: The Board Game', 45, 'Family', 26, 'Những dòng sông gợn sóng, những cánh rừng xào xạc, những cánh đồng lúa mì đung đưa trong gió và đây đó một ngôi làng nhỏ dễ thương - đó chính là Dorfromantik! Trò chơi điện tử của studio phát triển nhỏ Toukana Interactive đã gây xúc động cho cộng đồng game thủ kể từ khi ra mắt Early Access vào tháng 3 năm 2021 và đã giành được đủ loại giải thưởng danh giá. Giờ đây, Michael Palm và Lukas Zach đang biến trò chơi giải đố và chiến lược xây dựng phổ biến thành một trò chơi gia đình dành cho người già và trẻ với Dorfromantik: The Board Game.\r\n\r\nTrong Dorfromantik: The Board Game, tối đa sáu người chơi cùng nhau xếp các ô hình lục giác để tạo cảnh quan đẹp mắt và cố gắng thực hiện mệnh lệnh của dân chúng, đồng thời xếp một con đường dài và một dòng sông càng dài càng tốt, mà còn tính đến các cờ cung cấp điểm trong các khu vực kèm theo. Người chơi quản lý để làm điều này càng tốt, họ càng có thể ghi được nhiều điểm hơn khi kết thúc. Trong quá trình diễn ra chiến dịch có thể chơi lại, số điểm kiếm được có thể được sử dụng để mở khóa các ô mới được ẩn trong các hộp bị khóa ban đầu. Những nhiệm vụ này đặt ra những nhiệm vụ mới, bổ sung cho người chơi và giúp nâng cao điểm số ngày càng cao.', 'Sanpham/pegasus-spiele-dorfromantik-the-board-game.jpg', 30),
('BG031', 'Hive Classic', 45, 'Chess ', 14, 'Hive là một trò chơi chiến lược dành cho hai người chơi không bị giới hạn bởi bàn cờ và có thể chơi ở mọi nơi trên mọi bề mặt phẳng. Tổ ong được tạo thành từ 22 mảnh, 11 mảnh màu đen và 11 mảnh màu trắng, giống như nhiều loại sinh vật khác nhau, mỗi mảnh có cách di chuyển độc đáo.\r\n\r\nKhông cần thiết lập, trò chơi bắt đầu khi mảnh đầu tiên được đặt xuống. Khi các quân cờ tiếp theo được đặt, điều này tạo thành một mô hình trở thành bề mặt chơi (bản thân các quân cờ trở thành bàn cờ). Không giống như các trò chơi tương tự khác, các quân cờ không bao giờ bị loại bỏ và không phải chơi tất cả. Mục tiêu của trò chơi là bao vây hoàn toàn quân hậu của đối thủ, đồng thời cố gắng ngăn cản đối thủ làm điều tương tự với quân hậu của bạn. Người chơi bao vây hoàn toàn nữ hoàng của đối thủ sẽ thắng trò chơi.', 'Sanpham/gen-42-hive-.webp', 31),
('BG032', 'Chess: Luxury Version', 65, 'Chess ', 17, 'Bộ Cờ Tướng Cao Cấp là bộ cờ vua hoàn toàn bằng gỗ cao cấp. Nó có một bảng gỗ hoàn thiện đẹp mắt và các quân cờ bằng gỗ có đáy nhung để bảo vệ bảng và mang lại trải nghiệm chơi thú vị.', 'Sanpham/asmodee-chess-luxury-version.webp', 32),
('BG033', 'Chessplus', 35, 'Chess ', 19, 'Chessplus, – Đó không phải là cờ vua. Thế tốt hơn rồi!\r\nKết hợp & Chinh phục.\r\nBắt đầu kết hợp ngay từ nước đi đầu tiên của bạn - di chuyển Tượng trên đường chéo lên Tốt. Quân cờ kết hợp mới (Biawn) giờ đây có thể di chuyển dưới dạng Tượng hoặc Tốt, hoặc nó có thể tách ra bằng cách di chuyển một trong hai quân cờ ra xa riêng lẻ.\r\nBạn có thích thăng quân Tốt lên quân Hậu không? Hãy nhanh chóng theo dõi quân Tốt của bạn sang phía bên kia của bàn cờ bằng cách sử dụng Xe hoặc Tượng và WHAM bạn có thêm một QUEEN trên bàn cờ. Nhưng hãy coi chừng nếu bạn mất một quân cờ Kết hợp, bạn sẽ mất hai quân cờ tiêu chuẩn BANG!\r\nKết hợp quân Hậu và quân Mã (Quight) để có quân TỔN THƯƠNG - Quân Hậu THẬT trên chiến mã của mình đang chiến đấu trên bàn cờ, bất cứ lúc nào cô ấy có thể nhảy trở lại bàn cờ để giao chiến với quân Hậu.\r\nMột trận chiến thời TRUNG cổ thực sự với quân Tốt CƯỠI NGỰA như KỶ SĨ THẬT và BẮN MŨI TÊN từ các tòa tháp (Xe), và quân Hậu DẪN ĐẦU CHI PHÍ trên những chiến mã dũng mãnh của họ.\r\nCác trò chơi Chessplus nhanh hơn, có nhiều nước đi bất ngờ và nhiều hơn theo cấp số nhân, tất cả các chiến lược mới (sẽ được khám phá) và cách chơi dễ dàng hơn khi so sánh với Cờ vua.\r\nTrò chơi bảng chiến lược mới dựa trên Cờ vua nơi người chơi có thể KẾT HỢP và TÁCH các quân cờ của họ. Học trong 20 giây để tận hưởng niềm vui và thử thách trọn đời.', 'Sanpham/chessplus-chessplus.jpg', 33),
('BG034', 'Chess and Checkers: Folding Version', 45, 'Chess ', 20, 'Hai trò chơi cổ điển trong một gói được sản xuất đẹp mắt! Bộ cờ vua và cờ đam hoàn toàn bằng gỗ này mang đến cho người chơi trải nghiệm chơi cao cấp cho cả cờ vua và cờ đam. Tất cả các quân cờ của trò chơi đều bằng gỗ và phần đáy rỗng của ván gỗ cho phép nó gập lại một nửa để cất giữ, đồng thời tạo ra một hộp gỗ để đựng các quân cờ của trò chơi. Cũng bao gồm túi kraft để giữ các mảnh.', 'Sanpham/61zmEca6lL._AC_SY300_SX300_.jpg', 34),
('BG035', 'Onitama Light & Shadow', 22, 'Chess ', 26, 'Bản mở rộng thứ ba cho Onitama, Light and Shadow mang đến một cách mới để khám phá trò chơi chiến thuật võ thuật đơn giản và tao nhã bằng cách giới thiệu một loại quân tốt mới: Ninja! Không giống như những con tốt khác, Ninja di chuyển bí mật, ẩn khỏi tầm nhìn của đối thủ cho đến khi họ sẵn sàng tấn công...\r\n\r\nCó hai cách để chơi Ánh sáng và Bóng tối:\r\n\r\n- Way of the Shadow là một trò chơi đối xứng, trong đó mỗi người chơi triển khai Ninja của riêng mình.\r\n\r\n- Way of the Light là một trò chơi bất đối xứng, trong đó một người chơi Ninja đấu với một người chơi Onitama Master và Học sinh truyền thống.', 'Sanpham/pic6946703.webp', 35),
('BG036', 'Railroad Ink: Blazing Red', 27, 'Dice Games ', 21, 'Trong trò chơi giải đố nhiều người chơi Railroad Ink, mục tiêu của bạn là kết nối càng nhiều lối thoát hiểm trên bảng càng tốt. Mỗi vòng, một bộ xúc xắc được tung ra ở giữa bàn, xác định loại đường bộ và đường sắt nào dành cho tất cả người chơi. Bạn phải vẽ các tuyến đường này trên bảng có thể xóa được của mình để tạo các tuyến giao thông và kết nối các lối ra của mình, cố gắng tối ưu hóa các biểu tượng có sẵn tốt hơn đối thủ của bạn.\r\n\r\nBạn kết nối càng nhiều lối thoát, bạn càng ghi được nhiều điểm vào cuối trò chơi, nhưng bạn sẽ mất điểm cho mỗi tuyến đường chưa hoàn thành, vì vậy hãy lên kế hoạch cẩn thận! Bạn sẽ tận dụng vận may của mình và cố gắng mở rộng mạng lưới giao thông của mình đến lối ra tiếp theo hay bạn sẽ chơi an toàn và bắt đầu một tuyến đường mới, đơn giản hơn để quản lý?\r\n\r\nRailroad Ink có hai phiên bản, mỗi phiên bản bao gồm hai bản mở rộng với các bộ xúc xắc bổ sung bổ sung các quy tắc đặc biệt cho trò chơi của bạn. Phiên bản Blazing Red bao gồm các bản mở rộng Lava và Meteor. Cố gắng hạn chế dung nham đến từ núi lửa đang phun trào trước khi nó phá hủy các tuyến đường của bạn, hoặc đối phó với sự tàn phá do các cuộc tấn công của thiên thạch và khai thác các miệng núi lửa để lấy quặng quý. Những quy tắc đặc biệt này có thể thêm gia vị cho mọi thứ và làm cho mỗi trò chơi chơi và cảm thấy khác nhau.\r\n\r\nMỗi hộp cho phép bạn chơi từ 1 đến 6 người chơi và nếu bạn kết hợp nhiều hộp hơn, bạn có thể chơi với tối đa 12 người chơi (hoặc hơn). Giới hạn duy nhất về số lượng người chơi là số lượng bảng bạn có!', 'Sanpham/luma-imports-railroad-ink-blazing-red.jpg', 36),
('BG037', 'Railroad Ink: Challenge: Shining Yellow', 27, 'Dice Games ', 18, 'Railroad Ink Challenge là một trò chơi cuộn và viết nhanh dành cho 1 đến 4 người chơi. Hãy lấy một tấm bảng và một cây bút lông có thể tẩy được, và sẵn sàng để đạt đến đỉnh cao của mạng lưới kết nối! Tung xúc xắc và vẽ các tuyến đường để kết nối các lối thoát xung quanh bàn cờ của bạn. Mở rộng mạng lưới của bạn với đường sắt, đường cao tốc và nhà ga để thu thập điểm, nhưng bạn sẽ bị phạt vì bất kỳ kết nối mở nào, vì vậy hãy lên kế hoạch cẩn thận!\r\n\r\nRailroad Ink Challenge có mọi thứ bạn yêu thích từ các trò chơi Railroad Ink ban đầu và hơn thế nữa, với trọng tâm hoàn toàn mới là tương tác với người chơi nhờ các mục tiêu trong trò chơi! Chỉ những người đạt được chúng trước mới nhận được phần thưởng, vì vậy bạn phải theo dõi xem đối thủ của mình đang làm gì và cố gắng hoàn thành mục tiêu trước khi họ làm! Mỗi lần có một bộ mục tiêu khác nhau, vì vậy sẽ không có hai trò chơi nào giống nhau!\r\n\r\nNhưng xin chờ chút nữa! Vẽ các cấu hình tuyến đường uốn cong tâm trí chưa từng có nhờ xúc xắc mới! Kết nối các cấu trúc đặc biệt với mạng của bạn để kích hoạt các hiệu ứng mới: các nhà máy cho phép bạn nhân đôi một con súc sắc, các ngôi làng cho điểm thưởng nếu họ ở gần nhà ga, các trường đại học mở khóa thêm các tuyến đường đặc biệt — hãy sử dụng các hiệu ứng này một cách khôn ngoan và bạn sẽ ghi điểm lớn!\r\n\r\nRailroad Ink Challenge có hai phiên bản, mỗi phiên bản bao gồm một bản mở rộng với một bộ xúc xắc bổ sung bổ sung các quy tắc đặc biệt mới cho trò chơi của bạn. Sử dụng ốc đảo để bảo vệ cây xương rồng của bạn khỏi khí hậu sa mạc khô cằn trong Shining Yellow Edition!', 'Sanpham/horrible-guild-game-studios-railroad-ink-challenge.jpg', 37),
('BG038', 'High Score', 15, 'Dice Games ', 16, 'High Score là một trò chơi xúc xắc khéo léo với những thử thách độc đáo. Việc lật một thẻ thử thách mới sẽ cho người chơi biết cách ghi điểm trong vòng này và cách bạn có thể gieo lại xúc xắc của mình. Liệu số chẵn có bị 0 điểm vòng này? Vòng xoáy này sẽ có tác dụng gì?\r\n\r\nSau khi người chơi đầu tiên kết thúc lượt của mình, những người chơi khác có thể cố gắng đánh bại số điểm của họ, nhưng mạo hiểm quá nhiều và bạn có thể ra về tay trắng. Ai có nhiều điểm nhất sau bảy vòng sẽ thắng.', 'Sanpham/thames-kosmos-high-score.jpg', 38),
('BG039', 'Sakura Heroes', 25, 'Dice Games ', 13, 'Ai sẽ làm chủ những thử thách của ngọn núi ma thuật?\r\n\r\nTrong Sakura Heroes, bạn phải đối mặt với các nhiệm vụ xúc xắc ngày càng trở nên khó khăn hơn khi bạn tiến lên. Thu thập hoa và bùa may mắn để hoàn thành các thử thách. Mọi người tung xúc xắc của mình cùng một lúc và cố gắng lấy đúng biểu tượng bằng xúc xắc của mình càng nhanh càng tốt để tiến lên cấp độ tiếp theo. Thu thập những viên kim cương có giá trị nhất trên đường lên đỉnh ngọn núi ma thuật để đăng quang người chiến thắng anh hùng!', 'Sanpham/ravensburger-sakura-heroes.jpg', 39),
('BG040', 'Pinata Blast', 15, 'Dice Games ', 18, 'Mỗi vòng trong Piñata Blast, một người nào đó thả xúc xắc, sau đó mọi người cố gắng lấy viên xúc xắc phù hợp với quân bài của mình trước, đồng thời không lấy kẹo thối. Kiếm được nhiều điểm nhất để giành chiến thắng!', 'Sanpham/ravensburger-pinata-blast.jpg', 40),
('BG041', 'Drawn to Adventure', 30, 'Dice Games ', 19, 'Trong Drawn to Adventure, bạn và tối đa ba nhà thám hiểm khác sẽ bắt đầu một cuộc hành trình hoành tráng qua Năm cõi, nơi bạn có thể sử dụng các kỹ năng và khả năng của mình để tiêu diệt quái vật và hoàn thành các nhiệm vụ. Bạn sẽ có cơ hội kiếm được nhiều phần thưởng, chẳng hạn như mana để kích hoạt sức mạnh đặc biệt; kinh nghiệm để tăng cấp cho nhân vật của bạn; và—tất nhiên—kho báu huy hoàng!\r\n\r\nDrawn to Adventure là một trò chơi cuộn và viết dựa trên chiến dịch. Mỗi người chơi sử dụng một cuốn sách lật khô có chứa sáu bản đồ lưới lục giác khác nhau. Các chiến dịch được chơi trên ba trong số sáu bản đồ. Sau khi bản đồ thứ ba kết thúc, người chơi có nhiều kho báu nhất sẽ thắng. Vì vậy, hãy lấy cây bút mạnh mẽ của bạn và đi cùng; danh vọng và vận may đang chờ đợi những người thực sự bị cuốn hút vào cuộc phiêu lưu!', 'Sanpham/final-frontier-games-drawn-to-adventure.jpg', 41),
('BG042', 'Twilight Inscription', 70, 'Dice Games ', 15, 'Đế chế Lazax đã bị đốt cháy thành tro bụi, bị các đối tượng của nó chối bỏ. Hậu quả là bi kịch và xung đột nhỏ, một thời gian mất mát và kiệt sức. Trong Những năm đen tối sau đó, các phe phái của thiên hà đã rút lui và phục hồi sức mạnh của họ. Giờ đây, họ nhìn lên những vì sao và nhìn thấy một cơ hội—một cơ hội để lấy lại những gì đã mất. Một cơ hội để xác định lại nền văn minh thiên hà. Một cơ hội để lại dấu ấn của họ trên các vì sao.\r\n\r\nTwilight Inscription, một trò chơi cuộn và viết hoành tráng dành cho một đến tám người chơi, mang đến trải nghiệm không giống bất kỳ trò chơi Fantasy Flight nào đã từng làm trước đây. Với nguồn tài nguyên hạn chế tùy ý sử dụng, bạn sẽ cần quản lý cẩn thận Điều hướng, Mở rộng, Công nghiệp và Chiến tranh khi bạn tích lũy điểm chiến thắng và giành quyền lên ngôi trên Mecatol Rex. Phe của bạn sẽ trở thành những người cai trị mới của thiên hà? Hay đế chế non trẻ của bạn sẽ chìm vào quên lãng? Bất cứ điều gì cũng có thể xảy ra trong trò chơi chiến lược, có thể chơi lại vô tận này!', 'Sanpham/fantasy-flight-games-twilight-inscription.jpg', 42),
('BG043', 'Spot It! Disney Princess', 20, 'Card Games ', 10, 'Phát hiện nó! Là một trò chơi quan sát và phản xạ nhanh chóng cho tất cả! Luôn luôn chỉ có 1 biểu tượng phù hợp giữa 2 thẻ! Phát hiện nó đầu tiên và bạn giành chiến thắng! Phát hiện nó! Có 5 cách chơi khác nhau và phiên bản spot này có các biểu tượng, vật phẩm và nhân vật cổ điển liên quan đến các Công chúa Disney được yêu mến.', 'Sanpham/zygomatic-spot-it-disney-princess.jpg', 43),
('BG044', 'Smash Up: Big in Japan', 25, 'Card Games ', 12, 'Smash Up: Big in Japan mang đến màn đập phá cơ sở dễ thương nhất mà bạn từng thấy ở Smash Up, với bốn phe phái được sinh ra từ văn hóa đại chúng Nhật Bản: các cô gái chiến đấu trong anime, những sinh vật sưu tập dễ thương hoàn toàn không phải Pokémon, những chiến binh đầy màu sắc không phải là cách Power Rangers và Godzilla.', 'Sanpham/aeg-smash-up-big-in-japan.jpg', 44),
('BG045', 'Munchkin Apocalypse 2 Sheep Impact Game', 20, 'Card Games ', 13, 'Đó là sự kết thúc của thế giới ... một lần nữa. Munchkin Apocalypse 2: Sheep Impact là bản mở rộng gồm 106 lá bài cho Munchkin Apocalypse. Giờ đây, bạn có thể trang bị cho người sống sót cứng cỏi của mình với \"Rìu ái quốc\" và \"Khí sốt cà chua\" để đối đầu với \"Đế chế tan băng\"! Hãy tự bảo vệ mình bằng \"Bom Suit\" và \"Sổ tay sinh tồn\", nếu không \"Phương tiện chống đối xã hội\" sẽ kết liễu bạn sớm! Coi chừng \"Thảm họa! Velocirapture!\" và những Phong ấn mới đáng sợ như \"The Singularity\"! Chơi một Lớp mới - Daredevil - và coi thường hiểm họa tận thế!', 'Sanpham/steve-jackson-games-munchkin-apocalypse-2-sheep-im.jpg', 45),
('BG046', 'The Red Dragon Inn 7: The Tavern Crew', 40, 'Card Games ', 21, 'Tất cả các anh hùng (cuối cùng) đã xuất hiện trong đêm, vì vậy đã đến lúc quay trở lại với một cốc bia, một nắm xúc xắc và những chiếc túi lót bằng vàng của các nhà thám hiểm! Wench tham gia bữa tiệc tại The Red Dragon Inn và cô ấy mang theo những người còn lại trong nhóm quán rượu - Jasper the Bouncer, Molly the Stablehand và Warthorn Redbeard - cùng với cô ấy!\r\n\r\nRed Dragon Inn 7 là một bản mở rộng độc lập mới dành cho 2-4 người chơi cho loạt trò chơi The Red Dragon Inn. Trong trò chơi này, bạn và tối đa ba người bạn của mình sẽ vào vai nhân viên của quán rượu thân yêu của chúng ta, tận hưởng buổi tối sau khi tất cả những vị khách quen trong cuộc phiêu lưu đã bất tỉnh trong phòng (hoặc chuồng) của họ. Tất nhiên đây sẽ không phải là một đêm thư giãn yên tĩnh! Đánh bạc, ẩu đả và uống rượu suốt đêm khi bạn chứng minh rằng bạn có những gì cần thiết để theo kịp những anh hùng mà bạn xử lý đêm này qua đêm khác. Red Dragon Inn 7 có thể được kết hợp với tất cả các phiên bản trước của chúng tôi, cho phép bạn kết hợp các nhân vật (và tình trạng lộn xộn) cho các trò chơi có bốn người chơi trở lên!', 'Sanpham/slugfest-games-the-red-dragon-inn-7-the-tavern-cre.jpg', 46),
('BG047', 'Munchkin Russia', 35, 'Card Games ', 26, 'Chào mừng bạn đến với Munchkin Russia, nơi những câu chuyện cười đưa bạn đến! Chiến đấu với Troll Factory, KGBirds, Rasputin hoặc Hangover đáng sợ với Chó săn Nga và Balalaika bên cạnh bạn. Khi bạn giành chiến lợi phẩm và trở thành Hacker, Oligarch, Vận động viên hoặc Cossak trên đường lên Cấp 10, hãy coi chừng Cuộc cách mạng và nỗi kinh hoàng của Ca sĩ Eurovision. Và hãy chắc chắn để thưởng thức các mùa đẹp: xuân, hạ, thu, đông, đông, đông ...', 'Sanpham/steve-jackson-games-munchkin-russia.jpg', 47),
('BG048', 'The Red Dragon Inn 8: The Pub Crawl', 40, 'Card Games ', 27, 'Một bản mở rộng độc lập mới cho sê-ri từng đoạt giải thưởng! Những anh hùng lừng lẫy của chúng ta đã dành nhiều giờ đồng hồ (và rất nhiều xu!) tại quán rượu huyền thoại của Greyport, Red Dragon Inn. Nhưng ngay cả những khách hàng trung thành nhất thỉnh thoảng cũng muốn thay đổi khung cảnh... Vậy các anh hùng của chúng ta sẽ làm gì khi bốn bức tường quán rượu giống nhau đang trở nên hơi buồn tẻ? Thu thập quán rượu!\r\n\r\nRed Dragon Inn 8 giới thiệu năm nhân vật mới — chủ sở hữu của năm quán rượu hoàn toàn mới, cộng với một biến thể chơi mới nơi người chơi có thể đi vòng quanh nhiều quán rượu thay vì ở lại Red Dragon Inn.', 'Sanpham/slugfest-games-the-red-dragon-inn-8-the-pub-crawl-1.webp', 48),
('BG049', 'Good Omens: An Ineffable Game', 25, 'Card Games ', 18, 'Chào mừng đến với Tadfield! Các lực lượng của lời tiên tri, Thiên đường và Địa ngục đã tập hợp lại để bắt đầu Ha-ma-ghê-đôn. Các thiên thần và ác quỷ đang chuẩn bị cho trận chiến và chỉ có một nhóm kẻ gian dũng cảm mới có thể ngăn chặn nó. Đó là nơi bạn đến. Trong trò chơi này, bạn sẽ tìm thấy một số trò chơi xúc xắc và bài khác nhau có chủ đề xoay quanh các cuộc đối đầu diễn ra trong chương cuối cùng (hiện tại) của câu chuyện Good Omens. Nhiều trò chơi có sự kết hợp giữa xúc xắc và thẻ. Tại sao thẻ? Bởi vì các lá bài có trong bộ truyện và trong đặc tính của Good Omens. Toàn bộ sự tồn tại này giống như một trò chơi lớn đối với những người giật dây…', 'Sanpham/renegade-game-studios-good-omens-an-ineffable-game.webp', 49),
('BG050', 'Final Girl: A Knock at the Door', 20, 'Card Games ', 15, 'Hộp phim Cô gái cuối cùng\r\n\r\nKhông có gì giống như một cuộc hội ngộ tại Wingard Cottage yên tĩnh và tách biệt. Mọi người đang có một thời gian tuyệt vời. Rượu đang chảy và bữa tiệc đã bắt đầu. Rồi có tiếng gõ cửa. Liếc nhanh quanh phòng cho bạn biết tất cả những người lẽ ra đã ở đây rồi... Bạn đến gần cửa và từ từ mở nó ra, nhìn trộm quanh mép cửa. Không có ai ở đó. Nhưng ai đó đã... câu hỏi là, ai?\r\n\r\nTrò chơi kinh dị nào sẽ hoàn thành nếu không có cuộc xâm lược tại nhà? Những kẻ xâm nhập đang ở đây. Đối mặt không phải một, không phải hai, mà là BA kẻ giết người. Bạn nghĩ rằng một cái là khó, nhưng bạn thực sự sẽ phải kiễng chân trước những mối đe dọa giết người này.\r\n\r\nWingard Cottage mang đến thử thách mới với các sự kiện độc đáo và cơ chế chế tạo mới cho phép bạn lấy các vật phẩm thông thường và biến chúng thành vũ khí sử thi. Dùng con dao đó hay nhặt một ít gỗ và đinh để chế tạo The Obliterator? Nó sẽ tùy thuộc vào bạn, chỉ cần thực hiện cuộc gọi trước khi quá muộn!\r\n\r\nHộp Lõi, khi được kết hợp với một trong các Hộp Phim truyện của chúng tôi, sẽ có mọi thứ bạn cần để chơi trò chơi. Mỗi Hộp phim truyện có một Kẻ giết người độc đáo và Địa điểm mang tính biểu tượng, đồng thời bạn càng có nhiều Phim truyện, bạn càng có thể trải nghiệm nhiều sự kết hợp giữa kẻ giết người/địa điểm!\r\n\r\nMỗi Hộp phim truyện đều có hai mặt, với các bìa được minh họa tuyệt đẹp ở mặt trước VÀ mặt sau. Không chỉ vậy, các nắp hộp được gắn từ tính còn có thể tháo rời, với mặt sau của mỗi nắp có chức năng tương ứng là bảng Kẻ giết người và Bảng vị trí.', 'Sanpham/van-ryder-games-final-girl-a-knock-at-the-door-int-1.webp', 50);

-- --------------------------------------------------------

--
-- Table structure for table `carts`
--

CREATE TABLE `carts` (
  `id` int(11) NOT NULL,
  `USERNAME` varchar(100) NOT NULL,
  `MASP` varchar(100) NOT NULL,
  `quantity` int(11) NOT NULL,
  `TENSP` varchar(100) DEFAULT NULL,
  `GIA` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `carts`
--

INSERT INTO `carts` (`id`, `USERNAME`, `MASP`, `quantity`, `TENSP`, `GIA`) VALUES
(60, 'my', 'BG001', 1, 'Outer Rim', 74.999);

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `USERNAME` varchar(100) NOT NULL,
  `HOTEN` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `sdt` varchar(12) NOT NULL,
  `email` varchar(100) NOT NULL,
  `ngaytao` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`USERNAME`, `HOTEN`, `password`, `sdt`, `email`, `ngaytao`) VALUES
('AnNhien', '', 'annhien', '', 'annhien@gmail.com', NULL),
('hoangngochong', 'Hoàng Ngọc Hồng', 'hong122606', '0366928921', 'hoangngochong@gmail.com', '2023-06-27'),
('my', 'Trà My', 'my1234', '3333333', 'lilynguyen@gmail.com', NULL),
('Red2003', 'RedBlue', '12345678', '012345678', 'RedBlue@gmail.com', '2023-07-01');

-- --------------------------------------------------------

--
-- Table structure for table `order_game`
--

CREATE TABLE `order_game` (
  `order_id` bigint(20) UNSIGNED NOT NULL,
  `customer_id` bigint(20) UNSIGNED NOT NULL,
  `date_created` date DEFAULT NULL,
  `tongtien` double DEFAULT NULL,
  `soluong` bigint(21) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `phan_hoi`
--

CREATE TABLE `phan_hoi` (
  `HOTEN` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `email` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `noidung` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `id` int(11) NOT NULL,
  `ngay` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `phan_hoi`
--

INSERT INTO `phan_hoi` (`HOTEN`, `email`, `noidung`, `id`, `ngay`) VALUES
('Tu Thi Hue', 'huetu03@gmail.com', 'okiiiii', 2, '2023-07-03 00:00:00'),
('Card Game', 'lgirllovechan@gmail.com', 'hello', 5, '2023-07-03 00:00:00'),
('my', '21522109@gm.uit.edu.vn', 'hello', 6, '2023-07-03 00:00:00'),
('my', '21522109@gm.uit.edu.vn', 'jjjjjjjj', 7, '2023-07-03 00:00:00'),
('Tu Thi Hue', 'huetu03@gmail.com', 'fgdffd', 8, '2023-07-03 00:00:00'),
('Tu Thi Hue', 'huetu03@gmail.com', 'fgfdgd', 9, '2023-07-03 00:00:00'),
('Tu Thi Hue', 'huetu03@gmail.com', 'fgfdgd', 10, '2023-07-03 00:00:00'),
('Tu Thi Hue', 'huetu03@gmail.com', 'fgfdgd', 11, '2023-07-03 00:00:00'),
('Tu Thi Hue', 'huetu03@gmail.com', 'fgfdgd', 12, '2023-07-03 16:45:20'),
('hsajhsajk', 'huetu03@gmail.com', 'dsfsads', 13, '2023-07-03 16:45:49'),
('fgdf', 'hoangngochong@gmail.com', 'bbbbbbbbbbb', 14, '2023-07-03 16:58:58'),
('fgdf', 'hoangngochong@gmail.com', 'bbbbbbbbbbb', 15, '2023-07-03 12:00:28'),
('fgdf', 'hoangngochong@gmail.com', 'bbbbbbbbbbb', 16, '2023-07-03 12:00:30'),
('fgdf', 'hoangngochong@gmail.com', 'bbbbbbbbbbb', 17, '2023-07-03 12:01:17'),
('fgdf', 'hoangngochong@gmail.com', 'bbbbbbbbbbb', 18, '2023-07-03 12:05:15'),
('my', 'tuthihue.qn@gmail.com', 'hfdsa', 19, '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `thue`
--

CREATE TABLE `thue` (
  `USERNAME` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci DEFAULT NULL,
  `NGAYTHUE` date DEFAULT NULL,
  `TONGTIEN` float DEFAULT NULL,
  `ID_THUE` int(11) NOT NULL,
  `diem` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `thue`
--

INSERT INTO `thue` (`USERNAME`, `NGAYTHUE`, `TONGTIEN`, `ID_THUE`, `diem`) VALUES
('my', '2003-02-02', 100, 1, 2),
('my', '2003-02-02', 10, 2, 1),
('my', '2023-07-12', 24.999, 2573, 4),
('21522109', '2023-07-10', 135, 3268, NULL),
('my', '2023-07-12', 74.999, 3465, 2),
('my', '2023-07-12', 24.99, 4077, 3),
('smilily', '2023-06-09', 270, 4367, NULL),
('smilily', '2023-06-22', 130, 4396, NULL),
('hoangngochong', '2023-06-22', 120, 4397, NULL),
('smilily', '2023-06-23', 62, 4401, NULL),
('amika', '2023-06-24', 112, 4402, NULL),
('amika', '2023-06-24', 40, 4403, NULL),
('Trà My', '2023-07-11', 24.999, 4744, NULL),
('HOÀNG NGỌC HỒNG', '2023-06-26', 65, 4824, NULL),
('21522109', '2023-07-11', 21.999, 4965, NULL),
('gggghjk', '2023-07-11', 74.999, 5028, NULL),
('gggghjk', '2023-07-10', 1925, 5034, NULL),
('21522106', '2023-06-29', 65, 6039, NULL),
('21522109', '2023-07-10', 175, 6172, NULL),
('21522106', '2023-06-28', 65, 6271, NULL),
('HOÀNG NGỌC HỒNG', '2023-06-28', 65, 6466, NULL),
('HOÀNG NGỌC HỒNG', '2023-06-27', 65, 6492, NULL),
('Red', '2023-06-27', 65, 7276, NULL),
('Trà My', '2023-07-10', 75, 7613, NULL),
('Trà My', '2023-07-10', 175, 8436, NULL),
('HOÀNG NGỌC HỒNG', '2023-07-01', 65, 8480, NULL),
('Tu Thi Hue', '2023-07-12', 74.999, 8701, NULL),
('my', '2023-07-12', 24.999, 8853, NULL),
('HOÀNG NGỌC HỒNG', '2023-06-28', 65, 9431, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `thuegame`
--

CREATE TABLE `thuegame` (
  `ID_THUE` varchar(100) NOT NULL,
  `MASP` varchar(100) NOT NULL,
  `TENSP` varchar(255) DEFAULT NULL,
  `SOLUONG` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `thuegame`
--

INSERT INTO `thuegame` (`ID_THUE`, `MASP`, `TENSP`, `SOLUONG`) VALUES
('4824', 'BGOO1', 'Chess: Luxury Version', 1),
('7276', 'BGOO1', 'Chess: Luxury Version', 1),
('6492', 'BGOO1', 'Chess: Luxury Version', 1),
('2567', 'BGOO1', 'Chess: Luxury Version', 1),
('9431', 'BGOO1', 'Chess: Luxury Version', 1),
('6466', 'BGOO1', 'Chess: Luxury Version', 1),
('6271', 'BGOO1', 'Chess: Luxury Version', 1),
('1429', 'BGOO1', 'Chess: Luxury Version', 1),
('6039', 'BGOO1', 'Chess: Luxury Version', 1),
('8480', 'BGOO1', 'Chess: Luxury Version', 1),
('1350', 'BG002', 'Chessplus', 1),
('1793', 'BGOO1', 'Chess: Luxury Version', 1),
('1', 'bg02', 'a', 1),
('1', 'bg03', 'b', 1),
('1', 'bg04', 'c', 1),
('2', 'bg04', 'c', 1),
('5034', 'BGO32', 'Chess: Luxury Version', 17),
('5034', 'BG007', 'Squid Game', 1),
('5034', 'BG001', 'Outer Rim', 4),
('5034', 'BG021', 'G.I. JOE Deck-Building Game', 1),
('5034', 'BG009', 'Marvel United: Guardians of the Galaxy Remix', 3),
('5034', 'BG010', 'Masters of the Universe: The Board Game - Clash For Eternia', 2),
('5034', 'BG033', 'Chessplus', 2),
('5034', 'BG002', 'Not That Movie', 2),
('8436', 'BG001', 'Outer Rim', 2),
('8436', 'BG002', 'Not That Movie', 1),
('7613', 'BG001', 'Outer Rim', 1),
('3513', 'BG001', 'Outer Rim', 1),
('3268', 'BG001', 'Outer Rim', 1),
('3268', 'BG004', 'Dixit: Odyssey Expansion', 1),
('3268', 'BG002', 'Not That Movie', 1),
('6172', 'BG001', 'Outer Rim', 2),
('6172', 'BG002', 'Not That Movie', 1),
('4329', 'BG004', 'Dixit: Odyssey Expansion', 1),
('4329', 'BG002', 'Not That Movie', 1),
('4329', 'BG003', 'Best of Werewolves of Millers Hollow', 1),
('2506', 'BG001', 'Outer Rim', 1),
('2506', 'BG002', 'Not That Movie', 1),
('0343', 'BG001', 'Outer Rim', 1),
('5028', 'BG001', 'Outer Rim', 1),
('4744', 'BG002', 'Not That Movie', 1),
('4965', 'BG003', 'Best of Werewolves of Millers Hollow', 1),
('8701', 'BG001', 'Outer Rim', 1),
('2573', 'BG002', 'Not That Movie', 1),
('8853', 'BG002', 'Not That Movie', 1),
('3414', 'BG001', 'Outer Rim', 1),
('3465', 'BG001', 'Outer Rim', 1),
('4077', 'BG005', 'Skull', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tich_diem`
--

CREATE TABLE `tich_diem` (
  `Id_diem` int(11) NOT NULL,
  `USERNAME` varchar(100) NOT NULL,
  `diem` int(11) NOT NULL,
  `score_used` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tich_diem`
--

INSERT INTO `tich_diem` (`Id_diem`, `USERNAME`, `diem`, `score_used`) VALUES
(11, 'my', 12, 20);

-- --------------------------------------------------------

--
-- Table structure for table `tragame`
--

CREATE TABLE `tragame` (
  `ID_TRA` int(100) NOT NULL,
  `ID_THUE` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  `NGAYTRA` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tragame`
--

INSERT INTO `tragame` (`ID_TRA`, `ID_THUE`, `NGAYTRA`) VALUES
(0, '4824', '2023-07-01');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `binhluan`
--
ALTER TABLE `binhluan`
  ADD PRIMARY KEY (`id_comment`);

--
-- Indexes for table `boardgame`
--
ALTER TABLE `boardgame`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `carts`
--
ALTER TABLE `carts`
  ADD PRIMARY KEY (`id`),
  ADD KEY `USERNAME` (`USERNAME`),
  ADD KEY `carts_ibfk_3` (`MASP`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`USERNAME`);

--
-- Indexes for table `phan_hoi`
--
ALTER TABLE `phan_hoi`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `thue`
--
ALTER TABLE `thue`
  ADD PRIMARY KEY (`ID_THUE`),
  ADD UNIQUE KEY `ID_THUE` (`ID_THUE`);

--
-- Indexes for table `tich_diem`
--
ALTER TABLE `tich_diem`
  ADD PRIMARY KEY (`Id_diem`),
  ADD KEY `fk_username_diem` (`USERNAME`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `binhluan`
--
ALTER TABLE `binhluan`
  MODIFY `id_comment` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `boardgame`
--
ALTER TABLE `boardgame`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `carts`
--
ALTER TABLE `carts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT for table `phan_hoi`
--
ALTER TABLE `phan_hoi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `tich_diem`
--
ALTER TABLE `tich_diem`
  MODIFY `Id_diem` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `carts`
--
ALTER TABLE `carts`
  ADD CONSTRAINT `carts_ibfk_1` FOREIGN KEY (`USERNAME`) REFERENCES `customers` (`USERNAME`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
