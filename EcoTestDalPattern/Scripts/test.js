let question;
let answer;
function checkResult() {
    answer = $('input:checked').parent('label').text().trim();
    if (!answer) {
        alert("Зробіть вибір!");
        return false;
    } else {
        return true;
    }
    
}

function sendResult() {
    if (checkResult()) {
        $.ajax({
            url: '/Test/Check',
            type: 'POST',
            dataType: 'text',
            data: { data: answer },
            //async: false,
            success: function(result, status, xhr) {
                renderPage(JSON.parse(result));
            },
            error: function(xhr, status, error) {
                $("#test").html("Result: " + status + " " + error + " " + xhr.status + " " + xhr.statusText)
            }
        });
    } else {
        alert("Something wrong");
    }

}

function checkTest() {
    if (checkResult()) {
        $.ajax({
            url: '/Test/Result',
            type: 'POST',
            dataType: 'text',
            data: { data: answer },
            //async: false,
            success: function (result, status, xhr) {
                $("#test-div").html(`<h2>${result}</h2><a href="/Test" class ="btn btn-primary btn-lg">Спробувати ще раз</a>`);
            },
            error: function (xhr, status, error) {
                $("#test-div").html("Result: " + status + " " + error + " " + xhr.status + " " + xhr.statusText)
            }
        });
    } else {
        alert("Something wrong");
    }

}

function renderPage(questions) {
    $('h2').text(`Запитання ${questions.QuestionId} з 10`)
    $('h3').text(questions.QuestionText);
    $('label').eq(0).html('<input type="radio" name="answer" />'+questions.FirstAnswer);
    $('label').eq(1).html('<input type="radio" name="answer" />'+questions.SecondAnswer);
    $('label').eq(2).html('<input type="radio" name="answer" />'+questions.ThirdAnswer);
    if (questions.QuestionId === 10) {
        $('#nextButton').text("Результат").attr('onclick', 'checkTest()');

    }
}
