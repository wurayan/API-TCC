using API_TCC.Controllers.Base;
using API_TCC.Controllers.Database;
using API_TCC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TCC.Controllers
{
    internal class Controller_integracao_ef : Controller_integracao_base
    {
        //Eventos
        internal override bool Criar_evento(Model_eventos evento, bool editar = false)
        {
            var context = new Context_db();
            context.Eventos.Add(evento);
            return context.SaveChanges() > 0;
        }
        internal override bool Deletar_evento(int id)
        {
            var context = new Context_db();
            var obj = context.Eventos.SingleOrDefault<Model_eventos>(x => x.Id == id);
            context.Eventos.Remove(obj);
            return context.SaveChanges() > 0;
        }
        internal override bool Editar_evento(Model_eventos evento, int id)
        {
            var context = new Context_db();
            var evento_alter = context.Eventos.SingleOrDefault(x => x.Id == id);

            evento_alter.Evento_nome = evento.Evento_nome;
            evento_alter.Evento_data= evento.Evento_data;
            evento_alter.Evento_localizacao = evento.Evento_localizacao;
            evento_alter.Evento_descricao = evento.Evento_descricao;
            evento_alter.Evento_imagem = evento.Evento_imagem;
            evento_alter.Evento_preco = evento.Evento_preco;

            context.Eventos.Attach(evento_alter);
            context.Entry(evento_alter).State = System.Data.Entity.EntityState.Modified;

            return context.SaveChanges() > 0;
        }
        internal override Model_eventos Retornar_evento_unico(int id)
        {
            var context = new Context_db();
            return context.Eventos.SingleOrDefault<Model_eventos>(x => x.Id == id);
        }
        internal override List<Model_eventos> Retornar_todos_eventos()
        {
            var context = new Context_db();
            return context.Eventos.ToList();
        }


        //usuarios
        internal override bool Criar_usuario(Model_usuarios usuario, bool editar = false)
        {
            var context = new Context_db();
            context.Usuarios.Add(usuario);
            return context.SaveChanges() > 0;
        }
        internal override bool Deletar_usuario(int id)
        {
            var context = new Context_db();
            var obj = context.Usuarios.SingleOrDefault<Model_usuarios>(x => x.Usuario_Id == id);
            context.Usuarios.Remove(obj);
            return context.SaveChanges() > 0;
        }
        internal override bool Editar_usuario(Model_usuarios usuario, int id)
        {
            var context = new Context_db();
            var user_alter = context.Usuarios.SingleOrDefault(x => x.Usuario_Id== usuario.Usuario_Id);

            user_alter.Usuario_nome = usuario.Usuario_nome;
            user_alter.Usuario_email= usuario.Usuario_email;
            user_alter.Usuario_localizacao = usuario.Usuario_localizacao;
            user_alter.Usuario_senha = usuario.Usuario_senha;
            user_alter.Usuario_nascimento = usuario.Usuario_nascimento;

            context.Usuarios.Attach(user_alter);
            context.Entry(user_alter).State = System.Data.Entity.EntityState.Modified;

            return context.SaveChanges() > 0;
        }
        internal override List<Model_usuarios> Retornar_todos_usuarios()
        {
            var context = new Context_db();
            return context.Usuarios.ToList();
        }
        internal override Model_usuarios Retornar_usuario_unico(int id)
        {
            var context = new Context_db();
            return context.Usuarios.SingleOrDefault<Model_usuarios>(x => x.Usuario_Id == id);
        }


        //divulgadores
        internal override bool Criar_divulgador(Model_divulgadores divulgador, bool editar = false)
        {
            var context = new Context_db();
            context.Divulgadores.Add(divulgador);
            return context.SaveChanges() > 0;
        }
        internal override bool Deletar_divulgador(int id)
        {
            var context = new Context_db();
            var obj = context.Divulgadores.SingleOrDefault<Model_divulgadores>(x => x.Div_Id == id);
            context.Divulgadores.Remove(obj);
            return context.SaveChanges() > 0;
        }
        internal override bool Editar_divulgador(Model_divulgadores divulgador, int id)
        {

            var context = new Context_db();
            var div_alter = context.Divulgadores.SingleOrDefault(x => x.Div_Id == divulgador.Div_Id);

            div_alter.Div_nome = divulgador.Div_nome;
            div_alter.Div_contato = divulgador.Div_contato;
            div_alter.Div_localizacao = divulgador.Div_localizacao;
            div_alter.Div_senha = divulgador.Div_senha;

            context.Divulgadores.Attach(div_alter);
            context.Entry(div_alter).State = System.Data.Entity.EntityState.Modified;

            return context.SaveChanges() > 0;

        }
        internal override Model_divulgadores Retornar_divulgador_unico(int id)
        {
            var context = new Context_db();
            return context.Divulgadores.SingleOrDefault<Model_divulgadores>(x => x.Div_Id == id);
        }
        internal override List<Model_divulgadores> Retornar_todos_divulgadores()
        {
            var context = new Context_db();
            return context.Divulgadores.ToList();
        }
    }
}