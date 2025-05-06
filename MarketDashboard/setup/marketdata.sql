-- Create a new database
CREATE DATABASE MarketData;
GO

-- Use that new database
USE MarketData;
GO

-- Create a table to store fake market data
CREATE TABLE MarketPrices (
    Id INT PRIMARY KEY IDENTITY,
    Ticker NVARCHAR(10),
    Price FLOAT,
    Volume INT,
    Timestamp DATETIME
);
GO

-- Insert fake stock market data
INSERT INTO MarketPrices (Ticker, Price, Volume, Timestamp)
VALUES 
('AAPL', 178.45, 1200, GETDATE()),
('TSLA', 255.10, 980, GETDATE()),
('GOOG', 135.77, 1500, GETDATE()),
('MSFT', 310.15, 2000, GETDATE()),
('AMZN', 120.89, 870, GETDATE());