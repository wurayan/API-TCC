using API_TCC.Models;
using API_TCC.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API_TCC.Controllers
{
    [Route("Api/Eventos")]
    public class EventosController : ApiController
    {
        public Model_eventos Get(int id)
        {
            return Instances.Current.Integracao.Retornar_evento_unico(id);
        }
        public List<Model_eventos> Get()
        {
            return Instances.Current.Integracao.Retornar_todos_eventos();
        }
        public string Post([FromBody] Model_eventos evento)
        {
            if (Instances.Current.Integracao.Criar_evento(evento))
                return "O evento foi criado!";
            else
                return "Não foi possível criar o evento.";
        }

        public string Put([FromBody] Model_eventos evento, int id)
        {
            if (Instances.Current.Integracao.Editar_evento(evento, evento.Id = id))
                return "Os dados do evento foram editados!";
            else
                return "Não foi possível editar o evento.";
        }
        public string Delete(int id)
        {
            if (Instances.Current.Integracao.Deletar_evento(id))
                return "O evento foi deletado!";
            else
                return "Não foi possível apagar o evento.";
        }
    }
}