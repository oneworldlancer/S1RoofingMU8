window.scnWid, window.scnHei;

var OwnerWidth, OwnerHeight,
	RemoteWidth, RemoteHeight;

window.docHeight = function ()
{
	if ( self.innerHeight ) // all except Explorer
	{
		scnWid = self.innerWidth;
		scnHei = self.innerHeight;
	}
	else if ( document.documentElement && document.documentElement.clientHeight )
		// Explorer 6 Strict Mode
	{
		scnWid = document.documentElement.clientWidth;
		scnHei = document.documentElement.clientHeight;
	}
	else if ( document.body ) // other Explorers
	{
		scnWid = document.body.clientWidth;
		scnHei = document.body.clientHeight;
	}

	//document.getElementById('divRemoteCamera').style.width = (scnWid) + 'px';
	//document.getElementById('divRemoteCamera').style.height = (scnHei) + 'px';

	//document.getElementById('remote-video').style.width = (scnWid) + 'px';
	//document.getElementById('remote-video').style.height = (scnHei) + 'px';


	//document.getElementById('divOwnerCamera').style.width = (scnWid / 4) + 'px';
	//document.getElementById('divOwnerCamera').style.height = (((scnWid / 4) / 4) * 3) + 'px';


	//document.getElementById('local-video').style.width = (scnWid / 4) + 'px';
	//document.getElementById('local-video').style.height = (((scnWid / 4) / 4) * 3) + 'px';

}