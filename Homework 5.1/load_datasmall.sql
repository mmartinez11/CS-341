CREATE DATABASE IF NOT EXISTS hw5;
USE hw5;

DROP TABLE IF EXISTS author_table;
CREATE TABLE author_table (
  author_id int DEFAULT NULL,
  author text
);

INSERT INTO author_table VALUES (4,'Nicole Wetsman');
INSERT INTO author_table VALUES (2,'Roni Caryn Rabin');
INSERT INTO author_table VALUES (1,'Knvul Sheikh');
INSERT INTO author_table VALUES (3,'Emily Feng');


DROP TABLE IF EXISTS country_table;
CREATE TABLE country_table (
  country_id int DEFAULT NULL,
  country text
);

INSERT INTO country_table VALUES (1,'USA');
INSERT INTO country_table VALUES (3,'UK');
INSERT INTO country_table VALUES (5,'India');


DROP TABLE IF EXISTS news;
CREATE TABLE news (
  news_id int DEFAULT NULL,
  url text,
  publisher_id int DEFAULT NULL,
  publish_date text,
  title text,
  image text,
  body_text text,
  news_guard_score double DEFAULT NULL,
  mbfc_level text,
  political_bias_id int DEFAULT NULL,
  country_id int DEFAULT NULL,
  reliability int DEFAULT NULL
);

INSERT INTO news VALUES (1024, '', 4, '3/22/18', 'Bagels', '', 'text', '40', 'Very high', 3, 3, '1');
INSERT INTO news VALUES (58,'https://www.nytimes.com/article/what-is-coronavirus.html',1,'1/21/20','The Coronavirus: What Scientists Have Learned So Far','https://static01.nyt.com/images/2020/03/12/science/26VIRUS-EXPLAINER-update1/26VIRUS-EXPLAINER-update1-facebookJumbo.jpg','ABC',80,'High',1,1,1);
INSERT INTO news VALUES (1,'https://www.npr.org/2020/01/22/798392172/chinese-health-officials-more-die-from-newly-identified-coronavirus',2,'2/22/20','Chinese Health Officials: More Die From Newly Identified Coronavirus','https://media.npr.org/include/images/facebook-default-wide.jpg?s=1400','Chinese Health Officials: More Die From Newly Identified Coronavirus',100,'Very high',2,1,1);
INSERT INTO news VALUES (2,'https://www.theverge.com/2020/1/23/21078457/coronavirus-outbreak-china-wuhan-quarantine-who-sars-cdc-symptoms-risk',2,'2/23/19','Everything you need to know about the coronavirus','https://cdn.vox-cdn.com/thumbor/a9_Oz7cvSBKyalibjq3yKtypMqc=/0x153:2130x1268/fit-in/1200x630/cdn.vox-cdn.com/uploads/chorus_asset/file/19581722/VRG_ILLO_1777_AK_vaccine.0.jpg','Public health experts around the globe are scrambling to understand, track, and contain a new virus that appeared in Wuhan, China, at the beginning of December 2019. \nThe US currently has the worst outbreak of any country in the world.',75,'High',3,1,0);


DROP TABLE IF EXISTS news_authors;
CREATE TABLE news_authors (
  news_id int DEFAULT NULL,
  author_id int DEFAULT NULL
);

INSERT INTO news_authors VALUES (58,1);
INSERT INTO news_authors VALUES (58,2);
INSERT INTO news_authors VALUES (1,3);
INSERT INTO news_authors VALUES (2,4);
INSERT INTO news_authors VALUES (1024,1);
INSERT INTO news_authors VALUES (1024,4);


DROP TABLE IF EXISTS political_bias_table;
CREATE TABLE political_bias_table (
  political_bias_id int DEFAULT NULL,
  political_bias text
);

INSERT INTO political_bias_table VALUES (1,'Alphabet');
INSERT INTO political_bias_table VALUES (2,'Center');
INSERT INTO political_bias_table VALUES (3,'Left-center');


DROP TABLE IF EXISTS publisher_table;
CREATE TABLE publisher_table (
  publisher_id int DEFAULT NULL,
  publisher text
);

INSERT INTO publisher_table VALUES (1,'The New York Times');
INSERT INTO publisher_table VALUES (2,'National Public Radio (NPR)');
INSERT INTO publisher_table VALUES (3,'The Daily Bugle');
INSERT INTO publisher_table VALUES (4,'Whispers of Washington');
