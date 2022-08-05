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
    public class UsuariosController : ApiController
    {
        [Route("Usuarios/{id}")]
        public Model_usuarios Get(int id)
        {
            return Instances.Current.Integracao.Retornar_usuario_unico (id);
        }
        [Route("Usuarios")]
        public List<Model_usuarios> Get()
        {
            return Instances.Current.Integracao.Retornar_todos_usuarios();
        }
        [Route("Usuarios")]
        public string Post([FromBody] Model_usuarios usuario)
        {
            if (Instances.Current.Integracao.Criar_usuario(usuario))
                return "Usuário criado!";
            else
                return "Não foi possível criar usuário.";
        }
        [Route("Api/Usuario/{id}")]
        public string Put([FromBody] Model_usuarios usuario, int id)
        {
            if (Instances.Current.Integracao.Editar_usuario(usuario, usuario.Usuario_Id = id))
                return "Usuário editado com sucesso!";
            else
                return "Não foi possível editar usuário.";
        }
        [Route("Api/Usuario/{id}")]
        public string Delete(int id)
        {
            if (Instances.Current.Integracao.Deletar_usuario(id))
                return "Usuário deletado!";
            else
                return "Não foi possível apagar usuário.";
        }
    }
}