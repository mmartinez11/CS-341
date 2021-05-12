-- 3.	Write a SQL query which produces a table containing the title and month of each article. 

SELECT title, DATE_FORMAT(STR_TO_DATE(publish_date, '%c/%d/%y'), '%M') AS Month
FROM news
ORDER BY STR_TO_DATE(publish_date, '%m/%d/%y')

