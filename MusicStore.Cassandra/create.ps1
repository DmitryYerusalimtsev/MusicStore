$cassandraRoot = "D:/Servers/DataStax-DDC/apache-cassandra"
$cqlsh = "$cassandraRoot/bin/cqlsh"
$server = "localhost"
$port = "9042"

$keyspaces = @(
	"accounts",
	"music"
)

$keyspaceDirs = @(
	"types",
	"tables",
	"views"
)

# Executes all CQL scripts in specified directory.
function Execute-CQL([string]$dir)
{
	$dirExists = Test-Path $dir
    if($dirExists)
    {
		Get-ChildItem $dir -Filter *.cql | 
		Foreach-Object {
			$filePath = Join-Path $dir $_

			$command = "$cqlsh -f '$filePath' $server $port"
			$job = Start-Job { iex "$args" } -ArgumentList $command

			Wait-Job $job        
			echo $("$filePath DONE")
		}
	}
}

foreach ($ks in $keyspaces) 
{
	$scriptDir = Join-Path $PSScriptRoot.ToString() $ks
	Execute-CQL -dir $scriptDir

	foreach($ksDir in $keyspaceDirs)
	{
		$scrDir = Join-Path $scriptDir $ksDir
        Execute-CQL -dir $scrDir
	}
}
