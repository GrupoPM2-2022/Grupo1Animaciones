using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
namespace Grupo1Animaciones.Conexiones
{
   public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://animaciones-5f8b8-default-rtdb.firebaseio.com/");
    }
}
