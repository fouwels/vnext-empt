PROJ
=====

	Run: .\bootstrapr	dev
						full
						release
	To bootstrap

use latest dnx core

	dnvm upgrade
	dnvm use default -r coreclr
	dnx --watch . web
