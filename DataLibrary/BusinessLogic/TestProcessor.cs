using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BusinessLogic
{
    public static class TestProcessor
    {
        public static List<QuestionModel> GetQuestion()
        {
            string sql = @"select Id, QuestionId, QuestionText, FirstAnswer, SecondAnswer, ThirdAnswer, RightAnswer from dbo.Questions;";
            return SqlDataAccess.LoadData<QuestionModel>(sql);
        }
    }
}
