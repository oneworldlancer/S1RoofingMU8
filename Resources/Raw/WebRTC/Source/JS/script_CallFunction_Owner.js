
window.callVolume_Owner = function (callVolume) {

	try {

		if (localStream && _OwnerPeerUserID && _RemotePeerUserID) {

			////peer.socket._socket.send('{"type":"AUDIOVOLUME","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"audio","action":"mute"}}');

			//////localStream.getAudioTracks()[0].enabled = false;

			//////peer.socket._socket.send('{"type":"AUDIOMUTE","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"volume","action":"mute"}}');


			//////peer.socket._socket.send('{"type":"AUDIOVOLUME","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"volume","action":"' + callVolume + '"}}');

			if (peer.socket._socket != null) {

				peer.socket._socket.send('{"type":"AUDIOVOLUME","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","volume":"' + callVolume + '","payload":{" type":"volume","action":"' + callVolume + '"}}');
			}

			//

		}
	} catch (e) {

	}

}



window.callMute = function () {

	try {

		if (localStream) {

			localStream.getAudioTracks()[0].enabled = false;

/*			peer.socket._socket.send('{"type":"AUDIOMUTE","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"audio","action":"mute"}}');*/

		}
	} catch (e) {

	}



}

window.callUnMute = function () {

	try {

		if (localStream) {
			
			localStream.getAudioTracks()[0].enabled = true;

/*			peer.socket._socket.send('{"type":"AUDIOUNMUTE","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"audio","action":"unmute"}}');*/

		}
	} catch (e) {

	}



}



window.callPause = function () {

	try {

		if (localStream) {

			localStream.getVideoTracks()[0].enabled = false;

			peer.socket._socket.send('{"type":"VIDEOPAUSE","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"video","action":"pause"}}');

			//peer.socket._socket.send( '{"type":"VIDEOPAUSE","src":"' + OwnerUserID + '","dst":"' + RemoteUserID + '","payload":{" type":"media","connectionId":"mc_yph61qynxncanhfr","browser":"Chrome"}}' );


			//owner_HideCamera();

			document.getElementById('div_OwnerVideo').style.display = 'none';
			//document.getElementById('div_OwnerVideoSplash').style.display = 'none';

			_CallType = 'voice';

		}
	} catch (e) {
		return;
	}


}

window.callResume = function () {

	try {

		if (localStream) {

			localStream.getVideoTracks()[0].enabled = true;

			peer.socket._socket.send('{"type":"VIDEORESUME","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"video","action":"resume"}}');

			//owner_ShowCamera();

			document.getElementById('div_OwnerVideo').style.display = 'block';

			//if (document.getElementById('div_RemoteVideo').style.display == 'block')
			//{
			//	document.getElementById('div_OwnerVideoSplash').style.display = 'none';
			//} else {
			//	document.getElementById('div_OwnerVideoSplash').style.display = 'block';
			//}


			_CallType = 'video';

		}

	} catch (e) {

	}



}



window.callHold = function () {

	try {

		if (localStream) {

			localStream.getAudioTracks()[0].enabled = false;
			localStream.getVideoTracks()[0].enabled = false;

			peer.socket._socket.send('{"type":"CALLHOLD","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"call","action":"hold"}}');


			//owner_HideCamera();
			//remote_HideCamera();

			document.getElementById('div_OwnerVideo').style.display = 'none';
			document.getElementById('div_RemoteVideo').style.display = 'none';
			//document.getElementById('div_OwnerVideoSplash').style.display = 'none';

			_CallType = 'voice';

		}
	} catch (e) {

	}


}

window.callUnHold = function () {

	try {

		if (localStream) {

			localStream.getAudioTracks()[0].enabled = true;
			localStream.getVideoTracks()[0].enabled = false;

			peer.socket._socket.send('{"type":"CALLUNHOLD","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"call","action":"unhold"}}');

			//owner_HideCamera();
			//remote_HideCamera();

			document.getElementById('div_OwnerVideo').style.display = 'none';
			document.getElementById('div_RemoteVideo').style.display = 'none';
			//document.getElementById('div_OwnerVideoSplash').style.display = 'none';

			_CallType = 'voice';

		}

	} catch (e) {

	}




}



window.callSwitchCameraXX = function () {
	if (localStream) {
		localStream.getAudioTracks()[0].enabled = true;
		localStream.getVideoTracks()[0].enabled = true;

		peer.socket._socket.send('{"type":"SWITCHCAMERA","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"call","action":"unhold"}}');

	}
}


window.SwitchStreamXXX = function () {

	try {

		if (_CameraType != null) {

			if (_CameraType == 'front') {

				stop();
				gum('environment');
				//gum('environment');

				_CameraType = 'back';
			}
			else if (_CameraType == 'back') {

				stop();
				//gum('user');                  
				gum('user');

				_CameraType = 'front';

			}

			setTimeout('PeerDial();', 2000);

		}
	} catch (e) {
		return;
	}

};



window.SwitchStream = function () {

	try {

		if (_CameraType != null) {

			if (_CameraType == 'front') {

				stop();
				gum('environment');
				//gum('environment');

				_CameraType = 'back';
			}
			else if (_CameraType == 'back') {

				stop();
				//gum('user');                  
				gum('user');

				_CameraType = 'front';

			}

			setTimeout('PeerDial();', 2000);

		}
	} catch (e) {
		return;
	}

};


window.closeStream = function () {

	try {

		//alert('closeStream');

		//if (localStream) {

		//    localStream.getAudioTracks()[0].stop();
		//    localStream.getVideoTracks()[0].stop();

		//    localStream = null;
		//    try {
		//        stop();
		//    } catch (e) {
		//        //
		//    }
		//}


		var allTrack = localStream.getTracks();

		var track1;

		track1 = localStream.getTracks()[0];
		// track.stop();
		if (track1) {
			track1.stop();
			track1.enabled = false;
		}

		var track2;

		track2 = localStream.getTracks()[1];
		// track.stop();
		if (track2) {
			track2.stop();
			track2.enabled = false;
		}

		//localStream.stop();

		localStream = null;

		Android.showToast('window.closeStream');

	} catch (e) {
		return;
	}


};


window.owner_ShowCamera = function () {

	try {

		$("#div_OwnerVideo").fadeIn('slow');
	} catch (e) {

	}


};


window.owner_HideCamera = function () {

	try {

		$("#div_OwnerVideo").fadeOut('slow');

	} catch (e) {

	}


};


