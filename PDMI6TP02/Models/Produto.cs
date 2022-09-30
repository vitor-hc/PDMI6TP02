﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PDMI6TP02.Models
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
