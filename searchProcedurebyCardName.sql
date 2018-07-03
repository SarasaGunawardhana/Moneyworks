CREATE PROCEDURE searchCards(@searchName VARCHAR(100))
As
SELECT  b.bankId,b.bankName,c.cardName,c.imageUrl,b.logoUrl,c.intRate,c.creditLimit
FROM    banks b LEFT JOIN cards c 
            ON b.bankId = c.bankId
WHERE c.cardName Like '%'+@searchName+'%';