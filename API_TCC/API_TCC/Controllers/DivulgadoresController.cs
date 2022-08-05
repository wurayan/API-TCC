using API_TCC.Models;
using API_TCC.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API_TCC.Controllers
{
    [RoutePrefix("Api")]
    public class DivulgadoresController : ApiController
    {

        [Route("Divulgadores/{id}")]
        public Model_divulgadores Get(int id)
        {
            return Instances.Current.Integracao.Retornar_divulgador_unico(id);
        }

        [Route("Divulgadores")]
        public List<Model_divulgadores> Get()
        {
            return Instances.Current.Integracao.Retornar_todos_divulgadores();
        }

        [Route("Divulgadores")]
        public string Post([FromBody] Model_divulgadores divulgador)
        {
            if (Instances.Current.Integracao.Criar_divulgador(divulgador))
                return "Divulgador criado!";
            else
                return "Não foi possível criar divulgador.";
        }
        [Route("Divulgadores/{id}")]
        public string Put([FromBody] Model_divulgadores divulgador, int id)
        {
            if (Instances.Current.Integracao.Editar_divulgador(divulgador, divulgador.Div_Id = id))
                return "Divulgador editado com sucesso!";
            else
                return "Não foi possível editar divulgador.";
        }
        [Route("Divulgadores/{id}")]
        public string Delete(int id)
        {
            if (Instances.Current.Integracao.Deletar_divulgador(id))
                return "Divulgador deletado!";
            else
                return "Não foi possível apagar divulgador.";
        }
    }
}