﻿using ProjetoModeloDDD.Dominio.Entidades;
using ProjetoModeloDDD.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Dados.Repositorios
{
    public class ComentarioRepositorio : RepositorioBase<Comentario> , IComentarioRepositorio
    {
    }
}
