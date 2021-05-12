-- 1.	Write a SQL query which, given a news id stored in the variable @nid, generates a table containing the title of the article with that id.
-- SET @nid = 1;
-- set in the database load?

SELECT title
FROM news
WHERE news_id = @nid;
