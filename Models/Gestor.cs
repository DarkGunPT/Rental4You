﻿namespace TP.Models
{
    public class Gestor : User
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
