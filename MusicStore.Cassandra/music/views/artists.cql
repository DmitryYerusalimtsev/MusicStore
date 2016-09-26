USE music;

CREATE MATERIALIZED VIEW IF NOT EXISTS artists AS
SELECT artist_id,
	name,
	founded,
	logo
FROM artists_info
WHERE artist_id IS NOT NULL
PRIMARY KEY ((artist_id), name);