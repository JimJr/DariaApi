namespace DariaApi.Converters
{
    using DariaApi.Contracts.Entities;
    using DariaApi.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class ToDtoConverter
    {
        public static UserData ToDto(this User user)
        {
            if (user == null)
            {
                return null;
            }

            return new UserData
            {
                UserName = user.UserName
            };
        }
    }
}