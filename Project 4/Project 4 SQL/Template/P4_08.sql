-- 8.	Write a SQL query which produces a table containing the publisher names, 
-- and the percentage of articles for which are marked as reliable (1) among the articles published by that publisher.
select publisher_table.publisher, round((sum(reliability)/count(*)*100), 3) as "percentage"
from news
join publisher_table
on publisher_table.publisher_id = news.publisher_id
group by publisher_table.publisher
order by round((sum(reliability)/count(*)*100), 3) desc, publisher_table.publisher asc;
