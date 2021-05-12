-- 7.	Write a SQL query which produces a table containing for each month, 
-- the name of the month, the number of articles released in that month, 
-- the overall number of articles released, and the percentage of the overall number of articles released in that month.  
SELECT DATE_FORMAT(STR_TO_DATE(publish_date,"%m/%d/%y"), "%M") as "month", count(*) as numArticles,
(select count(*) from news) as overall, round(count(*)/(select count(*) from news) * 100, 3) as percentage
from news
group by DATE_FORMAT(STR_TO_DATE(publish_date,"%m/%d/%y"), "%M")
order by DATE_FORMAT(STR_TO_DATE(publish_date,"%m/%d/%y"), "%m") asc;
