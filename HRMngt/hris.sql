use hris;


create table department(
	departmentID char(5) not null,
	name nvarchar(30) not null,
	phone char(10) not null,
	location nvarchar(80) not null,
	primary key(departmentID)
)
go

create table users(
	userID char(5) not null,
	name nvarchar(50) not null,
	email varchar(30) not null,
	phone varchar(10) not null,
	address nvarchar(80) not null,
	birthday date not null,
	sex bit not null,
	position char(20) not null,
	deal_salary int null,
	username varchar(20) not null,
	password varchar(50) not null,
	managerID char(5) not null,
	departmentID char(5) not null,
	contract_type varchar(15) null,
	on_boarding date null,
	close_date date null,
	scan_contract varchar(300) null,
	note nvarchar(500) null,
	ava varchar(300) not null,
	status bit not null,
	primary key(userID),
	foreign key(departmentID) references department(departmentID)
)
go

create table thumb(
	thumbID char(5) not null,
	sender char(5) not null,
	receiver char(5) not null,
	date date not null,
	content nvarchar(30) not null,
	money int not null,
	status char(10) not null,
	primary key(thumbID),
	foreign key(sender) references users(userID),
	foreign key(receiver) references users(userID)
)
go
create table ticket(
	ticketID char(5) not null,
	sender char(5) not null,
	receiver char(5) not null,
	date date not null,
	content	nvarchar(30) not null,
	money int not null,
	complain nvarchar(60) null,
	status char(10) not null,
	primary key(ticketID),
	foreign key(sender) references users(userID),
	foreign key(receiver) references users(userID)
)
go
create table salary(
	userID char(5) not null,
	get_month int not null,
	get_year int not null,
	workday int not null,
	real_workday int not null,
	welfare int not null,
	thumb_total int not null,
	ticket_total int not null,
	tax int not null,
	total_salary int not null,
	res nvarchar(300) null,
	status char(10) not null,
	primary key(userID, get_month, get_year),
	foreign key(userID) references users(userID)
)
go
create table calendar(
	userID char(5) not null,
	date date not null,
	register_checkIn datetime not null,
	register_checkOut datetime not null,
	real_checkIn datetime null,
	real_checkOut datetime null,
	checkIn_location nvarchar(80) null,
	checkOut_location nvarchar(80) null,
	status char(5) not null,
	primary key(userID, date),
	foreign key(userID) references users(userID)
)

CREATE TRIGGER CheckThumbInsert
ON thumb
AFTER INSERT
AS
BEGIN
    DECLARE @sender char(5)
    DECLARE @receiver char(5)
    DECLARE @date date
    DECLARE @errMsg nvarchar(100)

    SELECT @sender = sender, @receiver = receiver, @date = date
    FROM inserted

    -- Kiểm tra nếu sender là receiver
    IF @sender = @receiver
    BEGIN
        SET @errMsg = 'Error: Sender cannot be the same as receiver.'
        RAISERROR(@errMsg, 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END

END


ALTER TABLE users
ADD CONSTRAINT CHK_users_Status CHECK (status IN ('Created', 'Interviewed', 'Training', 'Internship', 'Probationary', 'Onboarding', 'Retired'));

ALTER TABLE thumb
ADD CONSTRAINT CHK_thumb_Status CHECK (status IN ('Created', 'Deleted'));

ALTER TABLE ticket
ADD CONSTRAINT CHK_ticket_Status CHECK (status IN ('Created', 'Complain', 'Deleted'));

ALTER TABLE calendar
ADD CONSTRAINT CHK_calendar_Status CHECK (status IN ('Created', 'Approved', 'Rejected', 'Deleted','Attendance logged','Late', 'Consider'));


CREATE TRIGGER trg_UpdateRealWorkday
ON calendar
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @UserID char(5)
    DECLARE @Month int
    DECLARE @Year int
    DECLARE @RealWorkday int

    -- Lấy UserID, tháng và năm từ bảng calendar
    SELECT @UserID = UserID, @Month = MONTH(date), @Year = YEAR(date)
    FROM inserted

    -- Tính toán số ngày làm việc thực tế (real_workday) cho user trong tháng/năm tương ứng
    SELECT @RealWorkday = COUNT(*)
    FROM calendar
    WHERE userID = @UserID
    AND MONTH(date) = @Month
    AND YEAR(date) = @Year
    AND status = 'Attendance logged'

    -- Cập nhật real_workday trong bảng salary
    UPDATE salary
    SET real_workday = @RealWorkday
    WHERE userID = @UserID
    AND get_month = @Month
    AND get_year = @Year
END

-- Trigger tính thumbTotal và ticketTotal
-- Trigger tính thuế
-- Trigger tính total Salary

