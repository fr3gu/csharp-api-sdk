using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FortnoxAPILibrary.Entities
{
    public enum SalaryForm
    {
        ///<summary> Monthly salary </summary>
        [EnumMember(Value = "MAN")]
        MAN,
        ///<summary> Hourly pay </summary>
        [EnumMember(Value = "TIM")]
        TIM,
    }
}