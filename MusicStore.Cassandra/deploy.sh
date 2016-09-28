# DOES NOT WORK!!!

# Go to cassandra's directory.
CASSANDRA_ROOT='D:/Servers/DataStax-DDC/apache-cassandra'
CQLSH=CASSANDRA_ROOT'/bin/cqlsh'

# Run cqlsh.
eval $CQLSH

KEYSPACES='music accounts'
DIRECTORIES_TO_EXECUTE='types tables views'

# Iterate through a list of keyspaces.
for ks in $KEYSPACES
do
  echo $ks
  PATH_TO_SCRIPT=$ks

  # Iterate through all files in keyspace directory.
  for s in $PATH_TO_SCRIPT'/*'
  do
	echo $s
	SOURCE $s
  done

  # Iterate through all files in sub-directories.
  for d in DIRECTORIES_TO_EXECUTE
  do
    for s in $PATH_TO_SCRIPT'/'$d'/*'
	do
	  echo $s
	  SOURCE $s
    done
  done
done
