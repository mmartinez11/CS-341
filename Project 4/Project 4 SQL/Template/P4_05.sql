-- 5.	Write a SQL query which which produces a table containing the 
-- name of each country and the count of how many articles are in the dataset from each country.
select country_table.country, count(news.news_id) as articleCount
from news
right join country_table
on country_table.country_id = news.country_id
GROUP BY country_table.country
order by articleCount DESC;
