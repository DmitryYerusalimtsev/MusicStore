USE music;

CREATE TABLE IF NOT EXISTS artists_info(
	artist_id uuid,
	name text,
	description text,
	founded frozen<founded_info>,
	genres list<text>,
	language text,
	logo blob,
	PRIMARY KEY (artist_id )
)
WITH comment = 'Q2:  Find information about provided artist.';