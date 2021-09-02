create database QLKSC
go
use QLKSC
go

--Table Position

create table Position(
	IdPosition char(2) primary key,
	NamePosition nvarchar(30) not null
)
go
insert into Position values('GD',N'Giám đốc')
insert into Position values('PD',N'Phó Giám đốc')
insert into Position values('KT',N'Kế toán')
insert into Position values('TK',N'Thư ký')
insert into Position values('LT',N'Lễ tân')
insert into Position values('PV',N'Phục vụ')
insert into Position values('BV',N'Bảo vệ')

go

--Table Employee

create table Employee(
	IdEmployee char(5) primary key,
	IdPosition char(2) foreign key references Position(IdPosition) not null,
	NameEmployee nvarchar(50) not null,
	DateOfBirth date check(DateOfBirth < getdate()) not null,
	GenderEmployee nvarchar(3) check(GenderEmployee in(N'Nam',N'Nữ')) not null,
	PhoneNumber varchar(10) check(PhoneNumber like '[0-0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or PhoneNumber like '[0-0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
	IdCardEmployee char(12) check(IdCardEmployee like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') unique not null,
	AddressEmployee nvarchar(50) not null,
	EmailEmployee varchar(30) unique check(EmailEmployee  like '[a-z]%@[a-z]%.[a-z]%')
)
go
insert into Employee values('NV001','GD',N'Trần Khánh Linh',convert(date,'05/12/1992',105),N'Nữ','0981722672','015071000030',N'Hồ Chí Minh','linhtran@gmail.com')
insert into Employee values('NV002','PD',N'Nguyễn Như Hảo',convert(date,'02/02/1993',105),N'Nữ','0985785694','012398678911',N'Hồ Chí Minh','nhuhao@gmail.com')
insert into Employee values('NV003','KT',N'Nguyễn Phương Thảo',convert(date,'02/06/1997',105),N'Nữ','0985785694','01112555668',N'Nha Trang','phuongthao@gmail.com')
insert into Employee values('NV004','TK',N'Lê Thanh Thảo',convert(date,'25/12/1996',105),N'Nữ','0971146454','012212555669',N'Bình Thuận','thaole@gmail.com')
insert into Employee values('NV005','PV',N'Phạm Văn Hùng ',convert(date,'12/02/1996',105),N'Nam','0987749764','018212555866',N'Bình Dương','hungpham@gmail.com')
insert into Employee values('NV006','PV',N'Nguyễn Ngọc Anh',convert(date,'15/06/1995',105),N'Nữ','0968897845','017212555966',N'An Giang','ngocanh@gmail.com')
insert into Employee values('NV007','TK',N'Lê Bảo Trâm',convert(date,'22/02/1995',105),N'Nữ','0971108554','016212555866',N'Hồ Chí Minh','baotram@gmail.com')
insert into Employee values('NV008','BV',N'Hoàng Văn Thắng',convert(date,'15/04/1994',105),N'Nam','0978262042','012212555966',N'Bạc Liêu','vanthang@gmail.com')
insert into Employee values('NV009','PV',N'Nguyễn Hồng Hoa',convert(date,'11/02/1993',105),N'Nữ','0973555834','014212555676',N'Đà Nẵng','honghoa@gmail.com')
insert into Employee values('NV010','BV',N'Trần Hoàng Phúc',convert(date,'22/02/1994',105),N'Nam','0981928438','018212555686',N'Đồng Nai','hoangphuc@gmail.com')
insert into Employee values('NV011','KT',N'Nguyễn Ngọc My',convert(date,'02/07/1993',105),N'Nữ','0971056775','026212555696',N'Tiền Giang','ngocmy@gmail.com')
insert into Employee values('NV012','PV',N'Đỗ Thị Ngọc',convert(date,'12/12/1995',105),N'Nữ','0975499914','023212555766',N'Tây Ninh','ngocdo@gmail.com')
insert into Employee values('NV013','KT',N'Trần Hoàng Sơn',convert(date,'18/11/1991',105),N'Nam','0975474630','033212555987',N'Hồ Chí Minh','hoangson@gmail.com')
insert into Employee values('NV014','TK',N'Nguyễn Ngọc Hương',convert(date,'02/08/1993',105),N'Nữ','0978914791','044212555000',N'Bình Dương','ngochuong@gmail.com')
insert into Employee values('NV015','PV',N'Phạm Gia Hưng',convert(date,'12/01/1995',105),N'Nam','0981737670','010212555555',N'Sóc Trăng','giahung@gmail.com')

go

--Table RoomName

create table RoomName(
	RoomName varchar(10) primary key,
	Quantity int not null,
	PriceRoom int not null
)
go
insert into RoomName values('Standard',7,200000)
insert into RoomName values('Deluxe',6,300000)
insert into RoomName values('Suite',5,400000)
insert into RoomName values('Superio',3,500000)

go

--Table Room

create table Room(
	IdRoom char(4) primary key,
	RoomName varchar(10) foreign key references RoomName(RoomName),
	[status] bit
)
go
insert into Room values('S503','Standard',1)
insert into Room values('S504','Standard',1)
insert into Room values('S505','Standard',1)
insert into Room values('S403','Standard',0)
insert into Room values('S404','Standard',0)
insert into Room values('S405','Standard',0)
insert into Room values('S303','Standard',0)
insert into Room values('S304','Standard',0)
insert into Room values('S305','Standard',0)
insert into Room values('S205','Standard',0)
insert into Room values('D501','Deluxe',1)
insert into Room values('D502','Deluxe',1)
insert into Room values('D401','Deluxe',1)
insert into Room values('D402','Deluxe',1)
insert into Room values('D301','Deluxe',0)
insert into Room values('D302','Deluxe',0)
insert into Room values('D203','Deluxe',0)
insert into Room values('D204','Deluxe',0)
insert into Room values('D104','Deluxe',0)
insert into Room values('D105','Deluxe',0)
insert into Room values('E201','Suite',0)
insert into Room values('E202','Suite',0)
insert into Room values('E103','Suite',0)
insert into Room values('E102','Suite',0)
insert into Room values('E101','Suite',0)
insert into Room values('V001','Superio',1)
insert into Room values('V002','Superio',1)
insert into Room values('V003','Superio',0)
insert into Room values('V004','Superio',0)
insert into Room values('V005','Superio',0)

go

--Table Customer

create table Customer(
	IdCustomer char(5) primary key,
	NameCustomer nvarchar(50) not null,
	IdCardCustomer char(12) check(IdCardCustomer like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') unique not null,
	PhoneNumber varchar(10) check(PhoneNumber like '[0-0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or PhoneNumber like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
	EmailCustomer varchar(30) unique check(EmailCustomer  like '[a-z]%@[a-z]%.[a-z]%'),
	AddressCustomer nvarchar(50) not null
)
go
insert into Customer values('KH001',N'Nguyễn Quốc Bảo','011222555888','0909050505','quocbao@gmail.com',N'Hồ Chí Minh')
insert into Customer values('KH002',N'Lê Tú Anh','034222777511','0866504448','leanh@gmail.com',N'Hà Nội')
insert into Customer values('KH003',N'Trần Nhật Ánh','017222555782','0909050805','anhtran@gmail.com',N'Hà Nam')
insert into Customer values('KH004',N'Nguyễn Hiếu','077222444456','0867180610','hieunguyen@gmail.com',N'Nam Định')
insert into Customer values('KH005',N'Lê Văn Khoa','059229995753','0913050505','lekhoa@gmail.com',N'Đà Lạt')
insert into Customer values('KH006',N'Nguyễn Thiên Ân','011222557665','0865250001','nguyenan@gmail.com',N'Khánh Hòa')
insert into Customer values('KH007',N'Lê Ngọc Bích','034222771846','0867030814','ngocbich@gmail.com',N'Lâm Đồng')
insert into Customer values('KH008',N'Trần Minh Nhật','017222558711','0867632079','minhnhat@gmail.com',N'Hải Dương')
insert into Customer values('KH009',N'Nguyễn Long','077222449986','0867615066','longnguyen@gmail.com',N'Hải Phòng')
insert into Customer values('KH010',N'Lê Bảo Chi','059229993188','0862291015','lechi@gmail.com',N'Hà Nội')
insert into Customer values('KH011',N'Nguyễn Tâm','011222555344','0865491639','tamnguyen@gmail.com',N'Quảng Nam')
insert into Customer values('KH012',N'Lê Minh','034222777549','0869799774','leminh@gmail.com',N'Quảng Ninh')
insert into Customer values('KH013',N'Trần Uy Vũ','017222551100','0867484873','tranvu@gmail.com',N'Quảng Bình')
insert into Customer values('KH014',N'Nguyễn Lan Hương','077222448866','0865300912','huongnguyen@gmail.com',N'Thái Bình')
insert into Customer values('KH015',N'Lê Văn Quân','059229998645','0865477724','lequan@gmail.com',N'Bắc Ninh')
insert into Customer values('KH016',N'Nguyễn Hữu Thiện','011222557355','0865601232','huuthien@gmail.com',N'Vĩnh Long')
insert into Customer values('KH017',N'Lê Hoài An','034222777493','0869835178','lehoaian@gmail.com',N'Cà Mau')
insert into Customer values('KH018',N'Trần Mai Chi','017222557504','0866137013','maichi@gmail.com',N'Thái Nguyên')
insert into Customer values('KH019',N'Nguyễn Nhật Hạ ','077222444502','0869643286','nhatha@gmail.com',N'Long An')
insert into Customer values('KH020',N'Lê Đức Bình','059229996622','0866150508','lebinh@gmail.com',N'Đồng Tháp')
go

--Table Booking

create table Booking(
	IdBooking char(5) primary key,
	IdEmployee char(5) foreign key references Employee(IdEmployee) not null,
	IdCustomer char(5) foreign key references Customer(IdCustomer) not null,
	RoomName varchar(10) foreign key references RoomName(RoomName) not null,
	DateBook date default(getdate()) not null,
	DateCheckIn date default(getdate()) not null,
	DateCheckOut date default(getdate()) not null,
	MoneyDeposit int,
	Quantity int not null,
	[status] bit
)
go
insert into Booking values('DP001','NV002','KH001','Superio',getdate(),convert(date,'08/01/2021',105),convert(date,'08/02/2021',105),100000,2,0)
insert into Booking values('DP002','NV002','KH002','Standard',getdate(),convert(date,'01/03/2021',105),convert(date,'10/03/2021',105),60000,3,0)
insert into Booking values('DP003','NV003','KH003','Deluxe',getdate(),convert(date,'04/05/2021',105),convert(date,'12/05/2021',105),60000,2,0)
insert into Booking values('DP004','NV003','KH004','Deluxe',getdate(),convert(date,'08/01/2021',105),convert(date,'08/02/2021',105),60000,2,0)
insert into Booking values('DP005','NV002','KH005','Suite',getdate(),convert(date,'25/08/2021',105),convert(date,'28/08/2021',105),80000,2,1)

go

--Table Bookingdetails

create table Bookingdetails(
	IdBooking char(5) foreign key references Booking(IdBooking) not null,
	IdRoom char(4) foreign key references Room(IdRoom) not null,
	primary key(Idbooking,IdRoom)
)
go
insert into Bookingdetails values('DP001','V001')
insert into Bookingdetails values('DP001','V002')
insert into Bookingdetails values('DP002','S503')
insert into Bookingdetails values('DP002','S504')
insert into Bookingdetails values('DP002','S505')
insert into Bookingdetails values('DP003','D501')
insert into Bookingdetails values('DP003','D502')
insert into Bookingdetails values('DP004','D401')
insert into Bookingdetails values('DP004','D402')
insert into Bookingdetails values('DP005','E201')
insert into Bookingdetails values('DP005','E202')

go

--Table Bill

create table Bill(
	IdBill char(5) primary key,
	IdBooking char(5) foreign key references Booking(IdBooking) not null,
	DateBilling date default(getdate()) not null,
	Total int not null
)
go

insert into Bill values('HD001','DP005',getdate(),2400000)

go

--Table Role

create table [Role](
	Id char(1) primary key,
	Permission nvarchar(10) not null
)
go
insert into [Role] values('A',N'Quản trị')
insert into [Role] values('B',N'Nhân viên')
insert into [Role] values('C',N'Khách')

go

--Table Permission

create table Permission(
	IdEmployee char(5) foreign key references Employee(IdEmployee) not null,
	Id char(1) foreign key references [Role](Id) not null,
	[password] char(8) not null,
	primary key(IdEmployee,Id)
)
go
insert into Permission values('NV001','A','12345678')
insert into Permission values('NV002','B','12345678')
insert into Permission values('NV003','B','12345678')
insert into Permission values('NV004','C','12345678')
insert into Permission values('NV005','C','12345678')
insert into Permission values('NV006','A','12345678')
insert into Permission values('NV007','B','12345678')
insert into Permission values('NV008','C','12345678')
insert into Permission values('NV009','B','12345678')
insert into Permission values('NV010','C','12345678')

go

create proc getbill
	@IdBooking char(5)
as
begin
	select Bill.IdBill,Bill.DateBilling,Booking.IdBooking,Booking.IdCustomer,Customer.NameCustomer,Booking.RoomName,Booking.Quantity,Booking.DateCheckIn,Booking.DateCheckOut,Bill.Total
	from Bill as Bill,Booking as Booking, Customer as Customer
	where Bill.IdBill =Booking.IdBooking and Booking.IdCustomer = Customer.IdCustomer and Bill.IdBill = @IdBooking
end

go

create proc getemloyee
as
begin
	select IdEmployee,NamePosition,NameEmployee,DateOfBirth,GenderEmployee,PhoneNumber,IdCardEmployee,AddressEmployee,EmailEmployee
	from Employee,Position
	where Employee.IdPosition = Position.IdPosition
end

go

create proc getcustomer
as
begin
	select * from Customer
end