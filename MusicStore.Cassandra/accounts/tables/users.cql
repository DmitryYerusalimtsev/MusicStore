USE accounts;

CREATE TABLE IF NOT EXISTS users(
	user_id uuid,
	first_name text,
	last_name text,
	email text
	PRIMARY KEY ((user_id), first_name, last_name)
)
WITH comment = 'Q9: Find information about my account.';