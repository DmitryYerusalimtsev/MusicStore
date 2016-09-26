USE music;

CREATE MATERIALIZED VIEW IF NOT EXISTS albums_by_artist AS
SELECT artist_id,
	album_name,
	year,
	logo
FROM albums
WHERE artist_id IS NOT NULL 
	AND album_name IS NOT NULL 
	AND year IS NOT NULL
PRIMARY KEY ((artist_id), album_name, year);