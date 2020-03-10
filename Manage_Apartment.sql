USE master ;  
GO  
CREATE DATABASE ManageApartment;

CREATE TABLE Resident (
    Id int NOT NULL PRIMARY KEY,
    ResidentName nvarchar(50) NOT NULL,
	Room varchar(50),
	Floor varchar(50),
	ResidentImage varchar(100)
);

CREATE TABLE Equipment (
    Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    EquipmentName nvarchar(50) NOT NULL,
	PurchaseDate date,
	WarrantyPeriod int,
	EquipmentImage varchar(100),
	ResidentId int
);

CREATE TABLE Support (
    Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    SupportType nvarchar(50) NOT NULL,
	SupportDate date,
	SupportAddress nvarchar(100),
	SupportImage varchar(100),
	ResidentId int
);

CREATE TABLE JobInfo (
    JobID int NOT NULL PRIMARY KEY,
    Name varchar(50) NULL,
	LastExcutionDate datetime NULL,
	Status varchar(50) NULL
	
);

ALTER TABLE Equipment
ADD FOREIGN KEY (ResidentId) REFERENCES Resident(Id);

ALTER TABLE Support
ADD FOREIGN KEY (ResidentId) REFERENCES Resident(Id);

INSERT INTO Resident (Id, ResidentName, Room, Floor, ResidentImage)
VALUES (1, N'Nguyễn Tấn Phát', '105B', '1', 'http://192.168.43.81:45455/Static/Resident/nguyentanphat.jpg');
INSERT INTO Resident (Id, ResidentName, Room, Floor, ResidentImage)
VALUES (2, N'Trần Mạnh Tùng', '102A', '1', 'http://192.168.43.81:45455/Static/Resident/tranmanhtung.jpg');
INSERT INTO Resident (Id, ResidentName, Room, Floor, ResidentImage)
VALUES (3, N'Phan Thị Hiền', '202B', '2', 'http://192.168.43.81:45455/Static/Resident/phanthihien.jpg');
INSERT INTO Resident (Id, ResidentName, Room, Floor, ResidentImage)
VALUES (4, N'Lê Minh Thư', '302B', '3', 'http://192.168.43.81:45455/Static/Resident/leminhthu.jpg');
INSERT INTO Resident (Id, ResidentName, Room, Floor, ResidentImage)
VALUES (5, N'Võ Văn Tín', '404B', '4', 'http://192.168.43.81:45455/Static/Resident/vovantin.jpg');

INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Điều hòa', '2020-01-01', 12, 'http://192.168.43.81:45455/Static/Equipment/air_conditioner.png',1);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Nồi cơm điện', '2020-01-01', 18, 'http://192.168.43.81:45455/Static/Equipment/cooker.jpg',1);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Bếp điện', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/electric_stove.jpg',1);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Máy quạt', '2020-01-01', 24, 'http://192.168.43.81:45455/Static/Equipment/fan.jpg',1);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Tủ lạnh', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/fridge.jpg',1);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Lò vi sóng', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/microwave.jpg',1);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Máy giặt', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/washing_machine.png',1);

INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Điều hòa', '2020-01-01', 12, 'http://192.168.43.81:45455/Static/Equipment/air_conditioner.png',2);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Nồi cơm điện', '2020-01-01', 18, 'http://192.168.43.81:45455/Static/Equipment/cooker.jpg',2);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Bếp điện', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/electric_stove.jpg',2);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Máy quạt', '2020-01-01', 24, 'http://192.168.43.81:45455/Static/Equipment/fan.jpg',2);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Tủ lạnh', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/fridge.jpg',2);

INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Bếp điện', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/electric_stove.jpg',3);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Máy quạt', '2020-01-01', 24, 'http://192.168.43.81:45455/Static/Equipment/fan.jpg',3);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Tủ lạnh', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/fridge.jpg',3);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Lò vi sóng', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/microwave.jpg',3);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Máy giặt', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/washing_machine.png',3);

INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Nồi cơm điện', '2020-01-01', 18, 'http://192.168.43.81:45455/Static/Equipment/cooker.jpg',4);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Bếp điện', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/electric_stove.jpg',4);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Máy quạt', '2020-01-01', 24, 'http://192.168.43.81:45455/Static/Equipment/fan.jpg',4);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Tủ lạnh', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/fridge.jpg',4);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Lò vi sóng', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/microwave.jpg',4);


INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Điều hòa', '2020-01-01', 12, 'http://192.168.43.81:45455/Static/Equipment/air_conditioner.png',5);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Nồi cơm điện', '2020-01-01', 18, 'http://192.168.43.81:45455/Static/Equipment/cooker.jpg',5);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Bếp điện', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/electric_stove.jpg',5);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Máy quạt', '2020-01-01', 24, 'http://192.168.43.81:45455/Static/Equipment/fan.jpg',5);
INSERT INTO Equipment (EquipmentName, PurchaseDate, WarrantyPeriod, EquipmentImage, ResidentId)
VALUES (N'Máy giặt', '2020-01-01', 6, 'http://192.168.43.81:45455/Static/Equipment/washing_machine.png',5);

INSERT INTO Support (SupportType, SupportDate, SupportAddress, SupportImage, ResidentId)
VALUES (N'Lắp đặt', '2020-01-01',N'Lầu 5', 'http://192.168.43.81:45455/Static/Bill/bill_1.jpg',1);
INSERT INTO Support (SupportType, SupportDate, SupportAddress, SupportImage, ResidentId)
VALUES (N'Sửa chữa', '2020-02-05',N'Lầu 2', 'http://192.168.43.81:45455/Static/Bill/bill_2.jpg',1);
INSERT INTO Support (SupportType, SupportDate, SupportAddress, SupportImage, ResidentId)
VALUES (N'Vận chuyển', '2020-07-03',N'Lầu 3', 'http://192.168.43.81:45455/Static/Bill/bill_3.jpg',1);
INSERT INTO Support (SupportType, SupportDate, SupportAddress, SupportImage, ResidentId)
VALUES (N'Lắp đặt', '2020-02-02',N'Lầu 2', 'http://192.168.43.81:45455/Static/Bill/bill_4.jpg',3);
INSERT INTO Support (SupportType, SupportDate, SupportAddress, SupportImage, ResidentId)
VALUES (N'Sửa chữa', '2020-05-06',N'Lầu 6', 'http://192.168.43.81:45455/Static/Bill/bill_1.jpg',3);
INSERT INTO Support (SupportType, SupportDate, SupportAddress, SupportImage, ResidentId)
VALUES (N'Vận chuyển', '2020-02-03',N'Lầu 5', 'http://192.168.43.81:45455/Static/Bill/bill_4.jpg',3);
INSERT INTO Support (SupportType, SupportDate, SupportAddress, SupportImage, ResidentId)
VALUES (N'Lắp đặt', '2020-02-03',N'Lầu 4', 'http://192.168.43.81:45455/Static/Bill/bill_3.jpg',5);
INSERT INTO Support (SupportType, SupportDate, SupportAddress, SupportImage, ResidentId)
VALUES (N'Sửa chữa', '2020-08-01',N'Lầu 9', 'http://192.168.43.81:45455/Static/Bill/bill_2.jpg',5);
INSERT INTO Support (SupportType, SupportDate, SupportAddress, SupportImage, ResidentId)
VALUES (N'Vận chuyển', '2020-09-01',N'Lầu 3', 'http://192.168.43.81:45455/Static/Bill/bill_1.jpg',5);







