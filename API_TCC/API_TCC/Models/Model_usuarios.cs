using API_TCC.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API_TCC.Models
{
    public class Model_usuarios : Model_base
    {
        [Key]
        public int Usuario_Id { get; set; } //Foreign Key ganha nome diferenciado? (ask the teacher)
        public string Usuario_nome { get; set; }
        public DateTime Usuario_nascimento { get; set; } //setar o horario como 00:00 por padrão
        public string Usuario_email { get; set; } //fazer a verificação do email
        public string Usuario_senha { get; set; } //tratar a senha (criptografar)
        public string Usuario_localizacao { get; set; } 
    }
}