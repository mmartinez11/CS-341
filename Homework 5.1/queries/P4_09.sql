-- 9.	Write a SQL query which produces a table containing unique countries and their average news_guard_score.

SELECT country, ROUND(AVG(news_guard_score),3) AS avg_news_score
FROM news
JOIN country_table
USING (country_id)
GROUP BY country
ORDER BY AVG(news_guard_score) DESC, country ASC;
