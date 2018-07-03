CREATE PROCEDURE GetCards
As
SELECT  b.bankId,b.bankName,c.cardName,c.imageUrl,b.logoUrl,c.intRate,c.creditLimit
FROM    banks b LEFT JOIN cards c 
            ON b.bankId = c.bankId
ORDER   BY b.bankId

