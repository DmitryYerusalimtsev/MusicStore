CREATE KEYSPACE IF NOT EXISTS accounts
WITH REPLICATION = { 
	'class' : 'SimpleStrategy', 
	'replication_factor' : 3 
	}
AND DURABLE_WRITES = true;