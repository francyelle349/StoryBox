d
create table livros (id int, title varchar(20), price float);

insert into livros(id, title, price) values (2,'Love hypothesis', 33.65);
insert into livros(id,title,price) values (3,'harry potter',45.89);
insert into livros(id,title,price) values (4,'percy jackson', 90.89);
insert into livros(id,title,price) values (5,'under one roof', 56.87);
insert into livros(id,title,price) values (7,'under the rain2', 15.00);
delete from livros where id = 2;
delete from livros where id = 6;
alter table livros add  ISBN int;
update livros set ISBN = 5838392 where id = 2;
update livros set ISBN = 4848382 where id = 3;
update livros set ISBN = 3722289 where id = 4;
update livros set ISBN = 48448483 where id = 5;

-- constraint UNIQUE;
ALTER TABLE livros
ADD UNIQUE (ID);
alter table livros alter column id int NOT NULL;
ALTER TABLE livros
DROP CONSTRAINT CHK_PersonAge;
ALTER TABLE livros
ADD CONSTRAINT CHK_livrosPrice CHECK (price >=12);
select * from livros;

SELECT DATEPART(YEAR, GETDATE())        AS 'Year';        
SELECT DATEPART(QUARTER, GETDATE())     AS 'Quarter';     
SELECT DATEPART(MONTH, GETDATE())       AS 'Month';       
SELECT DATEPART(DAYOFYEAR, GETDATE())   AS 'DayOfYear';   
SELECT DATEPART(DAY, GETDATE())         AS 'Day';         
SELECT DATEPART(WEEK, GETDATE())        AS 'Week';        
SELECT DATEPART(WEEKDAY, GETDATE())     AS 'WeekDay';     
SELECT DATEPART(HOUR, GETDATE())        AS 'Hour';        
SELECT DATEPART(MINUTE, GETDATE())      AS 'Minute';      
SELECT DATEPART(SECOND, GETDATE())      AS 'Second';      
SELECT DATEPART(MILLISECOND, GETDATE()) AS 'MilliSecond'; 
SELECT DATEPART(MICROSECOND, GETDATE()) AS 'MicroSecond'; 
SELECT DATEPART(NANOSECOND, GETDATE())  AS 'NanoSecond';  
SELECT DATEPART(ISO_WEEK, GETDATE())    AS 'Week'; 

SELECT DATEFROMPARTS(2019,1,1)                         AS 'Date';          -- returns date
SELECT DATETIME2FROMPARTS(2019,1,1,6,0,0,0,1)          AS 'DateTime2';     -- returns datetime2
SELECT DATETIMEFROMPARTS(2019,1,1,6,0,0,0)             AS 'DateTime';      -- returns datetime
SELECT DATETIMEOFFSETFROMPARTS(2019,1,1,6,0,0,0,0,0,0) AS 'Offset';        -- returns datetimeoffset
SELECT SMALLDATETIMEFROMPARTS(2019,1,1,6,0)            AS 'SmallDateTime'; -- returns smalldatetime
SELECT TIMEFROMPARTS(6,0,0,0,0)                        AS 'Time';          -- returns time

SELECT DATEDIFF(DAY, 2019-31-01, 2019-01-01)      AS 'DateDif'    -- returns int
SELECT DATEDIFF_BIG(DAY, 2019-31-01, 2019-01-01)  AS 'DateDifBig' -- returns bigint
