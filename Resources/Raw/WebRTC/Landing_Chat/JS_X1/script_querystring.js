window.Query_GetParameterByName= function ( name )
{
	try
	{
		name = name.replace( /[\[]/, "\\[" ).replace( /[\]]/, "\\]" );
		var regex = new RegExp( "[\\?&]" + name + "=([^&#]*)" ),
			results = regex.exec( location.search );
		return results == null ? "" : decodeURIComponent( results[1].replace( /\+/g, " " ) );
	} catch ( e )
	{
		return 0;
	}


}
