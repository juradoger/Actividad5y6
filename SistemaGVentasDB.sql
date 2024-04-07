CREATE DATABASE SISTEMA_G_VENTAS;
CREATE TABLE VENTAS (
	IDVENTA			INT IDENTITY (1,1) NOT NULL,
	FECHAVENTA		DATETIME NOT NULL,
	TOTALVENTA		MONEY NOT NULL
	PRIMARY KEY(IDVENTA)
);
CREATE TABLE PRODUCTOS (
	IDPRODUCTO		INT IDENTITY (1,1) NOT NULL,
	NOMBRE			NVARCHAR(50) NOT NULL,
	PRECIOUNITARIO	MONEY NOT NULL
	PRIMARY KEY(IDPRODUCTO)
);
CREATE TABLE DETALLEVENTA (
	IDDETALLEVENTA		INT IDENTITY (1,1)NOT NULL,
	IDVENTA				INT NOT NULL,
	IDPRODUCTO			INT NOT NULL,
	CANTIDAD			INT NOT NULL,
	PRECIOUNITARIO		MONEY,
	TOTALDETALLE		MONEY
	PRIMARY KEY(IDDETALLEVENTA),
	FOREIGN KEY(IDVENTA) REFERENCES VENTAS(IDVENTA),
	FOREIGN KEY(IDPRODUCTO) REFERENCES PRODUCTOS(IDPRODUCTO)
);

INSERT INTO VENTAS (FECHAVENTA, TOTALVENTA) 
VALUES 
('2024-04-01 08:30:00', 150.00),
('2024-04-02 10:15:00', 200.00),
('2024-04-03 11:45:00', 180.50),
('2024-04-04 13:20:00', 220.75),
('2024-04-05 14:55:00', 300.20),
('2024-04-06 09:10:00', 175.60),
('2024-04-07 12:25:00', 250.30),
('2024-04-08 15:40:00', 190.00),
('2024-04-09 08:45:00', 280.90),
('2024-04-10 10:30:00', 210.40),
('2024-04-11 13:05:00', 195.75),
('2024-04-12 14:50:00', 230.80),
('2024-04-13 11:15:00', 265.25),
('2024-04-14 12:55:00', 320.10),
('2024-04-15 09:20:00', 275.50);

INSERT INTO PRODUCTOS (NOMBRE, PRECIOUNITARIO) 
VALUES 
('Camiseta de Algod�n', 15.99),
('Pantalones Vaqueros', 29.99),
('Zapatillas Deportivas', 39.99),
('Chaqueta de Cuero', 59.99),
('Vestido de Noche', 49.99),
('Reloj de Pulsera', 79.99),
('Bolso de Cuero', 34.99),
('Gafas de Sol', 24.99),
('Bufanda de Lana', 12.99),
('Sombrero de Fieltro', 19.99),
('Cintur�n de Cuero', 14.99),
('Botines de Cuero', 44.99),
('Mochila Escolar', 29.99),
('Malet�n de Viaje', 54.99),
('Paraguas Plegable', 9.99);

INSERT INTO DETALLEVENTA (IDVENTA, IDPRODUCTO, CANTIDAD, PRECIOUNITARIO, TOTALDETALLE) 
VALUES 
(1, 1, 2, 10.50, 21.00),
(1, 3, 1, 20.25, 20.25),
(1, 5, 3, 8.99, 26.97),
(2, 2, 2, 15.75, 31.50),
(2, 4, 1, 12.00, 12.00),
(2, 6, 2, 25.50, 51.00),
(3, 3, 3, 20.25, 60.75),
(3, 5, 2, 8.99, 17.98),
(3, 7, 1, 18.75, 18.75),
(4, 1, 1, 10.50, 10.50),
(4, 4, 2, 12.00, 24.00),
(4, 8, 3, 30.00, 90.00),
(5, 2, 3, 15.75, 47.25),
(5, 6, 1, 25.50, 25.50),
(5, 9, 2, 22.80, 45.60);