-- 10.	Write a SQL query linking each author to their probable political bias, based on the articles they’ve written.  
-- The table should contain three columns, the author name, the political bias, and the count of how many articles that author has published with that bias.  
-- Order the results alphabetically by author name, from greatest number of articles to least, and alphabetically by bias in the case of a tie.
select author_table.author, political_bias_table.political_bias, count(news.political_bias_id) as numArticles
from news
join news_authors
on news_authors.news_id = news.news_id
join author_table
on author_table.author_id = news_authors.author_id
join political_bias_table
on political_bias_table.political_bias_id = news.political_bias_id
group by author_table.author, political_bias_table.political_bias
order by author_table.author asc, count(news.political_bias_id) desc, political_bias_table.political_bias asc;
