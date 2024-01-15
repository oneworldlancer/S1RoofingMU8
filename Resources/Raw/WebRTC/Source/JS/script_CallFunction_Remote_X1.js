
// Owner Camera Pause
window.remote_VideoPause = function () {

	try {

		remote_HideCamera();
		Android.jsCall_remote_Pause();

	} catch (e) {
		return;
	}

}

// Owner Camera Resume
window.remote_VideoResume = function () {

	try {

		//remote_ShowCamera();
		document.getElementById('divRemoteCamera').style.display = 'block';
		Android.jsCall_remote_Resume();

	} catch (e) {
		return;
	}


}

// Owner Audio Mute
window.remote_Mute = function () {
	callMute();
}

// Owner Audio UnMute
window.remote_UnMute = function () {
	callUnMute();
}

// Owner Call Hold
window.remote_Hold = function () {

	try {

		if (localStream) {

			localStream.getAudioTracks()[0].enabled = false;
			localStream.getVideoTracks()[0].enabled = false;
		}

		document.getElementById('divOwnerCamera').style.display = 'none';
		document.getElementById('divRemoteCamera').style.display = 'none';

		_CallType = 'voice';

		Android.jsCall_remote_Hold();

	} catch (e) {

	}





}

// Owner Call UnHold
window.remote_UnHold = function () {

	try {

		if (localStream) {

			localStream.getAudioTracks()[0].enabled = true;
			localStream.getVideoTracks()[0].enabled = false;
		}

		document.getElementById('divOwnerCamera').style.display = 'none';
		document.getElementById('divRemoteCamera').style.display = 'none';

		_CallType = 'voice';


		Android.jsCall_remote_UnHold();

	} catch (e) {

	}

}



window.remote_ShowCamera = function () {

	try {

		$("#divRemoteCamera").fadeIn('slow');
	} catch (e) {

	}


}


window.remote_HideCamera = function () {

	try {

		$("#divRemoteCamera").fadeOut('slow');

	} catch (e) {

	}


}
