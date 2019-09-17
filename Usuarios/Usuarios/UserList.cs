﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    class UserList
    {
        private List<User> users = new List<User>();


        public void userAdd(User user)
        {
            users.Add(user);
        }

        public object[] select(int index)
        {
            string nome = users[index].Nome;
            string email = users[index].Email;
            string senha = users[index].Senha;
            long cpf = users[index].Cpf;
            bool ativo = users[index].Ativo;

            object[] vetor = { nome, email, senha, cpf, ativo };

            return vetor;
        }

        public void userDel(int index)
        {
            users[index].Ativo = false;
        }

        public int Tam
        {
            get { return users.Count; }     
        }

        public void alter(int index, User u)
        {
            users[index].Nome = u.Nome;
            users[index].Email = u.Email;
            users[index].Senha = u.Senha;
            users[index].Cpf = u.Cpf;
            users[index].Ativo = u.Ativo;
        }

    }
}
