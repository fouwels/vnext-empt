$workingdir = "./src/pls";
switch -wildcard (([string]($args)))
{
	"dev*" {
		Start-Process "npm" "install" 	-NoNewWindow -Wait -WorkingDirectory $workingdir;
		Start-Process "grunt" 			-NoNewWindow -Wait -WorkingDirectory $workingdir;
		Start-Process "nuget" "restore" -NoNewWindow -Wait -WorkingDirectory $workingdir;
	}
	"full*" {
		Start-Process "npm" "install" 	-NoNewWindow -Wait -WorkingDirectory $workingdir;
		Start-Process "grunt" 			-NoNewWindow -Wait -WorkingDirectory $workingdir;
		Start-Process "nuget" "restore" -NoNewWindow -Wait -WorkingDirectory $workingdir;
	}
	"release*" {
		Start-Process "npm" "install" 	-NoNewWindow -Wait -WorkingDirectory $workingdir;
		Start-Process "grunt" 			-NoNewWindow -Wait -WorkingDirectory $workingdir;
		Start-Process "nuget" "restore" -NoNewWindow -Wait -WorkingDirectory $workingdir;
	}
}

echo "k.";

