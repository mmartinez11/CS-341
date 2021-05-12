-- 9.	Write a SQL query which produces a table containing unique countries and their average news_guard_score.
select country_table.country, round((sum(news_guard_score)/count(*)), 3) as "avg_news_score"
from news
join country_table
on country_table.country_id = news.country_id
group by country_table.country
order by avg_news_score desc, country desc;
