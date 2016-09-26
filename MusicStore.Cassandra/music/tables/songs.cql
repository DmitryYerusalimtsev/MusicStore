USE music;

CREATE TABLE IF NOT EXISTS songs(
	artist_id uuid,
	song_name text,
	album_name text,
	artist_name text,
	genre text,
	file_id uuid,
	PRIMARY KEY ((artist_id, song_name), artist_name, genre, album_name)
)
WITH comment = 'Q6: Find all songs by genre.
		Q7: Find all songs of provided artist.
		Q8: Find all songs by search string.';