USE music;

CREATE TABLE IF NOT EXISTS artists_info(
	artist_id uuid PRIMARY KEY,
	name text,
	description text,
	founded frozen<founded_info>,
	genres list<text>,
	language text,
	logo blob
);