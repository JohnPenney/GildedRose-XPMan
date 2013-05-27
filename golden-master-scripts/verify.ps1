# Based on scripts from https://github.com/SamirTalwar/trivia-golden-master.git

if ($args.Count -ne 2)
{ 
	echo "Usage: verify \""your command here\"" \""output directory\"""
	exit
} 

$command=$args[0]
$dir=$args[1]

$failures=0
$latest_output="$dir/latest-output"

iex $command > $latest_output
$diff=diff (cat "$dir/golden-master") (cat $latest_output)
if ($diff)
{
    echo $diff
    $failures+=1
}

if ($failures -eq 0)
{
    echo "*** Passed ***"
    exit
}
else
{
    echo  "*** There were failures ***"
    exit
}
