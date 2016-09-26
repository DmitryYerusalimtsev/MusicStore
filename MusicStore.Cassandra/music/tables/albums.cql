USE music;

CREATE TABLE IF NOT EXISTS albums(
	artist_id uuid,
	album_name text,
	description text,
	year int,
	logo blob,
	PRIMARY KEY ((artist_id), album_name)
)
WITH comment = 'Q4: Find artist albums.';