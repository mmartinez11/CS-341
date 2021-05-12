-- 6.	Write a SQL query which produces a table containing the average news_guard_score for the data set.

SELECT ROUND(AVG(news_guard_score),3) AS `Average Score`
FROM news;
