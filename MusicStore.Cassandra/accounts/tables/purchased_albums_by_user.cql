USE accounts;

CREATE TABLE IF NOT EXISTS purchased_albums_by_user(
	user_id uuid,
	artist_id text,
	album_name text,
	year int,
	purchase_date date,
	logo blob,
	PRIMARY KEY ((user_id), artist_id, purchase_date, album_name)
)
WITH comment = 'Q10: Find my bought albums.';