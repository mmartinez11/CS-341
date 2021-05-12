-- 8.	Write a SQL query which produces a table containing the publisher names, 
-- and the percentage of articles for which are marked as reliable (1) among the articles published by that publisher.

SELECT publisher, ROUND(AVG(reliability)*100, 3) AS percentage
FROM news
JOIN publisher_table
USING (publisher_id)
GROUP BY publisher
ORDER BY percentage DESC, publisher;
