using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        #region Properties
        #endregion

        #region Methods

        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public static int CalculateAge(this DateTime date)
        {
            int age = DateTime.Today.Year - date.Year;
            if (date.AddYears(age) > DateTime.Today) age--;
            return age;

        }
        #endregion
    }
}