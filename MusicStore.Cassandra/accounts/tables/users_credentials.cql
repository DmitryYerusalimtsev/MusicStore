USE accounts;

CREATE TABLE IF NOT EXISTS users_credentials(
	user_id uuid,
	logon_name text,
	password_hash text,
	PRIMARY KEY ((logon_name, password_hash), user_id)
)
WITH comment = 'Q13: Find user by credentials.';