
window.callVolume_Remote = function (callVolume) {

	try {

		if (localStream && _OwnerPeerUserID && _RemotePeerUserID && _CallIsRunning) {

			Android.jsCall_Speaking_Volume_Change(callVolume);

			console.log('callVolume_Remote == ' + callVolume_Remote);

			//localStream.getAudioTracks()[0].enabled = false;

			//peer.socket._socket.send('{"type":"AUDIOMUTE","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"volume","action":"mute"}}');


			//peer.socket._socket.send('{"type":"AUDIOVOLUME","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"volume","action":"' + callVolume + '"}}');

		}
	} catch (e) {

	}

}


// Owner Camera Pause
window.remote_VideoPause = function () {

	try {

		//remote_HideCamera();
		document.getElementById('divRemoteCamera').style.display = 'none';

		//Android.jsCall_remote_Pause();


		//if (document.getElementById('divOwnerCamera').style.display == 'block') {
		//	document.getElementById('divOwnerCameraSplash').style.display = 'block';
		//} else {
		//	document.getElementById('divOwnerCameraSplash').style.display = 'none';
		//}


	} catch (e) {
		return;
	}

}

// Owner Camera Resume
window.remote_VideoResume = function () {

	try {

		//remote_ShowCamera();
		document.getElementById('divRemoteCamera').style.display = 'block';

		//Android.jsCall_remote_Resume();

		//if (document.getElementById('divOwnerCamera').style.display == 'block') {
		//	document.getElementById('divOwnerCameraSplash').style.display = 'none';
		//} else {
		//	document.getElementById('divOwnerCameraSplash').style.display = 'none';
		//}

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

		//owner_HideCamera();
		//remote_HideCamera();

		document.getElementById('divOwnerCamera').style.display = 'none';
		document.getElementById('divRemoteCamera').style.display = 'none';
		//document.getElementById('divOwnerCameraSplash').style.display = 'none';

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

		//owner_HideCamera();
		//remote_HideCamera();

		document.getElementById('divOwnerCamera').style.display = 'none';
		document.getElementById('divRemoteCamera').style.display = 'none';
		//document.getElementById('divOwnerCameraSplash').style.display = 'none';

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
