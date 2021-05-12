-- Which are the reliable publishers?
select publisher
from news 
where news_guard_score > 75;

