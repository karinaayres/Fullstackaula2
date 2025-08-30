using Aluno.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Repositorio
{
    internal interface IAlunoRepositorio
    {
        void Adicionar();
        List<int> Listar();
    }

   
}
