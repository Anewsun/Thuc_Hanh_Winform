CREATE TABLE HocSinh (
Ten varchar(100),
Diachi varchar(255),
Cmnd varchar(100),
NgaySinh Date
);
CREATE TABLE GiangVien(
Ten varchar(100),
Diachi varchar(255),
Cmnd varchar(100),
NgaySinh Date
);
INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgaySinh)
VALUES ('nva', 'hcm', '123', '2003-10-03');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgaySinh)
VALUES ('nva2', 'hcm', '1234', '2003-05-03');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgaySinh)
VALUES ('nva3', 'hcm', '1235', '2002-12-11');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgaySinh)
VALUES ('nva4', 'hcm', '1236', '2001-01-06');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgaySinh)
VALUES ('nva5', 'hcm', '1237', '2004-07-21');

INSERT INTO GiangVien(Ten, Diachi, Cmnd, NgaySinh)
VALUES ('gva', 'so1vvn', '321', '1990-10-03');
INSERT INTO GiangVien(Ten, Diachi, Cmnd, NgaySinh)
VALUES ('gva2', 'so2vvn', '4321', '1987-05-03');
INSERT INTO GiangVien(Ten, Diachi, Cmnd, NgaySinh)
VALUES ('gva3', 'hcm', '5321', '1974-12-11');
INSERT INTO GiangVien(Ten, Diachi, Cmnd, NgaySinh)
VALUES ('gva4', 'thu duc', '6321', '1999-01-06');
INSERT INTO GiangVien(Ten, Diachi, Cmnd, NgaySinh)
VALUES ('gva5', 'Le Van viet', '7321', '1995-07-21');
select * from HocSinh
select * from GiangVien