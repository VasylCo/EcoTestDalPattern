using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace EcoTestDalPattern.Models
{
    public static class TestModel
    {
        public static List<QuestionModel> Questions = new List<QuestionModel>();
        public static int result = 0;
        public static int questionNumber = 0;

        public static void CheckResult(string right, string answer)
        {
            if (right == answer)
            {
                result++;
            }

            questionNumber++;
            if (questionNumber > 10)
            {
                questionNumber = 0;
            }
        }

        public static void ResetTest()
        {
            result = 0;
            questionNumber = 0;
        }
    }
}