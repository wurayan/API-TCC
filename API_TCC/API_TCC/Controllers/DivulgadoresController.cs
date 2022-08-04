using API_TCC.Models;
using API_TCC.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API_TCC.Controllers
{
    [Route("Api/Divulgadores")]
    public class DivulgadoresController : ApiController
    {
        public Model_divulgadores Get(int id)
        {
            return Instances.Current.Integracao.Retornar_divulgador_unico(id);
        }
        public List<Model_divulgadores> Get()
        {
            return Instances.Current.Integracao.Retornar_todos_divulgadores();
        }
        public string Post([FromBody] Model_divulgadores divulgador)
        {
            if (Instances.Current.Integracao.Criar_divulgador(divulgador))
                return "Divulgador criado!";
            else
                return "Não foi possível criar divulgador.";
        }

        public string Put([FromBody] Model_divulgadores divulgador, int id)
        {
            if (Instances.Current.Integracao.Editar_divulgador(divulgador, divulgador.Div_Id = id))
                return "Divulgador editado com sucesso!";
            else
                return "Não foi possível editar divulgador.";
        }
        public string Delete(int id)
        {
            if (Instances.Current.Integracao.Deletar_divulgador(id))
                return "Divulgador deletado!";
            else
                return "Não foi possível apagar divulgador.";
        }
    }
}