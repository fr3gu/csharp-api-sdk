using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FortnoxAPILibrary.Entities
{
    [Entity(SingularName = "Expense", PluralName = "Expenses")]
    public class Expense
    {

        ///<summary> Unique expense code </summary>
        [JsonProperty]
        public string Code { get; set; }

        ///<summary> Description of expense </summary>
        [JsonProperty]
        public string Text { get; set; }

        ///<summary> Account number </summary>
        [JsonProperty]
        public int? Account { get; set; }
    }
}