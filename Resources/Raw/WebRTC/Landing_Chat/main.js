document.addEventListener('DOMContentLoaded', function () {









    /////////////////////////////////

    window.callFromCSharp = function (msg) {

        alert('callFromCSharp == ' + msg);

        //setTimeout(function () {
        //setTimeout(function () {
        //    callCSharpMethod();
        //}, 7000);
    }


    function callCSharpMethod_XXX1() {
        window.location = "/api/" + "alertCS2024";
        return false;

        //  window.location = "/api/" + dataId;
        //window.external.notify('MyCSharpMethod');
    }


    function callCSharpMethod() {

        window.jsBridge.invokeAction("am here ya ShoSho !!!");
        //window.location = "/api/" + "alertCS2024";
        //return false;

        //  window.location = "/api/" + dataId;
        //window.external.notify('MyCSharpMethod');
    }


});





function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}


window.loadJsonList = async function (arrJsonList) {


    try {

        //alert('callFromCSharp == ' + 'xxxx');

        /*var new_field_html = '<div class="row" style="width:100%;display:flex;flex-direction:row;margin-bottom:10px;"><div class="col-11" ><input type="text"  type="url" pattern="https?://.+" class="form-control" id="input_fileURL2" name="input_fileURL2" placeholder="Insert your hyperlink here ..." style="color:blue;"   data-inputfor="fupload"  required /></div><div class="col-1 text-center" style="width:50px;" ><img id="img_delURL2" name="img_delURL2" class="remove_input_button"  src="https://bsr.vemcoconsulting.com/img/img_delete.png" style="width:20px;height:20px;" alt="Delete" title="Delete" /></div></div>';*/

        var new_field_html;// = '<div class="row m-1 p-1 d-flex flex-row" style="height: 90px; color: white; background-color: #656565; border-radius: 5px; border: 1px solid #656565;" onclick="doClick();"><div style = "width:60px;margin:0px; padding: 0px;" ><div class="ms-1 mt-1 rounded-circle text-cetner align-middle" style="width:50px;height:50px;background-color:black;text-align:center;vertical-align:middle;"><div style="width:50px;height:50px;font-size:large;padding-top:10px;">SH</div></div></div ><div class="col d-flex flex-column" style="margin: 0px; padding: 0px; "><div style="color:black;font-size:large;">Shaymaa Hafez</div><div style="color:white;font-size:medium;">+201221977230</div><div style="color:whitesmoke;font-size:small;">Egypt, Ismailia</div></div><div class="p-1 float-end" style="width: 40px; margin: 0px; padding: 0px; "><img src="img/img_chat_white.png" class="float-end" alt="Logo" width="30" height="30" /></div></div> ';


        window.arrJson = JSON.parse(arrJsonList);

        //alert('arrJson == ' + arrJson.length);
        //alert('arrJson[0].GroupTitle == ' + arrJson[0].GroupTitle);

        $('#div_HTMLContent').empty();


        await sleep(500);


        for (var i = 0; i < window.arrJson.length; i++) {

            await sleep(i * 50);

            //alert('JSON.stringify(arrJson[i])  == ' + JSON.stringify(arrJson[i]));

            // onclick="doClick(\'asasa\');"
            //var jsonStringfy = JSON.stringify(arrJson[i]);// 'jsonStringfy';

            //alert('jsonStringfy == ' + jsonStringfy);

            new_field_html = '<div class="row m-1 p-1 d-flex flex-row" style="height: 90px; color: white; background-color: #656565; border-radius: 5px; border: 1px solid #656565;" onclick="doClick(\' ' + i + ' \');"><div style = "width:60px;margin:0px; padding: 0px;" ><div class="ms-1 mt-1 rounded-circle text-cetner align-middle" style="width:50px;height:50px;background-color:black;text-align:center;vertical-align:middle;"><div style="width:50px;height:50px;font-size:large;padding-top:10px;">' + window.arrJson[i].AvatarName + '</div></div></div ><div class="col d-flex flex-column" style="margin: 0px; padding: 0px; "><div style="color:black;font-size:large;margin:0px; padding: 0px;">' + window.arrJson[i].GroupTitle + '</div><div style="color:white;font-size:medium;margin:0px; padding: 0px;">' + arrJson[i].MessageText + '</div><div style="color:whitesmoke;font-size:small;margin:0px; padding: 0px;">' + window.arrJson[i].DateTimeText + '</div></div><div class="p-1 float-end" style="width: 40px; margin: 0px; padding: 0px; "><img src="img/img_chat_white.png" class="float-end" alt="Logo" width="30" height="30" style="margin:0px; padding: 0px;" /></div></div> ';

            $("#div_HTMLContent").append(new_field_html);


        }

    }
    catch (err) {

        //alert(err);
    }





}

