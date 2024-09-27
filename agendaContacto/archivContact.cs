    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Windows.Forms;
    namespace agendaContacto
    {
        internal class archivContact
        {

            public string NombreArchivo = "Contacto.csv";
        public string NombreArchivo2 = "AgendaEntera.csv";

        //Grabamos los datos
        //ABRIR, GRABAR Y CERRAR
        public void Grabar(string nombre, string apellido, int telefono, string correo, string categoria)
        {
            // Abrimos el archivo 
            using (StreamWriter AD = new StreamWriter(NombreArchivo, true))
            {
                AD.Write(nombre);
                AD.Write(";"); // separador de campos para diferenciar nombre de apellido 
                AD.Write(apellido);
                AD.Write(";");
                AD.Write(telefono);
                AD.Write(";");
                AD.Write(correo);
                AD.Write(";");
                // WriteLine da el enter para ir al otro registro
                AD.WriteLine(categoria);
            } // el using se encarga de cerrar y liberar los recursos automáticamente
        }
        public void GrabarTodos(string nombre, string apellido, int telefono, string correo, string categoria)
        {
            // Abrimos el archivo 
            using (StreamWriter AD = new StreamWriter(NombreArchivo2, true))
            {
                AD.Write(nombre);
                AD.Write(";"); // separador de campos para diferenciar nombre de apellido 
                AD.Write(apellido);
                AD.Write(";");
                AD.Write(telefono);
                AD.Write(";");
                AD.Write(correo);
                AD.Write(";");
                // WriteLine da el enter para ir al otro registro
                AD.WriteLine(categoria);
            } // el using se encarga de cerrar y liberar los recursos automáticamente
        }
    }
}
    
