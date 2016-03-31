--SQL Есть схема Customer (Id, Name), Sale (Id, CustomerId, Date, Sum)
--Написать запросы:
--1. Лучший покупатель за все время (тот Customer, у которого суммарно больше всего поле Sum)
--2. Лучший покупатель для каждого месяца (то же самое, что и 1, только для каждого месяца текущего года)
--Как вывести все числа, встречающиеся в колонке A более двух раз?
--Как сделать сумму по нарастающей? Например, есть таблица с датой и суммой продаж на каждую дату, нужно на
  --каждую дату выводить сумму продаж с начала года вплоть до этой даты включительно.
--Что такое нормализация сущностей в реляционной СУБД?
--RDBMS transactions isolation levels, blocks, deadlocks.
--select * from T1,T2 что будет в результате ?
--Как найти неуникальные значения в одном столбце? Решает. group by having... а в двух ?

datepart(month,ARR_DATE)

-- как найти дубли записей в таблице
SELECT col1, col2, col3, col4
FROM table
GROUP BY col1, col2, col3, col4
HAVING COUNT(*) > 1


--Как сделать сумму по нарастающей?
    SELECT date, SUM(out) out, 
      (SELECT SUM(out) 
       FROM Outcome_o 
       WHERE date <= o.date) run_tot 
    FROM Outcome_o o
    GROUP BY datepart(month,ARR_DATE);
	
--Теперь посчитаем нарастающий итог. То есть для каждого товара и даты посчитаем сумму продаж с начальной даты в заданной партиции до текущей даты. --Это опять-таки можно сделать, используя один запрос, без всяких джойнов. Используется расширение предложения over в агрегирующей функции:
select dtDate, iGoodId, sum ( mSells ) 
over 
( partition by iGoodId order by iGoodId asc, dtDate asc rows between unbounded preceding and current row )
from #goods
	

--как найти 
UPDATE sales
SET    status = 'ACTIVE'
WHERE  (saleprice, saledate) IN (
    SELECT saleprice, saledate
    FROM   sales
    GROUP  BY saleprice, saledate
    HAVING count(*) = 1 
    );


--Лучший покупатель за все время (тот Customer, у которого суммарно больше всего поле Sum)
SELECT NAME, SM FROM
(SELECT dc.NAME, SUM(fcs.SUM) AS SM,
  MAX(SUM(fcs.SUM)) OVER() AS maxSM
  FROM BI.DIM_CUSTOMERS dc
  INNER JOIN
  BI.FCT_CUSTOMERS_SALES fcs
  ON dc.ID = fcs.CUSTOMER_ID
  GROUP BY dc.NAME
  ) WHERE SM = maxSM;

--Лучший покупатель за все время (тот Customer, у которого суммарно больше всего поле Sum)
-- для каждого месяца текущего года.
SELECT NAME, SM FROM
(SELECT dc.NAME, SUM(fcs.SUM) AS SM,
  MAX(SUM(fcs.SUM)) OVER() AS maxSM
  FROM BI.DIM_CUSTOMERS dc
  INNER JOIN
  BI.FCT_CUSTOMERS_SALES fcs
  ON dc.ID = fcs.CUSTOMER_ID
  GROUP BY dc.NAME,EXTRACT(MONTH FROM fcs.DATE))
  ) WHERE SM = maxSM;

---Как вывести все числа, встречающиеся в колонке A более двух раз?  
  select a from t 
where a>0
group by a
having count(a)>1
  
  


  
  
 select country, count(*) as members, EXTRACT(MONTH FROM joined) as mn, EXTRACT(YEAR FROM JOINED) as yr,MIN(JOINED) as dt
from table
group by country, EXTRACT(MONTH FROM joined), EXTRACT(YEAR FROM JOINED)

select col,sm

from (select col, sum(col2) as sm,

      max(sum(col2)) over() as maxSm

        from <huge query>

      group by col)

where sm = maxSm;

--select * from
--(
--select a.*,rank() over (order by sum_sales desc) r from
--(
--select pub_id,sum(sales*price) sum_sales from titles group by pub_id
--) a
--)
--where r = 1;   



--UPDATE BI.DIM_PRJS s
--SET POS = 
--(
--  SELECT sp.POS
--	FROM 
--	(
--     SELECT ID, ROW_NUMBER() OVER(PARTITION BY BGT_YRS_KEY, PARENT_ID ORDER BY BGT_YRS_KEY, PARENT_ID, CODE) POS
--		 FROM BI.DIM_PRJS
--  ) sp
--  WHERE sp.ID = s.ID
--);


