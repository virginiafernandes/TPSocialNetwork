using System.IO;
using System;
using System.Collections.Generic;

namespace Orkurtir{
    class Program {
        static void Main() {
            Usuario u1 = new Usuario("Lucas","turboelgamer","F@M051N_1Msubs");
            Usuario u2 = new Usuario("Eduardo","madepino10","NEGOESadoro");
            var listaUsuarios = new List<Usuario>();
            listaUsuarios.Add(u1);
            listaUsuarios.Add(u2);
            
            foreach (var usuario in listaUsuarios){
                Console.WriteLine(usuario.Nome);
            }
        }
    }
}