using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace login.Models
{
    public class AuthorizationModel
    {
        public string login { get; set; }  // get; set; - определение свойства
                                           //Свойство — способ доступа к внутреннему состоянию объекта,
                                           //имитирующий переменную некоторого типа. 
        public string password { get; set; }

    }
}