﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente ricardo = new Cliente();

            //ricardo.nome = "Ricardo";
            //ricardo.cpf = "123.456.789.01";
            //ricardo.profissao = "Analista de Sistemas";

            ContaCorrente contaRicardo = new ContaCorrente();

            //contaRicardo.titular = ricardo;

            //contaRicardo.titular = new Cliente();

            //contaRicardo.titular.nome = "Ricardo";
            //contaRicardo.titular.cpf = "123.456.789.01";
            //contaRicardo.titular.profissao = "Analista de Sistemas";

            contaRicardo.saldo = 500;
            contaRicardo.numeroAgencia = 4545;
            contaRicardo.numero = 2313221;

            //contaRicardo.titular.nome = "Ricardo Moreira Soares";

            //Console.WriteLine(ricardo.nome);
            //Console.WriteLine(contaRicardo.titular.nome);
            //Console.WriteLine(contaRicardo.titular.cpf);

            if (contaRicardo.titular == null)
            {
                Console.WriteLine("Ops, esta referencia é nula.");
            }

            Console.WriteLine(contaRicardo.titular);

            Console.ReadKey();
        }
    }
}
