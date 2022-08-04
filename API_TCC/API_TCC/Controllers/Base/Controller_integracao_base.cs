using API_TCC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TCC.Controllers.Base
{
    internal abstract class Controller_integracao_base
    {
        //Métodos para Eventos
        internal abstract bool Criar_evento(Model_eventos evento, bool editar = false);
        internal abstract bool Deletar_evento(int id);
        internal abstract bool Editar_evento(Model_eventos evento, int id);
        internal abstract List<Model_eventos> Retornar_todos_eventos();
        internal abstract Model_eventos Retornar_evento_unico(int id);
        
        //Métodos para Usuarios
        internal abstract bool Criar_usuario(Model_usuarios usuario, bool editar = false);
        internal abstract bool Deletar_usuario(int id);
        internal abstract bool Editar_usuario(Model_usuarios usuario, int id);
        internal abstract List<Model_usuarios> Retornar_todos_usuarios();
        internal abstract Model_usuarios Retornar_usuario_unico(int id);

        //Métodos para divulgadores
        internal abstract bool Criar_divulgador(Model_divulgadores divulgador, bool editar = false);
        internal abstract bool Deletar_divulgador(int id);
        internal abstract bool Editar_divulgador(Model_divulgadores divulgador, int id);
        internal abstract List<Model_divulgadores> Retornar_todos_divulgadores();
        internal abstract Model_divulgadores Retornar_divulgador_unico(int id);

    }
}