
window.callMute = function () {
    if (localStream) {
        localStream.getAudioTracks()[0].enabled = false;

      /*  peer.socket._socket.send('{"type":"AUDIOMUTE","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"audio","action":"mute"}}');*/

    }
}

window.callUnMute = function () {
    if (localStream) {
        localStream.getAudioTracks()[0].enabled = true;

/*        peer.socket._socket.send('{"type":"AUDIOUNMUTE","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"audio","action":"unmute"}}');*/

    }
}



window.callPause = function () {
    try {
        if (localStream) {
            localStream.getVideoTracks()[0].enabled = false;

            //peer.socket._socket.send('{"type":"VIDEOPAUSE","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"video","action":"pause"}}');

            //peer.socket._socket.send( '{"type":"VIDEOPAUSE","src":"' + OwnerUserID + '","dst":"' + RemoteUserID + '","payload":{" type":"media","connectionId":"mc_yph61qynxncanhfr","browser":"Chrome"}}' );
        }
    } catch (e) {
        return;
    }


}

window.callResume = function () {
    if (localStream) {
        localStream.getVideoTracks()[0].enabled = true;

        //peer.socket._socket.send('{"type":"VIDEORESUME","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"video","action":"resume"}}');

    }
}



window.callHold = function () {
    if (localStream) {
        localStream.getAudioTracks()[0].enabled = false;
        localStream.getVideoTracks()[0].enabled = false;

        //peer.socket._socket.send('{"type":"CALLHOLD","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"call","action":"hold"}}');

    }
}

window.callUnHold = function () {
    if (localStream) {
        localStream.getAudioTracks()[0].enabled = true;
        localStream.getVideoTracks()[0].enabled = true;

/*        peer.socket._socket.send('{"type":"CALLUNHOLD","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"call","action":"unhold"}}');*/

    }
}

window.callSwitchCameraXX = function () {
    if (localStream) {
        localStream.getAudioTracks()[0].enabled = true;
        localStream.getVideoTracks()[0].enabled = true;

/*        peer.socket._socket.send('{"type":"SWITCHCAMERA","src":"' + _OwnerPeerUserID + '","dst":"' + _RemotePeerUserID + '","payload":{" type":"call","action":"unhold"}}');*/

    }
}



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

            setTimeout('PeerDial();', 3000);

        }
    } catch (e) {
        return;
    }

};




window.closeStream = function () {

    try {

        //alert('closeStream');

        if (localStream) {

            localStream.getAudioTracks()[0].stop();
            localStream.getVideoTracks()[0].stop();

            localStream = null;
            try {
                stop();
            } catch (e) {
                //
            }
        }
    } catch (e) {
        return;
    }


};






window.ConnectServerxxx = function () {

    try {

        PeerConnect();

        setTimeout('ConnectRemote();', 2000);

    } catch (e) {
        return;
    }


};





window.ConnectRemotexxx = function () {

    try {

        // TODO Tag_Android
        if (_CallType == 'offer') {

            //Android.jsCall_Owner_doGenerateNewScreenCallShowID();
        }
        else if (_CallType == 'answer') {

            PeerDial();

        }

    } catch (e) {
        return;
    }


};


