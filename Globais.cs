﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0;
        //public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "banco_academia.db";
        public static string caminhoBanco = caminho + @"\banco\";
        public static string caminhoFoto = caminho + @"\foto\";

    }
}
