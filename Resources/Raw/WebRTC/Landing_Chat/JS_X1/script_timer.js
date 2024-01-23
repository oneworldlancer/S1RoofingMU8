// Timer library 1.0
var timer;

var second;
var minute;
var hour;

var timerSecond, timerMinute, timerHour;

var CallDuration= '00:00:00';

var strSecond="0";
var strMinute="0";
var strHour="0";

	var time = 0; 	//  The default time of the timer
	var mode = 1; 	//	Mode: count up or count down
	var status = 0;	//	Status: timer is running or stoped
	var timer_id;	//	This is used by setInterval function


window._timer= function ( callback )
{
	// this will start the timer ex. start the timer with 1 second interval timer.start(1000)
	this.start = function ( interval )
	{
		interval = ( typeof ( interval ) !== 'undefined' ) ? interval : 1000;

		if ( status == 0 )
		{
			status = 1;
			timer_id = setInterval( function ()
			{
				switch ( mode )
				{
					default:
						if ( time )
						{
							time--;
							generateTime();
							if ( typeof ( callback ) === 'function' ) callback( time );
						}
						break;

					case 1:
						if ( time < 86400 )
						{
							time++;
							generateTime();
							if ( typeof ( callback ) === 'function' ) callback( time );
						}
						break;
				}
			}, interval );
		}
	}

	//  Same as the name, this will stop or pause the timer ex. timer.stop()
	this.stop = function ()
	{
		if ( status == 1 )
		{
			status = 0;
			clearInterval( timer_id );
		}
	}

	// Reset the timer to zero or reset it to your own custom time ex. reset to zero second timer.reset(0)
	this.reset = function ( sec )
	{
		sec = ( typeof ( sec ) !== 'undefined' ) ? sec : 0;
		time = sec;
		generateTime( time );
	}

	// Change the mode of the timer, count-up (1) or countdown (0)
	this.mode = function ( tmode )
	{
		mode = tmode;
	}

	// This method return the current value of the timer
	this.getTime = function ()
	{
		return time;
	}

	// This method return the current mode of the timer count-up (1) or countdown (0)
	this.getMode = function ()
	{
		return mode;
	}

	// This method return the status of the timer running (1) or stoped (1)
	this.getStatus
	{
		return status;
	}

	// This method will render the time variable to hour:minute:second format
	function generateTime()
	{
		var second = time % 60;
		var minute = Math.floor( time / 60 ) % 60;
		var hour = Math.floor( time / 3600 ) % 60;

		second = ( second < 10 ) ? '0' + second : second;
		minute = ( minute < 10 ) ? '0' + minute : minute;
		hour = ( hour < 10 ) ? '0' + hour : hour;

		//$( 'div.timer span.second' ).html( second );
		//$( 'div.timer span.minute' ).html( minute );
		//$( 'div.timer span.hour' ).html( hour );

		//	$( 'timerHour' ).html( hour );
		//	$( 'timerMinute' ).html( minute );

		timerSecond = document.getElementById( 'timerSecond' );
		timerMinute = document.getElementById( 'timerMinute' );
		timerHour = document.getElementById( 'timerHour' );

		timerSecond.textContent = second;
		timerMinute.textContent = minute ;
		timerHour.textContent = hour;

		CallDuration = hour + ':'
			+ minute + ':'
			+ second;

			strHour=hour;
			strMinute=minute;
			strSecond=second;

	}
}


window.startTimer = function ()
{
	try
	{
		if ( !timer ) timer = new _timer;

		(
		function ( time )
		{
			if ( time == 0 )
			{
				timer.stop();
				alert( 'time out' );
			}
		}
	);
		timer.reset( 0 );
		timer.mode( 1 );
		timer.start();

	} catch ( e )
	{
		return;
	}

}

window.pauseTimer = function ()
{
	try
	{
		if ( timer )
		{
			timer.stop();
		}

	} catch ( e )
	{
		return;
	}

}

window.resumeTimer = function ()
{
	try
	{
		if ( timer )
		{
			timer.start( 1000 );
		}

	} catch ( e )
	{
		return;
	}

}

window.resetTimer = function ()
{
	try
	{
		timer.start( 0 );
	} catch ( e )
	{
		return;
	}

}

window.countTimer = function ()
{
	try
	{
		timer.start( 0 );
	} catch ( e )
	{
		return;
	}

}

window.SetCallTimer = function (secTimer)
{
	try
	{
		timer.reset(secTimer);
	} catch ( e )
	{
		return;
	}

}


window.GetCallTimer = function ()
{
	try
	{
		//CallDuration=timerHour.textContent + ' : '
		//	+ timerMinute.textContent + ' : '
		//	+ timerSecond.textContent

		Android.jsCall_getCallActionDuration(CallDuration);

		//alert( CallDuration );

	} catch ( e )
	{
		return;
	}

}



window.ParseCallTimer = function ()
{
	try
	{
		Android.jsCall_getCallActionTimeParse(strHour,strMinute,strSecond);
	} catch ( e )
	{
		return;
	}

}



window.GetCurrentParseCallTimerOnHold = function ()
{
	try
	{
		Android.jsCall_getCurrentParseCallTimerOnHold(strHour,strMinute,strSecond);
	} catch ( e )
	{
		return;
	}

}


window.GetCurrentParseCallTimerOnUnHold = function ()
{
	try
	{
		Android.jsCall_getCurrentParseCallTimerOnUnHold(strHour,strMinute,strSecond);
	} catch ( e )
	{
		return;
	}

}
