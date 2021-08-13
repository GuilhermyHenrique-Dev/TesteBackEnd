﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FullbarDigital.CadastroDeAlunos.Dominio.Models
{
    public class Historico : Model
    {
        public long IdAluno { get; set; }
        public long IdDiciplina { get; set; }
        public decimal Nota { get; set; }
        public string Status { get; set; }
        public virtual Aluno Aluno { get; set; }
        public virtual Diciplina Diciplina { get; set; }
    }
}
