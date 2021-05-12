-- What is the range of reliability for each category of political bias?
select political_bias, min(news_guard_score) as MIN, max(news_guard_score) as MAX
from news 
group by political_bias;
