function makeDrink(id) {    
    $.ajax({
        type: "Get",
        url: "Home/GetProcess",                
        data: { "Id": id },
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {             
            displayProcess(result[0]);            
        },
        error: function (result) {            
            alert('error');
        }
    });
}

async function displayProcess(data) {
     $(".btn").addClass('disabled');
     $(".dot-windmill").css('visibility', 'visible');    

    for (let i = 0; i < data.length; i++) {        
        $("#process").text(data[i].name);
        await new Promise(done => setTimeout(() => done(), data[i].executionTimeMs)); 
    }        

    $(".dot-windmill").css('visibility', 'hidden'); 
    $("#process").text(' - - - DRINK  READY  - - -');
    await new Promise(done => setTimeout(() => { $("#process").empty(); $(".btn").removeClass('disabled');}, 3000));     
}








 