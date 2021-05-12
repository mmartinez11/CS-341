-- 4.	Write a SQL query which produces a table of unique publisher names that have news articles in the data set.
select DISTINCT publisher_table.publisher
from publisher_table
join news
on publisher_table.publisher_id=news.publisher_id
order by publisher_table.publisher asc;
