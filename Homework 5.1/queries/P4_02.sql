-- 2.	Write a SQL query which produces the news id and length of articles, 
-- but only for articles with a length greater than 100 characters.

SELECT news_id, LENGTH(body_text) AS length
FROM news
WHERE LENGTH(body_text)>100
ORDER BY news_id;
