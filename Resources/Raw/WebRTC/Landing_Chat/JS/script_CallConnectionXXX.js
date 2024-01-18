﻿
/////////////////////////////

window._CallTokenID, window._GroupID, window._GroupType,

        window._OwnerUserID, window._OwnerMobileNumberID,
        window._RemoteUserID, window._RemoteMobileNumberID,

        window._OwnerPeerUserID, window._RemotePeerUserID,

window._CallTag, window._CallType, window._CallDirection;

window._IsGUMConnected = false;


window.Call_LoadParam = function () {

	//alert('window.jq_LoadParam ');

	_CameraTarget = Query_GetParameterByName('cam');
	_CameraType = _CameraTarget;

	_CallTokenID = Query_GetParameterByName('caltknid');

	//_GroupID = Query_GetParameterByName('grpid');
	//_GroupType = Query_GetParameterByName('grptyp');


	_OwnerUserID = Query_GetParameterByName('ownid');
	_OwnerMobileNumberID = Query_GetParameterByName('ownmobid');


	_RemoteUserID = Query_GetParameterByName('rmtid');
	_RemoteMobileNumberID = Query_GetParameterByName('rmtmobid');

	_CallTag = Query_GetParameterByName('caltag');
	_CallDirection = Query_GetParameterByName('caldir');

	_CallType = Query_GetParameterByName('caltyp');

	_OwnerPeerUserID = _CallTokenID + '-' + _OwnerMobileNumberID;
	_RemotePeerUserID = _CallTokenID + '-' + _RemoteMobileNumberID;




	// Shaymaa
	//_CallTag = 'offer';//Query_GetParameterByName('caltyp');
	//_CallDirection = 'out';//Query_GetParameterByName('caldir');

	//_OwnerPeerUserID = 'Xcat5';//_CallTokenID + '-' + _OwnerMobileNumberID;
	//_RemotePeerUserID = 'Xcat3';//_CallTokenID + '-' + _RemoteMobileNumberID;


	//Hafez
	/*    _CallTag = 'answer';//Query_GetParameterByName('caltyp');
        _CallDirection = 'in';//Query_GetParameterByName('caldir');
        _OwnerPeerUserID = 'Xcat3';//_CallTokenID + '-' + _OwnerMobileNumberID;
        _RemotePeerUserID = 'Xcat5';//_CallTokenID + '-' + _RemoteMobileNumberID;*/


	//alert(_OwnerPeerUserID);

	if (_CallTag == 'offer') {
		_CallIsOffer = true;
	} else if (_CallTag == 'answer') {
		_CallIsOffer = false;
	}

	//PeerConnect();

}


window.SetCallTokenID = function (CallTokenID) {

	try {

		if (CallTokenID) {

			//alert(CallTokenID);

			_CallTokenID = CallTokenID;

			_CallTag = 'offer';
			_CallDirection = 'out';
			_CallType = 'voice';

			//_OwnerPeerUserID = 'Xcat10';//_CallTokenID + '-' + _OwnerMobileNumberID;
			//_RemotePeerUserID = 'Xcat3';//_CallTokenID + '-' + _RemoteMobileNumberID;


			_OwnerPeerUserID = _CallTokenID + '-' + _OwnerMobileNumberID;
			_RemotePeerUserID = _CallTokenID + '-' + _RemoteMobileNumberID;

			_CallIsRunning = false;
			_CallIsOffer = true;

			_CallTag = 'offer';

			PeerConnect();
		}

	} catch (e) {
		return;
	}


};


window.ConnectServer = function () {

	try {

		//owner_ShowCamera();

		//if (_CallType == 'voice') {
		//    owner_HideCamera();
		//}
		//else {
		//    owner_ShowCamera();
		//}

		if (_CallTag == 'offer') {
		PeerConnect();
		}

		//setTimeout('ConnectRemote();', 2000);

	} catch (e) {
		return;
	}


};


window.ConnectRemote = function () {

	try {

		// TODO Tag_Android
		if (_CallTag == 'offer') {

			//Android.jsCall_Owner_doGenerateNewScreenCallShowID();
		}
		else if (_CallTag == 'answer') {

			console.log('TlknCall==' + 'window.ConnectRemote');

			PeerDial();

		}

	} catch (e) {
		return;
	}


};


window.CheckGUMConnectedForDial = function () {

	try {
		if (_CallTag == 'answer') {
			PeerConnect();
		}
	} catch (e) {

	}















	try {

		//console.log('TlknCall==' + 'window.CheckGUMConnectedForDial');

		//if (_IsGUMConnected == true) {

		//	console.log('TlknCall==' + '_IsGUMConnected == true');

		//	//setTimeout('PeerDial();', 3000);

		//	PeerDial();

		//} else {

		//	console.log('TlknCall==' + 'setTimeout');
		//	setTimeout(CheckGUMConnectedForDial(), 2000);

		//}


		////if (_CallIsRunning == false) {

		////	console.log('TlknCall==' + '_CallIsRunning == false');

		////	if (_IsGUMConnected == true) {
		////		PeerDial();
		////	} else {
		////		setTimeout('CheckGUMConnectedForDial();', 3000);

		////	} 

		////} else {

		////	console.log('TlknCall==' + 'setTimeout("CheckGUMConnectedForDial();")');

		////	//PeerConnect();

		////	setTimeout('CheckGUMConnectedForDial();', 3000);
		////	//setTimeout('PeerDial();', 3000);
		////}

	} catch (e) {
		return;
	}

	////try {

	////		if (_IsGUMConnected == true) {

	////			PeerDial();

	////			return;

	////		} else {

	////			//PeerConnect();

	////			setTimeout('CheckGUMConnectedForDial();', 3000);
	////			//setTimeout('PeerDial();', 3000);
	////		}

	////	} catch (e) {
	////		return;
	////	}


};