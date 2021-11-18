﻿using DesignPattern_Strategy.Dominio;
using DesignPattern_Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Strategy.Infraestrutura.Impostos
{
    public class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
                return orcamento.Valor * 0.05;
            else if(orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                return orcamento.Valor * 0.07;
            else
                return ((orcamento.Valor * 0.08) + 30.00);
        }
    }
}