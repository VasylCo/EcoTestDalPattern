using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcoTestDalPattern.Models;
using Newtonsoft.Json;
using static DataLibrary.BusinessLogic.TestProcessor;
using static EcoTestDalPattern.Models.TestModel;

namespace EcoTestDalPattern.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ResetTest();
            var question = GetQuestion();
            Questions.Clear();
            foreach (var row in question)
            {
                Questions.Add(new QuestionModel
                {
                    QuestionId = row.QuestionId,
                    QuestionText = row.QuestionText,
                    FirstAnswer = row.FirstAnswer,
                    SecondAnswer = row.SecondAnswer,
                    ThirdAnswer = row.ThirdAnswer,
                    RightAnswer = row.RightAnswer
                });

            }


            return View(Questions[questionNumber]);


        }

        [HttpPost]
        public string Check(string data)
        {
            
            
            CheckResult(Questions[questionNumber].RightAnswer, data);
            return JsonConvert.SerializeObject(Questions[questionNumber]);
            
        }

        public ActionResult Result(string data)
        {
            CheckResult(Questions[questionNumber].RightAnswer, data);
            string finalResult = $"Ваш результат: {result} з 10!";
            return Content(finalResult);
        }

    }
}