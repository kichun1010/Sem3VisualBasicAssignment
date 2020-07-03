-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 
-- 伺服器版本： 10.1.40-MariaDB
-- PHP 版本： 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `sdp`
--

-- --------------------------------------------------------

--
-- 資料表結構 `category`
--

CREATE TABLE `category` (
  `CategoryID` char(2) NOT NULL,
  `CategoryName` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `category`
--

INSERT INTO `category` (`CategoryID`, `CategoryName`) VALUES
('A', 'Sheet Metal'),
('B', 'Major Assemblies'),
('C', 'Light Components'),
('D', 'Accessories');

-- --------------------------------------------------------

--
-- 資料表結構 `dealerinfo`
--

CREATE TABLE `dealerinfo` (
  `DealerID` varchar(8) NOT NULL,
  `CompanyName` varchar(50) NOT NULL,
  `ContactPerson1` varchar(30) NOT NULL,
  `ContactPerson2` int(30) DEFAULT NULL,
  `ContactPerson1PhoneNo` int(15) NOT NULL,
  `ContactPerson2PhoneNo` int(15) DEFAULT NULL,
  `ShippingAddress1` varchar(80) NOT NULL,
  `ShippingAddress2` varchar(80) DEFAULT NULL,
  `Email` varchar(100) NOT NULL,
  `CreditValue` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 傾印資料表的資料 `dealerinfo`
--

INSERT INTO `dealerinfo` (`DealerID`, `CompanyName`, `ContactPerson1`, `ContactPerson2`, `ContactPerson1PhoneNo`, `ContactPerson2PhoneNo`, `ShippingAddress1`, `ShippingAddress2`, `Email`, `CreditValue`) VALUES
('1', '1', '1', NULL, 2147483647, NULL, '1', NULL, '1', 0),
('12345', 'ABFFF', 'I am 12345 people', NULL, 2147483647, NULL, 'TKO', NULL, '123@hotmail.com', 0),
('test', 'AAAA', 'AA', NULL, 2147483647, NULL, 'AAA', NULL, 'mm@gmail.com', 0),
('test1', 'aa', 'aa', NULL, 2147483647, NULL, 'aa', NULL, 'aa', 0),
('Testing', 'Motor Car Limited Company', 'Admin1', NULL, 2147483647, NULL, '20 Tsing Yi Road,Tsing Yi Island,New Territories,Hong Kong', NULL, '123456789@stu.vtc.edu.hk', 0),
('Testing2', 'Namco Limited Hong Kong', 'cust1', NULL, 2147483647, NULL, 'Flat A, 27/F, King Hon Building, Tai Koo,Hong Kong', NULL, 'namco_hongkong@gmail.com', 0);

-- --------------------------------------------------------

--
-- 資料表結構 `deliverynote`
--

CREATE TABLE `deliverynote` (
  `DeliveryNoteNo` char(10) NOT NULL,
  `DealerID` varchar(8) NOT NULL,
  `OrderNo` varchar(11) NOT NULL,
  `ShippingAddress` varchar(80) NOT NULL,
  `ShippingDate` date DEFAULT NULL,
  `DeliveryDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 傾印資料表的資料 `deliverynote`
--

INSERT INTO `deliverynote` (`DeliveryNoteNo`, `DealerID`, `OrderNo`, `ShippingAddress`, `ShippingDate`, `DeliveryDate`) VALUES
('D130323010', 'Testing2', 'S1302110003', '', '2013-04-04', '2013-03-23'),
('D150628016', 'Testing2', 'S1504040007', '', '2015-07-12', '2015-06-28'),
('D170413001', 'Testing', 'S1702160110', '', '2017-04-23', '2017-04-13'),
('D170802000', 'Testing', 'S1706140230', '', '2017-08-12', '2017-08-02'),
('D190412000', 'Testing', 'S1903120123', '', '2019-04-28', '2019-04-12');

-- --------------------------------------------------------

--
-- 資料表結構 `dic`
--

CREATE TABLE `dic` (
  `orderserial` varchar(100) NOT NULL,
  `date` varchar(100) NOT NULL,
  `invoicename` varchar(100) NOT NULL,
  `invoiceaddress` varchar(100) NOT NULL,
  `deliveryaddress` varchar(100) NOT NULL,
  `dealerorderno` varchar(100) NOT NULL,
  `desinstruct` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `dic`
--

INSERT INTO `dic` (`orderserial`, `date`, `invoicename`, `invoiceaddress`, `deliveryaddress`, `dealerorderno`, `desinstruct`) VALUES
('', '2015-12-17', '', '', '', '', ''),
('123', '2019-06-19', '444', '4567', 'eeer', '22213', '323'),
('123324', '2019-06-12', 'aaaa', 'reeqwee', 'reeww', '', '12332'),
('123445555', '2019-06-12', 'asdfaasd', '', '', '', ''),
('aaa', '2019-06-12', '', '', '', '', ''),
('aad', '2019-06-12', '', 'xxs', '', '', ''),
('adas', '2019-06-12', '123', 'qwe', '233', '1123', '1233'),
('adsaqw', '2019-06-12', '', '', '', '', ''),
('ccc', '2019-07-03', 'qw', 'rwee', 'qqwe', '', ''),
('dASSA', '2019-06-12', '', '', '', '', ''),
('hdfgd', '2019-06-14', '', '', '', '', ''),
('qq', '2019-06-12', '', 'aas', 'q', '', ''),
('rer', '2019-06-12', '', 'sdqqw', '', '', ''),
('S102938494', '2019-06-12', '12213', 'TKO', 'LALLA', '', 'AASSS'),
('saad', '2019-06-18', '32', 'qqwqw', 'dd', '', 'ww');

-- --------------------------------------------------------

--
-- 資料表結構 `did`
--

CREATE TABLE `did` (
  `orderno` varchar(100) NOT NULL,
  `productid` varchar(100) NOT NULL,
  `dealerid` varchar(100) NOT NULL,
  `category` varchar(3) NOT NULL,
  `orderqty` int(100) NOT NULL,
  `preoutstand` int(100) NOT NULL,
  `totalno` int(100) NOT NULL,
  `weight_kg` int(10) NOT NULL,
  `length_cm` int(10) NOT NULL,
  `width_cm` int(10) NOT NULL,
  `desInstruct` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `did`
--

INSERT INTO `did` (`orderno`, `productid`, `dealerid`, `category`, `orderqty`, `preoutstand`, `totalno`, `weight_kg`, `length_cm`, `width_cm`, `desInstruct`) VALUES
('123', 'Sa', 'q', 'wq', 121, 31, 321324, 112, 21, 343, 'sfewr'),
('aas', '1231q', 'weqeq131', 'a', 23123, 411, 123267, 21, 23, 3211, ''),
('asd', 'awwqee', '1qqwe', 'a', 1, 2, 3, 112, 21, 3, 'asda'),
('S1302110003', 'asd', '123', '12', 123, 32, 123, 322, 123, 321, ''),
('S130211003', '23', 'aa', 's', 23, 3, 423, 234, 22234, 232, '233'),
('ss', 'qre', 'qdr', '231', 4221, 4, 321, 3234, 13, 232, NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `inventory`
--

CREATE TABLE `inventory` (
  `ProductID` varchar(11) NOT NULL,
  `CategoryID` char(2) NOT NULL,
  `SupplierID` varchar(11) NOT NULL,
  `QtyInStock` int(10) NOT NULL,
  `QtyReserved` int(10) NOT NULL,
  `QtyOnOrder` int(10) NOT NULL,
  `ReOrderQty` int(10) NOT NULL,
  `ReOrderLevel` int(10) DEFAULT '3000',
  `DangerLevel` int(10) DEFAULT '2000',
  `Location` varchar(10) NOT NULL,
  `SalesStatus` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `inventory`
--

INSERT INTO `inventory` (`ProductID`, `CategoryID`, `SupplierID`, `QtyInStock`, `QtyReserved`, `QtyOnOrder`, `ReOrderQty`, `ReOrderLevel`, `DangerLevel`, `Location`, `SalesStatus`) VALUES
('A00001', 'A', 'SP121029', 100, 0, 0, 0, 100, 100, 'Area A', 'Off Sell'),
('A00002', 'A', 'SP140710', 100, 0, 300, 4800, 3000, 2000, 'Area A', 'Off Sell'),
('A00003', 'A', 'SP090123', 1600, 2300, 600, 10700, 3000, 2000, 'Area A', 'On Sell'),
('A00004', 'A', 'SP121029', 900, 1400, 0, 10500, 3000, 2000, 'Area A', 'On Sell'),
('A00005', 'A', 'SP110911', 4600, 0, 2300, 0, 3000, 2000, 'Area A', 'On Sell'),
('B00001', 'B', 'SP140710', 6500, 0, 1400, 0, 3000, 2000, 'Area B', 'On Sell'),
('B00002', 'B', 'SP121029', 10200, 0, 400, 0, 3000, 2000, 'Area B', 'On Sell'),
('B00003', 'B', 'SP090123', 9800, 0, 1200, 0, 3000, 2000, 'Area B', 'On Sell'),
('B00004', 'B', 'SP110911', 1800, 2000, 0, 10200, 3000, 2000, 'Area B', 'On Sell'),
('B00005', 'B', 'SP110911', 4300, 0, 100, 0, 3000, 2000, 'Area B', 'On Sell'),
('C00001', 'C', 'SP180123', 7500, 0, 200, 0, 3000, 2000, 'Area C', 'On Sell'),
('C00002', 'C', 'SP150911', 2500, 0, 600, 7500, 3000, 2000, 'Area C', 'On Sell'),
('C00003', 'C', 'SP090123', 3400, 0, 400, 6600, 3000, 2000, 'Area C', 'On Sell'),
('C00004', 'C', 'SP150911', 8900, 0, 2400, 0, 3000, 2000, 'Area C', 'On Sell'),
('C00005', 'C', 'SP121029', 700, 4500, 0, 13800, 3000, 2000, 'Area C', 'On Sell'),
('D00001', 'D', 'SP180123', 2100, 0, 0, 7900, 3000, 2000, 'Area D', 'On Sell'),
('D00002', 'D', 'SP180123', 3400, 0, 200, 0, 3000, 2000, 'Area D', 'On Sell'),
('D00003', 'D', 'SP180123', 7800, 0, 100, 0, 3000, 2000, 'Area D', 'On Sell'),
('D00004', 'D', 'SP121029', 4500, 0, 1000, 5500, 3000, 2000, 'Area D', 'On Sell'),
('D00005', 'D', 'SP140710', 5300, 0, 700, 0, 3000, 2000, 'Area D', 'On Sell');

-- --------------------------------------------------------

--
-- 資料表結構 `invoice`
--

CREATE TABLE `invoice` (
  `InvoiceNo` varchar(11) NOT NULL,
  `DealerID` varchar(8) NOT NULL,
  `OrderNo` varchar(11) NOT NULL,
  `InvoiceAddress` varchar(80) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 傾印資料表的資料 `invoice`
--

INSERT INTO `invoice` (`InvoiceNo`, `DealerID`, `OrderNo`, `InvoiceAddress`) VALUES
('I1303230100', 'Testing2', 'S1302110003', 'Flat A, 27/F, King Hon Building, Tai Koo,Hong Kong'),
('I1506280163', 'Testing2', 'S1504040007', 'Flat A, 27/F, King Hon Building, Tai Koo,Hong Kong'),
('I1704130014', 'Testing', 'S1702160110', '20 Tsing Yi Road,Tsing Yi Island,New Territories,Hong Kong'),
('I1708020006', 'Testing', 'S1706140230', '20 Tsing Yi Road,Tsing Yi Island,New Territories,Hong Kong'),
('I1904120001', 'Testing', 'S1903120123', '20 Tsing Yi Road,Tsing Yi Island,New Territories,Hong Kong');

-- --------------------------------------------------------

--
-- 資料表結構 `loginaccount`
--

CREATE TABLE `loginaccount` (
  `loginid` varchar(8) NOT NULL,
  `password` varchar(100) NOT NULL,
  `rid` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 傾印資料表的資料 `loginaccount`
--

INSERT INTO `loginaccount` (`loginid`, `password`, `rid`) VALUES
('12345', 'WZRHGrsBESr8wYFZ9sx0tPURuZgG2lmzyvWpwXPKz8U=', 1),
('smlcs001', 'smlcs100', 2),
('test', 'WZRHGrsBESr8wYFZ9sx0tPURuZgG2lmzyvWpwXPKz8U=', 1),
('test1', 'bGntwdu9PvhwxSUqzN+VNZZOuSNNiXllAmesFLJq3kA=', 1),
('Testing', 'B0gPuehbk5avBvAGzxyVAkryUxxl+1Bc+9Ct0eLzFXM=', 2),
('Testing2', 'fqoDVHiQDcPk6yDPm0T5Ff3DTfkBnn1qR2RXNobu34o=', 1);

-- --------------------------------------------------------

--
-- 資料表結構 `orderdetail`
--

CREATE TABLE `orderdetail` (
  `OrderNo` varchar(11) NOT NULL,
  `ProductID` varchar(11) NOT NULL,
  `Qty` int(10) NOT NULL,
  `OrderDate` date NOT NULL,
  `totalPrice` int(10) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 傾印資料表的資料 `orderdetail`
--

INSERT INTO `orderdetail` (`OrderNo`, `ProductID`, `Qty`, `OrderDate`, `totalPrice`, `id`) VALUES
('S1302110003', 'D00001', 600, '2013-02-11', 471000, 1),
('S1504040007', 'D00003', 500, '2015-04-04', 170500, 2),
('S1702160110', 'B00002', 100, '2017-02-16', 47800, 3),
('S1706140230', 'A00002', 400, '2017-06-14', 40400, 4),
('S1903120123', 'C00003', 200, '2019-03-12', 22000, 5),
('s1906130000', 'A00002', 100, '2019-06-13', 10100, 6),
('s1906130001', 'D00003', 100, '2019-06-13', 34100, 7),
('s1906130002', 'A00001', 11, '2019-06-13', 3344, 8),
('s1906130002', 'A00004', 11, '2019-06-13', 363, 9),
('s1906130002', 'C00005', 11, '2019-06-13', 1331, 10),
('s1907010000', 'A00001', 100, '2019-07-01', 30400, 11),
('s1907010000', 'A00002', 100, '2019-07-01', 10100, 12),
('s1907010000', 'A00003', 100, '2019-07-01', 11000, 13),
('s1907010000', 'A00004', 100, '2019-07-01', 3300, 14),
('s1907010000', 'A00005', 500, '2019-07-01', 6000, 15),
('s1907010001', 'A00001', 100, '2019-07-01', 30400, 16),
('s1907010001', 'A00004', 100, '2019-07-01', 3300, 17);

-- --------------------------------------------------------

--
-- 資料表結構 `orderrecord`
--

CREATE TABLE `orderrecord` (
  `OrderNo` varchar(11) NOT NULL,
  `DealerID` varchar(8) NOT NULL,
  `OrderDate` date NOT NULL,
  `Status` varchar(15) NOT NULL,
  `Remarks` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `orderrecord`
--

INSERT INTO `orderrecord` (`OrderNo`, `DealerID`, `OrderDate`, `Status`, `Remarks`) VALUES
('S1302110003', 'Testing2', '2013-02-11', 'On Sell', ''),
('S1504040007', 'Testing2', '2015-04-04', 'On Sell', 'fragile'),
('S1702160110', 'Testing', '2017-02-16', 'On Sell', ''),
('S1706140230', 'Testing', '2017-06-14', 'On Sell', 'Fast delivery'),
('S1903120123', 'Testing', '2019-03-12', 'On Sell', ''),
('s1906130000', '', '2019-06-13', 'pending', ''),
('s1906130001', 'test', '2019-06-13', 'pending', '...Fast Move'),
('s1906130002', 'test1', '2019-06-13', 'pending', ''),
('s1907010000', 'Testing2', '2019-07-01', 'pending', ''),
('s1907010001', '12345', '2019-07-01', 'pending', 'Fast Move');

-- --------------------------------------------------------

--
-- 資料表結構 `product`
--

CREATE TABLE `product` (
  `ProductID` varchar(11) NOT NULL,
  `ProductName` varchar(30) NOT NULL,
  `UnitPrice` int(10) NOT NULL,
  `Weight_kg` int(10) NOT NULL,
  `Width_cm` int(10) NOT NULL,
  `Length_cm` int(10) NOT NULL,
  `ProductDescription` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 傾印資料表的資料 `product`
--

INSERT INTO `product` (`ProductID`, `ProductName`, `UnitPrice`, `Weight_kg`, `Width_cm`, `Length_cm`, `ProductDescription`) VALUES
('A00001', 'Chevy II Chrome Front Bumper', 304, 10, 12, 46, '5-year limited rust through warranty!'),
('A00002', 'Chrome Bumper Bolts', 101, 23, 14, 11, 'New rear bumper mounting bracket set for your Camaro. Exact fit for all models. '),
('A00003', '67-68 Camaro Rear Bumper', 110, 14, 14, 35, 'GM Restoration Parts'),
('A00004', '\"Swish\" Door Lever Handles', 33, 18, 6, 25, 'Easy installation!'),
('A00005', '1/4\" Fender Welting', 12, 16, 15, 3, 'Powder-coated anodized finish Aluminum fender washers & screws'),
('B00001', 'Clutch', 120, 23, 12, 3, 'Allow quickly, easily and frequently removal'),
('B00002', 'Transmission', 478, 9, 17, 4, 'High Quality Aluminum T6061 No Drill Front Bumper Tow Hole Adapter License Plate Mounting Bracket'),
('B00003', 'Drive Line', 260, 13, 23, 13, 'Black powder coat with matte finish'),
('B00004', 'Horn circuit', 523, 11, 18, 8, 'Simple install-bolts directly on to car front tow hole'),
('B00005', 'Rear axle', 770, 12, 21, 11, 'lights,Angel adjustment to address any curves on cars bumper'),
('C00001', 'Aux & Universal Parts', 106, 13, 12, 6, 'Easy bolt-on installation. Relocates license plate to the center of the spare tire, mounted off of t'),
('C00002', 'Dummy Lamps', 97, 17, 25, 4, 'It will not damage the appearance of your car, at the same time enhance your car beautiful.'),
('C00003', 'Reflectors', 110, 23, 16, 8, 'Ultimate solution to add more lights to vehicle without bulky brackets.'),
('C00004', 'Bumper Lights', 86, 22, 21, 13, 'No cutting or welding required. It is made to install using factory windshield bracket bolts.'),
('C00005', 'Interior Lights', 121, 24, 32, 21, 'Fits 2018-2019 Jeep Wrangler JL'),
('D00001', 'Car Heater', 785, 16, 23, 25, 'Black power coat finish to avoid rust and corrosion.'),
('D00002', 'Air-conditioner', 1021, 32, 43, 32, 'No drilling required.'),
('D00003', 'Radio', 341, 7, 16, 23, 'Rare AM-FM radio for your Camaro. Exact fit for all 67 - 68 models.'),
('D00004', 'Wind screen wiper', 704, 3, 12, 23, 'Fits 2018-2019 Jeep Wrangler JL.'),
('D00005', 'Indicators', 411, 8, 15, 34, 'This is for mounting brackets ONLY, LED light is not included.');

-- --------------------------------------------------------

--
-- 資料表結構 `reorderrecord`
--

CREATE TABLE `reorderrecord` (
  `ReOrderNo` varchar(11) NOT NULL,
  `ProductID` varchar(11) NOT NULL,
  `SupplierID` varchar(11) NOT NULL,
  `ReOrderDate` varchar(100) NOT NULL,
  `PurchaseQty` int(10) NOT NULL,
  `ReceiveDate` varchar(100) NOT NULL,
  `Status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `reorderrecord`
--

INSERT INTO `reorderrecord` (`ReOrderNo`, `ProductID`, `SupplierID`, `ReOrderDate`, `PurchaseQty`, `ReceiveDate`, `Status`) VALUES
('RE190102000', 'A00002', 'SP140710', '2019-01-02', 4800, '2019-02-14', 'Received'),
('RE190203001', 'B00004', 'SP110911', '2019-02-03', 10200, '2019-03-04', 'Received'),
('RE190319010', 'C00005', 'SP121029', '2019-03-19', 13800, '2019-04-26', 'Received'),
('RE190523005', 'C00002', 'SP150911', '2019-05-23', 7500, '2019-06-08', 'Delivering'),
('RE190605021', 'D00004', 'SP121029', '2019-04-27', 5500, '2019-07-01', 'Ordered');

-- --------------------------------------------------------

--
-- 資料表結構 `staffinfo`
--

CREATE TABLE `staffinfo` (
  `StaffID` varchar(8) NOT NULL,
  `StaffName` varchar(30) NOT NULL,
  `Department` varchar(20) DEFAULT NULL,
  `Position` varchar(30) DEFAULT NULL,
  `Mobile` int(15) NOT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 傾印資料表的資料 `staffinfo`
--

INSERT INTO `staffinfo` (`StaffID`, `StaffName`, `Department`, `Position`, `Mobile`, `Email`) VALUES
('Admin1', 'Lesley', 'IT Department', 'Senior Programmer', 51405239, 'lesley5140@gmail.com'),
('Admin2', 'Niki', 'Sales Department', 'Sales Manager', 97689201, 'niki_hkwinner@gmail.com');

-- --------------------------------------------------------

--
-- 資料表結構 `supplier`
--

CREATE TABLE `supplier` (
  `SupplierID` varchar(11) NOT NULL,
  `SupplierName` varchar(50) NOT NULL,
  `SupplierAddress` varchar(80) NOT NULL,
  `SupplierPhone` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 傾印資料表的資料 `supplier`
--

INSERT INTO `supplier` (`SupplierID`, `SupplierName`, `SupplierAddress`, `SupplierPhone`) VALUES
('SP090123', 'Bosch', 'BSH Home Appliances Limited.Unit 07,23/F,CDW Building,388 Castle Peak Road,Tsuen', '+852 2565 6151'),
('SP110911', 'Continental', 'Continental AG,Büttnerstraße 25,Hannover,Lower Saxony,Germany', '+49 511 938-2238'),
('SP121029', 'Denso', 'Denso, LLC,BU Commercial Specialty Tires,1830 MacMillan Park Drive,Fort Mill,Sou', '+1 704-583-8959'),
('SP140710', 'Aisin', 'Aisin,Inc,6110 Cantay Road,Mississauga, Ontario,Canada', '+1 905 856-4363'),
('SP150911', 'Hyundai Mobis', 'Hyundai Mobis,Cadle Street,New Brighton West,Port Elizabeth,Cnr Hulley & Andre G', '+27 41 4065449'),
('SP180123', 'Magna', 'Magna.Ltd,2 Scholar Drive,Bundoora,Victoria,Australia', '+61 3 9468 1226');

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`CategoryID`);

--
-- 資料表索引 `dealerinfo`
--
ALTER TABLE `dealerinfo`
  ADD PRIMARY KEY (`DealerID`);

--
-- 資料表索引 `deliverynote`
--
ALTER TABLE `deliverynote`
  ADD PRIMARY KEY (`DeliveryNoteNo`);

--
-- 資料表索引 `dic`
--
ALTER TABLE `dic`
  ADD PRIMARY KEY (`orderserial`);

--
-- 資料表索引 `did`
--
ALTER TABLE `did`
  ADD PRIMARY KEY (`orderno`);

--
-- 資料表索引 `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`ProductID`);

--
-- 資料表索引 `invoice`
--
ALTER TABLE `invoice`
  ADD PRIMARY KEY (`InvoiceNo`) USING BTREE;

--
-- 資料表索引 `loginaccount`
--
ALTER TABLE `loginaccount`
  ADD PRIMARY KEY (`loginid`);

--
-- 資料表索引 `orderdetail`
--
ALTER TABLE `orderdetail`
  ADD PRIMARY KEY (`id`);

--
-- 資料表索引 `orderrecord`
--
ALTER TABLE `orderrecord`
  ADD PRIMARY KEY (`OrderNo`);

--
-- 資料表索引 `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductID`);

--
-- 資料表索引 `reorderrecord`
--
ALTER TABLE `reorderrecord`
  ADD PRIMARY KEY (`ReOrderNo`);

--
-- 資料表索引 `staffinfo`
--
ALTER TABLE `staffinfo`
  ADD PRIMARY KEY (`StaffID`);

--
-- 資料表索引 `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SupplierID`);

--
-- 在傾印的資料表使用自動增長(AUTO_INCREMENT)
--

--
-- 使用資料表自動增長(AUTO_INCREMENT) `orderdetail`
--
ALTER TABLE `orderdetail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
