using API_TCC.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API_TCC.Models
{
    public class Model_divulgadores : Model_base
    {
        [Key]
        public int Div_Id { get; set; }
        public string Div_nome { get; set; }
        public string Div_contato { get; set; }
        public string Div_localizacao { get; set; }
        public string Div_senha { get; set; }
    }
}