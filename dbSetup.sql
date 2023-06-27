-- Active: 1687891568252@@SG-lacy-trader-563-7673-mysql-master.servers.mongodirector.com@3306@GregslistHouses
CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';


-- CREATE TABLE houses(
--   id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
--   make VARCHAR(100) NOT NULL,
--   model VARCHAR(100) NOT NULL,
--   year INT NOT NULL DEFAULT 1990,
--   price DOUBLE NOT NULL DEFAULT 1.00,
--   color VARCHAR(100) NOT NULL,
--   description VARCHAR(500),

--   createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
--   updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP 
-- )  default charset utf8 COMMENT '';

CREATE TABLE houses(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  -- make VARCHAR(100) NOT NULL,
  -- model VARCHAR(100) NOT NULL,
  year INT NOT NULL DEFAULT 1990,
  price DOUBLE NOT NULL DEFAULT 1.00,
  address VARCHAR (250) NOT NULL,
  -- color VARCHAR(100) NOT NULL,
  bedrooms INT NOT NULL DEFAULT 1,
  bathrooms INT NOT NULL DEFAULT 1,
  description VARCHAR(500),

  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP 
)  default charset utf8 COMMENT '';

INSERT INTO houses 
(year, price, address, bedrooms, bathrooms, description)
VALUES
(1976, 175000, "486 Mason Dr", 2, 5, "Old trap house gone wrong. Need to sell ASAP, great deal");

SELECT * FROM houses ORDER BY createdAt DESC;

INSERT INTO houses 
(year, price, address, bedrooms, bathrooms, description)
VALUES
(1947, 17500000, "12 Poop Ct. Boise Idaho", 4, 3, "House designed by Luis Barragan. Idk why he wants to sell.");

INSERT INTO houses 
(year, price, address, bedrooms, bathrooms, description)
VALUES
(2012, 69000, "997 Lewis St Boise, Idaho", 3, 2, "My dog died and now i cant stand this place");

INSERT INTO houses 
(year, price, address, bedrooms, bathrooms, description)
VALUES
(2022, 550000, "3875 Nopal Dr. Nampa,Idaho", 2,1, "This market is craazy");

SELECT * FROM houses where id = LAST_INSERT_ID();

SELECT * FROM houses;

SELECT * FROM houses ORDER BY `createdAt` DESC;

