using API_TCC.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API_TCC.Models
{
    public class Model_eventos : Model_base
    {
        [Key]
        public int Id { get; set; }
        public string Evento_nome { get; set; }
        public DateTime Evento_data { get; set; }
        public string Evento_localizacao { get; set; } //Como tratar a geolocalização para ser salva
        public string Evento_preco { get; set; }
        public string Evento_descricao { get; set; }
        public byte[] Evento_imagem { get; set; }
    }
}