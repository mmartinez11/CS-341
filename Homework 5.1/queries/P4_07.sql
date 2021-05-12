-- 7.	Write a SQL query which produces a table containing for each month, 
-- the name of the month, the number of articles released in that month, 
-- the overall number of articles released, and the percentage of the overall number of articles released in that month.  

SELECT month, numArticles, overall, ROUND(100*numArticles/overall,3) AS percentage
FROM
(
SELECT month, monthnum, COUNT(publish_date) AS numArticles, overallCount AS overall
FROM
(
SELECT DATE_FORMAT(STR_TO_DATE(publish_date, '%m/%d/%y'), '%M') AS month, 
       DATE_FORMAT(STR_TO_DATE(publish_date, '%m/%d/%y'), '%m') AS monthnum,
	   publish_date
FROM news
) AS T1
JOIN
(
SELECT COUNT(*) overallCount FROM news
) AS T2
GROUP BY month, monthnum, overallCount
) AS T3
ORDER BY monthnum;
