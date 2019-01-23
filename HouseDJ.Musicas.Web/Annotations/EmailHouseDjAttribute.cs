using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HouseDJ.Musicas.Web.Annotations
{
    public class EmailHouseDjAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value.ToString().EndsWith("@housedj.com.br");
        }
    }
}